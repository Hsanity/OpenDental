//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class HistAppointmentCrud {
		///<summary>Gets one HistAppointment object from the database using the primary key.  Returns null if not found.</summary>
		public static HistAppointment SelectOne(long histApptNum) {
			string command="SELECT * FROM histappointment "
				+"WHERE HistApptNum = "+POut.Long(histApptNum);
			List<HistAppointment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one HistAppointment object from the database using a query.</summary>
		public static HistAppointment SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<HistAppointment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of HistAppointment objects from the database using a query.</summary>
		public static List<HistAppointment> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<HistAppointment> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<HistAppointment> TableToList(DataTable table) {
			List<HistAppointment> retVal=new List<HistAppointment>();
			HistAppointment histAppointment;
			foreach(DataRow row in table.Rows) {
				histAppointment=new HistAppointment();
				histAppointment.HistApptNum          = PIn.Long  (row["HistApptNum"].ToString());
				histAppointment.HistUserNum          = PIn.Long  (row["HistUserNum"].ToString());
				histAppointment.HistDateTStamp       = PIn.DateT (row["HistDateTStamp"].ToString());
				histAppointment.HistApptAction       = (OpenDentBusiness.HistAppointmentAction)PIn.Int(row["HistApptAction"].ToString());
				histAppointment.ApptSource           = (OpenDentBusiness.EServiceTypes)PIn.Int(row["ApptSource"].ToString());
				histAppointment.AptNum               = PIn.Long  (row["AptNum"].ToString());
				histAppointment.PatNum               = PIn.Long  (row["PatNum"].ToString());
				histAppointment.AptStatus            = (OpenDentBusiness.ApptStatus)PIn.Int(row["AptStatus"].ToString());
				histAppointment.Pattern              = PIn.String(row["Pattern"].ToString());
				histAppointment.Confirmed            = PIn.Long  (row["Confirmed"].ToString());
				histAppointment.TimeLocked           = PIn.Bool  (row["TimeLocked"].ToString());
				histAppointment.Op                   = PIn.Long  (row["Op"].ToString());
				histAppointment.Note                 = PIn.String(row["Note"].ToString());
				histAppointment.ProvNum              = PIn.Long  (row["ProvNum"].ToString());
				histAppointment.ProvHyg              = PIn.Long  (row["ProvHyg"].ToString());
				histAppointment.AptDateTime          = PIn.DateT (row["AptDateTime"].ToString());
				histAppointment.NextAptNum           = PIn.Long  (row["NextAptNum"].ToString());
				histAppointment.UnschedStatus        = PIn.Long  (row["UnschedStatus"].ToString());
				histAppointment.IsNewPatient         = PIn.Bool  (row["IsNewPatient"].ToString());
				histAppointment.ProcDescript         = PIn.String(row["ProcDescript"].ToString());
				histAppointment.Assistant            = PIn.Long  (row["Assistant"].ToString());
				histAppointment.ClinicNum            = PIn.Long  (row["ClinicNum"].ToString());
				histAppointment.IsHygiene            = PIn.Bool  (row["IsHygiene"].ToString());
				histAppointment.DateTStamp           = PIn.DateT (row["DateTStamp"].ToString());
				histAppointment.DateTimeArrived      = PIn.DateT (row["DateTimeArrived"].ToString());
				histAppointment.DateTimeSeated       = PIn.DateT (row["DateTimeSeated"].ToString());
				histAppointment.DateTimeDismissed    = PIn.DateT (row["DateTimeDismissed"].ToString());
				histAppointment.InsPlan1             = PIn.Long  (row["InsPlan1"].ToString());
				histAppointment.InsPlan2             = PIn.Long  (row["InsPlan2"].ToString());
				histAppointment.DateTimeAskedToArrive= PIn.DateT (row["DateTimeAskedToArrive"].ToString());
				histAppointment.ProcsColored         = PIn.String(row["ProcsColored"].ToString());
				histAppointment.ColorOverride        = Color.FromArgb(PIn.Int(row["ColorOverride"].ToString()));
				histAppointment.AppointmentTypeNum   = PIn.Long  (row["AppointmentTypeNum"].ToString());
				histAppointment.SecUserNumEntry      = PIn.Long  (row["SecUserNumEntry"].ToString());
				histAppointment.SecDateTEntry        = PIn.DateT (row["SecDateTEntry"].ToString());
				histAppointment.Priority             = (OpenDentBusiness.ApptPriority)PIn.Int(row["Priority"].ToString());
				histAppointment.ProvBarText          = PIn.String(row["ProvBarText"].ToString());
				histAppointment.PatternSecondary     = PIn.String(row["PatternSecondary"].ToString());
				histAppointment.SecurityHash         = PIn.String(row["SecurityHash"].ToString());
				histAppointment.ItemOrderPlanned     = PIn.Int   (row["ItemOrderPlanned"].ToString());
				retVal.Add(histAppointment);
			}
			return retVal;
		}

		///<summary>Converts a list of HistAppointment into a DataTable.</summary>
		public static DataTable ListToTable(List<HistAppointment> listHistAppointments,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="HistAppointment";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("HistApptNum");
			table.Columns.Add("HistUserNum");
			table.Columns.Add("HistDateTStamp");
			table.Columns.Add("HistApptAction");
			table.Columns.Add("ApptSource");
			table.Columns.Add("AptNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("AptStatus");
			table.Columns.Add("Pattern");
			table.Columns.Add("Confirmed");
			table.Columns.Add("TimeLocked");
			table.Columns.Add("Op");
			table.Columns.Add("Note");
			table.Columns.Add("ProvNum");
			table.Columns.Add("ProvHyg");
			table.Columns.Add("AptDateTime");
			table.Columns.Add("NextAptNum");
			table.Columns.Add("UnschedStatus");
			table.Columns.Add("IsNewPatient");
			table.Columns.Add("ProcDescript");
			table.Columns.Add("Assistant");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("IsHygiene");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("DateTimeArrived");
			table.Columns.Add("DateTimeSeated");
			table.Columns.Add("DateTimeDismissed");
			table.Columns.Add("InsPlan1");
			table.Columns.Add("InsPlan2");
			table.Columns.Add("DateTimeAskedToArrive");
			table.Columns.Add("ProcsColored");
			table.Columns.Add("ColorOverride");
			table.Columns.Add("AppointmentTypeNum");
			table.Columns.Add("SecUserNumEntry");
			table.Columns.Add("SecDateTEntry");
			table.Columns.Add("Priority");
			table.Columns.Add("ProvBarText");
			table.Columns.Add("PatternSecondary");
			table.Columns.Add("SecurityHash");
			table.Columns.Add("ItemOrderPlanned");
			foreach(HistAppointment histAppointment in listHistAppointments) {
				table.Rows.Add(new object[] {
					POut.Long  (histAppointment.HistApptNum),
					POut.Long  (histAppointment.HistUserNum),
					POut.DateT (histAppointment.HistDateTStamp,false),
					POut.Int   ((int)histAppointment.HistApptAction),
					POut.Int   ((int)histAppointment.ApptSource),
					POut.Long  (histAppointment.AptNum),
					POut.Long  (histAppointment.PatNum),
					POut.Int   ((int)histAppointment.AptStatus),
					            histAppointment.Pattern,
					POut.Long  (histAppointment.Confirmed),
					POut.Bool  (histAppointment.TimeLocked),
					POut.Long  (histAppointment.Op),
					            histAppointment.Note,
					POut.Long  (histAppointment.ProvNum),
					POut.Long  (histAppointment.ProvHyg),
					POut.DateT (histAppointment.AptDateTime,false),
					POut.Long  (histAppointment.NextAptNum),
					POut.Long  (histAppointment.UnschedStatus),
					POut.Bool  (histAppointment.IsNewPatient),
					            histAppointment.ProcDescript,
					POut.Long  (histAppointment.Assistant),
					POut.Long  (histAppointment.ClinicNum),
					POut.Bool  (histAppointment.IsHygiene),
					POut.DateT (histAppointment.DateTStamp,false),
					POut.DateT (histAppointment.DateTimeArrived,false),
					POut.DateT (histAppointment.DateTimeSeated,false),
					POut.DateT (histAppointment.DateTimeDismissed,false),
					POut.Long  (histAppointment.InsPlan1),
					POut.Long  (histAppointment.InsPlan2),
					POut.DateT (histAppointment.DateTimeAskedToArrive,false),
					            histAppointment.ProcsColored,
					POut.Int   (histAppointment.ColorOverride.ToArgb()),
					POut.Long  (histAppointment.AppointmentTypeNum),
					POut.Long  (histAppointment.SecUserNumEntry),
					POut.DateT (histAppointment.SecDateTEntry,false),
					POut.Int   ((int)histAppointment.Priority),
					            histAppointment.ProvBarText,
					            histAppointment.PatternSecondary,
					            histAppointment.SecurityHash,
					POut.Int   (histAppointment.ItemOrderPlanned),
				});
			}
			return table;
		}

		///<summary>Inserts one HistAppointment into the database.  Returns the new priKey.</summary>
		public static long Insert(HistAppointment histAppointment) {
			return Insert(histAppointment,false);
		}

		///<summary>Inserts one HistAppointment into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(HistAppointment histAppointment,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				histAppointment.HistApptNum=ReplicationServers.GetKey("histappointment","HistApptNum");
			}
			string command="INSERT INTO histappointment (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="HistApptNum,";
			}
			command+="HistUserNum,HistDateTStamp,HistApptAction,ApptSource,AptNum,PatNum,AptStatus,Pattern,Confirmed,TimeLocked,Op,Note,ProvNum,ProvHyg,AptDateTime,NextAptNum,UnschedStatus,IsNewPatient,ProcDescript,Assistant,ClinicNum,IsHygiene,DateTimeArrived,DateTimeSeated,DateTimeDismissed,InsPlan1,InsPlan2,DateTimeAskedToArrive,ProcsColored,ColorOverride,AppointmentTypeNum,SecUserNumEntry,SecDateTEntry,Priority,ProvBarText,PatternSecondary,SecurityHash,ItemOrderPlanned) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(histAppointment.HistApptNum)+",";
			}
			command+=
				     POut.Long  (histAppointment.HistUserNum)+","
				+    DbHelper.Now()+","
				+    POut.Int   ((int)histAppointment.HistApptAction)+","
				+    POut.Int   ((int)histAppointment.ApptSource)+","
				+    POut.Long  (histAppointment.AptNum)+","
				+    POut.Long  (histAppointment.PatNum)+","
				+    POut.Int   ((int)histAppointment.AptStatus)+","
				+"'"+POut.String(histAppointment.Pattern)+"',"
				+    POut.Long  (histAppointment.Confirmed)+","
				+    POut.Bool  (histAppointment.TimeLocked)+","
				+    POut.Long  (histAppointment.Op)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    POut.Long  (histAppointment.ProvNum)+","
				+    POut.Long  (histAppointment.ProvHyg)+","
				+    POut.DateT (histAppointment.AptDateTime)+","
				+    POut.Long  (histAppointment.NextAptNum)+","
				+    POut.Long  (histAppointment.UnschedStatus)+","
				+    POut.Bool  (histAppointment.IsNewPatient)+","
				+"'"+POut.String(histAppointment.ProcDescript)+"',"
				+    POut.Long  (histAppointment.Assistant)+","
				+    POut.Long  (histAppointment.ClinicNum)+","
				+    POut.Bool  (histAppointment.IsHygiene)+","
				//DateTStamp can only be set by MySQL
				+    POut.DateT (histAppointment.DateTimeArrived)+","
				+    POut.DateT (histAppointment.DateTimeSeated)+","
				+    POut.DateT (histAppointment.DateTimeDismissed)+","
				+    POut.Long  (histAppointment.InsPlan1)+","
				+    POut.Long  (histAppointment.InsPlan2)+","
				+    POut.DateT (histAppointment.DateTimeAskedToArrive)+","
				+    DbHelper.ParamChar+"paramProcsColored,"
				+    POut.Int   (histAppointment.ColorOverride.ToArgb())+","
				+    POut.Long  (histAppointment.AppointmentTypeNum)+","
				+    POut.Long  (histAppointment.SecUserNumEntry)+","
				+    POut.DateT (histAppointment.SecDateTEntry)+","
				+    POut.Int   ((int)histAppointment.Priority)+","
				+"'"+POut.String(histAppointment.ProvBarText)+"',"
				+"'"+POut.String(histAppointment.PatternSecondary)+"',"
				+"'"+POut.String(histAppointment.SecurityHash)+"',"
				+    POut.Int   (histAppointment.ItemOrderPlanned)+")";
			if(histAppointment.Note==null) {
				histAppointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(histAppointment.Note));
			if(histAppointment.ProcsColored==null) {
				histAppointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(histAppointment.ProcsColored));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramNote,paramProcsColored);
			}
			else {
				histAppointment.HistApptNum=Db.NonQ(command,true,"HistApptNum","histAppointment",paramNote,paramProcsColored);
			}
			return histAppointment.HistApptNum;
		}

		///<summary>Inserts one HistAppointment into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(HistAppointment histAppointment) {
			return InsertNoCache(histAppointment,false);
		}

		///<summary>Inserts one HistAppointment into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(HistAppointment histAppointment,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO histappointment (";
			if(!useExistingPK && isRandomKeys) {
				histAppointment.HistApptNum=ReplicationServers.GetKeyNoCache("histappointment","HistApptNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="HistApptNum,";
			}
			command+="HistUserNum,HistDateTStamp,HistApptAction,ApptSource,AptNum,PatNum,AptStatus,Pattern,Confirmed,TimeLocked,Op,Note,ProvNum,ProvHyg,AptDateTime,NextAptNum,UnschedStatus,IsNewPatient,ProcDescript,Assistant,ClinicNum,IsHygiene,DateTimeArrived,DateTimeSeated,DateTimeDismissed,InsPlan1,InsPlan2,DateTimeAskedToArrive,ProcsColored,ColorOverride,AppointmentTypeNum,SecUserNumEntry,SecDateTEntry,Priority,ProvBarText,PatternSecondary,SecurityHash,ItemOrderPlanned) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(histAppointment.HistApptNum)+",";
			}
			command+=
				     POut.Long  (histAppointment.HistUserNum)+","
				+    DbHelper.Now()+","
				+    POut.Int   ((int)histAppointment.HistApptAction)+","
				+    POut.Int   ((int)histAppointment.ApptSource)+","
				+    POut.Long  (histAppointment.AptNum)+","
				+    POut.Long  (histAppointment.PatNum)+","
				+    POut.Int   ((int)histAppointment.AptStatus)+","
				+"'"+POut.String(histAppointment.Pattern)+"',"
				+    POut.Long  (histAppointment.Confirmed)+","
				+    POut.Bool  (histAppointment.TimeLocked)+","
				+    POut.Long  (histAppointment.Op)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    POut.Long  (histAppointment.ProvNum)+","
				+    POut.Long  (histAppointment.ProvHyg)+","
				+    POut.DateT (histAppointment.AptDateTime)+","
				+    POut.Long  (histAppointment.NextAptNum)+","
				+    POut.Long  (histAppointment.UnschedStatus)+","
				+    POut.Bool  (histAppointment.IsNewPatient)+","
				+"'"+POut.String(histAppointment.ProcDescript)+"',"
				+    POut.Long  (histAppointment.Assistant)+","
				+    POut.Long  (histAppointment.ClinicNum)+","
				+    POut.Bool  (histAppointment.IsHygiene)+","
				//DateTStamp can only be set by MySQL
				+    POut.DateT (histAppointment.DateTimeArrived)+","
				+    POut.DateT (histAppointment.DateTimeSeated)+","
				+    POut.DateT (histAppointment.DateTimeDismissed)+","
				+    POut.Long  (histAppointment.InsPlan1)+","
				+    POut.Long  (histAppointment.InsPlan2)+","
				+    POut.DateT (histAppointment.DateTimeAskedToArrive)+","
				+    DbHelper.ParamChar+"paramProcsColored,"
				+    POut.Int   (histAppointment.ColorOverride.ToArgb())+","
				+    POut.Long  (histAppointment.AppointmentTypeNum)+","
				+    POut.Long  (histAppointment.SecUserNumEntry)+","
				+    POut.DateT (histAppointment.SecDateTEntry)+","
				+    POut.Int   ((int)histAppointment.Priority)+","
				+"'"+POut.String(histAppointment.ProvBarText)+"',"
				+"'"+POut.String(histAppointment.PatternSecondary)+"',"
				+"'"+POut.String(histAppointment.SecurityHash)+"',"
				+    POut.Int   (histAppointment.ItemOrderPlanned)+")";
			if(histAppointment.Note==null) {
				histAppointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(histAppointment.Note));
			if(histAppointment.ProcsColored==null) {
				histAppointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(histAppointment.ProcsColored));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramNote,paramProcsColored);
			}
			else {
				histAppointment.HistApptNum=Db.NonQ(command,true,"HistApptNum","histAppointment",paramNote,paramProcsColored);
			}
			return histAppointment.HistApptNum;
		}

		///<summary>Updates one HistAppointment in the database.</summary>
		public static void Update(HistAppointment histAppointment) {
			string command="UPDATE histappointment SET "
				+"HistUserNum          =  "+POut.Long  (histAppointment.HistUserNum)+", "
				//HistDateTStamp not allowed to change
				+"HistApptAction       =  "+POut.Int   ((int)histAppointment.HistApptAction)+", "
				+"ApptSource           =  "+POut.Int   ((int)histAppointment.ApptSource)+", "
				+"AptNum               =  "+POut.Long  (histAppointment.AptNum)+", "
				+"PatNum               =  "+POut.Long  (histAppointment.PatNum)+", "
				+"AptStatus            =  "+POut.Int   ((int)histAppointment.AptStatus)+", "
				+"Pattern              = '"+POut.String(histAppointment.Pattern)+"', "
				+"Confirmed            =  "+POut.Long  (histAppointment.Confirmed)+", "
				+"TimeLocked           =  "+POut.Bool  (histAppointment.TimeLocked)+", "
				+"Op                   =  "+POut.Long  (histAppointment.Op)+", "
				+"Note                 =  "+DbHelper.ParamChar+"paramNote, "
				+"ProvNum              =  "+POut.Long  (histAppointment.ProvNum)+", "
				+"ProvHyg              =  "+POut.Long  (histAppointment.ProvHyg)+", "
				+"AptDateTime          =  "+POut.DateT (histAppointment.AptDateTime)+", "
				+"NextAptNum           =  "+POut.Long  (histAppointment.NextAptNum)+", "
				+"UnschedStatus        =  "+POut.Long  (histAppointment.UnschedStatus)+", "
				+"IsNewPatient         =  "+POut.Bool  (histAppointment.IsNewPatient)+", "
				+"ProcDescript         = '"+POut.String(histAppointment.ProcDescript)+"', "
				+"Assistant            =  "+POut.Long  (histAppointment.Assistant)+", "
				+"ClinicNum            =  "+POut.Long  (histAppointment.ClinicNum)+", "
				+"IsHygiene            =  "+POut.Bool  (histAppointment.IsHygiene)+", "
				//DateTStamp can only be set by MySQL
				+"DateTimeArrived      =  "+POut.DateT (histAppointment.DateTimeArrived)+", "
				+"DateTimeSeated       =  "+POut.DateT (histAppointment.DateTimeSeated)+", "
				+"DateTimeDismissed    =  "+POut.DateT (histAppointment.DateTimeDismissed)+", "
				+"InsPlan1             =  "+POut.Long  (histAppointment.InsPlan1)+", "
				+"InsPlan2             =  "+POut.Long  (histAppointment.InsPlan2)+", "
				+"DateTimeAskedToArrive=  "+POut.DateT (histAppointment.DateTimeAskedToArrive)+", "
				+"ProcsColored         =  "+DbHelper.ParamChar+"paramProcsColored, "
				+"ColorOverride        =  "+POut.Int   (histAppointment.ColorOverride.ToArgb())+", "
				+"AppointmentTypeNum   =  "+POut.Long  (histAppointment.AppointmentTypeNum)+", "
				//SecUserNumEntry excluded from update
				+"SecDateTEntry        =  "+POut.DateT (histAppointment.SecDateTEntry)+", "
				+"Priority             =  "+POut.Int   ((int)histAppointment.Priority)+", "
				+"ProvBarText          = '"+POut.String(histAppointment.ProvBarText)+"', "
				+"PatternSecondary     = '"+POut.String(histAppointment.PatternSecondary)+"', "
				+"SecurityHash         = '"+POut.String(histAppointment.SecurityHash)+"', "
				+"ItemOrderPlanned     =  "+POut.Int   (histAppointment.ItemOrderPlanned)+" "
				+"WHERE HistApptNum = "+POut.Long(histAppointment.HistApptNum);
			if(histAppointment.Note==null) {
				histAppointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(histAppointment.Note));
			if(histAppointment.ProcsColored==null) {
				histAppointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(histAppointment.ProcsColored));
			Db.NonQ(command,paramNote,paramProcsColored);
		}

		///<summary>Updates one HistAppointment in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(HistAppointment histAppointment,HistAppointment oldHistAppointment) {
			string command="";
			if(histAppointment.HistUserNum != oldHistAppointment.HistUserNum) {
				if(command!="") { command+=",";}
				command+="HistUserNum = "+POut.Long(histAppointment.HistUserNum)+"";
			}
			//HistDateTStamp not allowed to change
			if(histAppointment.HistApptAction != oldHistAppointment.HistApptAction) {
				if(command!="") { command+=",";}
				command+="HistApptAction = "+POut.Int   ((int)histAppointment.HistApptAction)+"";
			}
			if(histAppointment.ApptSource != oldHistAppointment.ApptSource) {
				if(command!="") { command+=",";}
				command+="ApptSource = "+POut.Int   ((int)histAppointment.ApptSource)+"";
			}
			if(histAppointment.AptNum != oldHistAppointment.AptNum) {
				if(command!="") { command+=",";}
				command+="AptNum = "+POut.Long(histAppointment.AptNum)+"";
			}
			if(histAppointment.PatNum != oldHistAppointment.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(histAppointment.PatNum)+"";
			}
			if(histAppointment.AptStatus != oldHistAppointment.AptStatus) {
				if(command!="") { command+=",";}
				command+="AptStatus = "+POut.Int   ((int)histAppointment.AptStatus)+"";
			}
			if(histAppointment.Pattern != oldHistAppointment.Pattern) {
				if(command!="") { command+=",";}
				command+="Pattern = '"+POut.String(histAppointment.Pattern)+"'";
			}
			if(histAppointment.Confirmed != oldHistAppointment.Confirmed) {
				if(command!="") { command+=",";}
				command+="Confirmed = "+POut.Long(histAppointment.Confirmed)+"";
			}
			if(histAppointment.TimeLocked != oldHistAppointment.TimeLocked) {
				if(command!="") { command+=",";}
				command+="TimeLocked = "+POut.Bool(histAppointment.TimeLocked)+"";
			}
			if(histAppointment.Op != oldHistAppointment.Op) {
				if(command!="") { command+=",";}
				command+="Op = "+POut.Long(histAppointment.Op)+"";
			}
			if(histAppointment.Note != oldHistAppointment.Note) {
				if(command!="") { command+=",";}
				command+="Note = "+DbHelper.ParamChar+"paramNote";
			}
			if(histAppointment.ProvNum != oldHistAppointment.ProvNum) {
				if(command!="") { command+=",";}
				command+="ProvNum = "+POut.Long(histAppointment.ProvNum)+"";
			}
			if(histAppointment.ProvHyg != oldHistAppointment.ProvHyg) {
				if(command!="") { command+=",";}
				command+="ProvHyg = "+POut.Long(histAppointment.ProvHyg)+"";
			}
			if(histAppointment.AptDateTime != oldHistAppointment.AptDateTime) {
				if(command!="") { command+=",";}
				command+="AptDateTime = "+POut.DateT(histAppointment.AptDateTime)+"";
			}
			if(histAppointment.NextAptNum != oldHistAppointment.NextAptNum) {
				if(command!="") { command+=",";}
				command+="NextAptNum = "+POut.Long(histAppointment.NextAptNum)+"";
			}
			if(histAppointment.UnschedStatus != oldHistAppointment.UnschedStatus) {
				if(command!="") { command+=",";}
				command+="UnschedStatus = "+POut.Long(histAppointment.UnschedStatus)+"";
			}
			if(histAppointment.IsNewPatient != oldHistAppointment.IsNewPatient) {
				if(command!="") { command+=",";}
				command+="IsNewPatient = "+POut.Bool(histAppointment.IsNewPatient)+"";
			}
			if(histAppointment.ProcDescript != oldHistAppointment.ProcDescript) {
				if(command!="") { command+=",";}
				command+="ProcDescript = '"+POut.String(histAppointment.ProcDescript)+"'";
			}
			if(histAppointment.Assistant != oldHistAppointment.Assistant) {
				if(command!="") { command+=",";}
				command+="Assistant = "+POut.Long(histAppointment.Assistant)+"";
			}
			if(histAppointment.ClinicNum != oldHistAppointment.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(histAppointment.ClinicNum)+"";
			}
			if(histAppointment.IsHygiene != oldHistAppointment.IsHygiene) {
				if(command!="") { command+=",";}
				command+="IsHygiene = "+POut.Bool(histAppointment.IsHygiene)+"";
			}
			//DateTStamp can only be set by MySQL
			if(histAppointment.DateTimeArrived != oldHistAppointment.DateTimeArrived) {
				if(command!="") { command+=",";}
				command+="DateTimeArrived = "+POut.DateT(histAppointment.DateTimeArrived)+"";
			}
			if(histAppointment.DateTimeSeated != oldHistAppointment.DateTimeSeated) {
				if(command!="") { command+=",";}
				command+="DateTimeSeated = "+POut.DateT(histAppointment.DateTimeSeated)+"";
			}
			if(histAppointment.DateTimeDismissed != oldHistAppointment.DateTimeDismissed) {
				if(command!="") { command+=",";}
				command+="DateTimeDismissed = "+POut.DateT(histAppointment.DateTimeDismissed)+"";
			}
			if(histAppointment.InsPlan1 != oldHistAppointment.InsPlan1) {
				if(command!="") { command+=",";}
				command+="InsPlan1 = "+POut.Long(histAppointment.InsPlan1)+"";
			}
			if(histAppointment.InsPlan2 != oldHistAppointment.InsPlan2) {
				if(command!="") { command+=",";}
				command+="InsPlan2 = "+POut.Long(histAppointment.InsPlan2)+"";
			}
			if(histAppointment.DateTimeAskedToArrive != oldHistAppointment.DateTimeAskedToArrive) {
				if(command!="") { command+=",";}
				command+="DateTimeAskedToArrive = "+POut.DateT(histAppointment.DateTimeAskedToArrive)+"";
			}
			if(histAppointment.ProcsColored != oldHistAppointment.ProcsColored) {
				if(command!="") { command+=",";}
				command+="ProcsColored = "+DbHelper.ParamChar+"paramProcsColored";
			}
			if(histAppointment.ColorOverride != oldHistAppointment.ColorOverride) {
				if(command!="") { command+=",";}
				command+="ColorOverride = "+POut.Int(histAppointment.ColorOverride.ToArgb())+"";
			}
			if(histAppointment.AppointmentTypeNum != oldHistAppointment.AppointmentTypeNum) {
				if(command!="") { command+=",";}
				command+="AppointmentTypeNum = "+POut.Long(histAppointment.AppointmentTypeNum)+"";
			}
			//SecUserNumEntry excluded from update
			if(histAppointment.SecDateTEntry != oldHistAppointment.SecDateTEntry) {
				if(command!="") { command+=",";}
				command+="SecDateTEntry = "+POut.DateT(histAppointment.SecDateTEntry)+"";
			}
			if(histAppointment.Priority != oldHistAppointment.Priority) {
				if(command!="") { command+=",";}
				command+="Priority = "+POut.Int   ((int)histAppointment.Priority)+"";
			}
			if(histAppointment.ProvBarText != oldHistAppointment.ProvBarText) {
				if(command!="") { command+=",";}
				command+="ProvBarText = '"+POut.String(histAppointment.ProvBarText)+"'";
			}
			if(histAppointment.PatternSecondary != oldHistAppointment.PatternSecondary) {
				if(command!="") { command+=",";}
				command+="PatternSecondary = '"+POut.String(histAppointment.PatternSecondary)+"'";
			}
			if(histAppointment.SecurityHash != oldHistAppointment.SecurityHash) {
				if(command!="") { command+=",";}
				command+="SecurityHash = '"+POut.String(histAppointment.SecurityHash)+"'";
			}
			if(histAppointment.ItemOrderPlanned != oldHistAppointment.ItemOrderPlanned) {
				if(command!="") { command+=",";}
				command+="ItemOrderPlanned = "+POut.Int(histAppointment.ItemOrderPlanned)+"";
			}
			if(command=="") {
				return false;
			}
			if(histAppointment.Note==null) {
				histAppointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(histAppointment.Note));
			if(histAppointment.ProcsColored==null) {
				histAppointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(histAppointment.ProcsColored));
			command="UPDATE histappointment SET "+command
				+" WHERE HistApptNum = "+POut.Long(histAppointment.HistApptNum);
			Db.NonQ(command,paramNote,paramProcsColored);
			return true;
		}

		///<summary>Returns true if Update(HistAppointment,HistAppointment) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(HistAppointment histAppointment,HistAppointment oldHistAppointment) {
			if(histAppointment.HistUserNum != oldHistAppointment.HistUserNum) {
				return true;
			}
			//HistDateTStamp not allowed to change
			if(histAppointment.HistApptAction != oldHistAppointment.HistApptAction) {
				return true;
			}
			if(histAppointment.ApptSource != oldHistAppointment.ApptSource) {
				return true;
			}
			if(histAppointment.AptNum != oldHistAppointment.AptNum) {
				return true;
			}
			if(histAppointment.PatNum != oldHistAppointment.PatNum) {
				return true;
			}
			if(histAppointment.AptStatus != oldHistAppointment.AptStatus) {
				return true;
			}
			if(histAppointment.Pattern != oldHistAppointment.Pattern) {
				return true;
			}
			if(histAppointment.Confirmed != oldHistAppointment.Confirmed) {
				return true;
			}
			if(histAppointment.TimeLocked != oldHistAppointment.TimeLocked) {
				return true;
			}
			if(histAppointment.Op != oldHistAppointment.Op) {
				return true;
			}
			if(histAppointment.Note != oldHistAppointment.Note) {
				return true;
			}
			if(histAppointment.ProvNum != oldHistAppointment.ProvNum) {
				return true;
			}
			if(histAppointment.ProvHyg != oldHistAppointment.ProvHyg) {
				return true;
			}
			if(histAppointment.AptDateTime != oldHistAppointment.AptDateTime) {
				return true;
			}
			if(histAppointment.NextAptNum != oldHistAppointment.NextAptNum) {
				return true;
			}
			if(histAppointment.UnschedStatus != oldHistAppointment.UnschedStatus) {
				return true;
			}
			if(histAppointment.IsNewPatient != oldHistAppointment.IsNewPatient) {
				return true;
			}
			if(histAppointment.ProcDescript != oldHistAppointment.ProcDescript) {
				return true;
			}
			if(histAppointment.Assistant != oldHistAppointment.Assistant) {
				return true;
			}
			if(histAppointment.ClinicNum != oldHistAppointment.ClinicNum) {
				return true;
			}
			if(histAppointment.IsHygiene != oldHistAppointment.IsHygiene) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			if(histAppointment.DateTimeArrived != oldHistAppointment.DateTimeArrived) {
				return true;
			}
			if(histAppointment.DateTimeSeated != oldHistAppointment.DateTimeSeated) {
				return true;
			}
			if(histAppointment.DateTimeDismissed != oldHistAppointment.DateTimeDismissed) {
				return true;
			}
			if(histAppointment.InsPlan1 != oldHistAppointment.InsPlan1) {
				return true;
			}
			if(histAppointment.InsPlan2 != oldHistAppointment.InsPlan2) {
				return true;
			}
			if(histAppointment.DateTimeAskedToArrive != oldHistAppointment.DateTimeAskedToArrive) {
				return true;
			}
			if(histAppointment.ProcsColored != oldHistAppointment.ProcsColored) {
				return true;
			}
			if(histAppointment.ColorOverride != oldHistAppointment.ColorOverride) {
				return true;
			}
			if(histAppointment.AppointmentTypeNum != oldHistAppointment.AppointmentTypeNum) {
				return true;
			}
			//SecUserNumEntry excluded from update
			if(histAppointment.SecDateTEntry != oldHistAppointment.SecDateTEntry) {
				return true;
			}
			if(histAppointment.Priority != oldHistAppointment.Priority) {
				return true;
			}
			if(histAppointment.ProvBarText != oldHistAppointment.ProvBarText) {
				return true;
			}
			if(histAppointment.PatternSecondary != oldHistAppointment.PatternSecondary) {
				return true;
			}
			if(histAppointment.SecurityHash != oldHistAppointment.SecurityHash) {
				return true;
			}
			if(histAppointment.ItemOrderPlanned != oldHistAppointment.ItemOrderPlanned) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one HistAppointment from the database.</summary>
		public static void Delete(long histApptNum) {
			string command="DELETE FROM histappointment "
				+"WHERE HistApptNum = "+POut.Long(histApptNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many HistAppointments from the database.</summary>
		public static void DeleteMany(List<long> listHistApptNums) {
			if(listHistApptNums==null || listHistApptNums.Count==0) {
				return;
			}
			string command="DELETE FROM histappointment "
				+"WHERE HistApptNum IN("+string.Join(",",listHistApptNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}