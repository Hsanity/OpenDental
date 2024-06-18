//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class WebChatMessageCrud {
		///<summary>Gets one WebChatMessage object from the database using the primary key.  Returns null if not found.</summary>
		public static WebChatMessage SelectOne(long webChatMessageNum) {
			string command="SELECT * FROM webchatmessage "
				+"WHERE WebChatMessageNum = "+POut.Long(webChatMessageNum);
			List<WebChatMessage> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one WebChatMessage object from the database using a query.</summary>
		public static WebChatMessage SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebChatMessage> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of WebChatMessage objects from the database using a query.</summary>
		public static List<WebChatMessage> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebChatMessage> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<WebChatMessage> TableToList(DataTable table) {
			List<WebChatMessage> retVal=new List<WebChatMessage>();
			WebChatMessage webChatMessage;
			foreach(DataRow row in table.Rows) {
				webChatMessage=new WebChatMessage();
				webChatMessage.WebChatMessageNum= PIn.Long  (row["WebChatMessageNum"].ToString());
				webChatMessage.WebChatSessionNum= PIn.Long  (row["WebChatSessionNum"].ToString());
				webChatMessage.UserName         = PIn.String(row["UserName"].ToString());
				webChatMessage.DateT            = PIn.DateT (row["DateT"].ToString());
				webChatMessage.MessageText      = PIn.String(row["MessageText"].ToString());
				webChatMessage.MessageType      = (OpenDentBusiness.WebChatMessageType)PIn.Int(row["MessageType"].ToString());
				webChatMessage.IpAddress        = PIn.String(row["IpAddress"].ToString());
				webChatMessage.NeedsFollowUp    = PIn.Bool  (row["NeedsFollowUp"].ToString());
				retVal.Add(webChatMessage);
			}
			return retVal;
		}

		///<summary>Converts a list of WebChatMessage into a DataTable.</summary>
		public static DataTable ListToTable(List<WebChatMessage> listWebChatMessages,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="WebChatMessage";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("WebChatMessageNum");
			table.Columns.Add("WebChatSessionNum");
			table.Columns.Add("UserName");
			table.Columns.Add("DateT");
			table.Columns.Add("MessageText");
			table.Columns.Add("MessageType");
			table.Columns.Add("IpAddress");
			table.Columns.Add("NeedsFollowUp");
			foreach(WebChatMessage webChatMessage in listWebChatMessages) {
				table.Rows.Add(new object[] {
					POut.Long  (webChatMessage.WebChatMessageNum),
					POut.Long  (webChatMessage.WebChatSessionNum),
					            webChatMessage.UserName,
					POut.DateT (webChatMessage.DateT,false),
					            webChatMessage.MessageText,
					POut.Int   ((int)webChatMessage.MessageType),
					            webChatMessage.IpAddress,
					POut.Bool  (webChatMessage.NeedsFollowUp),
				});
			}
			return table;
		}

		///<summary>Inserts one WebChatMessage into the database.  Returns the new priKey.</summary>
		public static long Insert(WebChatMessage webChatMessage) {
			return Insert(webChatMessage,false);
		}

		///<summary>Inserts one WebChatMessage into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(WebChatMessage webChatMessage,bool useExistingPK) {
			string command="INSERT INTO webchatmessage (";
			if(useExistingPK) {
				command+="WebChatMessageNum,";
			}
			command+="WebChatSessionNum,UserName,MessageText,MessageType,IpAddress,NeedsFollowUp) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webChatMessage.WebChatMessageNum)+",";
			}
			command+=
				     POut.Long  (webChatMessage.WebChatSessionNum)+","
				+"'"+POut.String(webChatMessage.UserName)+"',"
				//DateT can only be set by MySQL
				+"'"+POut.String(webChatMessage.MessageText)+"',"
				+    POut.Int   ((int)webChatMessage.MessageType)+","
				+"'"+POut.String(webChatMessage.IpAddress)+"',"
				+    POut.Bool  (webChatMessage.NeedsFollowUp)+")";
			if(useExistingPK) {
				Db.NonQ(command);
			}
			else {
				webChatMessage.WebChatMessageNum=Db.NonQ(command,true,"WebChatMessageNum","webChatMessage");
			}
			return webChatMessage.WebChatMessageNum;
		}

		///<summary>Inserts one WebChatMessage into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(WebChatMessage webChatMessage) {
			return InsertNoCache(webChatMessage,false);
		}

		///<summary>Inserts one WebChatMessage into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(WebChatMessage webChatMessage,bool useExistingPK) {
			string command="INSERT INTO webchatmessage (";
			if(useExistingPK) {
				command+="WebChatMessageNum,";
			}
			command+="WebChatSessionNum,UserName,MessageText,MessageType,IpAddress,NeedsFollowUp) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webChatMessage.WebChatMessageNum)+",";
			}
			command+=
				     POut.Long  (webChatMessage.WebChatSessionNum)+","
				+"'"+POut.String(webChatMessage.UserName)+"',"
				//DateT can only be set by MySQL
				+"'"+POut.String(webChatMessage.MessageText)+"',"
				+    POut.Int   ((int)webChatMessage.MessageType)+","
				+"'"+POut.String(webChatMessage.IpAddress)+"',"
				+    POut.Bool  (webChatMessage.NeedsFollowUp)+")";
			if(useExistingPK) {
				Db.NonQ(command);
			}
			else {
				webChatMessage.WebChatMessageNum=Db.NonQ(command,true,"WebChatMessageNum","webChatMessage");
			}
			return webChatMessage.WebChatMessageNum;
		}

		///<summary>Updates one WebChatMessage in the database.</summary>
		public static void Update(WebChatMessage webChatMessage) {
			string command="UPDATE webchatmessage SET "
				+"WebChatSessionNum=  "+POut.Long  (webChatMessage.WebChatSessionNum)+", "
				+"UserName         = '"+POut.String(webChatMessage.UserName)+"', "
				//DateT can only be set by MySQL
				+"MessageText      = '"+POut.String(webChatMessage.MessageText)+"', "
				+"MessageType      =  "+POut.Int   ((int)webChatMessage.MessageType)+", "
				+"IpAddress        = '"+POut.String(webChatMessage.IpAddress)+"', "
				+"NeedsFollowUp    =  "+POut.Bool  (webChatMessage.NeedsFollowUp)+" "
				+"WHERE WebChatMessageNum = "+POut.Long(webChatMessage.WebChatMessageNum);
			Db.NonQ(command);
		}

		///<summary>Updates one WebChatMessage in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(WebChatMessage webChatMessage,WebChatMessage oldWebChatMessage) {
			string command="";
			if(webChatMessage.WebChatSessionNum != oldWebChatMessage.WebChatSessionNum) {
				if(command!="") { command+=",";}
				command+="WebChatSessionNum = "+POut.Long(webChatMessage.WebChatSessionNum)+"";
			}
			if(webChatMessage.UserName != oldWebChatMessage.UserName) {
				if(command!="") { command+=",";}
				command+="UserName = '"+POut.String(webChatMessage.UserName)+"'";
			}
			//DateT can only be set by MySQL
			if(webChatMessage.MessageText != oldWebChatMessage.MessageText) {
				if(command!="") { command+=",";}
				command+="MessageText = '"+POut.String(webChatMessage.MessageText)+"'";
			}
			if(webChatMessage.MessageType != oldWebChatMessage.MessageType) {
				if(command!="") { command+=",";}
				command+="MessageType = "+POut.Int   ((int)webChatMessage.MessageType)+"";
			}
			if(webChatMessage.IpAddress != oldWebChatMessage.IpAddress) {
				if(command!="") { command+=",";}
				command+="IpAddress = '"+POut.String(webChatMessage.IpAddress)+"'";
			}
			if(webChatMessage.NeedsFollowUp != oldWebChatMessage.NeedsFollowUp) {
				if(command!="") { command+=",";}
				command+="NeedsFollowUp = "+POut.Bool(webChatMessage.NeedsFollowUp)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE webchatmessage SET "+command
				+" WHERE WebChatMessageNum = "+POut.Long(webChatMessage.WebChatMessageNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(WebChatMessage,WebChatMessage) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(WebChatMessage webChatMessage,WebChatMessage oldWebChatMessage) {
			if(webChatMessage.WebChatSessionNum != oldWebChatMessage.WebChatSessionNum) {
				return true;
			}
			if(webChatMessage.UserName != oldWebChatMessage.UserName) {
				return true;
			}
			//DateT can only be set by MySQL
			if(webChatMessage.MessageText != oldWebChatMessage.MessageText) {
				return true;
			}
			if(webChatMessage.MessageType != oldWebChatMessage.MessageType) {
				return true;
			}
			if(webChatMessage.IpAddress != oldWebChatMessage.IpAddress) {
				return true;
			}
			if(webChatMessage.NeedsFollowUp != oldWebChatMessage.NeedsFollowUp) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one WebChatMessage from the database.</summary>
		public static void Delete(long webChatMessageNum) {
			string command="DELETE FROM webchatmessage "
				+"WHERE WebChatMessageNum = "+POut.Long(webChatMessageNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many WebChatMessages from the database.</summary>
		public static void DeleteMany(List<long> listWebChatMessageNums) {
			if(listWebChatMessageNums==null || listWebChatMessageNums.Count==0) {
				return;
			}
			string command="DELETE FROM webchatmessage "
				+"WHERE WebChatMessageNum IN("+string.Join(",",listWebChatMessageNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}