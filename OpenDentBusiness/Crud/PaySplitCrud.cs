//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenDentBusiness.Crud{
	public class PaySplitCrud {
		///<summary>Gets one PaySplit object from the database using the primary key.  Returns null if not found.</summary>
		public static PaySplit SelectOne(long splitNum) {
			string command="SELECT * FROM paysplit "
				+"WHERE SplitNum = "+POut.Long(splitNum);
			List<PaySplit> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one PaySplit object from the database using a query.</summary>
		public static PaySplit SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PaySplit> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of PaySplit objects from the database using a query.</summary>
		public static List<PaySplit> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PaySplit> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<PaySplit> TableToList(DataTable table) {
			List<PaySplit> retVal=new List<PaySplit>();
			PaySplit paySplit;
			foreach(DataRow row in table.Rows) {
				paySplit=new PaySplit();
				paySplit.SplitNum        = PIn.Long  (row["SplitNum"].ToString());
				paySplit.SplitAmt        = PIn.Double(row["SplitAmt"].ToString());
				paySplit.PatNum          = PIn.Long  (row["PatNum"].ToString());
				paySplit.ProcDate        = PIn.Date  (row["ProcDate"].ToString());
				paySplit.PayNum          = PIn.Long  (row["PayNum"].ToString());
				paySplit.IsDiscount      = PIn.Bool  (row["IsDiscount"].ToString());
				paySplit.DiscountType    = PIn.Byte  (row["DiscountType"].ToString());
				paySplit.ProvNum         = PIn.Long  (row["ProvNum"].ToString());
				paySplit.PayPlanNum      = PIn.Long  (row["PayPlanNum"].ToString());
				paySplit.DatePay         = PIn.Date  (row["DatePay"].ToString());
				paySplit.ProcNum         = PIn.Long  (row["ProcNum"].ToString());
				paySplit.DateEntry       = PIn.Date  (row["DateEntry"].ToString());
				paySplit.UnearnedType    = PIn.Long  (row["UnearnedType"].ToString());
				paySplit.ClinicNum       = PIn.Long  (row["ClinicNum"].ToString());
				paySplit.SecUserNumEntry = PIn.Long  (row["SecUserNumEntry"].ToString());
				paySplit.SecDateTEdit    = PIn.DateT (row["SecDateTEdit"].ToString());
				paySplit.FSplitNum       = PIn.Long  (row["FSplitNum"].ToString());
				paySplit.AdjNum          = PIn.Long  (row["AdjNum"].ToString());
				paySplit.PayPlanChargeNum= PIn.Long  (row["PayPlanChargeNum"].ToString());
				paySplit.PayPlanDebitType= (OpenDentBusiness.PayPlanDebitTypes)PIn.Int(row["PayPlanDebitType"].ToString());
				paySplit.SecurityHash    = PIn.String(row["SecurityHash"].ToString());
				retVal.Add(paySplit);
			}
			return retVal;
		}

		///<summary>Converts a list of PaySplit into a DataTable.</summary>
		public static DataTable ListToTable(List<PaySplit> listPaySplits,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="PaySplit";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("SplitNum");
			table.Columns.Add("SplitAmt");
			table.Columns.Add("PatNum");
			table.Columns.Add("ProcDate");
			table.Columns.Add("PayNum");
			table.Columns.Add("IsDiscount");
			table.Columns.Add("DiscountType");
			table.Columns.Add("ProvNum");
			table.Columns.Add("PayPlanNum");
			table.Columns.Add("DatePay");
			table.Columns.Add("ProcNum");
			table.Columns.Add("DateEntry");
			table.Columns.Add("UnearnedType");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("SecUserNumEntry");
			table.Columns.Add("SecDateTEdit");
			table.Columns.Add("FSplitNum");
			table.Columns.Add("AdjNum");
			table.Columns.Add("PayPlanChargeNum");
			table.Columns.Add("PayPlanDebitType");
			table.Columns.Add("SecurityHash");
			foreach(PaySplit paySplit in listPaySplits) {
				table.Rows.Add(new object[] {
					POut.Long  (paySplit.SplitNum),
					POut.Double(paySplit.SplitAmt),
					POut.Long  (paySplit.PatNum),
					POut.DateT (paySplit.ProcDate,false),
					POut.Long  (paySplit.PayNum),
					POut.Bool  (paySplit.IsDiscount),
					POut.Byte  (paySplit.DiscountType),
					POut.Long  (paySplit.ProvNum),
					POut.Long  (paySplit.PayPlanNum),
					POut.DateT (paySplit.DatePay,false),
					POut.Long  (paySplit.ProcNum),
					POut.DateT (paySplit.DateEntry,false),
					POut.Long  (paySplit.UnearnedType),
					POut.Long  (paySplit.ClinicNum),
					POut.Long  (paySplit.SecUserNumEntry),
					POut.DateT (paySplit.SecDateTEdit,false),
					POut.Long  (paySplit.FSplitNum),
					POut.Long  (paySplit.AdjNum),
					POut.Long  (paySplit.PayPlanChargeNum),
					POut.Int   ((int)paySplit.PayPlanDebitType),
					            paySplit.SecurityHash,
				});
			}
			return table;
		}

		///<summary>Inserts one PaySplit into the database.  Returns the new priKey.</summary>
		public static long Insert(PaySplit paySplit) {
			return Insert(paySplit,false);
		}

		///<summary>Inserts one PaySplit into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(PaySplit paySplit,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				paySplit.SplitNum=ReplicationServers.GetKey("paysplit","SplitNum");
			}
			string command="INSERT INTO paysplit (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="SplitNum,";
			}
			command+="SplitAmt,PatNum,ProcDate,PayNum,IsDiscount,DiscountType,ProvNum,PayPlanNum,DatePay,ProcNum,DateEntry,UnearnedType,ClinicNum,SecUserNumEntry,FSplitNum,AdjNum,PayPlanChargeNum,PayPlanDebitType,SecurityHash) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(paySplit.SplitNum)+",";
			}
			command+=
				 		 POut.Double(paySplit.SplitAmt)+","
				+    POut.Long  (paySplit.PatNum)+","
				+    POut.Date  (paySplit.ProcDate)+","
				+    POut.Long  (paySplit.PayNum)+","
				+    POut.Bool  (paySplit.IsDiscount)+","
				+    POut.Byte  (paySplit.DiscountType)+","
				+    POut.Long  (paySplit.ProvNum)+","
				+    POut.Long  (paySplit.PayPlanNum)+","
				+    POut.Date  (paySplit.DatePay)+","
				+    POut.Long  (paySplit.ProcNum)+","
				+    DbHelper.Now()+","
				+    POut.Long  (paySplit.UnearnedType)+","
				+    POut.Long  (paySplit.ClinicNum)+","
				+    POut.Long  (paySplit.SecUserNumEntry)+","
				//SecDateTEdit can only be set by MySQL
				+    POut.Long  (paySplit.FSplitNum)+","
				+    POut.Long  (paySplit.AdjNum)+","
				+    POut.Long  (paySplit.PayPlanChargeNum)+","
				+    POut.Int   ((int)paySplit.PayPlanDebitType)+","
				+"'"+POut.String(paySplit.SecurityHash)+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				paySplit.SplitNum=Db.NonQ(command,true,"SplitNum","paySplit");
			}
			return paySplit.SplitNum;
		}

		///<summary>Inserts many PaySplits into the database.</summary>
		public static void InsertMany(List<PaySplit> listPaySplits) {
			InsertMany(listPaySplits,false);
		}

		///<summary>Inserts many PaySplits into the database.  Provides option to use the existing priKey.</summary>
		public static void InsertMany(List<PaySplit> listPaySplits,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				foreach(PaySplit paySplit in listPaySplits) {
					Insert(paySplit);
				}
			}
			else {
				StringBuilder sbCommands=null;
				int index=0;
				int countRows=0;
				while(index < listPaySplits.Count) {
					PaySplit paySplit=listPaySplits[index];
					StringBuilder sbRow=new StringBuilder("(");
					bool hasComma=false;
					if(sbCommands==null) {
						sbCommands=new StringBuilder();
						sbCommands.Append("INSERT INTO paysplit (");
						if(useExistingPK) {
							sbCommands.Append("SplitNum,");
						}
						sbCommands.Append("SplitAmt,PatNum,ProcDate,PayNum,IsDiscount,DiscountType,ProvNum,PayPlanNum,DatePay,ProcNum,DateEntry,UnearnedType,ClinicNum,SecUserNumEntry,FSplitNum,AdjNum,PayPlanChargeNum,PayPlanDebitType,SecurityHash) VALUES ");
						countRows=0;
					}
					else {
						hasComma=true;
					}
					if(useExistingPK) {
						sbRow.Append(POut.Long(paySplit.SplitNum)); sbRow.Append(",");
					}
					sbRow.Append(POut.Double(paySplit.SplitAmt)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.PatNum)); sbRow.Append(",");
					sbRow.Append(POut.Date(paySplit.ProcDate)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.PayNum)); sbRow.Append(",");
					sbRow.Append(POut.Bool(paySplit.IsDiscount)); sbRow.Append(",");
					sbRow.Append(POut.Byte(paySplit.DiscountType)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.ProvNum)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.PayPlanNum)); sbRow.Append(",");
					sbRow.Append(POut.Date(paySplit.DatePay)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.ProcNum)); sbRow.Append(",");
					sbRow.Append(DbHelper.Now()); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.UnearnedType)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.ClinicNum)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.SecUserNumEntry)); sbRow.Append(",");
					//SecDateTEdit can only be set by MySQL
					sbRow.Append(POut.Long(paySplit.FSplitNum)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.AdjNum)); sbRow.Append(",");
					sbRow.Append(POut.Long(paySplit.PayPlanChargeNum)); sbRow.Append(",");
					sbRow.Append(POut.Int((int)paySplit.PayPlanDebitType)); sbRow.Append(",");
					sbRow.Append("'"+POut.String(paySplit.SecurityHash)+"'"); sbRow.Append(")");
					if(sbCommands.Length+sbRow.Length+1 > TableBase.MaxAllowedPacketCount && countRows > 0) {
						Db.NonQ(sbCommands.ToString());
						sbCommands=null;
					}
					else {
						if(hasComma) {
							sbCommands.Append(",");
						}
						sbCommands.Append(sbRow.ToString());
						countRows++;
						if(index==listPaySplits.Count-1) {
							Db.NonQ(sbCommands.ToString());
						}
						index++;
					}
				}
			}
		}

		///<summary>Inserts one PaySplit into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PaySplit paySplit) {
			return InsertNoCache(paySplit,false);
		}

		///<summary>Inserts one PaySplit into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PaySplit paySplit,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO paysplit (";
			if(!useExistingPK && isRandomKeys) {
				paySplit.SplitNum=ReplicationServers.GetKeyNoCache("paysplit","SplitNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="SplitNum,";
			}
			command+="SplitAmt,PatNum,ProcDate,PayNum,IsDiscount,DiscountType,ProvNum,PayPlanNum,DatePay,ProcNum,DateEntry,UnearnedType,ClinicNum,SecUserNumEntry,FSplitNum,AdjNum,PayPlanChargeNum,PayPlanDebitType,SecurityHash) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(paySplit.SplitNum)+",";
			}
			command+=
				 	   POut.Double(paySplit.SplitAmt)+","
				+    POut.Long  (paySplit.PatNum)+","
				+    POut.Date  (paySplit.ProcDate)+","
				+    POut.Long  (paySplit.PayNum)+","
				+    POut.Bool  (paySplit.IsDiscount)+","
				+    POut.Byte  (paySplit.DiscountType)+","
				+    POut.Long  (paySplit.ProvNum)+","
				+    POut.Long  (paySplit.PayPlanNum)+","
				+    POut.Date  (paySplit.DatePay)+","
				+    POut.Long  (paySplit.ProcNum)+","
				+    DbHelper.Now()+","
				+    POut.Long  (paySplit.UnearnedType)+","
				+    POut.Long  (paySplit.ClinicNum)+","
				+    POut.Long  (paySplit.SecUserNumEntry)+","
				//SecDateTEdit can only be set by MySQL
				+    POut.Long  (paySplit.FSplitNum)+","
				+    POut.Long  (paySplit.AdjNum)+","
				+    POut.Long  (paySplit.PayPlanChargeNum)+","
				+    POut.Int   ((int)paySplit.PayPlanDebitType)+","
				+"'"+POut.String(paySplit.SecurityHash)+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				paySplit.SplitNum=Db.NonQ(command,true,"SplitNum","paySplit");
			}
			return paySplit.SplitNum;
		}

		///<summary>Updates one PaySplit in the database.</summary>
		public static void Update(PaySplit paySplit) {
			string command="UPDATE paysplit SET "
				+"SplitAmt        =  "+POut.Double(paySplit.SplitAmt)+", "
				+"PatNum          =  "+POut.Long  (paySplit.PatNum)+", "
				+"ProcDate        =  "+POut.Date  (paySplit.ProcDate)+", "
				+"PayNum          =  "+POut.Long  (paySplit.PayNum)+", "
				+"IsDiscount      =  "+POut.Bool  (paySplit.IsDiscount)+", "
				+"DiscountType    =  "+POut.Byte  (paySplit.DiscountType)+", "
				+"ProvNum         =  "+POut.Long  (paySplit.ProvNum)+", "
				+"PayPlanNum      =  "+POut.Long  (paySplit.PayPlanNum)+", "
				+"DatePay         =  "+POut.Date  (paySplit.DatePay)+", "
				+"ProcNum         =  "+POut.Long  (paySplit.ProcNum)+", "
				//DateEntry not allowed to change
				+"UnearnedType    =  "+POut.Long  (paySplit.UnearnedType)+", "
				+"ClinicNum       =  "+POut.Long  (paySplit.ClinicNum)+", "
				//SecUserNumEntry excluded from update
				//SecDateTEdit can only be set by MySQL
				+"FSplitNum       =  "+POut.Long  (paySplit.FSplitNum)+", "
				+"AdjNum          =  "+POut.Long  (paySplit.AdjNum)+", "
				+"PayPlanChargeNum=  "+POut.Long  (paySplit.PayPlanChargeNum)+", "
				+"PayPlanDebitType=  "+POut.Int   ((int)paySplit.PayPlanDebitType)+", "
				+"SecurityHash    = '"+POut.String(paySplit.SecurityHash)+"' "
				+"WHERE SplitNum = "+POut.Long(paySplit.SplitNum);
			Db.NonQ(command);
		}

		///<summary>Updates one PaySplit in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(PaySplit paySplit,PaySplit oldPaySplit) {
			string command="";
			if(paySplit.SplitAmt != oldPaySplit.SplitAmt) {
				if(command!="") { command+=",";}
				command+="SplitAmt = "+POut.Double(paySplit.SplitAmt)+"";
			}
			if(paySplit.PatNum != oldPaySplit.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(paySplit.PatNum)+"";
			}
			if(paySplit.ProcDate.Date != oldPaySplit.ProcDate.Date) {
				if(command!="") { command+=",";}
				command+="ProcDate = "+POut.Date(paySplit.ProcDate)+"";
			}
			if(paySplit.PayNum != oldPaySplit.PayNum) {
				if(command!="") { command+=",";}
				command+="PayNum = "+POut.Long(paySplit.PayNum)+"";
			}
			if(paySplit.IsDiscount != oldPaySplit.IsDiscount) {
				if(command!="") { command+=",";}
				command+="IsDiscount = "+POut.Bool(paySplit.IsDiscount)+"";
			}
			if(paySplit.DiscountType != oldPaySplit.DiscountType) {
				if(command!="") { command+=",";}
				command+="DiscountType = "+POut.Byte(paySplit.DiscountType)+"";
			}
			if(paySplit.ProvNum != oldPaySplit.ProvNum) {
				if(command!="") { command+=",";}
				command+="ProvNum = "+POut.Long(paySplit.ProvNum)+"";
			}
			if(paySplit.PayPlanNum != oldPaySplit.PayPlanNum) {
				if(command!="") { command+=",";}
				command+="PayPlanNum = "+POut.Long(paySplit.PayPlanNum)+"";
			}
			if(paySplit.DatePay.Date != oldPaySplit.DatePay.Date) {
				if(command!="") { command+=",";}
				command+="DatePay = "+POut.Date(paySplit.DatePay)+"";
			}
			if(paySplit.ProcNum != oldPaySplit.ProcNum) {
				if(command!="") { command+=",";}
				command+="ProcNum = "+POut.Long(paySplit.ProcNum)+"";
			}
			//DateEntry not allowed to change
			if(paySplit.UnearnedType != oldPaySplit.UnearnedType) {
				if(command!="") { command+=",";}
				command+="UnearnedType = "+POut.Long(paySplit.UnearnedType)+"";
			}
			if(paySplit.ClinicNum != oldPaySplit.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(paySplit.ClinicNum)+"";
			}
			//SecUserNumEntry excluded from update
			//SecDateTEdit can only be set by MySQL
			if(paySplit.FSplitNum != oldPaySplit.FSplitNum) {
				if(command!="") { command+=",";}
				command+="FSplitNum = "+POut.Long(paySplit.FSplitNum)+"";
			}
			if(paySplit.AdjNum != oldPaySplit.AdjNum) {
				if(command!="") { command+=",";}
				command+="AdjNum = "+POut.Long(paySplit.AdjNum)+"";
			}
			if(paySplit.PayPlanChargeNum != oldPaySplit.PayPlanChargeNum) {
				if(command!="") { command+=",";}
				command+="PayPlanChargeNum = "+POut.Long(paySplit.PayPlanChargeNum)+"";
			}
			if(paySplit.PayPlanDebitType != oldPaySplit.PayPlanDebitType) {
				if(command!="") { command+=",";}
				command+="PayPlanDebitType = "+POut.Int   ((int)paySplit.PayPlanDebitType)+"";
			}
			if(paySplit.SecurityHash != oldPaySplit.SecurityHash) {
				if(command!="") { command+=",";}
				command+="SecurityHash = '"+POut.String(paySplit.SecurityHash)+"'";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE paysplit SET "+command
				+" WHERE SplitNum = "+POut.Long(paySplit.SplitNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(PaySplit,PaySplit) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(PaySplit paySplit,PaySplit oldPaySplit) {
			if(paySplit.SplitAmt != oldPaySplit.SplitAmt) {
				return true;
			}
			if(paySplit.PatNum != oldPaySplit.PatNum) {
				return true;
			}
			if(paySplit.ProcDate.Date != oldPaySplit.ProcDate.Date) {
				return true;
			}
			if(paySplit.PayNum != oldPaySplit.PayNum) {
				return true;
			}
			if(paySplit.IsDiscount != oldPaySplit.IsDiscount) {
				return true;
			}
			if(paySplit.DiscountType != oldPaySplit.DiscountType) {
				return true;
			}
			if(paySplit.ProvNum != oldPaySplit.ProvNum) {
				return true;
			}
			if(paySplit.PayPlanNum != oldPaySplit.PayPlanNum) {
				return true;
			}
			if(paySplit.DatePay.Date != oldPaySplit.DatePay.Date) {
				return true;
			}
			if(paySplit.ProcNum != oldPaySplit.ProcNum) {
				return true;
			}
			//DateEntry not allowed to change
			if(paySplit.UnearnedType != oldPaySplit.UnearnedType) {
				return true;
			}
			if(paySplit.ClinicNum != oldPaySplit.ClinicNum) {
				return true;
			}
			//SecUserNumEntry excluded from update
			//SecDateTEdit can only be set by MySQL
			if(paySplit.FSplitNum != oldPaySplit.FSplitNum) {
				return true;
			}
			if(paySplit.AdjNum != oldPaySplit.AdjNum) {
				return true;
			}
			if(paySplit.PayPlanChargeNum != oldPaySplit.PayPlanChargeNum) {
				return true;
			}
			if(paySplit.PayPlanDebitType != oldPaySplit.PayPlanDebitType) {
				return true;
			}
			if(paySplit.SecurityHash != oldPaySplit.SecurityHash) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one PaySplit from the database.</summary>
		public static void Delete(long splitNum) {
			string command="DELETE FROM paysplit "
				+"WHERE SplitNum = "+POut.Long(splitNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many PaySplits from the database.</summary>
		public static void DeleteMany(List<long> listSplitNums) {
			if(listSplitNums==null || listSplitNums.Count==0) {
				return;
			}
			string command="DELETE FROM paysplit "
				+"WHERE SplitNum IN("+string.Join(",",listSplitNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

		///<summary>Inserts, updates, or deletes database rows to match supplied list.  Returns true if db changes were made.
		///Supply Security.CurUser.UserNum, used to set the SecUserNumEntry field for Inserts.</summary>
		public static bool Sync(List<PaySplit> listNew,List<PaySplit> listDB,long userNum) {
			//Adding items to lists changes the order of operation. All inserts are completed first, then updates, then deletes.
			List<PaySplit> listIns    =new List<PaySplit>();
			List<PaySplit> listUpdNew =new List<PaySplit>();
			List<PaySplit> listUpdDB  =new List<PaySplit>();
			List<PaySplit> listDel    =new List<PaySplit>();
			listNew.Sort((PaySplit x,PaySplit y) => { return x.SplitNum.CompareTo(y.SplitNum); });
			listDB.Sort((PaySplit x,PaySplit y) => { return x.SplitNum.CompareTo(y.SplitNum); });
			int idxNew=0;
			int idxDB=0;
			int rowsUpdatedCount=0;
			PaySplit fieldNew;
			PaySplit fieldDB;
			//Because both lists have been sorted using the same criteria, we can now walk each list to determine which list contians the next element.  The next element is determined by Primary Key.
			//If the New list contains the next item it will be inserted.  If the DB contains the next item, it will be deleted.  If both lists contain the next item, the item will be updated.
			while(idxNew<listNew.Count || idxDB<listDB.Count) {
				fieldNew=null;
				if(idxNew<listNew.Count) {
					fieldNew=listNew[idxNew];
				}
				fieldDB=null;
				if(idxDB<listDB.Count) {
					fieldDB=listDB[idxDB];
				}
				//begin compare
				if(fieldNew!=null && fieldDB==null) {//listNew has more items, listDB does not.
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew==null && fieldDB!=null) {//listDB has more items, listNew does not.
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				else if(fieldNew.SplitNum<fieldDB.SplitNum) {//newPK less than dbPK, newItem is 'next'
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew.SplitNum>fieldDB.SplitNum) {//dbPK less than newPK, dbItem is 'next'
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				//Both lists contain the 'next' item, update required
				listUpdNew.Add(fieldNew);
				listUpdDB.Add(fieldDB);
				idxNew++;
				idxDB++;
			}
			//Commit changes to DB
			for(int i=0;i<listIns.Count;i++) {
				listIns[i].SecUserNumEntry=userNum;
				Insert(listIns[i]);
			}
			for(int i=0;i<listUpdNew.Count;i++) {
				if(Update(listUpdNew[i],listUpdDB[i])) {
					rowsUpdatedCount++;
				}
			}
			DeleteMany(listDel.Select(x => x.SplitNum).ToList());
			if(rowsUpdatedCount>0 || listIns.Count>0 || listDel.Count>0) {
				return true;
			}
			return false;
		}

	}
}