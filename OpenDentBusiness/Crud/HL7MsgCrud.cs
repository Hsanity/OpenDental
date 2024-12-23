//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class HL7MsgCrud {
		///<summary>Gets one HL7Msg object from the database using the primary key.  Returns null if not found.</summary>
		public static HL7Msg SelectOne(long hL7MsgNum) {
			string command="SELECT * FROM hl7msg "
				+"WHERE HL7MsgNum = "+POut.Long(hL7MsgNum);
			List<HL7Msg> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one HL7Msg object from the database using a query.</summary>
		public static HL7Msg SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<HL7Msg> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of HL7Msg objects from the database using a query.</summary>
		public static List<HL7Msg> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<HL7Msg> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<HL7Msg> TableToList(DataTable table) {
			List<HL7Msg> retVal=new List<HL7Msg>();
			HL7Msg hL7Msg;
			foreach(DataRow row in table.Rows) {
				hL7Msg=new HL7Msg();
				hL7Msg.HL7MsgNum = PIn.Long  (row["HL7MsgNum"].ToString());
				hL7Msg.HL7Status = (OpenDentBusiness.HL7MessageStatus)PIn.Int(row["HL7Status"].ToString());
				hL7Msg.MsgText   = PIn.String(row["MsgText"].ToString());
				hL7Msg.AptNum    = PIn.Long  (row["AptNum"].ToString());
				hL7Msg.DateTStamp= PIn.DateT (row["DateTStamp"].ToString());
				hL7Msg.PatNum    = PIn.Long  (row["PatNum"].ToString());
				hL7Msg.Note      = PIn.String(row["Note"].ToString());
				retVal.Add(hL7Msg);
			}
			return retVal;
		}

		///<summary>Converts a list of HL7Msg into a DataTable.</summary>
		public static DataTable ListToTable(List<HL7Msg> listHL7Msgs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="HL7Msg";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("HL7MsgNum");
			table.Columns.Add("HL7Status");
			table.Columns.Add("MsgText");
			table.Columns.Add("AptNum");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("PatNum");
			table.Columns.Add("Note");
			foreach(HL7Msg hL7Msg in listHL7Msgs) {
				table.Rows.Add(new object[] {
					POut.Long  (hL7Msg.HL7MsgNum),
					POut.Int   ((int)hL7Msg.HL7Status),
					            hL7Msg.MsgText,
					POut.Long  (hL7Msg.AptNum),
					POut.DateT (hL7Msg.DateTStamp,false),
					POut.Long  (hL7Msg.PatNum),
					            hL7Msg.Note,
				});
			}
			return table;
		}

		///<summary>Inserts one HL7Msg into the database.  Returns the new priKey.</summary>
		public static long Insert(HL7Msg hL7Msg) {
			return Insert(hL7Msg,false);
		}

		///<summary>Inserts one HL7Msg into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(HL7Msg hL7Msg,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				hL7Msg.HL7MsgNum=ReplicationServers.GetKey("hl7msg","HL7MsgNum");
			}
			string command="INSERT INTO hl7msg (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="HL7MsgNum,";
			}
			command+="HL7Status,MsgText,AptNum,PatNum,Note) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(hL7Msg.HL7MsgNum)+",";
			}
			command+=
				     POut.Int   ((int)hL7Msg.HL7Status)+","
				+    DbHelper.ParamChar+"paramMsgText,"
				+    POut.Long  (hL7Msg.AptNum)+","
				//DateTStamp can only be set by MySQL
				+    POut.Long  (hL7Msg.PatNum)+","
				+    DbHelper.ParamChar+"paramNote)";
			if(hL7Msg.MsgText==null) {
				hL7Msg.MsgText="";
			}
			OdSqlParameter paramMsgText=new OdSqlParameter("paramMsgText",OdDbType.Text,POut.StringParam(hL7Msg.MsgText));
			if(hL7Msg.Note==null) {
				hL7Msg.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(hL7Msg.Note));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramMsgText,paramNote);
			}
			else {
				hL7Msg.HL7MsgNum=Db.NonQ(command,true,"HL7MsgNum","hL7Msg",paramMsgText,paramNote);
			}
			return hL7Msg.HL7MsgNum;
		}

		///<summary>Inserts one HL7Msg into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(HL7Msg hL7Msg) {
			return InsertNoCache(hL7Msg,false);
		}

		///<summary>Inserts one HL7Msg into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(HL7Msg hL7Msg,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO hl7msg (";
			if(!useExistingPK && isRandomKeys) {
				hL7Msg.HL7MsgNum=ReplicationServers.GetKeyNoCache("hl7msg","HL7MsgNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="HL7MsgNum,";
			}
			command+="HL7Status,MsgText,AptNum,PatNum,Note) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(hL7Msg.HL7MsgNum)+",";
			}
			command+=
				     POut.Int   ((int)hL7Msg.HL7Status)+","
				+    DbHelper.ParamChar+"paramMsgText,"
				+    POut.Long  (hL7Msg.AptNum)+","
				//DateTStamp can only be set by MySQL
				+    POut.Long  (hL7Msg.PatNum)+","
				+    DbHelper.ParamChar+"paramNote)";
			if(hL7Msg.MsgText==null) {
				hL7Msg.MsgText="";
			}
			OdSqlParameter paramMsgText=new OdSqlParameter("paramMsgText",OdDbType.Text,POut.StringParam(hL7Msg.MsgText));
			if(hL7Msg.Note==null) {
				hL7Msg.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(hL7Msg.Note));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramMsgText,paramNote);
			}
			else {
				hL7Msg.HL7MsgNum=Db.NonQ(command,true,"HL7MsgNum","hL7Msg",paramMsgText,paramNote);
			}
			return hL7Msg.HL7MsgNum;
		}

		///<summary>Updates one HL7Msg in the database.</summary>
		public static void Update(HL7Msg hL7Msg) {
			string command="UPDATE hl7msg SET "
				+"HL7Status =  "+POut.Int   ((int)hL7Msg.HL7Status)+", "
				+"MsgText   =  "+DbHelper.ParamChar+"paramMsgText, "
				+"AptNum    =  "+POut.Long  (hL7Msg.AptNum)+", "
				//DateTStamp can only be set by MySQL
				+"PatNum    =  "+POut.Long  (hL7Msg.PatNum)+", "
				+"Note      =  "+DbHelper.ParamChar+"paramNote "
				+"WHERE HL7MsgNum = "+POut.Long(hL7Msg.HL7MsgNum);
			if(hL7Msg.MsgText==null) {
				hL7Msg.MsgText="";
			}
			OdSqlParameter paramMsgText=new OdSqlParameter("paramMsgText",OdDbType.Text,POut.StringParam(hL7Msg.MsgText));
			if(hL7Msg.Note==null) {
				hL7Msg.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(hL7Msg.Note));
			Db.NonQ(command,paramMsgText,paramNote);
		}

		///<summary>Updates one HL7Msg in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(HL7Msg hL7Msg,HL7Msg oldHL7Msg) {
			string command="";
			if(hL7Msg.HL7Status != oldHL7Msg.HL7Status) {
				if(command!="") { command+=",";}
				command+="HL7Status = "+POut.Int   ((int)hL7Msg.HL7Status)+"";
			}
			if(hL7Msg.MsgText != oldHL7Msg.MsgText) {
				if(command!="") { command+=",";}
				command+="MsgText = "+DbHelper.ParamChar+"paramMsgText";
			}
			if(hL7Msg.AptNum != oldHL7Msg.AptNum) {
				if(command!="") { command+=",";}
				command+="AptNum = "+POut.Long(hL7Msg.AptNum)+"";
			}
			//DateTStamp can only be set by MySQL
			if(hL7Msg.PatNum != oldHL7Msg.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(hL7Msg.PatNum)+"";
			}
			if(hL7Msg.Note != oldHL7Msg.Note) {
				if(command!="") { command+=",";}
				command+="Note = "+DbHelper.ParamChar+"paramNote";
			}
			if(command=="") {
				return false;
			}
			if(hL7Msg.MsgText==null) {
				hL7Msg.MsgText="";
			}
			OdSqlParameter paramMsgText=new OdSqlParameter("paramMsgText",OdDbType.Text,POut.StringParam(hL7Msg.MsgText));
			if(hL7Msg.Note==null) {
				hL7Msg.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(hL7Msg.Note));
			command="UPDATE hl7msg SET "+command
				+" WHERE HL7MsgNum = "+POut.Long(hL7Msg.HL7MsgNum);
			Db.NonQ(command,paramMsgText,paramNote);
			return true;
		}

		///<summary>Returns true if Update(HL7Msg,HL7Msg) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(HL7Msg hL7Msg,HL7Msg oldHL7Msg) {
			if(hL7Msg.HL7Status != oldHL7Msg.HL7Status) {
				return true;
			}
			if(hL7Msg.MsgText != oldHL7Msg.MsgText) {
				return true;
			}
			if(hL7Msg.AptNum != oldHL7Msg.AptNum) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			if(hL7Msg.PatNum != oldHL7Msg.PatNum) {
				return true;
			}
			if(hL7Msg.Note != oldHL7Msg.Note) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one HL7Msg from the database.</summary>
		public static void Delete(long hL7MsgNum) {
			string command="DELETE FROM hl7msg "
				+"WHERE HL7MsgNum = "+POut.Long(hL7MsgNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many HL7Msgs from the database.</summary>
		public static void DeleteMany(List<long> listHL7MsgNums) {
			if(listHL7MsgNums==null || listHL7MsgNums.Count==0) {
				return;
			}
			string command="DELETE FROM hl7msg "
				+"WHERE HL7MsgNum IN("+string.Join(",",listHL7MsgNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}