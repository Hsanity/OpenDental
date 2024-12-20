using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using OpenDentBusiness;

namespace OpenDental{

	///<summary>Used in public health.  This screening table is meant to be general purpose.  It is compliant with the popular Basic Screening Survey.  It is also designed with minimal foreign keys and can be easily adapted to a palm or pocketPC.  This table can be used with only the screengroup table, but is more efficient if provider, school, and county tables are also available.</summary>
	public struct Screen{
		///<summary>Primary key</summary>
		public int ScreenNum;
		///<summary>The date of the screening.</summary>
		public DateTime ScreenDate;
		///<summary>FK to school.SchoolName, although it will not crash if key absent.</summary>
		public string GradeSchool;
		///<summary>FK to county.CountyName, although it will not crash if key absent.</summary>
		public string County;
		///<summary>Enum:PlaceOfService</summary>
		public PlaceOfService PlaceService;
		///<summary>FK to provider.ProvNum.  ProvNAME is always entered, but ProvNum supplements it by letting user select from list.  When entering a provNum, the name will be filled in automatically. Can be 0 if the provider is not in the list, but provName is required.</summary>
		public int ProvNum;
		///<summary>Required.</summary>
		public string ProvName;
		///<summary>Enum:PatientGender</summary>
		public PatientGender Gender;
		///<summary>Enum:PatientRace and ethnicity.</summary>
		public PatientRace Race;
		///<summary>Enum:PatientGrade</summary>
		public PatientGrade GradeLevel;
		///<summary>Age of patient at the time the screening was done. Faster than recording birthdates.</summary>
		public int Age;
		///<summary>Enum:TreatmentUrgency</summary>
		public TreatmentUrgency Urgency;
		///<summary>Enum:YN Set to true if patient has cavities.</summary>
		public YN HasCaries;
		///<summary>Enum:YN Set to true if patient needs sealants.</summary>
		public YN NeedsSealants;
		///<summary>Enum:YN</summary>
		public YN CariesExperience;
		///<summary>Enum:YN</summary>
		public YN EarlyChildCaries;
		///<summary>Enum:YN</summary>
		public YN ExistingSealants;
		///<summary>Enum:YN</summary>
		public YN MissingAllTeeth;
		///<summary>Optional</summary>
		public DateTime Birthdate;
		///<summary>FK to screengroup.ScreenGroupNum.</summary>
		public int ScreenGroupNum;
		///<summary>The order of this item within its group.</summary>
		public int ScreenGroupOrder;
		///<summary>.</summary>
		public string Comments;
	}

	/*=========================================================================================
		=================================== class Screens ===========================================*/
  ///<summary></summary>
	public class Screens{
		///<summary></summary>
		public static Screen Cur;
		///<summary></summary>
		public static Screen[] List;

