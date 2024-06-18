//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class ClaimPaymentCrud {
		///<summary>Gets one ClaimPayment object from the database using the primary key.  Returns null if not found.</summary>
		public static ClaimPayment SelectOne(long claimPaymentNum) {
			string command="SELECT * FROM claimpayment "
				+"WHERE ClaimPaymentNum = "+POut.Long(claimPaymentNum);
			List<ClaimPayment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one ClaimPayment object from the database using a query.</summary>
		public static ClaimPayment SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ClaimPayment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of ClaimPayment objects from the database using a query.</summary>
		public static List<ClaimPayment> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ClaimPayment> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<ClaimPayment> TableToList(DataTable table) {
			List<ClaimPayment> retVal=new List<ClaimPayment>();
			ClaimPayment claimPayment;
			foreach(DataRow row in table.Rows) {
				claimPayment=new ClaimPayment();
				claimPayment.ClaimPaymentNum= PIn.Long  (row["ClaimPaymentNum"].ToString());
				claimPayment.CheckDate      = PIn.Date  (row["CheckDate"].ToString());
				claimPayment.CheckAmt       = PIn.Double(row["CheckAmt"].ToString());
				claimPayment.CheckNum       = PIn.String(row["CheckNum"].ToString());
				claimPayment.BankBranch     = PIn.String(row["BankBranch"].ToString());
				claimPayment.Note           = PIn.String(row["Note"].ToString());
				claimPayment.ClinicNum      = PIn.Long  (row["ClinicNum"].ToString());
				claimPayment.DepositNum     = PIn.Long  (row["DepositNum"].ToString());
				claimPayment.CarrierName    = PIn.String(row["CarrierName"].ToString());
				claimPayment.DateIssued     = PIn.Date  (row["DateIssued"].ToString());
				claimPayment.IsPartial      = PIn.Bool  (row["IsPartial"].ToString());
				claimPayment.PayType        = PIn.Long  (row["PayType"].ToString());
				claimPayment.SecUserNumEntry= PIn.Long  (row["SecUserNumEntry"].ToString());
				claimPayment.SecDateEntry   = PIn.Date  (row["SecDateEntry"].ToString());
				claimPayment.SecDateTEdit   = PIn.DateT (row["SecDateTEdit"].ToString());
				claimPayment.PayGroup       = PIn.Long  (row["PayGroup"].ToString());
				retVal.Add(claimPayment);
			}
			return retVal;
		}

		///<summary>Converts a list of ClaimPayment into a DataTable.</summary>
		public static DataTable ListToTable(List<ClaimPayment> listClaimPayments,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="ClaimPayment";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ClaimPaymentNum");
			table.Columns.Add("CheckDate");
			table.Columns.Add("CheckAmt");
			table.Columns.Add("CheckNum");
			table.Columns.Add("BankBranch");
			table.Columns.Add("Note");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("DepositNum");
			table.Columns.Add("CarrierName");
			table.Columns.Add("DateIssued");
			table.Columns.Add("IsPartial");
			table.Columns.Add("PayType");
			table.Columns.Add("SecUserNumEntry");
			table.Columns.Add("SecDateEntry");
			table.Columns.Add("SecDateTEdit");
			table.Columns.Add("PayGroup");
			foreach(ClaimPayment claimPayment in listClaimPayments) {
				table.Rows.Add(new object[] {
					POut.Long  (claimPayment.ClaimPaymentNum),
					POut.DateT (claimPayment.CheckDate,false),
					POut.Double(claimPayment.CheckAmt),
					            claimPayment.CheckNum,
					            claimPayment.BankBranch,
					            claimPayment.Note,
					POut.Long  (claimPayment.ClinicNum),
					POut.Long  (claimPayment.DepositNum),
					            claimPayment.CarrierName,
					POut.DateT (claimPayment.DateIssued,false),
					POut.Bool  (claimPayment.IsPartial),
					POut.Long  (claimPayment.PayType),
					POut.Long  (claimPayment.SecUserNumEntry),
					POut.DateT (claimPayment.SecDateEntry,false),
					POut.DateT (claimPayment.SecDateTEdit,false),
					POut.Long  (claimPayment.PayGroup),
				});
			}
			return table;
		}

		///<summary>Inserts one ClaimPayment into the database.  Returns the new priKey.</summary>
		public static long Insert(ClaimPayment claimPayment) {
			return Insert(claimPayment,false);
		}

		///<summary>Inserts one ClaimPayment into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(ClaimPayment claimPayment,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				claimPayment.ClaimPaymentNum=ReplicationServers.GetKey("claimpayment","ClaimPaymentNum");
			}
			string command="INSERT INTO claimpayment (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ClaimPaymentNum,";
			}
			command+="CheckDate,CheckAmt,CheckNum,BankBranch,Note,ClinicNum,DepositNum,CarrierName,DateIssued,IsPartial,PayType,SecUserNumEntry,SecDateEntry,PayGroup) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(claimPayment.ClaimPaymentNum)+",";
			}
			command+=
				     POut.Date  (claimPayment.CheckDate)+","
				+		 POut.Double(claimPayment.CheckAmt)+","
				+"'"+POut.String(claimPayment.CheckNum)+"',"
				+"'"+POut.String(claimPayment.BankBranch)+"',"
				+"'"+POut.String(claimPayment.Note)+"',"
				+    POut.Long  (claimPayment.ClinicNum)+","
				+    POut.Long  (claimPayment.DepositNum)+","
				+"'"+POut.String(claimPayment.CarrierName)+"',"
				+    POut.Date  (claimPayment.DateIssued)+","
				+    POut.Bool  (claimPayment.IsPartial)+","
				+    POut.Long  (claimPayment.PayType)+","
				+    POut.Long  (claimPayment.SecUserNumEntry)+","
				+    DbHelper.Now()+","
				//SecDateTEdit can only be set by MySQL
				+    POut.Long  (claimPayment.PayGroup)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				claimPayment.ClaimPaymentNum=Db.NonQ(command,true,"ClaimPaymentNum","claimPayment");
			}
			return claimPayment.ClaimPaymentNum;
		}

		///<summary>Inserts one ClaimPayment into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ClaimPayment claimPayment) {
			return InsertNoCache(claimPayment,false);
		}

		///<summary>Inserts one ClaimPayment into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ClaimPayment claimPayment,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO claimpayment (";
			if(!useExistingPK && isRandomKeys) {
				claimPayment.ClaimPaymentNum=ReplicationServers.GetKeyNoCache("claimpayment","ClaimPaymentNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ClaimPaymentNum,";
			}
			command+="CheckDate,CheckAmt,CheckNum,BankBranch,Note,ClinicNum,DepositNum,CarrierName,DateIssued,IsPartial,PayType,SecUserNumEntry,SecDateEntry,PayGroup) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(claimPayment.ClaimPaymentNum)+",";
			}
			command+=
				     POut.Date  (claimPayment.CheckDate)+","
				+	   POut.Double(claimPayment.CheckAmt)+","
				+"'"+POut.String(claimPayment.CheckNum)+"',"
				+"'"+POut.String(claimPayment.BankBranch)+"',"
				+"'"+POut.String(claimPayment.Note)+"',"
				+    POut.Long  (claimPayment.ClinicNum)+","
				+    POut.Long  (claimPayment.DepositNum)+","
				+"'"+POut.String(claimPayment.CarrierName)+"',"
				+    POut.Date  (claimPayment.DateIssued)+","
				+    POut.Bool  (claimPayment.IsPartial)+","
				+    POut.Long  (claimPayment.PayType)+","
				+    POut.Long  (claimPayment.SecUserNumEntry)+","
				+    DbHelper.Now()+","
				//SecDateTEdit can only be set by MySQL
				+    POut.Long  (claimPayment.PayGroup)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				claimPayment.ClaimPaymentNum=Db.NonQ(command,true,"ClaimPaymentNum","claimPayment");
			}
			return claimPayment.ClaimPaymentNum;
		}

		///<summary>Updates one ClaimPayment in the database.</summary>
		public static void Update(ClaimPayment claimPayment) {
			string command="UPDATE claimpayment SET "
				+"CheckDate      =  "+POut.Date  (claimPayment.CheckDate)+", "
				+"CheckAmt       =  "+POut.Double(claimPayment.CheckAmt)+", "
				+"CheckNum       = '"+POut.String(claimPayment.CheckNum)+"', "
				+"BankBranch     = '"+POut.String(claimPayment.BankBranch)+"', "
				+"Note           = '"+POut.String(claimPayment.Note)+"', "
				+"ClinicNum      =  "+POut.Long  (claimPayment.ClinicNum)+", "
				+"DepositNum     =  "+POut.Long  (claimPayment.DepositNum)+", "
				+"CarrierName    = '"+POut.String(claimPayment.CarrierName)+"', "
				+"DateIssued     =  "+POut.Date  (claimPayment.DateIssued)+", "
				+"IsPartial      =  "+POut.Bool  (claimPayment.IsPartial)+", "
				+"PayType        =  "+POut.Long  (claimPayment.PayType)+", "
				//SecUserNumEntry excluded from update
				//SecDateEntry not allowed to change
				//SecDateTEdit can only be set by MySQL
				+"PayGroup       =  "+POut.Long  (claimPayment.PayGroup)+" "
				+"WHERE ClaimPaymentNum = "+POut.Long(claimPayment.ClaimPaymentNum);
			Db.NonQ(command);
		}

		///<summary>Updates one ClaimPayment in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(ClaimPayment claimPayment,ClaimPayment oldClaimPayment) {
			string command="";
			if(claimPayment.CheckDate.Date != oldClaimPayment.CheckDate.Date) {
				if(command!="") { command+=",";}
				command+="CheckDate = "+POut.Date(claimPayment.CheckDate)+"";
			}
			if(claimPayment.CheckAmt != oldClaimPayment.CheckAmt) {
				if(command!="") { command+=",";}
				command+="CheckAmt = "+POut.Double(claimPayment.CheckAmt)+"";
			}
			if(claimPayment.CheckNum != oldClaimPayment.CheckNum) {
				if(command!="") { command+=",";}
				command+="CheckNum = '"+POut.String(claimPayment.CheckNum)+"'";
			}
			if(claimPayment.BankBranch != oldClaimPayment.BankBranch) {
				if(command!="") { command+=",";}
				command+="BankBranch = '"+POut.String(claimPayment.BankBranch)+"'";
			}
			if(claimPayment.Note != oldClaimPayment.Note) {
				if(command!="") { command+=",";}
				command+="Note = '"+POut.String(claimPayment.Note)+"'";
			}
			if(claimPayment.ClinicNum != oldClaimPayment.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(claimPayment.ClinicNum)+"";
			}
			if(claimPayment.DepositNum != oldClaimPayment.DepositNum) {
				if(command!="") { command+=",";}
				command+="DepositNum = "+POut.Long(claimPayment.DepositNum)+"";
			}
			if(claimPayment.CarrierName != oldClaimPayment.CarrierName) {
				if(command!="") { command+=",";}
				command+="CarrierName = '"+POut.String(claimPayment.CarrierName)+"'";
			}
			if(claimPayment.DateIssued.Date != oldClaimPayment.DateIssued.Date) {
				if(command!="") { command+=",";}
				command+="DateIssued = "+POut.Date(claimPayment.DateIssued)+"";
			}
			if(claimPayment.IsPartial != oldClaimPayment.IsPartial) {
				if(command!="") { command+=",";}
				command+="IsPartial = "+POut.Bool(claimPayment.IsPartial)+"";
			}
			if(claimPayment.PayType != oldClaimPayment.PayType) {
				if(command!="") { command+=",";}
				command+="PayType = "+POut.Long(claimPayment.PayType)+"";
			}
			//SecUserNumEntry excluded from update
			//SecDateEntry not allowed to change
			//SecDateTEdit can only be set by MySQL
			if(claimPayment.PayGroup != oldClaimPayment.PayGroup) {
				if(command!="") { command+=",";}
				command+="PayGroup = "+POut.Long(claimPayment.PayGroup)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE claimpayment SET "+command
				+" WHERE ClaimPaymentNum = "+POut.Long(claimPayment.ClaimPaymentNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(ClaimPayment,ClaimPayment) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(ClaimPayment claimPayment,ClaimPayment oldClaimPayment) {
			if(claimPayment.CheckDate.Date != oldClaimPayment.CheckDate.Date) {
				return true;
			}
			if(claimPayment.CheckAmt != oldClaimPayment.CheckAmt) {
				return true;
			}
			if(claimPayment.CheckNum != oldClaimPayment.CheckNum) {
				return true;
			}
			if(claimPayment.BankBranch != oldClaimPayment.BankBranch) {
				return true;
			}
			if(claimPayment.Note != oldClaimPayment.Note) {
				return true;
			}
			if(claimPayment.ClinicNum != oldClaimPayment.ClinicNum) {
				return true;
			}
			if(claimPayment.DepositNum != oldClaimPayment.DepositNum) {
				return true;
			}
			if(claimPayment.CarrierName != oldClaimPayment.CarrierName) {
				return true;
			}
			if(claimPayment.DateIssued.Date != oldClaimPayment.DateIssued.Date) {
				return true;
			}
			if(claimPayment.IsPartial != oldClaimPayment.IsPartial) {
				return true;
			}
			if(claimPayment.PayType != oldClaimPayment.PayType) {
				return true;
			}
			//SecUserNumEntry excluded from update
			//SecDateEntry not allowed to change
			//SecDateTEdit can only be set by MySQL
			if(claimPayment.PayGroup != oldClaimPayment.PayGroup) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one ClaimPayment from the database.</summary>
		public static void Delete(long claimPaymentNum) {
			string command="DELETE FROM claimpayment "
				+"WHERE ClaimPaymentNum = "+POut.Long(claimPaymentNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many ClaimPayments from the database.</summary>
		public static void DeleteMany(List<long> listClaimPaymentNums) {
			if(listClaimPaymentNums==null || listClaimPaymentNums.Count==0) {
				return;
			}
			string command="DELETE FROM claimpayment "
				+"WHERE ClaimPaymentNum IN("+string.Join(",",listClaimPaymentNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}