//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class DiscountPlanCrud {
		///<summary>Gets one DiscountPlan object from the database using the primary key.  Returns null if not found.</summary>
		public static DiscountPlan SelectOne(long discountPlanNum) {
			string command="SELECT * FROM discountplan "
				+"WHERE DiscountPlanNum = "+POut.Long(discountPlanNum);
			List<DiscountPlan> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one DiscountPlan object from the database using a query.</summary>
		public static DiscountPlan SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<DiscountPlan> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of DiscountPlan objects from the database using a query.</summary>
		public static List<DiscountPlan> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<DiscountPlan> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<DiscountPlan> TableToList(DataTable table) {
			List<DiscountPlan> retVal=new List<DiscountPlan>();
			DiscountPlan discountPlan;
			foreach(DataRow row in table.Rows) {
				discountPlan=new DiscountPlan();
				discountPlan.DiscountPlanNum     = PIn.Long  (row["DiscountPlanNum"].ToString());
				discountPlan.Description         = PIn.String(row["Description"].ToString());
				discountPlan.FeeSchedNum         = PIn.Long  (row["FeeSchedNum"].ToString());
				discountPlan.DefNum              = PIn.Long  (row["DefNum"].ToString());
				discountPlan.IsHidden            = PIn.Bool  (row["IsHidden"].ToString());
				discountPlan.PlanNote            = PIn.String(row["PlanNote"].ToString());
				discountPlan.ExamFreqLimit       = PIn.Int   (row["ExamFreqLimit"].ToString());
				discountPlan.XrayFreqLimit       = PIn.Int   (row["XrayFreqLimit"].ToString());
				discountPlan.ProphyFreqLimit     = PIn.Int   (row["ProphyFreqLimit"].ToString());
				discountPlan.FluorideFreqLimit   = PIn.Int   (row["FluorideFreqLimit"].ToString());
				discountPlan.PerioFreqLimit      = PIn.Int   (row["PerioFreqLimit"].ToString());
				discountPlan.LimitedExamFreqLimit= PIn.Int   (row["LimitedExamFreqLimit"].ToString());
				discountPlan.PAFreqLimit         = PIn.Int   (row["PAFreqLimit"].ToString());
				discountPlan.AnnualMax           = PIn.Double(row["AnnualMax"].ToString());
				retVal.Add(discountPlan);
			}
			return retVal;
		}

		///<summary>Converts a list of DiscountPlan into a DataTable.</summary>
		public static DataTable ListToTable(List<DiscountPlan> listDiscountPlans,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="DiscountPlan";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("DiscountPlanNum");
			table.Columns.Add("Description");
			table.Columns.Add("FeeSchedNum");
			table.Columns.Add("DefNum");
			table.Columns.Add("IsHidden");
			table.Columns.Add("PlanNote");
			table.Columns.Add("ExamFreqLimit");
			table.Columns.Add("XrayFreqLimit");
			table.Columns.Add("ProphyFreqLimit");
			table.Columns.Add("FluorideFreqLimit");
			table.Columns.Add("PerioFreqLimit");
			table.Columns.Add("LimitedExamFreqLimit");
			table.Columns.Add("PAFreqLimit");
			table.Columns.Add("AnnualMax");
			foreach(DiscountPlan discountPlan in listDiscountPlans) {
				table.Rows.Add(new object[] {
					POut.Long  (discountPlan.DiscountPlanNum),
					            discountPlan.Description,
					POut.Long  (discountPlan.FeeSchedNum),
					POut.Long  (discountPlan.DefNum),
					POut.Bool  (discountPlan.IsHidden),
					            discountPlan.PlanNote,
					POut.Int   (discountPlan.ExamFreqLimit),
					POut.Int   (discountPlan.XrayFreqLimit),
					POut.Int   (discountPlan.ProphyFreqLimit),
					POut.Int   (discountPlan.FluorideFreqLimit),
					POut.Int   (discountPlan.PerioFreqLimit),
					POut.Int   (discountPlan.LimitedExamFreqLimit),
					POut.Int   (discountPlan.PAFreqLimit),
					POut.Double(discountPlan.AnnualMax),
				});
			}
			return table;
		}

		///<summary>Inserts one DiscountPlan into the database.  Returns the new priKey.</summary>
		public static long Insert(DiscountPlan discountPlan) {
			return Insert(discountPlan,false);
		}

		///<summary>Inserts one DiscountPlan into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(DiscountPlan discountPlan,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				discountPlan.DiscountPlanNum=ReplicationServers.GetKey("discountplan","DiscountPlanNum");
			}
			string command="INSERT INTO discountplan (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="DiscountPlanNum,";
			}
			command+="Description,FeeSchedNum,DefNum,IsHidden,PlanNote,ExamFreqLimit,XrayFreqLimit,ProphyFreqLimit,FluorideFreqLimit,PerioFreqLimit,LimitedExamFreqLimit,PAFreqLimit,AnnualMax) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(discountPlan.DiscountPlanNum)+",";
			}
			command+=
				 "'"+POut.String(discountPlan.Description)+"',"
				+    POut.Long  (discountPlan.FeeSchedNum)+","
				+    POut.Long  (discountPlan.DefNum)+","
				+    POut.Bool  (discountPlan.IsHidden)+","
				+    DbHelper.ParamChar+"paramPlanNote,"
				+    POut.Int   (discountPlan.ExamFreqLimit)+","
				+    POut.Int   (discountPlan.XrayFreqLimit)+","
				+    POut.Int   (discountPlan.ProphyFreqLimit)+","
				+    POut.Int   (discountPlan.FluorideFreqLimit)+","
				+    POut.Int   (discountPlan.PerioFreqLimit)+","
				+    POut.Int   (discountPlan.LimitedExamFreqLimit)+","
				+    POut.Int   (discountPlan.PAFreqLimit)+","
				+		 POut.Double(discountPlan.AnnualMax)+")";
			if(discountPlan.PlanNote==null) {
				discountPlan.PlanNote="";
			}
			OdSqlParameter paramPlanNote=new OdSqlParameter("paramPlanNote",OdDbType.Text,POut.StringParam(discountPlan.PlanNote));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramPlanNote);
			}
			else {
				discountPlan.DiscountPlanNum=Db.NonQ(command,true,"DiscountPlanNum","discountPlan",paramPlanNote);
			}
			return discountPlan.DiscountPlanNum;
		}

		///<summary>Inserts one DiscountPlan into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(DiscountPlan discountPlan) {
			return InsertNoCache(discountPlan,false);
		}

		///<summary>Inserts one DiscountPlan into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(DiscountPlan discountPlan,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO discountplan (";
			if(!useExistingPK && isRandomKeys) {
				discountPlan.DiscountPlanNum=ReplicationServers.GetKeyNoCache("discountplan","DiscountPlanNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="DiscountPlanNum,";
			}
			command+="Description,FeeSchedNum,DefNum,IsHidden,PlanNote,ExamFreqLimit,XrayFreqLimit,ProphyFreqLimit,FluorideFreqLimit,PerioFreqLimit,LimitedExamFreqLimit,PAFreqLimit,AnnualMax) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(discountPlan.DiscountPlanNum)+",";
			}
			command+=
				 "'"+POut.String(discountPlan.Description)+"',"
				+    POut.Long  (discountPlan.FeeSchedNum)+","
				+    POut.Long  (discountPlan.DefNum)+","
				+    POut.Bool  (discountPlan.IsHidden)+","
				+    DbHelper.ParamChar+"paramPlanNote,"
				+    POut.Int   (discountPlan.ExamFreqLimit)+","
				+    POut.Int   (discountPlan.XrayFreqLimit)+","
				+    POut.Int   (discountPlan.ProphyFreqLimit)+","
				+    POut.Int   (discountPlan.FluorideFreqLimit)+","
				+    POut.Int   (discountPlan.PerioFreqLimit)+","
				+    POut.Int   (discountPlan.LimitedExamFreqLimit)+","
				+    POut.Int   (discountPlan.PAFreqLimit)+","
				+	   POut.Double(discountPlan.AnnualMax)+")";
			if(discountPlan.PlanNote==null) {
				discountPlan.PlanNote="";
			}
			OdSqlParameter paramPlanNote=new OdSqlParameter("paramPlanNote",OdDbType.Text,POut.StringParam(discountPlan.PlanNote));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramPlanNote);
			}
			else {
				discountPlan.DiscountPlanNum=Db.NonQ(command,true,"DiscountPlanNum","discountPlan",paramPlanNote);
			}
			return discountPlan.DiscountPlanNum;
		}

		///<summary>Updates one DiscountPlan in the database.</summary>
		public static void Update(DiscountPlan discountPlan) {
			string command="UPDATE discountplan SET "
				+"Description         = '"+POut.String(discountPlan.Description)+"', "
				+"FeeSchedNum         =  "+POut.Long  (discountPlan.FeeSchedNum)+", "
				+"DefNum              =  "+POut.Long  (discountPlan.DefNum)+", "
				+"IsHidden            =  "+POut.Bool  (discountPlan.IsHidden)+", "
				+"PlanNote            =  "+DbHelper.ParamChar+"paramPlanNote, "
				+"ExamFreqLimit       =  "+POut.Int   (discountPlan.ExamFreqLimit)+", "
				+"XrayFreqLimit       =  "+POut.Int   (discountPlan.XrayFreqLimit)+", "
				+"ProphyFreqLimit     =  "+POut.Int   (discountPlan.ProphyFreqLimit)+", "
				+"FluorideFreqLimit   =  "+POut.Int   (discountPlan.FluorideFreqLimit)+", "
				+"PerioFreqLimit      =  "+POut.Int   (discountPlan.PerioFreqLimit)+", "
				+"LimitedExamFreqLimit=  "+POut.Int   (discountPlan.LimitedExamFreqLimit)+", "
				+"PAFreqLimit         =  "+POut.Int   (discountPlan.PAFreqLimit)+", "
				+"AnnualMax           =  "+POut.Double(discountPlan.AnnualMax)+" "
				+"WHERE DiscountPlanNum = "+POut.Long(discountPlan.DiscountPlanNum);
			if(discountPlan.PlanNote==null) {
				discountPlan.PlanNote="";
			}
			OdSqlParameter paramPlanNote=new OdSqlParameter("paramPlanNote",OdDbType.Text,POut.StringParam(discountPlan.PlanNote));
			Db.NonQ(command,paramPlanNote);
		}

		///<summary>Updates one DiscountPlan in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(DiscountPlan discountPlan,DiscountPlan oldDiscountPlan) {
			string command="";
			if(discountPlan.Description != oldDiscountPlan.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(discountPlan.Description)+"'";
			}
			if(discountPlan.FeeSchedNum != oldDiscountPlan.FeeSchedNum) {
				if(command!="") { command+=",";}
				command+="FeeSchedNum = "+POut.Long(discountPlan.FeeSchedNum)+"";
			}
			if(discountPlan.DefNum != oldDiscountPlan.DefNum) {
				if(command!="") { command+=",";}
				command+="DefNum = "+POut.Long(discountPlan.DefNum)+"";
			}
			if(discountPlan.IsHidden != oldDiscountPlan.IsHidden) {
				if(command!="") { command+=",";}
				command+="IsHidden = "+POut.Bool(discountPlan.IsHidden)+"";
			}
			if(discountPlan.PlanNote != oldDiscountPlan.PlanNote) {
				if(command!="") { command+=",";}
				command+="PlanNote = "+DbHelper.ParamChar+"paramPlanNote";
			}
			if(discountPlan.ExamFreqLimit != oldDiscountPlan.ExamFreqLimit) {
				if(command!="") { command+=",";}
				command+="ExamFreqLimit = "+POut.Int(discountPlan.ExamFreqLimit)+"";
			}
			if(discountPlan.XrayFreqLimit != oldDiscountPlan.XrayFreqLimit) {
				if(command!="") { command+=",";}
				command+="XrayFreqLimit = "+POut.Int(discountPlan.XrayFreqLimit)+"";
			}
			if(discountPlan.ProphyFreqLimit != oldDiscountPlan.ProphyFreqLimit) {
				if(command!="") { command+=",";}
				command+="ProphyFreqLimit = "+POut.Int(discountPlan.ProphyFreqLimit)+"";
			}
			if(discountPlan.FluorideFreqLimit != oldDiscountPlan.FluorideFreqLimit) {
				if(command!="") { command+=",";}
				command+="FluorideFreqLimit = "+POut.Int(discountPlan.FluorideFreqLimit)+"";
			}
			if(discountPlan.PerioFreqLimit != oldDiscountPlan.PerioFreqLimit) {
				if(command!="") { command+=",";}
				command+="PerioFreqLimit = "+POut.Int(discountPlan.PerioFreqLimit)+"";
			}
			if(discountPlan.LimitedExamFreqLimit != oldDiscountPlan.LimitedExamFreqLimit) {
				if(command!="") { command+=",";}
				command+="LimitedExamFreqLimit = "+POut.Int(discountPlan.LimitedExamFreqLimit)+"";
			}
			if(discountPlan.PAFreqLimit != oldDiscountPlan.PAFreqLimit) {
				if(command!="") { command+=",";}
				command+="PAFreqLimit = "+POut.Int(discountPlan.PAFreqLimit)+"";
			}
			if(discountPlan.AnnualMax != oldDiscountPlan.AnnualMax) {
				if(command!="") { command+=",";}
				command+="AnnualMax = "+POut.Double(discountPlan.AnnualMax)+"";
			}
			if(command=="") {
				return false;
			}
			if(discountPlan.PlanNote==null) {
				discountPlan.PlanNote="";
			}
			OdSqlParameter paramPlanNote=new OdSqlParameter("paramPlanNote",OdDbType.Text,POut.StringParam(discountPlan.PlanNote));
			command="UPDATE discountplan SET "+command
				+" WHERE DiscountPlanNum = "+POut.Long(discountPlan.DiscountPlanNum);
			Db.NonQ(command,paramPlanNote);
			return true;
		}

		///<summary>Returns true if Update(DiscountPlan,DiscountPlan) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(DiscountPlan discountPlan,DiscountPlan oldDiscountPlan) {
			if(discountPlan.Description != oldDiscountPlan.Description) {
				return true;
			}
			if(discountPlan.FeeSchedNum != oldDiscountPlan.FeeSchedNum) {
				return true;
			}
			if(discountPlan.DefNum != oldDiscountPlan.DefNum) {
				return true;
			}
			if(discountPlan.IsHidden != oldDiscountPlan.IsHidden) {
				return true;
			}
			if(discountPlan.PlanNote != oldDiscountPlan.PlanNote) {
				return true;
			}
			if(discountPlan.ExamFreqLimit != oldDiscountPlan.ExamFreqLimit) {
				return true;
			}
			if(discountPlan.XrayFreqLimit != oldDiscountPlan.XrayFreqLimit) {
				return true;
			}
			if(discountPlan.ProphyFreqLimit != oldDiscountPlan.ProphyFreqLimit) {
				return true;
			}
			if(discountPlan.FluorideFreqLimit != oldDiscountPlan.FluorideFreqLimit) {
				return true;
			}
			if(discountPlan.PerioFreqLimit != oldDiscountPlan.PerioFreqLimit) {
				return true;
			}
			if(discountPlan.LimitedExamFreqLimit != oldDiscountPlan.LimitedExamFreqLimit) {
				return true;
			}
			if(discountPlan.PAFreqLimit != oldDiscountPlan.PAFreqLimit) {
				return true;
			}
			if(discountPlan.AnnualMax != oldDiscountPlan.AnnualMax) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one DiscountPlan from the database.</summary>
		public static void Delete(long discountPlanNum) {
			string command="DELETE FROM discountplan "
				+"WHERE DiscountPlanNum = "+POut.Long(discountPlanNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many DiscountPlans from the database.</summary>
		public static void DeleteMany(List<long> listDiscountPlanNums) {
			if(listDiscountPlanNums==null || listDiscountPlanNums.Count==0) {
				return;
			}
			string command="DELETE FROM discountplan "
				+"WHERE DiscountPlanNum IN("+string.Join(",",listDiscountPlanNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}