   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  !    OpenDental.FrmPatientSelect   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��944��$	��696��   OpenDental.FrmODBase    Text$  Select Patient��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.Label  -     Name$ labelMatchingRecords��$��Right=�$	��220��$��Bottom=�$��17��$��	0,0,31,56q�   Text$ 0 Records Displayed��   HAlign$ Center=�   VAlign$ Center=�   WpfControls.UI.Button  -     Name$ butOK��   WpfControls.UI.Button   Click$ butOK_Click��$��Right=�$��76��$��Bottom=�$��26��$��0,0,10,7q�   Text$	 _OK��   WpfControls.UI.Grid  -   	  Name$	 gridMain��$��Stretch=�$��Stretch=�$��	3,2,276,7q�
   ArrowsWhenNoFocus
 .    HScrollVisible .    Title$ Select Patient��   TranslationName$ FormPatientSelect��   WrapText .     WpfControls.UI.GroupBox  -     Name$ 	groupBox1��$��Right=�$	��262��$��61��$��
0,502,10,0q�   
TabIndexOD$ 1��   Text$ Search��.@�   WpfControls.UI.CheckBox  -     Name$ checkRefresh��   WpfControls.UI.CheckBox   Click$ checkRefresh_Click��$	��245��$��18��$��	11,41,0,0q�   Text$ Refresh while typing��   
CheckAlign$ 
MiddleLeft=�  -   $ 	butGetAll��$ butGetAll_Click��$��75��$��23��$��
148,15,0,0q�$ Get All��  -   $ 	butSearch��$ butSearch_Click��$��75��$��23��$��	42,15,0,0q�$ _Search��  -   $ 	groupBox2��$��Right=�$	��262��$	��499��$��0,2,10,0q�$ 0��$ 
Search by:��.@�  -	   $ butOnScreenKeyboard��$ butOnScreenKeyboard_Click��$��90��$��23��$��
166,10,0,0q�$ Keyboard��	   WpfControls.UI.TextBox	  -
    	 Name$ textInvoiceNumber��$��90��$��20��$��166,295,0,0q� 	  
TabIndexOD$ 12��  -   $ labelInvoiceNumber��$	��156��$��17��$��
11,296,0,0q�$ Invoice Number��$ Right=�$ Center=�  -   $ checkShowMerged��$	��236��$��17��$��
11,477,0,0q�$ Show Merged Patients��$ 
MiddleLeft=�	  -   $ 
textRegKey��$��90��$��20��$��166,335,0,0q�$ 14��  -   $ labelRegKey��$	��156��$��17��$��
11,336,0,0q�$ RegKey��$ Right=�$ Center=� 
   WpfControls.UI.ComboClinic
  -    
 Name$ comboClinic��$	��195��$��21��$��
61,398,0,0q� 
  
IncludeAll . 	  -   $ textCountry��$��90��$��20��$��166,315,0,0q�$ 13��  -   $ labelCountry��$	��156��$��17��$��
11,316,0,0q�$ Country��$ Right=�$ Center=�	  -   $ 	textEmail��$��90��$��20��$��166,275,0,0q�$ 11��  -   $ 
labelEmail��$	��156��$��13��$��
11,279,0,0q�$ E-mail��$ Right=�$ Center=�	  -   $ textSubscriberID��$��90��$��20��$��166,255,0,0q�$ 10��  -   $ label13��$	��156��$��13��$��
11,259,0,0q�$ Subscriber ID��$ Right=�$ Center=�   WpfControls.UI.ComboBox  -     Name$ 	comboSite��$	��158��$��21��$��
98,377,0,0q�  -   $ 	labelSite��$��86��$��14��$��
11,381,0,0q�$
 Site��$ Right=�$ Center=�  -   $ comboBillingType��$	��158��$��21��$��
98,356,0,0q�	  -   $ textBirthdate��$��90��$��20��$��166,235,0,0q�$ 9��  -   $ label2��$	��156��$��13��$��
11,239,0,0q�$ 	Birthdate��$ Right=�$ Center=�  -   $ checkShowArchived��$ checkShowArchived_Click��$	��245��$��16��$��
11,460,0,0q�$+ %Show Archived/Deceased/Hidden Clinics��$ 
MiddleLeft=�	  -   $ textChartNumber��$��90��$��20��$��166,215,0,0q�$ 8��	  -   $ textSSN��$��90��$��20��$��166,175,0,0q�$ 6��  -   $ label12��$	��155��$��13��$��
11,179,0,0q�$	 SSN��$ Right=�$ Center=�  -   $ label11��$��87��$��15��$��
11,360,0,0q�$ Billing Type��$ Right=�$ Center=�  -    $ label10��$	��156��$��13��$��
11,219,0,0q�$ Chart Number��$ Right=�$ Center=�	  -!   $ 
textPatNum��$��90��$��20��$��166,195,0,0q�$ 7��  -"   $ label9��$	��156��$��13��$��
11,199,0,0q�$ Patient Number��$ Right=�$ Center=�	  -#   $ 	textState��$��90��$��20��$��166,155,0,0q�$ 5��  -$   $ label8��$	��154��$��13��$��
11,159,0,0q�$ State��$ Right=�$ Center=�	  -%   $ textCity��$��90��$��20��$��166,135,0,0q�$ 4��  -&   $ label7��$	��152��$��14��$��
11,137,0,0q�$
 City��$ Right=�$ Center=�  -'   $ checkGuarantors��$	��245��$��16��$��
11,426,0,0q�$ Guarantors Only��$ 
MiddleLeft=�  -(   $ checkShowInactive��$	��245��$��16��$��
11,443,0,0q�$ Show Inactive Patients��$ 
MiddleLeft=�  -)   $ label6��$	��245��$��14��$��	11,38,0,0q�$+ %Hint: enter values in multiple boxes.��$ Center=�	  -*   $ textAddress��$��90��$��20��$��166,115,0,0q�$ 3��  -+   $ label5��$	��154��$��13��$��
11,118,0,0q�$ Address��$ Right=�$ Center=�	  -,   $ 	textPhone��$��90��$��20��$��
166,95,0,0q�$ 2��  --   $ label4��$	��155��$��16��$��	11,97,0,0q�$ Phone (any)��$ Right=�$ Center=�	  -.   $ 	textFName��$��90��$��20��$��
166,75,0,0q�$ 1��  -/   $ label3��$	��154��$��13��$��	11,79,0,0q�$ 
First Name��$ Right=�$ Center=�	  -0   $ 	textLName��$��90��$��20��$��
166,55,0,0q�$ 0��  -1   $ label1��$	��154��$��13��$��	11,58,0,0q�$ 	Last Name��$ Right=�$ Center=�  -2   $ groupAddPatient��$��Right=�$	��262��$��43��$��
0,564,10,0q�$ 2��$ Add New Family:��.@�  -3   $ butAddPatient��$ butAddPatient_Click��$��75��$��23��$��	42,15,0,0q�$ _Add Pt��  -4   $ 
butAddMany��$ butAddMany_Click��$��75��$��23��$��
148,15,0,0q�$ Add Many��