		///<summary></summary>
		public static void Refresh(int screenGroupNum){
			string command =
				"SELECT * from screen "
				+"WHERE ScreenGroupNum = '"+POut.PInt(screenGroupNum)+"' "
				+"ORDER BY ScreenGroupOrder";
			DataTable table=General.GetTable(command);
			List=new Screen[table.Rows.Count];
			for(int i=0;i<List.Length;i++){
				List[i].ScreenNum       =                  PIn.PInt   (table.Rows[i][0].ToString());
				List[i].ScreenDate      =                  PIn.PDate  (table.Rows[i][1].ToString());
				List[i].GradeSchool     =                  PIn.PString(table.Rows[i][2].ToString());
				List[i].County          =                  PIn.PString(table.Rows[i][3].ToString());
				List[i].PlaceService    =(PlaceOfService)  PIn.PInt   (table.Rows[i][4].ToString());
				List[i].ProvNum         =                  PIn.PInt   (table.Rows[i][5].ToString());
				List[i].ProvName        =                  PIn.PString(table.Rows[i][6].ToString());
				List[i].Gender          =(PatientGender)   PIn.PInt   (table.Rows[i][7].ToString());
				List[i].Race            =(PatientRace)     PIn.PInt   (table.Row}�  �   ! Wv�� >  Doctor�p   "� 	A ssistant5 ��t� N$  � Fro�F�4�w��ҩ�
s� K% ��#��
#�C #� #�    ���( @Z  �  #�#�=�#��k��������   ��G�ؽ��G��Z���k�#��#�U�5�������U��������I� �t��P����}k���������Y0����H  ��tc���)�.����@iê�������Q��BV�ҏ���Q������� ����Ky�����`a9�s�dU@~u��@�ũh��s�d��t��s�d�u�u����`�>�#j�s�` �(a��5	���my�a���`�s�}���``@	
�g���$ c���N�1D� ���]cZd���cf����c�y�c��y�c�y�c��k�b��c����(�c 
�($��(����(#�ub��c�g2�   ��^WYd0�\bڃhl4���c���`a~�`H�;�L��hkJs�`a���(#B���h�"t�8+1u��0  @ �0��,?1�016���=?1�4�p�NDU?�{�0qSٱ&�?q�0�NY1��?1�0 dP 2y�?1�m8�?��0���?2�8 �����8y?r�0P&� ���q�1  �0vsdK?0�2� 1XV�?q�2 2C,�ep�8�[?q�0q(�����tp�011XF�?0�0 �  1N�?���01&1��?1��t��-L�����1�pq�p?�q�0��?1��q0�~�?1��4������%��2 1`Q��?0�8�R?���10/q"�?1�0q�X�#����8�v$?q�0�*���8?1�89?�1�8�=?1�S��� 0��
�ſy@1P�0�?q0c�E1$��0  1�?q�10�1��p0q1�~;?0q�1��;?�1�31� �p0��X�oH?0	8���V?0
0 ��q��?�10b�X�Wpg0q1#�?qgq�31f�?1�0q	�6f�%�r  1�?q?�l{�0׵�{xG�2\?�8wg[p?~8x�7�� xg�> �  @Z p     XP  	�PZv�� RF8!F FS ��D�FG
Q k黄kGQ #���# # E k #���#SG#��#� S $��� ���51�!��}�#K�"� � ���v�Y#�фG�Ò$��5��}��ђ%�#H @ ����&���'� ��:��(���h�!��#)��,*B�*��&w���+�@ �в��ѳ,�������-��tQ���-�.�!� �/���j0���1��,Q�5��;�#2��@  �
<�*3�k�4`  R����5h2�=r6`a`h�Lr7�`��`t!�r8a`�)aDs9b  )a�Rs:;7`a�<d�pn�s=`a��bws�>�aL{s?h:Vt@`�>�3��r(A` �,�t�B`e_�Ch�tD`e.��M�Ead:�sFS`�.�sG�Q�G���rHb@� a܎�rI�R���sJhZ�sK`a,�&�$�rLh�,sRMh7-sN` ����?�>p��OPhg2�vQ?~�R0������Sr� (���?1T0�3b%0|D 0�U�8yE?qV0��q27.pW0f �^��N?qX�1�3-���?1�Y1py&0	�?�1Zt�mH/�m�[05�?�\�q0q�?2]1c�1�u=��^g108���?1_�2 ��>p�`?�!a0q�Ms�b0  '0����c0 0�W�5?1d0�qlO�?1e4�)�Lpf0q(1X�M?0gxk�wz?0h01ql�y?�itqC��-�pjqp1�	5?qk1@1��?1l0q1�?�#m8?2�n0qq1}�?�0o0�1�?�p4.p�!��pq8�o?q�r8+�?1s4bF�����t�420̠�?0�u8:�?�v4b3pA��pw�0�r1'��?0
x8�?  $~u?~v?~x	?~y?~z ��   ~w�	� �{L}L�~&&�&�����t����	��	��	���	��	��	��	V�
�������	�U�	��	��	���U���c����U��������U�������������v��  
EoU�̩������U��������U����p�p�Up�p�p�p�Up�p�p�p�Up�p�p�p�Up�p�p�p�Up�p�p�p�Up�p�p�p�p�p�mX > � R ALL  notes n eed to b e on St  David's  Foundati on.  NO  more enter for Sharr`Wal�tonbj�p�p��p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�?$~�?~�?~�I?~�?~�?~��?~�?~�?$~�?~�?~�I?~�?~�?~��?~�?~�?$~�?~�?~��?~�?~�e���0,)��?~I?~?~?~�	?~?~
?$~?~?~I?~?~?~�?~?~?$~?~�~�I?~�?~�?~�?~?~?$~?~?~�I~~?~� ?~!?~"?$~#?~$?~%I?~&?~'?~�(?~)?~+?$~,?~-?~0I?~1?~2?~�3?~4?~6?$~5?~8?~9I?~:?~<?~�=?~>?~??$~@?~A?~CI?~D?~E?~�F?~H?~I?$~J?~K?~LI?~.?~M?~�N?~O?~P?$~Q?~R?~TI?~?~V?~�U?~W?~X?~�sCг   ~�N�8�YLZUL\&[&]&^U��_'`aU�Ob'��cU�d�	e�	f�	gU�	�;�	h�SU�	i�	j�	k�lU�m�p�^�,oU�	q�r�s�tU�u�w�x�yU�z�{�|�}U�~����B |� < 4 246-3151 -2748-20 48
exp  01/09
J ust call ed to us e this o�nce  �����p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�p��p�pvp�p��p�p�p�p��p�p�p�p��p�p�p�p��p�p�p�p��?~�?~�?$~�?~�?~�I?~�?~�?~��?~�?~�?$~�?~�?~�I?~�?~�?~��?~�?~�?$~�?~�?~�I?~�?~�?~��?~�?~�?$~�?~�?~�	?~�=*|�  $ SEND  RECEIPT  after c ha='" +POut.PInt   ((int)Cur.ExistingSealants)+"'"
				+",MissingAllTeeth ='"  +POut.PInt   ((int)Cur.MissingAllTeeth)+"'"
				+",Birthdate ='"        +POut.PDate  (Cur.Birthdate)+"'"
				+",ScreenGroupNum ='"   +POut.PInt   (Cur.ScreenGroupNum)+"'"
				+",ScreenGroupOrder ='" +POut.PInt   (Cur.ScreenGroupOrder)+"'"
				+",Comments ='"         +POut.PString(Cur.Comments)+"'"
				+" WHERE ScreenNum = '" +POut.PInt(Cur.ScreenNum)+"'";
			General.NonQ(command);
		}

		///<summary>Updates all screens for a group with the date,prov, and location info of the current group.</summary>
		public static void UpdateForGroup(){
			string command = "UPDATE screen SET "
				+"ScreenDate     ='"    +POut.PDate  (ScreenGroups.Cur.SGDate)+"'"
				+",GradeSchool ='"      +POut.PString(ScreenGroups.Cur.GradeSchool)+"'"
				+",County ='"           +POut.PString(ScreenGroups.Cur.County)+"'"
				+",PlaceService ='"     +POut.PInt   ((int)ScreenGroups.Cur.PlaceService)+"'"
				+",ProvNum ='"          +POut.PInt   (ScreenGroups.Cur.ProvNum)+"'"
				+",ProvName ='"         +POut.PString(ScreenGroups.Cur.ProvName)+"'"
				+" WHERE ScreenGroupNum = '" +ScreenGroups.Cur.ScreenGroupNum.ToString()+"'";
			General.NonQ(command);
		}

		///<summary></summary>
		public static void DeleteCur(){
			string command = "DELETE from screen WHERE ScreenNum = '"+POut.PInt(Cur.ScreenNum)+"'";
			General.NonQ(command);
		}


	}

	

}













