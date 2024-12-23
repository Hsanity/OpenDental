//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class EFormFieldDefCrud {
		///<summary>Gets one EFormFieldDef object from the database using the primary key.  Returns null if not found.</summary>
		public static EFormFieldDef SelectOne(long eFormFieldDefNum) {
			string command="SELECT * FROM eformfielddef "
				+"WHERE EFormFieldDefNum = "+POut.Long(eFormFieldDefNum);
			List<EFormFieldDef> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one EFormFieldDef object from the database using a query.</summary>
		public static EFormFieldDef SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<EFormFieldDef> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of EFormFieldDef objects from the database using a query.</summary>
		public static List<EFormFieldDef> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<EFormFieldDef> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<EFormFieldDef> TableToList(DataTable table) {
			List<EFormFieldDef> retVal=new List<EFormFieldDef>();
			EFormFieldDef eFormFieldDef;
			foreach(DataRow row in table.Rows) {
				eFormFieldDef=new EFormFieldDef();
				eFormFieldDef.EFormFieldDefNum = PIn.Long  (row["EFormFieldDefNum"].ToString());
				eFormFieldDef.EFormDefNum      = PIn.Long  (row["EFormDefNum"].ToString());
				eFormFieldDef.FieldType        = (OpenDentBusiness.EnumEFormFieldType)PIn.Int(row["FieldType"].ToString());
				eFormFieldDef.DbLink           = PIn.String(row["DbLink"].ToString());
				eFormFieldDef.ValueLabel       = PIn.String(row["ValueLabel"].ToString());
				eFormFieldDef.ItemOrder        = PIn.Int   (row["ItemOrder"].ToString());
				eFormFieldDef.PickListVis      = PIn.String(row["PickListVis"].ToString());
				eFormFieldDef.PickListDb       = PIn.String(row["PickListDb"].ToString());
				eFormFieldDef.IsHorizStacking  = PIn.Bool  (row["IsHorizStacking"].ToString());
				eFormFieldDef.IsTextWrap       = PIn.Bool  (row["IsTextWrap"].ToString());
				eFormFieldDef.Width            = PIn.Int   (row["Width"].ToString());
				eFormFieldDef.FontScale        = PIn.Int   (row["FontScale"].ToString());
				eFormFieldDef.IsRequired       = PIn.Bool  (row["IsRequired"].ToString());
				eFormFieldDef.ConditionalParent= PIn.String(row["ConditionalParent"].ToString());
				eFormFieldDef.ConditionalValue = PIn.String(row["ConditionalValue"].ToString());
				eFormFieldDef.LabelAlign       = (OpenDentBusiness.EnumEFormLabelAlign)PIn.Int(row["LabelAlign"].ToString());
				eFormFieldDef.SpaceBelow       = PIn.Int   (row["SpaceBelow"].ToString());
				eFormFieldDef.ReportableName   = PIn.String(row["ReportableName"].ToString());
				eFormFieldDef.IsLocked         = PIn.Bool  (row["IsLocked"].ToString());
				eFormFieldDef.Border           = (OpenDentBusiness.EnumEFormBorder)PIn.Int(row["Border"].ToString());
				eFormFieldDef.IsWidthPercentage= PIn.Bool  (row["IsWidthPercentage"].ToString());
				eFormFieldDef.MinWidth         = PIn.Int   (row["MinWidth"].ToString());
				retVal.Add(eFormFieldDef);
			}
			return retVal;
		}

		///<summary>Converts a list of EFormFieldDef into a DataTable.</summary>
		public static DataTable ListToTable(List<EFormFieldDef> listEFormFieldDefs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="EFormFieldDef";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("EFormFieldDefNum");
			table.Columns.Add("EFormDefNum");
			table.Columns.Add("FieldType");
			table.Columns.Add("DbLink");
			table.Columns.Add("ValueLabel");
			table.Columns.Add("ItemOrder");
			table.Columns.Add("PickListVis");
			table.Columns.Add("PickListDb");
			table.Columns.Add("IsHorizStacking");
			table.Columns.Add("IsTextWrap");
			table.Columns.Add("Width");
			table.Columns.Add("FontScale");
			table.Columns.Add("IsRequired");
			table.Columns.Add("ConditionalParent");
			table.Columns.Add("ConditionalValue");
			table.Columns.Add("LabelAlign");
			table.Columns.Add("SpaceBelow");
			table.Columns.Add("ReportableName");
			table.Columns.Add("IsLocked");
			table.Columns.Add("Border");
			table.Columns.Add("IsWidthPercentage");
			table.Columns.Add("MinWidth");
			foreach(EFormFieldDef eFormFieldDef in listEFormFieldDefs) {
				table.Rows.Add(new object[] {
					POut.Long  (eFormFieldDef.EFormFieldDefNum),
					POut.Long  (eFormFieldDef.EFormDefNum),
					POut.Int   ((int)eFormFieldDef.FieldType),
					            eFormFieldDef.DbLink,
					            eFormFieldDef.ValueLabel,
					POut.Int   (eFormFieldDef.ItemOrder),
					            eFormFieldDef.PickListVis,
					            eFormFieldDef.PickListDb,
					POut.Bool  (eFormFieldDef.IsHorizStacking),
					POut.Bool  (eFormFieldDef.IsTextWrap),
					POut.Int   (eFormFieldDef.Width),
					POut.Int   (eFormFieldDef.FontScale),
					POut.Bool  (eFormFieldDef.IsRequired),
					            eFormFieldDef.ConditionalParent,
					            eFormFieldDef.ConditionalValue,
					POut.Int   ((int)eFormFieldDef.LabelAlign),
					POut.Int   (eFormFieldDef.SpaceBelow),
					            eFormFieldDef.ReportableName,
					POut.Bool  (eFormFieldDef.IsLocked),
					POut.Int   ((int)eFormFieldDef.Border),
					POut.Bool  (eFormFieldDef.IsWidthPercentage),
					POut.Int   (eFormFieldDef.MinWidth),
				});
			}
			return table;
		}

		///<summary>Inserts one EFormFieldDef into the database.  Returns the new priKey.</summary>
		public static long Insert(EFormFieldDef eFormFieldDef) {
			return Insert(eFormFieldDef,false);
		}

		///<summary>Inserts one EFormFieldDef into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(EFormFieldDef eFormFieldDef,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				eFormFieldDef.EFormFieldDefNum=ReplicationServers.GetKey("eformfielddef","EFormFieldDefNum");
			}
			string command="INSERT INTO eformfielddef (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="EFormFieldDefNum,";
			}
			command+="EFormDefNum,FieldType,DbLink,ValueLabel,ItemOrder,PickListVis,PickListDb,IsHorizStacking,IsTextWrap,Width,FontScale,IsRequired,ConditionalParent,ConditionalValue,LabelAlign,SpaceBelow,ReportableName,IsLocked,Border,IsWidthPercentage,MinWidth) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(eFormFieldDef.EFormFieldDefNum)+",";
			}
			command+=
				     POut.Long  (eFormFieldDef.EFormDefNum)+","
				+    POut.Int   ((int)eFormFieldDef.FieldType)+","
				+"'"+POut.String(eFormFieldDef.DbLink)+"',"
				+    DbHelper.ParamChar+"paramValueLabel,"
				+    POut.Int   (eFormFieldDef.ItemOrder)+","
				+"'"+POut.String(eFormFieldDef.PickListVis)+"',"
				+"'"+POut.String(eFormFieldDef.PickListDb)+"',"
				+    POut.Bool  (eFormFieldDef.IsHorizStacking)+","
				+    POut.Bool  (eFormFieldDef.IsTextWrap)+","
				+    POut.Int   (eFormFieldDef.Width)+","
				+    POut.Int   (eFormFieldDef.FontScale)+","
				+    POut.Bool  (eFormFieldDef.IsRequired)+","
				+"'"+POut.String(eFormFieldDef.ConditionalParent)+"',"
				+"'"+POut.String(eFormFieldDef.ConditionalValue)+"',"
				+    POut.Int   ((int)eFormFieldDef.LabelAlign)+","
				+    POut.Int   (eFormFieldDef.SpaceBelow)+","
				+"'"+POut.String(eFormFieldDef.ReportableName)+"',"
				+    POut.Bool  (eFormFieldDef.IsLocked)+","
				+    POut.Int   ((int)eFormFieldDef.Border)+","
				+    POut.Bool  (eFormFieldDef.IsWidthPercentage)+","
				+    POut.Int   (eFormFieldDef.MinWidth)+")";
			if(eFormFieldDef.ValueLabel==null) {
				eFormFieldDef.ValueLabel="";
			}
			OdSqlParameter paramValueLabel=new OdSqlParameter("paramValueLabel",OdDbType.Text,POut.StringParam(eFormFieldDef.ValueLabel));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramValueLabel);
			}
			else {
				eFormFieldDef.EFormFieldDefNum=Db.NonQ(command,true,"EFormFieldDefNum","eFormFieldDef",paramValueLabel);
			}
			return eFormFieldDef.EFormFieldDefNum;
		}

		///<summary>Inserts one EFormFieldDef into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(EFormFieldDef eFormFieldDef) {
			return InsertNoCache(eFormFieldDef,false);
		}

		///<summary>Inserts one EFormFieldDef into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(EFormFieldDef eFormFieldDef,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO eformfielddef (";
			if(!useExistingPK && isRandomKeys) {
				eFormFieldDef.EFormFieldDefNum=ReplicationServers.GetKeyNoCache("eformfielddef","EFormFieldDefNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="EFormFieldDefNum,";
			}
			command+="EFormDefNum,FieldType,DbLink,ValueLabel,ItemOrder,PickListVis,PickListDb,IsHorizStacking,IsTextWrap,Width,FontScale,IsRequired,ConditionalParent,ConditionalValue,LabelAlign,SpaceBelow,ReportableName,IsLocked,Border,IsWidthPercentage,MinWidth) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(eFormFieldDef.EFormFieldDefNum)+",";
			}
			command+=
				     POut.Long  (eFormFieldDef.EFormDefNum)+","
				+    POut.Int   ((int)eFormFieldDef.FieldType)+","
				+"'"+POut.String(eFormFieldDef.DbLink)+"',"
				+    DbHelper.ParamChar+"paramValueLabel,"
				+    POut.Int   (eFormFieldDef.ItemOrder)+","
				+"'"+POut.String(eFormFieldDef.PickListVis)+"',"
				+"'"+POut.String(eFormFieldDef.PickListDb)+"',"
				+    POut.Bool  (eFormFieldDef.IsHorizStacking)+","
				+    POut.Bool  (eFormFieldDef.IsTextWrap)+","
				+    POut.Int   (eFormFieldDef.Width)+","
				+    POut.Int   (eFormFieldDef.FontScale)+","
				+    POut.Bool  (eFormFieldDef.IsRequired)+","
				+"'"+POut.String(eFormFieldDef.ConditionalParent)+"',"
				+"'"+POut.String(eFormFieldDef.ConditionalValue)+"',"
				+    POut.Int   ((int)eFormFieldDef.LabelAlign)+","
				+    POut.Int   (eFormFieldDef.SpaceBelow)+","
				+"'"+POut.String(eFormFieldDef.ReportableName)+"',"
				+    POut.Bool  (eFormFieldDef.IsLocked)+","
				+    POut.Int   ((int)eFormFieldDef.Border)+","
				+    POut.Bool  (eFormFieldDef.IsWidthPercentage)+","
				+    POut.Int   (eFormFieldDef.MinWidth)+")";
			if(eFormFieldDef.ValueLabel==null) {
				eFormFieldDef.ValueLabel="";
			}
			OdSqlParameter paramValueLabel=new OdSqlParameter("paramValueLabel",OdDbType.Text,POut.StringParam(eFormFieldDef.ValueLabel));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramValueLabel);
			}
			else {
				eFormFieldDef.EFormFieldDefNum=Db.NonQ(command,true,"EFormFieldDefNum","eFormFieldDef",paramValueLabel);
			}
			return eFormFieldDef.EFormFieldDefNum;
		}

		///<summary>Updates one EFormFieldDef in the database.</summary>
		public static void Update(EFormFieldDef eFormFieldDef) {
			string command="UPDATE eformfielddef SET "
				+"EFormDefNum      =  "+POut.Long  (eFormFieldDef.EFormDefNum)+", "
				+"FieldType        =  "+POut.Int   ((int)eFormFieldDef.FieldType)+", "
				+"DbLink           = '"+POut.String(eFormFieldDef.DbLink)+"', "
				+"ValueLabel       =  "+DbHelper.ParamChar+"paramValueLabel, "
				+"ItemOrder        =  "+POut.Int   (eFormFieldDef.ItemOrder)+", "
				+"PickListVis      = '"+POut.String(eFormFieldDef.PickListVis)+"', "
				+"PickListDb       = '"+POut.String(eFormFieldDef.PickListDb)+"', "
				+"IsHorizStacking  =  "+POut.Bool  (eFormFieldDef.IsHorizStacking)+", "
				+"IsTextWrap       =  "+POut.Bool  (eFormFieldDef.IsTextWrap)+", "
				+"Width            =  "+POut.Int   (eFormFieldDef.Width)+", "
				+"FontScale        =  "+POut.Int   (eFormFieldDef.FontScale)+", "
				+"IsRequired       =  "+POut.Bool  (eFormFieldDef.IsRequired)+", "
				+"ConditionalParent= '"+POut.String(eFormFieldDef.ConditionalParent)+"', "
				+"ConditionalValue = '"+POut.String(eFormFieldDef.ConditionalValue)+"', "
				+"LabelAlign       =  "+POut.Int   ((int)eFormFieldDef.LabelAlign)+", "
				+"SpaceBelow       =  "+POut.Int   (eFormFieldDef.SpaceBelow)+", "
				+"ReportableName   = '"+POut.String(eFormFieldDef.ReportableName)+"', "
				+"IsLocked         =  "+POut.Bool  (eFormFieldDef.IsLocked)+", "
				+"Border           =  "+POut.Int   ((int)eFormFieldDef.Border)+", "
				+"IsWidthPercentage=  "+POut.Bool  (eFormFieldDef.IsWidthPercentage)+", "
				+"MinWidth         =  "+POut.Int   (eFormFieldDef.MinWidth)+" "
				+"WHERE EFormFieldDefNum = "+POut.Long(eFormFieldDef.EFormFieldDefNum);
			if(eFormFieldDef.ValueLabel==null) {
				eFormFieldDef.ValueLabel="";
			}
			OdSqlParameter paramValueLabel=new OdSqlParameter("paramValueLabel",OdDbType.Text,POut.StringParam(eFormFieldDef.ValueLabel));
			Db.NonQ(command,paramValueLabel);
		}

		///<summary>Updates one EFormFieldDef in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(EFormFieldDef eFormFieldDef,EFormFieldDef oldEFormFieldDef) {
			string command="";
			if(eFormFieldDef.EFormDefNum != oldEFormFieldDef.EFormDefNum) {
				if(command!="") { command+=",";}
				command+="EFormDefNum = "+POut.Long(eFormFieldDef.EFormDefNum)+"";
			}
			if(eFormFieldDef.FieldType != oldEFormFieldDef.FieldType) {
				if(command!="") { command+=",";}
				command+="FieldType = "+POut.Int   ((int)eFormFieldDef.FieldType)+"";
			}
			if(eFormFieldDef.DbLink != oldEFormFieldDef.DbLink) {
				if(command!="") { command+=",";}
				command+="DbLink = '"+POut.String(eFormFieldDef.DbLink)+"'";
			}
			if(eFormFieldDef.ValueLabel != oldEFormFieldDef.ValueLabel) {
				if(command!="") { command+=",";}
				command+="ValueLabel = "+DbHelper.ParamChar+"paramValueLabel";
			}
			if(eFormFieldDef.ItemOrder != oldEFormFieldDef.ItemOrder) {
				if(command!="") { command+=",";}
				command+="ItemOrder = "+POut.Int(eFormFieldDef.ItemOrder)+"";
			}
			if(eFormFieldDef.PickListVis != oldEFormFieldDef.PickListVis) {
				if(command!="") { command+=",";}
				command+="PickListVis = '"+POut.String(eFormFieldDef.PickListVis)+"'";
			}
			if(eFormFieldDef.PickListDb != oldEFormFieldDef.PickListDb) {
				if(command!="") { command+=",";}
				command+="PickListDb = '"+POut.String(eFormFieldDef.PickListDb)+"'";
			}
			if(eFormFieldDef.IsHorizStacking != oldEFormFieldDef.IsHorizStacking) {
				if(command!="") { command+=",";}
				command+="IsHorizStacking = "+POut.Bool(eFormFieldDef.IsHorizStacking)+"";
			}
			if(eFormFieldDef.IsTextWrap != oldEFormFieldDef.IsTextWrap) {
				if(command!="") { command+=",";}
				command+="IsTextWrap = "+POut.Bool(eFormFieldDef.IsTextWrap)+"";
			}
			if(eFormFieldDef.Width != oldEFormFieldDef.Width) {
				if(command!="") { command+=",";}
				command+="Width = "+POut.Int(eFormFieldDef.Width)+"";
			}
			if(eFormFieldDef.FontScale != oldEFormFieldDef.FontScale) {
				if(command!="") { command+=",";}
				command+="FontScale = "+POut.Int(eFormFieldDef.FontScale)+"";
			}
			if(eFormFieldDef.IsRequired != oldEFormFieldDef.IsRequired) {
				if(command!="") { command+=",";}
				command+="IsRequired = "+POut.Bool(eFormFieldDef.IsRequired)+"";
			}
			if(eFormFieldDef.ConditionalParent != oldEFormFieldDef.ConditionalParent) {
				if(command!="") { command+=",";}
				command+="ConditionalParent = '"+POut.String(eFormFieldDef.ConditionalParent)+"'";
			}
			if(eFormFieldDef.ConditionalValue != oldEFormFieldDef.ConditionalValue) {
				if(command!="") { command+=",";}
				command+="ConditionalValue = '"+POut.String(eFormFieldDef.ConditionalValue)+"'";
			}
			if(eFormFieldDef.LabelAlign != oldEFormFieldDef.LabelAlign) {
				if(command!="") { command+=",";}
				command+="LabelAlign = "+POut.Int   ((int)eFormFieldDef.LabelAlign)+"";
			}
			if(eFormFieldDef.SpaceBelow != oldEFormFieldDef.SpaceBelow) {
				if(command!="") { command+=",";}
				command+="SpaceBelow = "+POut.Int(eFormFieldDef.SpaceBelow)+"";
			}
			if(eFormFieldDef.ReportableName != oldEFormFieldDef.ReportableName) {
				if(command!="") { command+=",";}
				command+="ReportableName = '"+POut.String(eFormFieldDef.ReportableName)+"'";
			}
			if(eFormFieldDef.IsLocked != oldEFormFieldDef.IsLocked) {
				if(command!="") { command+=",";}
				command+="IsLocked = "+POut.Bool(eFormFieldDef.IsLocked)+"";
			}
			if(eFormFieldDef.Border != oldEFormFieldDef.Border) {
				if(command!="") { command+=",";}
				command+="Border = "+POut.Int   ((int)eFormFieldDef.Border)+"";
			}
			if(eFormFieldDef.IsWidthPercentage != oldEFormFieldDef.IsWidthPercentage) {
				if(command!="") { command+=",";}
				command+="IsWidthPercentage = "+POut.Bool(eFormFieldDef.IsWidthPercentage)+"";
			}
			if(eFormFieldDef.MinWidth != oldEFormFieldDef.MinWidth) {
				if(command!="") { command+=",";}
				command+="MinWidth = "+POut.Int(eFormFieldDef.MinWidth)+"";
			}
			if(command=="") {
				return false;
			}
			if(eFormFieldDef.ValueLabel==null) {
				eFormFieldDef.ValueLabel="";
			}
			OdSqlParameter paramValueLabel=new OdSqlParameter("paramValueLabel",OdDbType.Text,POut.StringParam(eFormFieldDef.ValueLabel));
			command="UPDATE eformfielddef SET "+command
				+" WHERE EFormFieldDefNum = "+POut.Long(eFormFieldDef.EFormFieldDefNum);
			Db.NonQ(command,paramValueLabel);
			return true;
		}

		///<summary>Returns true if Update(EFormFieldDef,EFormFieldDef) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(EFormFieldDef eFormFieldDef,EFormFieldDef oldEFormFieldDef) {
			if(eFormFieldDef.EFormDefNum != oldEFormFieldDef.EFormDefNum) {
				return true;
			}
			if(eFormFieldDef.FieldType != oldEFormFieldDef.FieldType) {
				return true;
			}
			if(eFormFieldDef.DbLink != oldEFormFieldDef.DbLink) {
				return true;
			}
			if(eFormFieldDef.ValueLabel != oldEFormFieldDef.ValueLabel) {
				return true;
			}
			if(eFormFieldDef.ItemOrder != oldEFormFieldDef.ItemOrder) {
				return true;
			}
			if(eFormFieldDef.PickListVis != oldEFormFieldDef.PickListVis) {
				return true;
			}
			if(eFormFieldDef.PickListDb != oldEFormFieldDef.PickListDb) {
				return true;
			}
			if(eFormFieldDef.IsHorizStacking != oldEFormFieldDef.IsHorizStacking) {
				return true;
			}
			if(eFormFieldDef.IsTextWrap != oldEFormFieldDef.IsTextWrap) {
				return true;
			}
			if(eFormFieldDef.Width != oldEFormFieldDef.Width) {
				return true;
			}
			if(eFormFieldDef.FontScale != oldEFormFieldDef.FontScale) {
				return true;
			}
			if(eFormFieldDef.IsRequired != oldEFormFieldDef.IsRequired) {
				return true;
			}
			if(eFormFieldDef.ConditionalParent != oldEFormFieldDef.ConditionalParent) {
				return true;
			}
			if(eFormFieldDef.ConditionalValue != oldEFormFieldDef.ConditionalValue) {
				return true;
			}
			if(eFormFieldDef.LabelAlign != oldEFormFieldDef.LabelAlign) {
				return true;
			}
			if(eFormFieldDef.SpaceBelow != oldEFormFieldDef.SpaceBelow) {
				return true;
			}
			if(eFormFieldDef.ReportableName != oldEFormFieldDef.ReportableName) {
				return true;
			}
			if(eFormFieldDef.IsLocked != oldEFormFieldDef.IsLocked) {
				return true;
			}
			if(eFormFieldDef.Border != oldEFormFieldDef.Border) {
				return true;
			}
			if(eFormFieldDef.IsWidthPercentage != oldEFormFieldDef.IsWidthPercentage) {
				return true;
			}
			if(eFormFieldDef.MinWidth != oldEFormFieldDef.MinWidth) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one EFormFieldDef from the database.</summary>
		public static void Delete(long eFormFieldDefNum) {
			string command="DELETE FROM eformfielddef "
				+"WHERE EFormFieldDefNum = "+POut.Long(eFormFieldDefNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many EFormFieldDefs from the database.</summary>
		public static void DeleteMany(List<long> listEFormFieldDefNums) {
			if(listEFormFieldDefNums==null || listEFormFieldDefNums.Count==0) {
				return;
			}
			string command="DELETE FROM eformfielddef "
				+"WHERE EFormFieldDefNum IN("+string.Join(",",listEFormFieldDefNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}