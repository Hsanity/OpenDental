﻿//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class MobileBugVersionCrud {
		///<summary>Gets one MobileBugVersion object from the database using the primary key.  Returns null if not found.</summary>
		public static MobileBugVersion SelectOne(long mobileBugVersionNum) {
			string command="SELECT * FROM mobilebugversion "
				+"WHERE MobileBugVersionNum = "+POut.Long(mobileBugVersionNum);
			List<MobileBugVersion> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one MobileBugVersion object from the database using a query.</summary>
		public static MobileBugVersion SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<MobileBugVersion> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of MobileBugVersion objects from the database using a query.</summary>
		public static List<MobileBugVersion> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<MobileBugVersion> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<MobileBugVersion> TableToList(DataTable table) {
			List<MobileBugVersion> retVal=new List<MobileBugVersion>();
			MobileBugVersion mobileBugVersion;
			foreach(DataRow row in table.Rows) {
				mobileBugVersion=new MobileBugVersion();
				mobileBugVersion.MobileBugVersionNum= PIn.Long  (row["MobileBugVersionNum"].ToString());
				mobileBugVersion.MobileBugNum       = PIn.Long  (row["MobileBugNum"].ToString());
				string bugStatus=row["BugStatus"].ToString();
				if(bugStatus=="") {
					mobileBugVersion.BugStatus        =(OpenDentBusiness.MobileBugStatus)0;
				}
				else try{
					mobileBugVersion.BugStatus        =(OpenDentBusiness.MobileBugStatus)Enum.Parse(typeof(OpenDentBusiness.MobileBugStatus),bugStatus);
				}
				catch{
					mobileBugVersion.BugStatus        =(OpenDentBusiness.MobileBugStatus)0;
				}
				mobileBugVersion.MobileVersionFound = PIn.String(row["MobileVersionFound"].ToString());
				mobileBugVersion.MobileVersionFixed = PIn.String(row["MobileVersionFixed"].ToString());
				string appType=row["AppType"].ToString();
				if(appType=="") {
					mobileBugVersion.AppType          =(OpenDentBusiness.AppType)0;
				}
				else try{
					mobileBugVersion.AppType          =(OpenDentBusiness.AppType)Enum.Parse(typeof(OpenDentBusiness.AppType),appType);
				}
				catch{
					mobileBugVersion.AppType          =(OpenDentBusiness.AppType)0;
				}
				retVal.Add(mobileBugVersion);
			}
			return retVal;
		}

		///<summary>Converts a list of MobileBugVersion into a DataTable.</summary>
		public static DataTable ListToTable(List<MobileBugVersion> listMobileBugVersions,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="MobileBugVersion";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("MobileBugVersionNum");
			table.Columns.Add("MobileBugNum");
			table.Columns.Add("BugStatus");
			table.Columns.Add("MobileVersionFound");
			table.Columns.Add("MobileVersionFixed");
			table.Columns.Add("AppType");
			foreach(MobileBugVersion mobileBugVersion in listMobileBugVersions) {
				table.Rows.Add(new object[] {
					POut.Long  (mobileBugVersion.MobileBugVersionNum),
					POut.Long  (mobileBugVersion.MobileBugNum),
					POut.Int   ((int)mobileBugVersion.BugStatus),
					            mobileBugVersion.MobileVersionFound,
					            mobileBugVersion.MobileVersionFixed,
					POut.Int   ((int)mobileBugVersion.AppType),
				});
			}
			return table;
		}

		///<summary>Inserts one MobileBugVersion into the database.  Returns the new priKey.</summary>
		public static long Insert(MobileBugVersion mobileBugVersion) {
			return Insert(mobileBugVersion,false);
		}

		///<summary>Inserts one MobileBugVersion into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(MobileBugVersion mobileBugVersion,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				mobileBugVersion.MobileBugVersionNum=ReplicationServers.GetKey("mobilebugversion","MobileBugVersionNum");
			}
			string command="INSERT INTO mobilebugversion (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="MobileBugVersionNum,";
			}
			command+="MobileBugNum,BugStatus,MobileVersionFound,MobileVersionFixed,AppType) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(mobileBugVersion.MobileBugVersionNum)+",";
			}
			command+=
				     POut.Long  (mobileBugVersion.MobileBugNum)+","
				+"'"+POut.String(mobileBugVersion.BugStatus.ToString())+"',"
				+"'"+POut.String(mobileBugVersion.MobileVersionFound)+"',"
				+"'"+POut.String(mobileBugVersion.MobileVersionFixed)+"',"
				+"'"+POut.String(mobileBugVersion.AppType.ToString())+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				mobileBugVersion.MobileBugVersionNum=Db.NonQ(command,true,"MobileBugVersionNum","mobileBugVersion");
			}
			return mobileBugVersion.MobileBugVersionNum;
		}

		///<summary>Inserts one MobileBugVersion into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(MobileBugVersion mobileBugVersion) {
			return InsertNoCache(mobileBugVersion,false);
		}

		///<summary>Inserts one MobileBugVersion into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(MobileBugVersion mobileBugVersion,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO mobilebugversion (";
			if(!useExistingPK && isRandomKeys) {
				mobileBugVersion.MobileBugVersionNum=ReplicationServers.GetKeyNoCache("mobilebugversion","MobileBugVersionNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="MobileBugVersionNum,";
			}
			command+="MobileBugNum,BugStatus,MobileVersionFound,MobileVersionFixed,AppType) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(mobileBugVersion.MobileBugVersionNum)+",";
			}
			command+=
				     POut.Long  (mobileBugVersion.MobileBugNum)+","
				+"'"+POut.String(mobileBugVersion.BugStatus.ToString())+"',"
				+"'"+POut.String(mobileBugVersion.MobileVersionFound)+"',"
				+"'"+POut.String(mobileBugVersion.MobileVersionFixed)+"',"
				+"'"+POut.String(mobileBugVersion.AppType.ToString())+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				mobileBugVersion.MobileBugVersionNum=Db.NonQ(command,true,"MobileBugVersionNum","mobileBugVersion");
			}
			return mobileBugVersion.MobileBugVersionNum;
		}

		///<summary>Updates one MobileBugVersion in the database.</summary>
		public static void Update(MobileBugVersion mobileBugVersion) {
			string command="UPDATE mobilebugversion SET "
				+"MobileBugNum       =  "+POut.Long  (mobileBugVersion.MobileBugNum)+", "
				+"BugStatus          = '"+POut.String(mobileBugVersion.BugStatus.ToString())+"', "
				+"MobileVersionFound = '"+POut.String(mobileBugVersion.MobileVersionFound)+"', "
				+"MobileVersionFixed = '"+POut.String(mobileBugVersion.MobileVersionFixed)+"', "
				+"AppType            = '"+POut.String(mobileBugVersion.AppType.ToString())+"' "
				+"WHERE MobileBugVersionNum = "+POut.Long(mobileBugVersion.MobileBugVersionNum);
			Db.NonQ(command);
		}

		///<summary>Updates one MobileBugVersion in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(MobileBugVersion mobileBugVersion,MobileBugVersion oldMobileBugVersion) {
			string command="";
			if(mobileBugVersion.MobileBugNum != oldMobileBugVersion.MobileBugNum) {
				if(command!="") { command+=",";}
				command+="MobileBugNum = "+POut.Long(mobileBugVersion.MobileBugNum)+"";
			}
			if(mobileBugVersion.BugStatus != oldMobileBugVersion.BugStatus) {
				if(command!="") { command+=",";}
				command+="BugStatus = '"+POut.String(mobileBugVersion.BugStatus.ToString())+"'";
			}
			if(mobileBugVersion.MobileVersionFound != oldMobileBugVersion.MobileVersionFound) {
				if(command!="") { command+=",";}
				command+="MobileVersionFound = '"+POut.String(mobileBugVersion.MobileVersionFound)+"'";
			}
			if(mobileBugVersion.MobileVersionFixed != oldMobileBugVersion.MobileVersionFixed) {
				if(command!="") { command+=",";}
				command+="MobileVersionFixed = '"+POut.String(mobileBugVersion.MobileVersionFixed)+"'";
			}
			if(mobileBugVersion.AppType != oldMobileBugVersion.AppType) {
				if(command!="") { command+=",";}
				command+="AppType = '"+POut.String(mobileBugVersion.AppType.ToString())+"'";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE mobilebugversion SET "+command
				+" WHERE MobileBugVersionNum = "+POut.Long(mobileBugVersion.MobileBugVersionNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(MobileBugVersion,MobileBugVersion) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(MobileBugVersion mobileBugVersion,MobileBugVersion oldMobileBugVersion) {
			if(mobileBugVersion.MobileBugNum != oldMobileBugVersion.MobileBugNum) {
				return true;
			}
			if(mobileBugVersion.BugStatus != oldMobileBugVersion.BugStatus) {
				return true;
			}
			if(mobileBugVersion.MobileVersionFound != oldMobileBugVersion.MobileVersionFound) {
				return true;
			}
			if(mobileBugVersion.MobileVersionFixed != oldMobileBugVersion.MobileVersionFixed) {
				return true;
			}
			if(mobileBugVersion.AppType != oldMobileBugVersion.AppType) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one MobileBugVersion from the database.</summary>
		public static void Delete(long mobileBugVersionNum) {
			string command="DELETE FROM mobilebugversion "
				+"WHERE MobileBugVersionNum = "+POut.Long(mobileBugVersionNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many MobileBugVersions from the database.</summary>
		public static void DeleteMany(List<long> listMobileBugVersionNums) {
			if(listMobileBugVersionNums==null || listMobileBugVersionNums.Count==0) {
				return;
			}
			string command="DELETE FROM mobilebugversion "
				+"WHERE MobileBugVersionNum IN("+string.Join(",",listMobileBugVersionNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}