//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class RecallTypeCrud {
		///<summary>Gets one RecallType object from the database using the primary key.  Returns null if not found.</summary>
		public static RecallType SelectOne(long recallTypeNum) {
			string command="SELECT * FROM recalltype "
				+"WHERE RecallTypeNum = "+POut.Long(recallTypeNum);
			List<RecallType> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one RecallType object from the database using a query.</summary>
		public static RecallType SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<RecallType> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of RecallType objects from the database using a query.</summary>
		public static List<RecallType> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<RecallType> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<RecallType> TableToList(DataTable table) {
			List<RecallType> retVal=new List<RecallType>();
			RecallType recallType;
			foreach(DataRow row in table.Rows) {
				recallType=new RecallType();
				recallType.RecallTypeNum  = PIn.Long  (row["RecallTypeNum"].ToString());
				recallType.Description    = PIn.String(row["Description"].ToString());
				recallType.DefaultInterval= new Interval(PIn.Int(row["DefaultInterval"].ToString()));
				recallType.TimePattern    = PIn.String(row["TimePattern"].ToString());
				recallType.Procedures     = PIn.String(row["Procedures"].ToString());
				recallType.AppendToSpecial= PIn.Bool  (row["AppendToSpecial"].ToString());
				retVal.Add(recallType);
			}
			return retVal;
		}

		///<summary>Converts a list of RecallType into a DataTable.</summary>
		public static DataTable ListToTable(List<RecallType> listRecallTypes,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="RecallType";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("RecallTypeNum");
			table.Columns.Add("Description");
			table.Columns.Add("DefaultInterval");
			table.Columns.Add("TimePattern");
			table.Columns.Add("Procedures");
			table.Columns.Add("AppendToSpecial");
			foreach(RecallType recallType in listRecallTypes) {
				table.Rows.Add(new object[] {
					POut.Long  (recallType.RecallTypeNum),
					            recallType.Description,
					POut.Int   (recallType.DefaultInterval.ToInt()),
					            recallType.TimePattern,
					            recallType.Procedures,
					POut.Bool  (recallType.AppendToSpecial),
				});
			}
			return table;
		}

		///<summary>Inserts one RecallType into the database.  Returns the new priKey.</summary>
		public static long Insert(RecallType recallType) {
			return Insert(recallType,false);
		}

		///<summary>Inserts one RecallType into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(RecallType recallType,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				recallType.RecallTypeNum=ReplicationServers.GetKey("recalltype","RecallTypeNum");
			}
			string command="INSERT INTO recalltype (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="RecallTypeNum,";
			}
			command+="Description,DefaultInterval,TimePattern,Procedures,AppendToSpecial) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(recallType.RecallTypeNum)+",";
			}
			command+=
				 "'"+POut.String(recallType.Description)+"',"
				+    POut.Int   (recallType.DefaultInterval.ToInt())+","
				+"'"+POut.String(recallType.TimePattern)+"',"
				+"'"+POut.String(recallType.Procedures)+"',"
				+    POut.Bool  (recallType.AppendToSpecial)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				recallType.RecallTypeNum=Db.NonQ(command,true,"RecallTypeNum","recallType");
			}
			return recallType.RecallTypeNum;
		}

		///<summary>Inserts one RecallType into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(RecallType recallType) {
			return InsertNoCache(recallType,false);
		}

		///<summary>Inserts one RecallType into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(RecallType recallType,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO recalltype (";
			if(!useExistingPK && isRandomKeys) {
				recallType.RecallTypeNum=ReplicationServers.GetKeyNoCache("recalltype","RecallTypeNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="RecallTypeNum,";
			}
			command+="Description,DefaultInterval,TimePattern,Procedures,AppendToSpecial) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(recallType.RecallTypeNum)+",";
			}
			command+=
				 "'"+POut.String(recallType.Description)+"',"
				+    POut.Int   (recallType.DefaultInterval.ToInt())+","
				+"'"+POut.String(recallType.TimePattern)+"',"
				+"'"+POut.String(recallType.Procedures)+"',"
				+    POut.Bool  (recallType.AppendToSpecial)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				recallType.RecallTypeNum=Db.NonQ(command,true,"RecallTypeNum","recallType");
			}
			return recallType.RecallTypeNum;
		}

		///<summary>Updates one RecallType in the database.</summary>
		public static void Update(RecallType recallType) {
			string command="UPDATE recalltype SET "
				+"Description    = '"+POut.String(recallType.Description)+"', "
				+"DefaultInterval=  "+POut.Int   (recallType.DefaultInterval.ToInt())+", "
				+"TimePattern    = '"+POut.String(recallType.TimePattern)+"', "
				+"Procedures     = '"+POut.String(recallType.Procedures)+"', "
				+"AppendToSpecial=  "+POut.Bool  (recallType.AppendToSpecial)+" "
				+"WHERE RecallTypeNum = "+POut.Long(recallType.RecallTypeNum);
			Db.NonQ(command);
		}

		///<summary>Updates one RecallType in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(RecallType recallType,RecallType oldRecallType) {
			string command="";
			if(recallType.Description != oldRecallType.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(recallType.Description)+"'";
			}
			if(recallType.DefaultInterval != oldRecallType.DefaultInterval) {
				if(command!="") { command+=",";}
				command+="DefaultInterval = "+POut.Int(recallType.DefaultInterval.ToInt())+"";
			}
			if(recallType.TimePattern != oldRecallType.TimePattern) {
				if(command!="") { command+=",";}
				command+="TimePattern = '"+POut.String(recallType.TimePattern)+"'";
			}
			if(recallType.Procedures != oldRecallType.Procedures) {
				if(command!="") { command+=",";}
				command+="Procedures = '"+POut.String(recallType.Procedures)+"'";
			}
			if(recallType.AppendToSpecial != oldRecallType.AppendToSpecial) {
				if(command!="") { command+=",";}
				command+="AppendToSpecial = "+POut.Bool(recallType.AppendToSpecial)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE recalltype SET "+command
				+" WHERE RecallTypeNum = "+POut.Long(recallType.RecallTypeNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(RecallType,RecallType) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(RecallType recallType,RecallType oldRecallType) {
			if(recallType.Description != oldRecallType.Description) {
				return true;
			}
			if(recallType.DefaultInterval != oldRecallType.DefaultInterval) {
				return true;
			}
			if(recallType.TimePattern != oldRecallType.TimePattern) {
				return true;
			}
			if(recallType.Procedures != oldRecallType.Procedures) {
				return true;
			}
			if(recallType.AppendToSpecial != oldRecallType.AppendToSpecial) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one RecallType from the database.</summary>
		public static void Delete(long recallTypeNum) {
			string command="DELETE FROM recalltype "
				+"WHERE RecallTypeNum = "+POut.Long(recallTypeNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many RecallTypes from the database.</summary>
		public static void DeleteMany(List<long> listRecallTypeNums) {
			if(listRecallTypeNums==null || listRecallTypeNums.Count==0) {
				return;
			}
			string command="DELETE FROM recalltype "
				+"WHERE RecallTypeNum IN("+string.Join(",",listRecallTypeNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}