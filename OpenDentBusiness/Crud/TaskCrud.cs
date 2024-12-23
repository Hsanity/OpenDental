//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class TaskCrud {
		///<summary>Gets one Task object from the database using the primary key.  Returns null if not found.</summary>
		public static Task SelectOne(long taskNum) {
			string command="SELECT * FROM task "
				+"WHERE TaskNum = "+POut.Long(taskNum);
			List<Task> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Task object from the database using a query.</summary>
		public static Task SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Task> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Task objects from the database using a query.</summary>
		public static List<Task> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Task> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Task> TableToList(DataTable table) {
			List<Task> retVal=new List<Task>();
			Task task;
			foreach(DataRow row in table.Rows) {
				task=new Task();
				task.TaskNum          = PIn.Long  (row["TaskNum"].ToString());
				task.TaskListNum      = PIn.Long  (row["TaskListNum"].ToString());
				task.DateTask         = PIn.Date  (row["DateTask"].ToString());
				task.KeyNum           = PIn.Long  (row["KeyNum"].ToString());
				task.Descript         = PIn.String(row["Descript"].ToString());
				task.TaskStatus       = (OpenDentBusiness.TaskStatusEnum)PIn.Int(row["TaskStatus"].ToString());
				task.IsRepeating      = PIn.Bool  (row["IsRepeating"].ToString());
				task.DateType         = (OpenDentBusiness.TaskDateType)PIn.Int(row["DateType"].ToString());
				task.FromNum          = PIn.Long  (row["FromNum"].ToString());
				task.ObjectType       = (OpenDentBusiness.TaskObjectType)PIn.Int(row["ObjectType"].ToString());
				task.DateTimeEntry    = PIn.DateT (row["DateTimeEntry"].ToString());
				task.UserNum          = PIn.Long  (row["UserNum"].ToString());
				task.DateTimeFinished = PIn.DateT (row["DateTimeFinished"].ToString());
				task.PriorityDefNum   = PIn.Long  (row["PriorityDefNum"].ToString());
				task.ReminderGroupId  = PIn.String(row["ReminderGroupId"].ToString());
				task.ReminderType     = (OpenDentBusiness.TaskReminderType)PIn.Int(row["ReminderType"].ToString());
				task.ReminderFrequency= PIn.Int   (row["ReminderFrequency"].ToString());
				task.DateTimeOriginal = PIn.DateT (row["DateTimeOriginal"].ToString());
				task.SecDateTEdit     = PIn.DateT (row["SecDateTEdit"].ToString());
				task.DescriptOverride = PIn.String(row["DescriptOverride"].ToString());
				task.IsReadOnly       = PIn.Bool  (row["IsReadOnly"].ToString());
				task.TriageCategory   = PIn.Long  (row["TriageCategory"].ToString());
				retVal.Add(task);
			}
			return retVal;
		}

		///<summary>Converts a list of Task into a DataTable.</summary>
		public static DataTable ListToTable(List<Task> listTasks,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Task";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("TaskNum");
			table.Columns.Add("TaskListNum");
			table.Columns.Add("DateTask");
			table.Columns.Add("KeyNum");
			table.Columns.Add("Descript");
			table.Columns.Add("TaskStatus");
			table.Columns.Add("IsRepeating");
			table.Columns.Add("DateType");
			table.Columns.Add("FromNum");
			table.Columns.Add("ObjectType");
			table.Columns.Add("DateTimeEntry");
			table.Columns.Add("UserNum");
			table.Columns.Add("DateTimeFinished");
			table.Columns.Add("PriorityDefNum");
			table.Columns.Add("ReminderGroupId");
			table.Columns.Add("ReminderType");
			table.Columns.Add("ReminderFrequency");
			table.Columns.Add("DateTimeOriginal");
			table.Columns.Add("SecDateTEdit");
			table.Columns.Add("DescriptOverride");
			table.Columns.Add("IsReadOnly");
			table.Columns.Add("TriageCategory");
			foreach(Task task in listTasks) {
				table.Rows.Add(new object[] {
					POut.Long  (task.TaskNum),
					POut.Long  (task.TaskListNum),
					POut.DateT (task.DateTask,false),
					POut.Long  (task.KeyNum),
					            task.Descript,
					POut.Int   ((int)task.TaskStatus),
					POut.Bool  (task.IsRepeating),
					POut.Int   ((int)task.DateType),
					POut.Long  (task.FromNum),
					POut.Int   ((int)task.ObjectType),
					POut.DateT (task.DateTimeEntry,false),
					POut.Long  (task.UserNum),
					POut.DateT (task.DateTimeFinished,false),
					POut.Long  (task.PriorityDefNum),
					            task.ReminderGroupId,
					POut.Int   ((int)task.ReminderType),
					POut.Int   (task.ReminderFrequency),
					POut.DateT (task.DateTimeOriginal,false),
					POut.DateT (task.SecDateTEdit,false),
					            task.DescriptOverride,
					POut.Bool  (task.IsReadOnly),
					POut.Long  (task.TriageCategory),
				});
			}
			return table;
		}

		///<summary>Inserts one Task into the database.  Returns the new priKey.</summary>
		public static long Insert(Task task) {
			return Insert(task,false);
		}

		///<summary>Inserts one Task into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Task task,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				task.TaskNum=ReplicationServers.GetKey("task","TaskNum");
			}
			string command="INSERT INTO task (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="TaskNum,";
			}
			command+="TaskListNum,DateTask,KeyNum,Descript,TaskStatus,IsRepeating,DateType,FromNum,ObjectType,DateTimeEntry,UserNum,DateTimeFinished,PriorityDefNum,ReminderGroupId,ReminderType,ReminderFrequency,DateTimeOriginal,DescriptOverride,IsReadOnly,TriageCategory) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(task.TaskNum)+",";
			}
			command+=
				     POut.Long  (task.TaskListNum)+","
				+    POut.Date  (task.DateTask)+","
				+    POut.Long  (task.KeyNum)+","
				+    DbHelper.ParamChar+"paramDescript,"
				+    POut.Int   ((int)task.TaskStatus)+","
				+    POut.Bool  (task.IsRepeating)+","
				+    POut.Int   ((int)task.DateType)+","
				+    POut.Long  (task.FromNum)+","
				+    POut.Int   ((int)task.ObjectType)+","
				+    POut.DateT (task.DateTimeEntry)+","
				+    POut.Long  (task.UserNum)+","
				+    POut.DateT (task.DateTimeFinished)+","
				+    POut.Long  (task.PriorityDefNum)+","
				+"'"+POut.String(task.ReminderGroupId)+"',"
				+    POut.Int   ((int)task.ReminderType)+","
				+    POut.Int   (task.ReminderFrequency)+","
				+    DbHelper.Now()+","
				//SecDateTEdit can only be set by MySQL
				+"'"+POut.String(task.DescriptOverride)+"',"
				+    POut.Bool  (task.IsReadOnly)+","
				+    POut.Long  (task.TriageCategory)+")";
			if(task.Descript==null) {
				task.Descript="";
			}
			OdSqlParameter paramDescript=new OdSqlParameter("paramDescript",OdDbType.Text,POut.StringParam(task.Descript));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramDescript);
			}
			else {
				task.TaskNum=Db.NonQ(command,true,"TaskNum","task",paramDescript);
			}
			return task.TaskNum;
		}

		///<summary>Inserts one Task into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Task task) {
			return InsertNoCache(task,false);
		}

		///<summary>Inserts one Task into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Task task,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO task (";
			if(!useExistingPK && isRandomKeys) {
				task.TaskNum=ReplicationServers.GetKeyNoCache("task","TaskNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="TaskNum,";
			}
			command+="TaskListNum,DateTask,KeyNum,Descript,TaskStatus,IsRepeating,DateType,FromNum,ObjectType,DateTimeEntry,UserNum,DateTimeFinished,PriorityDefNum,ReminderGroupId,ReminderType,ReminderFrequency,DateTimeOriginal,DescriptOverride,IsReadOnly,TriageCategory) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(task.TaskNum)+",";
			}
			command+=
				     POut.Long  (task.TaskListNum)+","
				+    POut.Date  (task.DateTask)+","
				+    POut.Long  (task.KeyNum)+","
				+    DbHelper.ParamChar+"paramDescript,"
				+    POut.Int   ((int)task.TaskStatus)+","
				+    POut.Bool  (task.IsRepeating)+","
				+    POut.Int   ((int)task.DateType)+","
				+    POut.Long  (task.FromNum)+","
				+    POut.Int   ((int)task.ObjectType)+","
				+    POut.DateT (task.DateTimeEntry)+","
				+    POut.Long  (task.UserNum)+","
				+    POut.DateT (task.DateTimeFinished)+","
				+    POut.Long  (task.PriorityDefNum)+","
				+"'"+POut.String(task.ReminderGroupId)+"',"
				+    POut.Int   ((int)task.ReminderType)+","
				+    POut.Int   (task.ReminderFrequency)+","
				+    DbHelper.Now()+","
				//SecDateTEdit can only be set by MySQL
				+"'"+POut.String(task.DescriptOverride)+"',"
				+    POut.Bool  (task.IsReadOnly)+","
				+    POut.Long  (task.TriageCategory)+")";
			if(task.Descript==null) {
				task.Descript="";
			}
			OdSqlParameter paramDescript=new OdSqlParameter("paramDescript",OdDbType.Text,POut.StringParam(task.Descript));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramDescript);
			}
			else {
				task.TaskNum=Db.NonQ(command,true,"TaskNum","task",paramDescript);
			}
			return task.TaskNum;
		}

		///<summary>Updates one Task in the database.</summary>
		public static void Update(Task task) {
			string command="UPDATE task SET "
				+"TaskListNum      =  "+POut.Long  (task.TaskListNum)+", "
				+"DateTask         =  "+POut.Date  (task.DateTask)+", "
				+"KeyNum           =  "+POut.Long  (task.KeyNum)+", "
				+"Descript         =  "+DbHelper.ParamChar+"paramDescript, "
				+"TaskStatus       =  "+POut.Int   ((int)task.TaskStatus)+", "
				+"IsRepeating      =  "+POut.Bool  (task.IsRepeating)+", "
				+"DateType         =  "+POut.Int   ((int)task.DateType)+", "
				+"FromNum          =  "+POut.Long  (task.FromNum)+", "
				+"ObjectType       =  "+POut.Int   ((int)task.ObjectType)+", "
				+"DateTimeEntry    =  "+POut.DateT (task.DateTimeEntry)+", "
				+"UserNum          =  "+POut.Long  (task.UserNum)+", "
				+"DateTimeFinished =  "+POut.DateT (task.DateTimeFinished)+", "
				+"PriorityDefNum   =  "+POut.Long  (task.PriorityDefNum)+", "
				+"ReminderGroupId  = '"+POut.String(task.ReminderGroupId)+"', "
				+"ReminderType     =  "+POut.Int   ((int)task.ReminderType)+", "
				+"ReminderFrequency=  "+POut.Int   (task.ReminderFrequency)+", "
				//DateTimeOriginal not allowed to change
				//SecDateTEdit can only be set by MySQL
				+"DescriptOverride = '"+POut.String(task.DescriptOverride)+"', "
				+"IsReadOnly       =  "+POut.Bool  (task.IsReadOnly)+", "
				+"TriageCategory   =  "+POut.Long  (task.TriageCategory)+" "
				+"WHERE TaskNum = "+POut.Long(task.TaskNum);
			if(task.Descript==null) {
				task.Descript="";
			}
			OdSqlParameter paramDescript=new OdSqlParameter("paramDescript",OdDbType.Text,POut.StringParam(task.Descript));
			Db.NonQ(command,paramDescript);
		}

		///<summary>Updates one Task in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Task task,Task oldTask) {
			string command="";
			if(task.TaskListNum != oldTask.TaskListNum) {
				if(command!="") { command+=",";}
				command+="TaskListNum = "+POut.Long(task.TaskListNum)+"";
			}
			if(task.DateTask.Date != oldTask.DateTask.Date) {
				if(command!="") { command+=",";}
				command+="DateTask = "+POut.Date(task.DateTask)+"";
			}
			if(task.KeyNum != oldTask.KeyNum) {
				if(command!="") { command+=",";}
				command+="KeyNum = "+POut.Long(task.KeyNum)+"";
			}
			if(task.Descript != oldTask.Descript) {
				if(command!="") { command+=",";}
				command+="Descript = "+DbHelper.ParamChar+"paramDescript";
			}
			if(task.TaskStatus != oldTask.TaskStatus) {
				if(command!="") { command+=",";}
				command+="TaskStatus = "+POut.Int   ((int)task.TaskStatus)+"";
			}
			if(task.IsRepeating != oldTask.IsRepeating) {
				if(command!="") { command+=",";}
				command+="IsRepeating = "+POut.Bool(task.IsRepeating)+"";
			}
			if(task.DateType != oldTask.DateType) {
				if(command!="") { command+=",";}
				command+="DateType = "+POut.Int   ((int)task.DateType)+"";
			}
			if(task.FromNum != oldTask.FromNum) {
				if(command!="") { command+=",";}
				command+="FromNum = "+POut.Long(task.FromNum)+"";
			}
			if(task.ObjectType != oldTask.ObjectType) {
				if(command!="") { command+=",";}
				command+="ObjectType = "+POut.Int   ((int)task.ObjectType)+"";
			}
			if(task.DateTimeEntry != oldTask.DateTimeEntry) {
				if(command!="") { command+=",";}
				command+="DateTimeEntry = "+POut.DateT(task.DateTimeEntry)+"";
			}
			if(task.UserNum != oldTask.UserNum) {
				if(command!="") { command+=",";}
				command+="UserNum = "+POut.Long(task.UserNum)+"";
			}
			if(task.DateTimeFinished != oldTask.DateTimeFinished) {
				if(command!="") { command+=",";}
				command+="DateTimeFinished = "+POut.DateT(task.DateTimeFinished)+"";
			}
			if(task.PriorityDefNum != oldTask.PriorityDefNum) {
				if(command!="") { command+=",";}
				command+="PriorityDefNum = "+POut.Long(task.PriorityDefNum)+"";
			}
			if(task.ReminderGroupId != oldTask.ReminderGroupId) {
				if(command!="") { command+=",";}
				command+="ReminderGroupId = '"+POut.String(task.ReminderGroupId)+"'";
			}
			if(task.ReminderType != oldTask.ReminderType) {
				if(command!="") { command+=",";}
				command+="ReminderType = "+POut.Int   ((int)task.ReminderType)+"";
			}
			if(task.ReminderFrequency != oldTask.ReminderFrequency) {
				if(command!="") { command+=",";}
				command+="ReminderFrequency = "+POut.Int(task.ReminderFrequency)+"";
			}
			//DateTimeOriginal not allowed to change
			//SecDateTEdit can only be set by MySQL
			if(task.DescriptOverride != oldTask.DescriptOverride) {
				if(command!="") { command+=",";}
				command+="DescriptOverride = '"+POut.String(task.DescriptOverride)+"'";
			}
			if(task.IsReadOnly != oldTask.IsReadOnly) {
				if(command!="") { command+=",";}
				command+="IsReadOnly = "+POut.Bool(task.IsReadOnly)+"";
			}
			if(task.TriageCategory != oldTask.TriageCategory) {
				if(command!="") { command+=",";}
				command+="TriageCategory = "+POut.Long(task.TriageCategory)+"";
			}
			if(command=="") {
				return false;
			}
			if(task.Descript==null) {
				task.Descript="";
			}
			OdSqlParameter paramDescript=new OdSqlParameter("paramDescript",OdDbType.Text,POut.StringParam(task.Descript));
			command="UPDATE task SET "+command
				+" WHERE TaskNum = "+POut.Long(task.TaskNum);
			Db.NonQ(command,paramDescript);
			return true;
		}

		///<summary>Returns true if Update(Task,Task) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Task task,Task oldTask) {
			if(task.TaskListNum != oldTask.TaskListNum) {
				return true;
			}
			if(task.DateTask.Date != oldTask.DateTask.Date) {
				return true;
			}
			if(task.KeyNum != oldTask.KeyNum) {
				return true;
			}
			if(task.Descript != oldTask.Descript) {
				return true;
			}
			if(task.TaskStatus != oldTask.TaskStatus) {
				return true;
			}
			if(task.IsRepeating != oldTask.IsRepeating) {
				return true;
			}
			if(task.DateType != oldTask.DateType) {
				return true;
			}
			if(task.FromNum != oldTask.FromNum) {
				return true;
			}
			if(task.ObjectType != oldTask.ObjectType) {
				return true;
			}
			if(task.DateTimeEntry != oldTask.DateTimeEntry) {
				return true;
			}
			if(task.UserNum != oldTask.UserNum) {
				return true;
			}
			if(task.DateTimeFinished != oldTask.DateTimeFinished) {
				return true;
			}
			if(task.PriorityDefNum != oldTask.PriorityDefNum) {
				return true;
			}
			if(task.ReminderGroupId != oldTask.ReminderGroupId) {
				return true;
			}
			if(task.ReminderType != oldTask.ReminderType) {
				return true;
			}
			if(task.ReminderFrequency != oldTask.ReminderFrequency) {
				return true;
			}
			//DateTimeOriginal not allowed to change
			//SecDateTEdit can only be set by MySQL
			if(task.DescriptOverride != oldTask.DescriptOverride) {
				return true;
			}
			if(task.IsReadOnly != oldTask.IsReadOnly) {
				return true;
			}
			if(task.TriageCategory != oldTask.TriageCategory) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Task from the database.</summary>
		public static void Delete(long taskNum) {
			ClearFkey(taskNum);
			string command="DELETE FROM task "
				+"WHERE TaskNum = "+POut.Long(taskNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Tasks from the database.</summary>
		public static void DeleteMany(List<long> listTaskNums) {
			if(listTaskNums==null || listTaskNums.Count==0) {
				return;
			}
			ClearFkey(listTaskNums);
			string command="DELETE FROM task "
				+"WHERE TaskNum IN("+string.Join(",",listTaskNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

		///<summary>Zeros securitylog FKey column for rows that are using the matching taskNum as FKey and are related to Task.
		///Permtypes are generated from the AuditPerms property of the CrudTableAttribute within the Task table type.</summary>
		public static void ClearFkey(long taskNum) {
			if(taskNum==0) {
				return;
			}
			string command="UPDATE securitylog SET FKey=0 WHERE FKey="+POut.Long(taskNum)+" AND PermType IN (66)";
			Db.NonQ(command);
		}

		///<summary>Zeros securitylog FKey column for rows that are using the matching taskNums as FKey and are related to Task.
		///Permtypes are generated from the AuditPerms property of the CrudTableAttribute within the Task table type.</summary>
		public static void ClearFkey(List<long> listTaskNums) {
			if(listTaskNums==null || listTaskNums.FindAll(x => x != 0).Count==0) {
				return;
			}
			string command="UPDATE securitylog SET FKey=0 WHERE FKey IN("+String.Join(",",listTaskNums.FindAll(x => x != 0))+") AND PermType IN (66)";
			Db.NonQ(command);
		}

	}
}