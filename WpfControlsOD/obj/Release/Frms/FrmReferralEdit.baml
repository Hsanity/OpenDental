   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI       OpenDental.FrmReferralEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $
��1261��$	��698��   OpenDental.FrmODBase    Text$  Edit Referral��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.ComboBox  -     Name$ comboSpecialty��$	��201��$��21��$��149,505,0,0q�   WpfControls.UI.CheckBox  -     Name$ checkHiddenComms��   WpfControls.UI.CheckBox   Click$ checkHiddenComms_Click��$	��115��$��18��$��1079,223,0,0q�   Text$ Show Hidden  ��   
CheckAlign$ MiddleRight=�   WpfControls.UI.Button  -     Name$ 
butAddComm��   WpfControls.UI.Button   Click$ butAddComm_Click��$��493,217,0,0q�	   Text$	 Add Comm��
   Icon$
 CommLog=�$��24��$	��100��   WpfControls.UI.Grid  -     Name$ gridComm��$��493,245,0,0q�   Title$+ %Communications Log - Referral Details��   TranslationName$ TableCommLog��$	��701��$	��357��    WpfControls.UI.ComboClinic  -     Name$ comboClinicPicker��$	��200��$��21��$��112,581,0,0q�   IncludeUnassigned .    IsMultiSelect . 	   WpfControls.UI.Label	  -    	 Name$ labelDisplayNote��$	��137��$��31��$��469,170,0,0q� 	  Text$, &Display Notes (shows in Family module)�� 	  HAlign$ Right=�
   WpfControls.UI.TextRich
  -    
 Name$ textDisplayNote��$	��273��$��47��$��606,170,0,0q� 
  QuickPasteType$ Referral=� 
  
TabIndexOD$ 23��   WpfControls.UI.TextBox  -     Name$ textBusinessName��$	��297��$��20��$��149,311,0,0q�   
TabIndexOD$ 14��	  -	   $ labelBusinessName��$	��104��$��18��$��
44,313,0,0q�$ Business Name��$ Right=�  -
   $ checkIsPreferred��$	��150��$��18��$��
12,467,0,0q�$ Preferred Referral��$ MiddleRight=�  -   $ checkEmailTrustDirect��$	��156��$��18��$��	6,334,0,0q�$ E-mail Trust for Direct��$ MiddleRight=�  -   $ checkIsDoctor��$��86��$��18��$��
76,485,0,0q�$ 	Is Doctor��$ MiddleRight=�  -   $ 	butDelete��$ butDelete_Click��$��80��$��Bottom=�$��24��$��	16,0,0,17q�$	 Delete��$
 DeleteX=�  -   $ 	comboSlip��$	��275��$��21��$��149,539,0,0q�	  -   $ label21��$	��147��$��44��$��	3,530,0,0q�$B <Referral Slip (custom referral slips may be added in Sheets)��$ Right=�	  -   $ label20��$��11��$��1��$��177,248,0,0q�$ )��$ Right=�	  -   $ label19��$	��117��$��18��$��
