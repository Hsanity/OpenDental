//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class EquipmentCrud {
		///<summary>Gets one Equipment object from the database using the primary key.  Returns null if not found.</summary>
		public static Equipment SelectOne(long equipmentNum) {
			string command="SELECT * FROM equipment "
				+"WHERE EquipmentNum = "+POut.Long(equipmentNum);
			List<Equipment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Equipment object from the database using a query.</summary>
		public static Equipment SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Equipment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Equipment objects from the database using a query.</summary>
		public static List<Equipment> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Equipment> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Equipment> TableToList(DataTable table) {
			List<Equipment> retVal=new List<Equipment>();
			Equipment equipment;
			foreach(DataRow row in table.Rows) {
				equipment=new Equipment();
				equipment.EquipmentNum     = PIn.Long  (row["EquipmentNum"].ToString());
				equipment.Description      = PIn.String(row["Description"].ToString());
				equipment.SerialNumber     = PIn.String(row["SerialNumber"].ToString());
				equipment.ModelYear        = PIn.String(row["ModelYear"].ToString());
				equipment.DatePurchased    = PIn.Date  (row["DatePurchased"].ToString());
				equipment.DateSold         = PIn.Date  (row["DateSold"].ToString());
				equipment.PurchaseCost     = PIn.Double(row["PurchaseCost"].ToString());
				equipment.MarketValue      = PIn.Double(row["MarketValue"].ToString());
				equipment.Location         = PIn.String(row["Location"].ToString());
				equipment.DateEntry        = PIn.Date  (row["DateEntry"].ToString());
				equipment.ProvNumCheckedOut= PIn.Long  (row["ProvNumCheckedOut"].ToString());
				equipment.DateCheckedOut   = PIn.Date  (row["DateCheckedOut"].ToString());
				equipment.DateExpectedBack = PIn.Date  (row["DateExpectedBack"].ToString());
				equipment.DispenseNote     = PIn.String(row["DispenseNote"].ToString());
				equipment.Status           = PIn.String(row["Status"].ToString());
				retVal.Add(equipment);
			}
			return retVal;
		}

		///<summary>Converts a list of Equipment into a DataTable.</summary>
		public static DataTable ListToTable(List<Equipment> listEquipments,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Equipment";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("EquipmentNum");
			table.Columns.Add("Description");
			table.Columns.Add("SerialNumber");
			table.Columns.Add("ModelYear");
			table.Columns.Add("DatePurchased");
			table.Columns.Add("DateSold");
			table.Columns.Add("PurchaseCost");
			table.Columns.Add("MarketValue");
			table.Columns.Add("Location");
			table.Columns.Add("DateEntry");
			table.Columns.Add("ProvNumCheckedOut");
			table.Columns.Add("DateCheckedOut");
			table.Columns.Add("DateExpectedBack");
			table.Columns.Add("DispenseNote");
			table.Columns.Add("Status");
			foreach(Equipment equipment in listEquipments) {
				table.Rows.Add(new object[] {
					POut.Long  (equipment.EquipmentNum),
					            equipment.Description,
					            equipment.SerialNumber,
					            equipment.ModelYear,
					POut.DateT (equipment.DatePurchased,false),
					POut.DateT (equipment.DateSold,false),
					POut.Double(equipment.PurchaseCost),
					POut.Double(equipment.MarketValue),
					            equipment.Location,
					POut.DateT (equipment.DateEntry,false),
					POut.Long  (equipment.ProvNumCheckedOut),
					POut.DateT (equipment.DateCheckedOut,false),
					POut.DateT (equipment.DateExpectedBack,false),
					            equipment.DispenseNote,
					            equipment.Status,
				});
			}
			return table;
		}

		///<summary>Inserts one Equipment into the database.  Returns the new priKey.</summary>
		public static long Insert(Equipment equipment) {
			return Insert(equipment,false);
		}

		///<summary>Inserts one Equipment into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Equipment equipment,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				equipment.EquipmentNum=ReplicationServers.GetKey("equipment","EquipmentNum");
			}
			string command="INSERT INTO equipment (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="EquipmentNum,";
			}
			command+="Description,SerialNumber,ModelYear,DatePurchased,DateSold,PurchaseCost,MarketValue,Location,DateEntry,ProvNumCheckedOut,DateCheckedOut,DateExpectedBack,DispenseNote,Status) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(equipment.EquipmentNum)+",";
			}
			command+=
				     DbHelper.ParamChar+"paramDescription,"
				+"'"+POut.String(equipment.SerialNumber)+"',"
				+"'"+POut.String(equipment.ModelYear)+"',"
				+    POut.Date  (equipment.DatePurchased)+","
				+    POut.Date  (equipment.DateSold)+","
				+		 POut.Double(equipment.PurchaseCost)+","
				+		 POut.Double(equipment.MarketValue)+","
				+    DbHelper.ParamChar+"paramLocation,"
				+    POut.Date  (equipment.DateEntry)+","
				+    POut.Long  (equipment.ProvNumCheckedOut)+","
				+    POut.Date  (equipment.DateCheckedOut)+","
				+    POut.Date  (equipment.DateExpectedBack)+","
				+    DbHelper.ParamChar+"paramDispenseNote,"
				+    DbHelper.ParamChar+"paramStatus)";
			if(equipment.Description==null) {
				equipment.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(equipment.Description));
			if(equipment.Location==null) {
				equipment.Location="";
			}
			OdSqlParameter paramLocation=new OdSqlParameter("paramLocation",OdDbType.Text,POut.StringParam(equipment.Location));
			if(equipment.DispenseNote==null) {
				equipment.DispenseNote="";
			}
			OdSqlParameter paramDispenseNote=new OdSqlParameter("paramDispenseNote",OdDbType.Text,POut.StringNote(equipment.DispenseNote));
			if(equipment.Status==null) {
				equipment.Status="";
			}
			OdSqlParameter paramStatus=new OdSqlParameter("paramStatus",OdDbType.Text,POut.StringParam(equipment.Status));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramDescription,paramLocation,paramDispenseNote,paramStatus);
			}
			else {
				equipment.EquipmentNum=Db.NonQ(command,true,"EquipmentNum","equipment",paramDescription,paramLocation,paramDispenseNote,paramStatus);
			}
			return equipment.EquipmentNum;
		}

		///<summary>Inserts one Equipment into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Equipment equipment) {
			return InsertNoCache(equipment,false);
		}

		///<summary>Inserts one Equipment into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Equipment equipment,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO equipment (";
			if(!useExistingPK && isRandomKeys) {
				equipment.EquipmentNum=ReplicationServers.GetKeyNoCache("equipment","EquipmentNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="EquipmentNum,";
			}
			command+="Description,SerialNumber,ModelYear,DatePurchased,DateSold,PurchaseCost,MarketValue,Location,DateEntry,ProvNumCheckedOut,DateCheckedOut,DateExpectedBack,DispenseNote,Status) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(equipment.EquipmentNum)+",";
			}
			command+=
				     DbHelper.ParamChar+"paramDescription,"
				+"'"+POut.String(equipment.SerialNumber)+"',"
				+"'"+POut.String(equipment.ModelYear)+"',"
				+    POut.Date  (equipment.DatePurchased)+","
				+    POut.Date  (equipment.DateSold)+","
				+	   POut.Double(equipment.PurchaseCost)+","
				+	   POut.Double(equipment.MarketValue)+","
				+    DbHelper.ParamChar+"paramLocation,"
				+    POut.Date  (equipment.DateEntry)+","
				+    POut.Long  (equipment.ProvNumCheckedOut)+","
				+    POut.Date  (equipment.DateCheckedOut)+","
				+    POut.Date  (equipment.DateExpectedBack)+","
				+    DbHelper.ParamChar+"paramDispenseNote,"
				+    DbHelper.ParamChar+"paramStatus)";
			if(equipment.Description==null) {
				equipment.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(equipment.Description));
			if(equipment.Location==null) {
				equipment.Location="";
			}
			OdSqlParameter paramLocation=new OdSqlParameter("paramLocation",OdDbType.Text,POut.StringParam(equipment.Location));
			if(equipment.DispenseNote==null) {
				equipment.DispenseNote="";
			}
			OdSqlParameter paramDispenseNote=new OdSqlParameter("paramDispenseNote",OdDbType.Text,POut.StringNote(equipment.DispenseNote));
			if(equipment.Status==null) {
				equipment.Status="";
			}
			OdSqlParameter paramStatus=new OdSqlParameter("paramStatus",OdDbType.Text,POut.StringParam(equipment.Status));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramDescription,paramLocation,paramDispenseNote,paramStatus);
			}
			else {
				equipment.EquipmentNum=Db.NonQ(command,true,"EquipmentNum","equipment",paramDescription,paramLocation,paramDispenseNote,paramStatus);
			}
			return equipment.EquipmentNum;
		}

		///<summary>Updates one Equipment in the database.</summary>
		public static void Update(Equipment equipment) {
			string command="UPDATE equipment SET "
				+"Description      =  "+DbHelper.ParamChar+"paramDescription, "
				+"SerialNumber     = '"+POut.String(equipment.SerialNumber)+"', "
				+"ModelYear        = '"+POut.String(equipment.ModelYear)+"', "
				+"DatePurchased    =  "+POut.Date  (equipment.DatePurchased)+", "
				+"DateSold         =  "+POut.Date  (equipment.DateSold)+", "
				+"PurchaseCost     =  "+POut.Double(equipment.PurchaseCost)+", "
				+"MarketValue      =  "+POut.Double(equipment.MarketValue)+", "
				+"Location         =  "+DbHelper.ParamChar+"paramLocation, "
				+"DateEntry        =  "+POut.Date  (equipment.DateEntry)+", "
				+"ProvNumCheckedOut=  "+POut.Long  (equipment.ProvNumCheckedOut)+", "
				+"DateCheckedOut   =  "+POut.Date  (equipment.DateCheckedOut)+", "
				+"DateExpectedBack =  "+POut.Date  (equipment.DateExpectedBack)+", "
				+"DispenseNote     =  "+DbHelper.ParamChar+"paramDispenseNote, "
				+"Status           =  "+DbHelper.ParamChar+"paramStatus "
				+"WHERE EquipmentNum = "+POut.Long(equipment.EquipmentNum);
			if(equipment.Description==null) {
				equipment.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(equipment.Description));
			if(equipment.Location==null) {
				equipment.Location="";
			}
			OdSqlParameter paramLocation=new OdSqlParameter("paramLocation",OdDbType.Text,POut.StringParam(equipment.Location));
			if(equipment.DispenseNote==null) {
				equipment.DispenseNote="";
			}
			OdSqlParameter paramDispenseNote=new OdSqlParameter("paramDispenseNote",OdDbType.Text,POut.StringNote(equipment.DispenseNote));
			if(equipment.Status==null) {
				equipment.Status="";
			}
			OdSqlParameter paramStatus=new OdSqlParameter("paramStatus",OdDbType.Text,POut.StringParam(equipment.Status));
			Db.NonQ(command,paramDescription,paramLocation,paramDispenseNote,paramStatus);
		}

		///<summary>Updates one Equipment in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Equipment equipment,Equipment oldEquipment) {
			string command="";
			if(equipment.Description != oldEquipment.Description) {
				if(command!="") { command+=",";}
				command+="Description = "+DbHelper.ParamChar+"paramDescription";
			}
			if(equipment.SerialNumber != oldEquipment.SerialNumber) {
				if(command!="") { command+=",";}
				command+="SerialNumber = '"+POut.String(equipment.SerialNumber)+"'";
			}
			if(equipment.ModelYear != oldEquipment.ModelYear) {
				if(command!="") { command+=",";}
				command+="ModelYear = '"+POut.String(equipment.ModelYear)+"'";
			}
			if(equipment.DatePurchased.Date != oldEquipment.DatePurchased.Date) {
				if(command!="") { command+=",";}
				command+="DatePurchased = "+POut.Date(equipment.DatePurchased)+"";
			}
			if(equipment.DateSold.Date != oldEquipment.DateSold.Date) {
				if(command!="") { command+=",";}
				command+="DateSold = "+POut.Date(equipment.DateSold)+"";
			}
			if(equipment.PurchaseCost != oldEquipment.PurchaseCost) {
				if(command!="") { command+=",";}
				command+="PurchaseCost = "+POut.Double(equipment.PurchaseCost)+"";
			}
			if(equipment.MarketValue != oldEquipment.MarketValue) {
				if(command!="") { command+=",";}
				command+="MarketValue = "+POut.Double(equipment.MarketValue)+"";
			}
			if(equipment.Location != oldEquipment.Location) {
				if(command!="") { command+=",";}
				command+="Location = "+DbHelper.ParamChar+"paramLocation";
			}
			if(equipment.DateEntry.Date != oldEquipment.DateEntry.Date) {
				if(command!="") { command+=",";}
				command+="DateEntry = "+POut.Date(equipment.DateEntry)+"";
			}
			if(equipment.ProvNumCheckedOut != oldEquipment.ProvNumCheckedOut) {
				if(command!="") { command+=",";}
				command+="ProvNumCheckedOut = "+POut.Long(equipment.ProvNumCheckedOut)+"";
			}
			if(equipment.DateCheckedOut.Date != oldEquipment.DateCheckedOut.Date) {
				if(command!="") { command+=",";}
				command+="DateCheckedOut = "+POut.Date(equipment.DateCheckedOut)+"";
			}
			if(equipment.DateExpectedBack.Date != oldEquipment.DateExpectedBack.Date) {
				if(command!="") { command+=",";}
				command+="DateExpectedBack = "+POut.Date(equipment.DateExpectedBack)+"";
			}
			if(equipment.DispenseNote != oldEquipment.DispenseNote) {
				if(command!="") { command+=",";}
				command+="DispenseNote = "+DbHelper.ParamChar+"paramDispenseNote";
			}
			if(equipment.Status != oldEquipment.Status) {
				if(command!="") { command+=",";}
				command+="Status = "+DbHelper.ParamChar+"paramStatus";
			}
			if(command=="") {
				return false;
			}
			if(equipment.Description==null) {
				equipment.Description="";
			}
			OdSqlParameter paramDescription=new OdSqlParameter("paramDescription",OdDbType.Text,POut.StringParam(equipment.Description));
			if(equipment.Location==null) {
				equipment.Location="";
			}
			OdSqlParameter paramLocation=new OdSqlParameter("paramLocation",OdDbType.Text,POut.StringParam(equipment.Location));
			if(equipment.DispenseNote==null) {
				equipment.DispenseNote="";
			}
			OdSqlParameter paramDispenseNote=new OdSqlParameter("paramDispenseNote",OdDbType.Text,POut.StringNote(equipment.DispenseNote));
			if(equipment.Status==null) {
				equipment.Status="";
			}
			OdSqlParameter paramStatus=new OdSqlParameter("paramStatus",OdDbType.Text,POut.StringParam(equipment.Status));
			command="UPDATE equipment SET "+command
				+" WHERE EquipmentNum = "+POut.Long(equipment.EquipmentNum);
			Db.NonQ(command,paramDescription,paramLocation,paramDispenseNote,paramStatus);
			return true;
		}

		///<summary>Returns true if Update(Equipment,Equipment) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Equipment equipment,Equipment oldEquipment) {
			if(equipment.Description != oldEquipment.Description) {
				return true;
			}
			if(equipment.SerialNumber != oldEquipment.SerialNumber) {
				return true;
			}
			if(equipment.ModelYear != oldEquipment.ModelYear) {
				return true;
			}
			if(equipment.DatePurchased.Date != oldEquipment.DatePurchased.Date) {
				return true;
			}
			if(equipment.DateSold.Date != oldEquipment.DateSold.Date) {
				return true;
			}
			if(equipment.PurchaseCost != oldEquipment.PurchaseCost) {
				return true;
			}
			if(equipment.MarketValue != oldEquipment.MarketValue) {
				return true;
			}
			if(equipment.Location != oldEquipment.Location) {
				return true;
			}
			if(equipment.DateEntry.Date != oldEquipment.DateEntry.Date) {
				return true;
			}
			if(equipment.ProvNumCheckedOut != oldEquipment.ProvNumCheckedOut) {
				return true;
			}
			if(equipment.DateCheckedOut.Date != oldEquipment.DateCheckedOut.Date) {
				return true;
			}
			if(equipment.DateExpectedBack.Date != oldEquipment.DateExpectedBack.Date) {
				return true;
			}
			if(equipment.DispenseNote != oldEquipment.DispenseNote) {
				return true;
			}
			if(equipment.Status != oldEquipment.Status) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Equipment from the database.</summary>
		public static void Delete(long equipmentNum) {
			string command="DELETE FROM equipment "
				+"WHERE EquipmentNum = "+POut.Long(equipmentNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Equipments from the database.</summary>
		public static void DeleteMany(List<long> listEquipmentNums) {
			if(listEquipmentNums==null || listEquipmentNums.Count==0) {
				return;
			}
			string command="DELETE FROM equipment "
				+"WHERE EquipmentNum IN("+string.Join(",",listEquipmentNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}