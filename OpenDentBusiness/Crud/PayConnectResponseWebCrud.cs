//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class PayConnectResponseWebCrud {
		///<summary>Gets one PayConnectResponseWeb object from the database using the primary key.  Returns null if not found.</summary>
		public static PayConnectResponseWeb SelectOne(long payConnectResponseWebNum) {
			string command="SELECT * FROM payconnectresponseweb "
				+"WHERE PayConnectResponseWebNum = "+POut.Long(payConnectResponseWebNum);
			List<PayConnectResponseWeb> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one PayConnectResponseWeb object from the database using a query.</summary>
		public static PayConnectResponseWeb SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PayConnectResponseWeb> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of PayConnectResponseWeb objects from the database using a query.</summary>
		public static List<PayConnectResponseWeb> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PayConnectResponseWeb> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<PayConnectResponseWeb> TableToList(DataTable table) {
			List<PayConnectResponseWeb> retVal=new List<PayConnectResponseWeb>();
			PayConnectResponseWeb payConnectResponseWeb;
			foreach(DataRow row in table.Rows) {
				payConnectResponseWeb=new PayConnectResponseWeb();
				payConnectResponseWeb.PayConnectResponseWebNum= PIn.Long  (row["PayConnectResponseWebNum"].ToString());
				payConnectResponseWeb.PatNum                  = PIn.Long  (row["PatNum"].ToString());
				payConnectResponseWeb.PayNum                  = PIn.Long  (row["PayNum"].ToString());
				payConnectResponseWeb.CCSource                = (OpenDentBusiness.CreditCardSource)PIn.Int(row["CCSource"].ToString());
				payConnectResponseWeb.Amount                  = PIn.Double(row["Amount"].ToString());
				payConnectResponseWeb.PayNote                 = PIn.String(row["PayNote"].ToString());
				payConnectResponseWeb.AccountToken            = PIn.String(row["AccountToken"].ToString());
				payConnectResponseWeb.PayToken                = PIn.String(row["PayToken"].ToString());
				string processingStatus=row["ProcessingStatus"].ToString();
				if(processingStatus=="") {
					payConnectResponseWeb.ProcessingStatus      =(OpenDentBusiness.PayConnectWebStatus)0;
				}
				else try{
					payConnectResponseWeb.ProcessingStatus      =(OpenDentBusiness.PayConnectWebStatus)Enum.Parse(typeof(OpenDentBusiness.PayConnectWebStatus),processingStatus);
				}
				catch{
					payConnectResponseWeb.ProcessingStatus      =(OpenDentBusiness.PayConnectWebStatus)0;
				}
				payConnectResponseWeb.DateTimeEntry           = PIn.DateT (row["DateTimeEntry"].ToString());
				payConnectResponseWeb.DateTimePending         = PIn.DateT (row["DateTimePending"].ToString());
				payConnectResponseWeb.DateTimeCompleted       = PIn.DateT (row["DateTimeCompleted"].ToString());
				payConnectResponseWeb.DateTimeExpired         = PIn.DateT (row["DateTimeExpired"].ToString());
				payConnectResponseWeb.DateTimeLastError       = PIn.DateT (row["DateTimeLastError"].ToString());
				payConnectResponseWeb.LastResponseStr         = PIn.String(row["LastResponseStr"].ToString());
				payConnectResponseWeb.IsTokenSaved            = PIn.Bool  (row["IsTokenSaved"].ToString());
				payConnectResponseWeb.PaymentToken            = PIn.String(row["PaymentToken"].ToString());
				payConnectResponseWeb.ExpDateToken            = PIn.String(row["ExpDateToken"].ToString());
				payConnectResponseWeb.RefNumber               = PIn.String(row["RefNumber"].ToString());
				string transType=row["TransType"].ToString();
				if(transType=="") {
					payConnectResponseWeb.TransType             =(OpenDentBusiness.PayConnectService.transType)0;
				}
				else try{
					payConnectResponseWeb.TransType             =(OpenDentBusiness.PayConnectService.transType)Enum.Parse(typeof(OpenDentBusiness.PayConnectService.transType),transType);
				}
				catch{
					payConnectResponseWeb.TransType             =(OpenDentBusiness.PayConnectService.transType)0;
				}
				payConnectResponseWeb.EmailResponse           = PIn.String(row["EmailResponse"].ToString());
				payConnectResponseWeb.LogGuid                 = PIn.String(row["LogGuid"].ToString());
				retVal.Add(payConnectResponseWeb);
			}
			return retVal;
		}

		///<summary>Converts a list of PayConnectResponseWeb into a DataTable.</summary>
		public static DataTable ListToTable(List<PayConnectResponseWeb> listPayConnectResponseWebs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="PayConnectResponseWeb";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("PayConnectResponseWebNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("PayNum");
			table.Columns.Add("CCSource");
			table.Columns.Add("Amount");
			table.Columns.Add("PayNote");
			table.Columns.Add("AccountToken");
			table.Columns.Add("PayToken");
			table.Columns.Add("ProcessingStatus");
			table.Columns.Add("DateTimeEntry");
			table.Columns.Add("DateTimePending");
			table.Columns.Add("DateTimeCompleted");
			table.Columns.Add("DateTimeExpired");
			table.Columns.Add("DateTimeLastError");
			table.Columns.Add("LastResponseStr");
			table.Columns.Add("IsTokenSaved");
			table.Columns.Add("PaymentToken");
			table.Columns.Add("ExpDateToken");
			table.Columns.Add("RefNumber");
			table.Columns.Add("TransType");
			table.Columns.Add("EmailResponse");
			table.Columns.Add("LogGuid");
			foreach(PayConnectResponseWeb payConnectResponseWeb in listPayConnectResponseWebs) {
				table.Rows.Add(new object[] {
					POut.Long  (payConnectResponseWeb.PayConnectResponseWebNum),
					POut.Long  (payConnectResponseWeb.PatNum),
					POut.Long  (payConnectResponseWeb.PayNum),
					POut.Int   ((int)payConnectResponseWeb.CCSource),
					POut.Double(payConnectResponseWeb.Amount),
					            payConnectResponseWeb.PayNote,
					            payConnectResponseWeb.AccountToken,
					            payConnectResponseWeb.PayToken,
					POut.Int   ((int)payConnectResponseWeb.ProcessingStatus),
					POut.DateT (payConnectResponseWeb.DateTimeEntry,false),
					POut.DateT (payConnectResponseWeb.DateTimePending,false),
					POut.DateT (payConnectResponseWeb.DateTimeCompleted,false),
					POut.DateT (payConnectResponseWeb.DateTimeExpired,false),
					POut.DateT (payConnectResponseWeb.DateTimeLastError,false),
					            payConnectResponseWeb.LastResponseStr,
					POut.Bool  (payConnectResponseWeb.IsTokenSaved),
					            payConnectResponseWeb.PaymentToken,
					            payConnectResponseWeb.ExpDateToken,
					            payConnectResponseWeb.RefNumber,
					POut.Int   ((int)payConnectResponseWeb.TransType),
					            payConnectResponseWeb.EmailResponse,
					            payConnectResponseWeb.LogGuid,
				});
			}
			return table;
		}

		///<summary>Inserts one PayConnectResponseWeb into the database.  Returns the new priKey.</summary>
		public static long Insert(PayConnectResponseWeb payConnectResponseWeb) {
			return Insert(payConnectResponseWeb,false);
		}

		///<summary>Inserts one PayConnectResponseWeb into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(PayConnectResponseWeb payConnectResponseWeb,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				payConnectResponseWeb.PayConnectResponseWebNum=ReplicationServers.GetKey("payconnectresponseweb","PayConnectResponseWebNum");
			}
			string command="INSERT INTO payconnectresponseweb (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="PayConnectResponseWebNum,";
			}
			command+="PatNum,PayNum,CCSource,Amount,PayNote,AccountToken,PayToken,ProcessingStatus,DateTimeEntry,DateTimePending,DateTimeCompleted,DateTimeExpired,DateTimeLastError,LastResponseStr,IsTokenSaved,PaymentToken,ExpDateToken,RefNumber,TransType,EmailResponse,LogGuid) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(payConnectResponseWeb.PayConnectResponseWebNum)+",";
			}
			command+=
				     POut.Long  (payConnectResponseWeb.PatNum)+","
				+    POut.Long  (payConnectResponseWeb.PayNum)+","
				+    POut.Int   ((int)payConnectResponseWeb.CCSource)+","
				+		 POut.Double(payConnectResponseWeb.Amount)+","
				+"'"+POut.String(payConnectResponseWeb.PayNote)+"',"
				+"'"+POut.String(payConnectResponseWeb.AccountToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.PayToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.ProcessingStatus.ToString())+"',"
				+    DbHelper.Now()+","
				+    POut.DateT (payConnectResponseWeb.DateTimePending)+","
				+    POut.DateT (payConnectResponseWeb.DateTimeCompleted)+","
				+    POut.DateT (payConnectResponseWeb.DateTimeExpired)+","
				+    POut.DateT (payConnectResponseWeb.DateTimeLastError)+","
				+    DbHelper.ParamChar+"paramLastResponseStr,"
				+    POut.Bool  (payConnectResponseWeb.IsTokenSaved)+","
				+"'"+POut.String(payConnectResponseWeb.PaymentToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.ExpDateToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.RefNumber)+"',"
				+"'"+POut.String(payConnectResponseWeb.TransType.ToString())+"',"
				+"'"+POut.String(payConnectResponseWeb.EmailResponse)+"',"
				+"'"+POut.String(payConnectResponseWeb.LogGuid)+"')";
			if(payConnectResponseWeb.LastResponseStr==null) {
				payConnectResponseWeb.LastResponseStr="";
			}
			OdSqlParameter paramLastResponseStr=new OdSqlParameter("paramLastResponseStr",OdDbType.Text,POut.StringParam(payConnectResponseWeb.LastResponseStr));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramLastResponseStr);
			}
			else {
				payConnectResponseWeb.PayConnectResponseWebNum=Db.NonQ(command,true,"PayConnectResponseWebNum","payConnectResponseWeb",paramLastResponseStr);
			}
			return payConnectResponseWeb.PayConnectResponseWebNum;
		}

		///<summary>Inserts one PayConnectResponseWeb into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PayConnectResponseWeb payConnectResponseWeb) {
			return InsertNoCache(payConnectResponseWeb,false);
		}

		///<summary>Inserts one PayConnectResponseWeb into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PayConnectResponseWeb payConnectResponseWeb,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO payconnectresponseweb (";
			if(!useExistingPK && isRandomKeys) {
				payConnectResponseWeb.PayConnectResponseWebNum=ReplicationServers.GetKeyNoCache("payconnectresponseweb","PayConnectResponseWebNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="PayConnectResponseWebNum,";
			}
			command+="PatNum,PayNum,CCSource,Amount,PayNote,AccountToken,PayToken,ProcessingStatus,DateTimeEntry,DateTimePending,DateTimeCompleted,DateTimeExpired,DateTimeLastError,LastResponseStr,IsTokenSaved,PaymentToken,ExpDateToken,RefNumber,TransType,EmailResponse,LogGuid) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(payConnectResponseWeb.PayConnectResponseWebNum)+",";
			}
			command+=
				     POut.Long  (payConnectResponseWeb.PatNum)+","
				+    POut.Long  (payConnectResponseWeb.PayNum)+","
				+    POut.Int   ((int)payConnectResponseWeb.CCSource)+","
				+	   POut.Double(payConnectResponseWeb.Amount)+","
				+"'"+POut.String(payConnectResponseWeb.PayNote)+"',"
				+"'"+POut.String(payConnectResponseWeb.AccountToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.PayToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.ProcessingStatus.ToString())+"',"
				+    DbHelper.Now()+","
				+    POut.DateT (payConnectResponseWeb.DateTimePending)+","
				+    POut.DateT (payConnectResponseWeb.DateTimeCompleted)+","
				+    POut.DateT (payConnectResponseWeb.DateTimeExpired)+","
				+    POut.DateT (payConnectResponseWeb.DateTimeLastError)+","
				+    DbHelper.ParamChar+"paramLastResponseStr,"
				+    POut.Bool  (payConnectResponseWeb.IsTokenSaved)+","
				+"'"+POut.String(payConnectResponseWeb.PaymentToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.ExpDateToken)+"',"
				+"'"+POut.String(payConnectResponseWeb.RefNumber)+"',"
				+"'"+POut.String(payConnectResponseWeb.TransType.ToString())+"',"
				+"'"+POut.String(payConnectResponseWeb.EmailResponse)+"',"
				+"'"+POut.String(payConnectResponseWeb.LogGuid)+"')";
			if(payConnectResponseWeb.LastResponseStr==null) {
				payConnectResponseWeb.LastResponseStr="";
			}
			OdSqlParameter paramLastResponseStr=new OdSqlParameter("paramLastResponseStr",OdDbType.Text,POut.StringParam(payConnectResponseWeb.LastResponseStr));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramLastResponseStr);
			}
			else {
				payConnectResponseWeb.PayConnectResponseWebNum=Db.NonQ(command,true,"PayConnectResponseWebNum","payConnectResponseWeb",paramLastResponseStr);
			}
			return payConnectResponseWeb.PayConnectResponseWebNum;
		}

		///<summary>Updates one PayConnectResponseWeb in the database.</summary>
		public static void Update(PayConnectResponseWeb payConnectResponseWeb) {
			string command="UPDATE payconnectresponseweb SET "
				+"PatNum                  =  "+POut.Long  (payConnectResponseWeb.PatNum)+", "
				+"PayNum                  =  "+POut.Long  (payConnectResponseWeb.PayNum)+", "
				+"CCSource                =  "+POut.Int   ((int)payConnectResponseWeb.CCSource)+", "
				+"Amount                  =  "+POut.Double(payConnectResponseWeb.Amount)+", "
				+"PayNote                 = '"+POut.String(payConnectResponseWeb.PayNote)+"', "
				+"AccountToken            = '"+POut.String(payConnectResponseWeb.AccountToken)+"', "
				+"PayToken                = '"+POut.String(payConnectResponseWeb.PayToken)+"', "
				+"ProcessingStatus        = '"+POut.String(payConnectResponseWeb.ProcessingStatus.ToString())+"', "
				//DateTimeEntry not allowed to change
				+"DateTimePending         =  "+POut.DateT (payConnectResponseWeb.DateTimePending)+", "
				+"DateTimeCompleted       =  "+POut.DateT (payConnectResponseWeb.DateTimeCompleted)+", "
				+"DateTimeExpired         =  "+POut.DateT (payConnectResponseWeb.DateTimeExpired)+", "
				+"DateTimeLastError       =  "+POut.DateT (payConnectResponseWeb.DateTimeLastError)+", "
				+"LastResponseStr         =  "+DbHelper.ParamChar+"paramLastResponseStr, "
				+"IsTokenSaved            =  "+POut.Bool  (payConnectResponseWeb.IsTokenSaved)+", "
				+"PaymentToken            = '"+POut.String(payConnectResponseWeb.PaymentToken)+"', "
				+"ExpDateToken            = '"+POut.String(payConnectResponseWeb.ExpDateToken)+"', "
				+"RefNumber               = '"+POut.String(payConnectResponseWeb.RefNumber)+"', "
				+"TransType               = '"+POut.String(payConnectResponseWeb.TransType.ToString())+"', "
				+"EmailResponse           = '"+POut.String(payConnectResponseWeb.EmailResponse)+"', "
				+"LogGuid                 = '"+POut.String(payConnectResponseWeb.LogGuid)+"' "
				+"WHERE PayConnectResponseWebNum = "+POut.Long(payConnectResponseWeb.PayConnectResponseWebNum);
			if(payConnectResponseWeb.LastResponseStr==null) {
				payConnectResponseWeb.LastResponseStr="";
			}
			OdSqlParameter paramLastResponseStr=new OdSqlParameter("paramLastResponseStr",OdDbType.Text,POut.StringParam(payConnectResponseWeb.LastResponseStr));
			Db.NonQ(command,paramLastResponseStr);
		}

		///<summary>Updates one PayConnectResponseWeb in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(PayConnectResponseWeb payConnectResponseWeb,PayConnectResponseWeb oldPayConnectResponseWeb) {
			string command="";
			if(payConnectResponseWeb.PatNum != oldPayConnectResponseWeb.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(payConnectResponseWeb.PatNum)+"";
			}
			if(payConnectResponseWeb.PayNum != oldPayConnectResponseWeb.PayNum) {
				if(command!="") { command+=",";}
				command+="PayNum = "+POut.Long(payConnectResponseWeb.PayNum)+"";
			}
			if(payConnectResponseWeb.CCSource != oldPayConnectResponseWeb.CCSource) {
				if(command!="") { command+=",";}
				command+="CCSource = "+POut.Int   ((int)payConnectResponseWeb.CCSource)+"";
			}
			if(payConnectResponseWeb.Amount != oldPayConnectResponseWeb.Amount) {
				if(command!="") { command+=",";}
				command+="Amount = "+POut.Double(payConnectResponseWeb.Amount)+"";
			}
			if(payConnectResponseWeb.PayNote != oldPayConnectResponseWeb.PayNote) {
				if(command!="") { command+=",";}
				command+="PayNote = '"+POut.String(payConnectResponseWeb.PayNote)+"'";
			}
			if(payConnectResponseWeb.AccountToken != oldPayConnectResponseWeb.AccountToken) {
				if(command!="") { command+=",";}
				command+="AccountToken = '"+POut.String(payConnectResponseWeb.AccountToken)+"'";
			}
			if(payConnectResponseWeb.PayToken != oldPayConnectResponseWeb.PayToken) {
				if(command!="") { command+=",";}
				command+="PayToken = '"+POut.String(payConnectResponseWeb.PayToken)+"'";
			}
			if(payConnectResponseWeb.ProcessingStatus != oldPayConnectResponseWeb.ProcessingStatus) {
				if(command!="") { command+=",";}
				command+="ProcessingStatus = '"+POut.String(payConnectResponseWeb.ProcessingStatus.ToString())+"'";
			}
			//DateTimeEntry not allowed to change
			if(payConnectResponseWeb.DateTimePending != oldPayConnectResponseWeb.DateTimePending) {
				if(command!="") { command+=",";}
				command+="DateTimePending = "+POut.DateT(payConnectResponseWeb.DateTimePending)+"";
			}
			if(payConnectResponseWeb.DateTimeCompleted != oldPayConnectResponseWeb.DateTimeCompleted) {
				if(command!="") { command+=",";}
				command+="DateTimeCompleted = "+POut.DateT(payConnectResponseWeb.DateTimeCompleted)+"";
			}
			if(payConnectResponseWeb.DateTimeExpired != oldPayConnectResponseWeb.DateTimeExpired) {
				if(command!="") { command+=",";}
				command+="DateTimeExpired = "+POut.DateT(payConnectResponseWeb.DateTimeExpired)+"";
			}
			if(payConnectResponseWeb.DateTimeLastError != oldPayConnectResponseWeb.DateTimeLastError) {
				if(command!="") { command+=",";}
				command+="DateTimeLastError = "+POut.DateT(payConnectResponseWeb.DateTimeLastError)+"";
			}
			if(payConnectResponseWeb.LastResponseStr != oldPayConnectResponseWeb.LastResponseStr) {
				if(command!="") { command+=",";}
				command+="LastResponseStr = "+DbHelper.ParamChar+"paramLastResponseStr";
			}
			if(payConnectResponseWeb.IsTokenSaved != oldPayConnectResponseWeb.IsTokenSaved) {
				if(command!="") { command+=",";}
				command+="IsTokenSaved = "+POut.Bool(payConnectResponseWeb.IsTokenSaved)+"";
			}
			if(payConnectResponseWeb.PaymentToken != oldPayConnectResponseWeb.PaymentToken) {
				if(command!="") { command+=",";}
				command+="PaymentToken = '"+POut.String(payConnectResponseWeb.PaymentToken)+"'";
			}
			if(payConnectResponseWeb.ExpDateToken != oldPayConnectResponseWeb.ExpDateToken) {
				if(command!="") { command+=",";}
				command+="ExpDateToken = '"+POut.String(payConnectResponseWeb.ExpDateToken)+"'";
			}
			if(payConnectResponseWeb.RefNumber != oldPayConnectResponseWeb.RefNumber) {
				if(command!="") { command+=",";}
				command+="RefNumber = '"+POut.String(payConnectResponseWeb.RefNumber)+"'";
			}
			if(payConnectResponseWeb.TransType != oldPayConnectResponseWeb.TransType) {
				if(command!="") { command+=",";}
				command+="TransType = '"+POut.String(payConnectResponseWeb.TransType.ToString())+"'";
			}
			if(payConnectResponseWeb.EmailResponse != oldPayConnectResponseWeb.EmailResponse) {
				if(command!="") { command+=",";}
				command+="EmailResponse = '"+POut.String(payConnectResponseWeb.EmailResponse)+"'";
			}
			if(payConnectResponseWeb.LogGuid != oldPayConnectResponseWeb.LogGuid) {
				if(command!="") { command+=",";}
				command+="LogGuid = '"+POut.String(payConnectResponseWeb.LogGuid)+"'";
			}
			if(command=="") {
				return false;
			}
			if(payConnectResponseWeb.LastResponseStr==null) {
				payConnectResponseWeb.LastResponseStr="";
			}
			OdSqlParameter paramLastResponseStr=new OdSqlParameter("paramLastResponseStr",OdDbType.Text,POut.StringParam(payConnectResponseWeb.LastResponseStr));
			command="UPDATE payconnectresponseweb SET "+command
				+" WHERE PayConnectResponseWebNum = "+POut.Long(payConnectResponseWeb.PayConnectResponseWebNum);
			Db.NonQ(command,paramLastResponseStr);
			return true;
		}

		///<summary>Returns true if Update(PayConnectResponseWeb,PayConnectResponseWeb) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(PayConnectResponseWeb payConnectResponseWeb,PayConnectResponseWeb oldPayConnectResponseWeb) {
			if(payConnectResponseWeb.PatNum != oldPayConnectResponseWeb.PatNum) {
				return true;
			}
			if(payConnectResponseWeb.PayNum != oldPayConnectResponseWeb.PayNum) {
				return true;
			}
			if(payConnectResponseWeb.CCSource != oldPayConnectResponseWeb.CCSource) {
				return true;
			}
			if(payConnectResponseWeb.Amount != oldPayConnectResponseWeb.Amount) {
				return true;
			}
			if(payConnectResponseWeb.PayNote != oldPayConnectResponseWeb.PayNote) {
				return true;
			}
			if(payConnectResponseWeb.AccountToken != oldPayConnectResponseWeb.AccountToken) {
				return true;
			}
			if(payConnectResponseWeb.PayToken != oldPayConnectResponseWeb.PayToken) {
				return true;
			}
			if(payConnectResponseWeb.ProcessingStatus != oldPayConnectResponseWeb.ProcessingStatus) {
				return true;
			}
			//DateTimeEntry not allowed to change
			if(payConnectResponseWeb.DateTimePending != oldPayConnectResponseWeb.DateTimePending) {
				return true;
			}
			if(payConnectResponseWeb.DateTimeCompleted != oldPayConnectResponseWeb.DateTimeCompleted) {
				return true;
			}
			if(payConnectResponseWeb.DateTimeExpired != oldPayConnectResponseWeb.DateTimeExpired) {
				return true;
			}
			if(payConnectResponseWeb.DateTimeLastError != oldPayConnectResponseWeb.DateTimeLastError) {
				return true;
			}
			if(payConnectResponseWeb.LastResponseStr != oldPayConnectResponseWeb.LastResponseStr) {
				return true;
			}
			if(payConnectResponseWeb.IsTokenSaved != oldPayConnectResponseWeb.IsTokenSaved) {
				return true;
			}
			if(payConnectResponseWeb.PaymentToken != oldPayConnectResponseWeb.PaymentToken) {
				return true;
			}
			if(payConnectResponseWeb.ExpDateToken != oldPayConnectResponseWeb.ExpDateToken) {
				return true;
			}
			if(payConnectResponseWeb.RefNumber != oldPayConnectResponseWeb.RefNumber) {
				return true;
			}
			if(payConnectResponseWeb.TransType != oldPayConnectResponseWeb.TransType) {
				return true;
			}
			if(payConnectResponseWeb.EmailResponse != oldPayConnectResponseWeb.EmailResponse) {
				return true;
			}
			if(payConnectResponseWeb.LogGuid != oldPayConnectResponseWeb.LogGuid) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one PayConnectResponseWeb from the database.</summary>
		public static void Delete(long payConnectResponseWebNum) {
			string command="DELETE FROM payconnectresponseweb "
				+"WHERE PayConnectResponseWebNum = "+POut.Long(payConnectResponseWebNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many PayConnectResponseWebs from the database.</summary>
		public static void DeleteMany(List<long> listPayConnectResponseWebNums) {
			if(listPayConnectResponseWebNums==null || listPayConnectResponseWebNums.Count==0) {
				return;
			}
			string command="DELETE FROM payconnectresponseweb "
				+"WHERE PayConnectResponseWebNum IN("+string.Join(",",listPayConnectResponseWebNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}