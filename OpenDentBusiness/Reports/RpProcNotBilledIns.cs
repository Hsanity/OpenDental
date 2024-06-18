﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace OpenDentBusiness {
	public class RpProcNotBilledIns {
		///<summary>If not using clinics then supply an empty list of clinicNums.  listClinicNums must have at least one item if using clinics.
		///The table returned has the following columns in this order: 
		///PatientName, ProcDate, Descript, ProcFee, ProcNum, ClinicNum, PatNum, IsInProcess</summary>
		public static DataTable GetProcsNotBilled(List<long> listClinicNums,bool includeMedProcs,DateTime dateStart,DateTime dateEnd,
			bool showProcsBeforeIns,bool hasMultiVisitProcs)
		{
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				return Meth.GetTable(MethodBase.GetCurrentMethod(),listClinicNums,includeMedProcs,dateStart,dateEnd,showProcsBeforeIns,hasMultiVisitProcs);
			}
			string query="SELECT ";
			if(PrefC.GetBool(PrefName.ReportsShowPatNum)) {
				query+=DbHelper.Concat("CAST(patient.PatNum AS CHAR)","'-'","patient.LName","', '","patient.FName","' '","patient.MiddleI");
			}
			else {
				query+=DbHelper.Concat("patient.LName","', '","patient.FName","' '","patient.MiddleI");
			}
			query+=@" PatientName,
				CASE WHEN procmultivisit.ProcMultiVisitNum IS NULL THEN '"+Lans.g("enumProcStat",ProcStat.C.ToString())+@"' 
					ELSE '"+Lans.g("enumProcStat",ProcStatExt.InProcess)+@"' END Stat,
				procedurelog.ProcDate,'' Descript,
				procedurelog.ProcFee*(procedurelog.UnitQty+procedurelog.BaseUnits) procFee,
				procedurelog.ProcNum,procedurelog.ClinicNum,patient.PatNum,procedurelog.CodeNum
				FROM patient
				INNER JOIN procedurelog ON procedurelog.PatNum=patient.PatNum
					AND procedurelog.ProcFee>0
					AND procedurelog.procstatus="+POut.Enum(ProcStat.C)+@" 
					AND procedurelog.ProcDate BETWEEN "+POut.Date(dateStart)+" AND "+POut.Date(dateEnd)+@" 
				LEFT JOIN procedurecode ON procedurecode.CodeNum=procedurelog.CodeNum
				LEFT JOIN claimproc ON claimproc.ProcNum=procedurelog.ProcNum
				LEFT JOIN insplan ON insplan.PlanNum=claimproc.PlanNum
				LEFT JOIN procmultivisit ON procmultivisit.ProcNum=procedurelog.ProcNum
					AND procmultivisit.IsInProcess=1
				WHERE EXISTS(SELECT 1 FROM patplan WHERE patplan.PatNum=patient.PatNum)
				AND (";
			query+="(claimproc.NoBillIns=0 AND claimproc.Status="+POut.Enum(ClaimProcStatus.Estimate)+") ";//after ins was added
			if(showProcsBeforeIns) {
				query+=" OR (procedurecode.NoBillIns=0 AND claimproc.ClaimProcNum IS NULL)";//before ins was added
			}
			query+=")";
			if(!hasMultiVisitProcs) {
				query+=" AND procmultivisit.ProcMultiVisitNum IS NULL";
			}
			if(listClinicNums.Count>0) {
				query+=" AND procedurelog.ClinicNum IN ("+string.Join(",",listClinicNums)+")";
			}
			query+=@" GROUP BY procedurelog.ProcNum
			HAVING !MIN(insplan.IsMedical)";
			if(includeMedProcs) {
				query+=" OR MAX(insplan.IsMedical)";
			}
			if(showProcsBeforeIns) {
				query+=" OR ISNULL(MIN(insplan.PlanNum))";
			}
			query+=" ORDER BY patient.LName,patient.FName,patient.PatNum,procedurelog.ProcDate";
			DataTable table=Db.GetTable(query);
			List<DataRow> listDataRows=table.Select().ToList();
			for(int i=0;i<listDataRows.Count;i++) {
				DataRow dataRow = listDataRows[i];
				ProcedureCode procedureCode=ProcedureCodes.GetFirstOrDefault(x=>x.CodeNum==PIn.Long(dataRow["CodeNum"].ToString()));//guaranteed to always work
				if(CultureInfo.CurrentCulture.Name.EndsWith("CA") && procedureCode.IsCanadianLab) {//ignore Canadian labs
					table.Rows.Remove(dataRow);
					continue;
				}
				dataRow["Descript"]=procedureCode.Descript??"";
			}
			return table;
		}

	}
}