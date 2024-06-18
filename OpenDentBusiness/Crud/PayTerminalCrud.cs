//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class PayTerminalCrud {
		///<summary>Gets one PayTerminal object from the database using the primary key.  Returns null if not found.</summary>
		public static PayTerminal SelectOne(long payTerminalNum) {
			string command="SELECT * FROM payterminal "
				+"WHERE PayTerminalNum = "+POut.Long(payTerminalNum);
			List<PayTerminal> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one PayTerminal object from the database using a query.</summary>
		public static PayTerminal SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PayTerminal> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of PayTerminal objects from the database using a query.</summary>
		public static List<PayTerminal> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PayTerminal> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<PayTerminal> TableToList(DataTable table) {
			List<PayTerminal> retVal=new List<PayTerminal>();
			PayTerminal payTerminal;
			foreach(DataRow row in table.Rows) {
				payTerminal=new PayTerminal();
				payTerminal.PayTerminalNum= PIn.Long  (row["PayTerminalNum"].ToString());
				payTerminal.Name          = PIn.String(row["Name"].ToString());
				payTerminal.ClinicNum     = PIn.Long  (row["ClinicNum"].ToString());
				payTerminal.TerminalID    = PIn.String(row["TerminalID"].ToString());
				retVal.Add(payTerminal);
			}
			return retVal;
		}

		///<summary>Converts a list of PayTerminal into a DataTable.</summary>
		public static DataTable ListToTable(List<PayTerminal> listPayTerminals,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="PayTerminal";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("PayTerminalNum");
			table.Columns.Add("Name");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("TerminalID");
			foreach(PayTerminal payTerminal in listPayTerminals) {
				table.Rows.Add(new object[] {
					POut.Long  (payTerminal.PayTerminalNum),
					            payTerminal.Name,
					POut.Long  (payTerminal.ClinicNum),
					            payTerminal.TerminalID,
				});
			}
			return table;
		}

		///<summary>Inserts one PayTerminal into the database.  Returns the new priKey.</summary>
		public static long Insert(PayTerminal payTerminal) {
			return Insert(payTerminal,false);
		}

		///<summary>Inserts one PayTerminal into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(PayTerminal payTerminal,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				payTerminal.PayTerminalNum=ReplicationServers.GetKey("payterminal","PayTerminalNum");
			}
			string command="INSERT INTO payterminal (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="PayTerminalNum,";
			}
			command+="Name,ClinicNum,TerminalID) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(payTerminal.PayTerminalNum)+",";
			}
			command+=
				 "'"+POut.String(payTerminal.Name)+"',"
				+    POut.Long  (payTerminal.ClinicNum)+","
				+"'"+POut.String(payTerminal.TerminalID)+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				payTerminal.PayTerminalNum=Db.NonQ(command,true,"PayTerminalNum","payTerminal");
			}
			return payTerminal.PayTerminalNum;
		}

		///<summary>Inserts one PayTerminal into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PayTerminal payTerminal) {
			return InsertNoCache(payTerminal,false);
		}

		///<summary>Inserts one PayTerminal into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PayTerminal payTerminal,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO payterminal (";
			if(!useExistingPK && isRandomKeys) {
				payTerminal.PayTerminalNum=ReplicationServers.GetKeyNoCache("payterminal","PayTerminalNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="PayTerminalNum,";
			}
			command+="Name,ClinicNum,TerminalID) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(payTerminal.PayTerminalNum)+",";
			}
			command+=
				 "'"+POut.String(payTerminal.Name)+"',"
				+    POut.Long  (payTerminal.ClinicNum)+","
				+"'"+POut.String(payTerminal.TerminalID)+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				payTerminal.PayTerminalNum=Db.NonQ(command,true,"PayTerminalNum","payTerminal");
			}
			return payTerminal.PayTerminalNum;
		}

		///<summary>Updates one PayTerminal in the database.</summary>
		public static void Update(PayTerminal payTerminal) {
			string command="UPDATE payterminal SET "
				+"Name          = '"+POut.String(payTerminal.Name)+"', "
				+"ClinicNum     =  "+POut.Long  (payTerminal.ClinicNum)+", "
				+"TerminalID    = '"+POut.String(payTerminal.TerminalID)+"' "
				+"WHERE PayTerminalNum = "+POut.Long(payTerminal.PayTerminalNum);
			Db.NonQ(command);
		}

		///<summary>Updates one PayTerminal in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(PayTerminal payTerminal,PayTerminal oldPayTerminal) {
			string command="";
			if(payTerminal.Name != oldPayTerminal.Name) {
				if(command!="") { command+=",";}
				command+="Name = '"+POut.String(payTerminal.Name)+"'";
			}
			if(payTerminal.ClinicNum != oldPayTerminal.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(payTerminal.ClinicNum)+"";
			}
			if(payTerminal.TerminalID != oldPayTerminal.TerminalID) {
				if(command!="") { command+=",";}
				command+="TerminalID = '"+POut.String(payTerminal.TerminalID)+"'";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE payterminal SET "+command
				+" WHERE PayTerminalNum = "+POut.Long(payTerminal.PayTerminalNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(PayTerminal,PayTerminal) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(PayTerminal payTerminal,PayTerminal oldPayTerminal) {
			if(payTerminal.Name != oldPayTerminal.Name) {
				return true;
			}
			if(payTerminal.ClinicNum != oldPayTerminal.ClinicNum) {
				return true;
			}
			if(payTerminal.TerminalID != oldPayTerminal.TerminalID) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one PayTerminal from the database.</summary>
		public static void Delete(long payTerminalNum) {
			string command="DELETE FROM payterminal "
				+"WHERE PayTerminalNum = "+POut.Long(payTerminalNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many PayTerminals from the database.</summary>
		public static void DeleteMany(List<long> listPayTerminalNums) {
			if(listPayTerminalNums==null || listPayTerminalNums.Count==0) {
				return;
			}
			string command="DELETE FROM payterminal "
				+"WHERE PayTerminalNum IN("+string.Join(",",listPayTerminalNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}