31,444,0,0q�$ National Provider ID��$ Right=� 	  VAlign$ Center=�  -   $ textNationalProvID��$	��100��$��20��$��149,444,0,0q�$ 16��   WpfControls.UI.GroupBox  -     Name$ 	groupBox2��$	��383��$	��109��$��	590,8,0,0q�   Text$ Used By Patients��.@�	  -   $ label18��$	��323��$��18��$��	15,57,0,0q�$* $Patients referred FROM this referral��$ Bottom=�  -   $ textPatientsNumFrom��$��35��$��20��$��	17,78,0,0q�   ReadOnly . $ 3��  -   $ comboPatientsFrom��$	��299��$��21��$��	61,78,0,0q�	  -   $ label6��$	��323��$��18��$��	15,14,0,0q�$( "Patients referred TO this referral��$ Bottom=�  -   $ textPatientsNumTo��$��35��$��20��$��	17,35,0,0q� . $ 1��  -   $ comboPatientsTo��$	��299��$��21��$��	61,35,0,0q�
  -   $ 	textNotes��$	��588��$��47��$��606,121,0,0q�$ Referral=�$ 22��  -   $ checkHidden��$	��115��$��18��$��	47,24,0,0q�$ Hidden  ��$ MiddleRight=�  -   $ checkNotPerson��$	��115��$��18��$��
167,24,0,0q�$ 
Not Person��$ MiddleRight=�	  -   $ labelPatient��$	��612��$��18��$��63,8,0,0q�$e _This referral is a patient.  Some information can only be changed from the patient's edit form.��  -   $ 	textEmail��$	��297��$��20��$��149,289,0,0q�$ 13��  -   $ textOtherPhone��$	��161��$��149,267,0,0q�$ 12��$��20��  -    $ textZip��$	��161��$��20��$��149,223,0,0q�$ 8��  -!   $ textCity��$	��190��$��20��$��149,179,0,0q�$ 6��  -"   $ textAddress2��$	��297��$��20��$��149,157,0,0q�$ 5��  -#   $ textAddress��$	��297��$��20��$��149,135,0,0q�$ 4��  -$   $ 	textTitle��$��70��$��20��$��149,113,0,0q�$ 3��  -%   $ 
textPhone3��$��39��$��20��$��230,245,0,0q�$ 11��  -&   $ 
textPhone2��$��28��$��20��$��190,245,0,0q�$ 10��  -'   $ 
textPhone1��$��28��$��20��$��149,245,0,0q�$ 9��  -(   $ textST��$	��118��$��20��$��149,201,0,0q�$ 7��  -)   $ 	textMName��$	��169��$��20��$��
149,91,0,0q�$ 2��  -*   $ 	textFName��$	��297��$��20��$��
149,69,0,0q�$ 1��  -+   $ 	textLName��$	��297��$��20��$��
149,47,0,0q�$ 0��	  -,   $ label17��$	��101��$��18��$��503,121,0,0q�$ Notes��$ Right=�	  --   $ label22��$	��104��$��18��$��
44,291,0,0q�$ E-mail��$ Right=�	  -.   $ label16��$	��104��$��18��$��
44,269,0,0q�$ Other Phone��$ Right=�	  -/   $ labelZip��$	��104��$��18��$��
44,225,0,0q�$	 Zip��$ Right=�	  -0   $ label7��$	��104��$��18��$��
44,181,0,0q�$
 City��$ Right=�	  -1   $ label8��$	��104��$��18��$��
44,159,0,0q�$ Address2��$ Right=�	  -2   $ label9��$	��104��$��18��$��
44,137,0,0q�$ Address��$ Right=�	  -3   $ label5��$��89��$��18��$��
60,115,0,0q�$ Title (DDS)��$ Right=�	  -4   $ label13��$��6��$��16��$��220,247,0,0q�$ -��$ Center=�	  -5   $ label11��$��6��$��16��$��178,247,0,0q�$ )��$ Center=�	  -6   $ label12��$��11��$��16��$��140,247,0,0q�$ (��$ Right=�	  -7   $ label14��$��95��$��18��$��
44,247,0,0q�$ Phone��$ Right=�	  -8   $ label10��$��99��$��18��$��
51,508,0,0q�$ 	Specialty��$ Right=�  -9   $ groupSSN��$	��141��$��86��$��141,354,0,0q�$ SSN or TIN (no dashes)��.@�    WpfControls.UI.RadioButton  -:     Name$ radioTIN��    WpfControls.UI.RadioButton   Click$ radioTIN_Click��$	��104��$��20��$��9,39,0,0q�   Text$	 TIN��    
CheckAlign$  
MiddleLeft=�  -;   $ radioSSN��$ radioSSN_Click��$	��104��$��20��$��9,17,0,0q�$	 SSN��$  
MiddleLeft=�!   Checked! .   -<   $ textSSN��$	��100��$��20��$��8,61,0,0q�$ 2��	  -=   $ labelST��$	��104��$��18��$��
44,203,0,0q�$ ST��$ Right=�	  ->   $ label3��$	��104��$��18��$��	44,93,0,0q�$ Middle Name��$ Right=�	  -?   $ label2��$	��104��$��18��$��	44,71,0,0q�$ 
First Name��$ Right=�	  -@   $ label1��$	��104��$��18��$��	44,49,0,0q�$ 	Last Name��$ Right=�  -A   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,30,17q�$	 _Save��	  -B   $ label19_Copy��$	��225��$��18��$��165,467,0,0q�$$ just for filtering in the list��$ Center=