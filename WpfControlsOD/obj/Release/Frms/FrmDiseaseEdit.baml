   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI      OpenDental.FrmDiseaseEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��495��$	��426��   OpenDental.FrmODBase    Text$  Edit Problem��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.TextBox  -     Name$ 	textIcd10��$	��321��$��20��$��
118,64,0,0q�   	ColorBack$ 	#FFF0F0F0��   WpfControls.UI.Label  -     Name$ label9��$	��100��$��19��$��	14,65,0,0q�   Text$ ICD10��   HAlign$ Right=�   VAlign$ Center=�  -   $ label8��$	��150��$��17��$��333,349,0,0q�$ Only for CCD��$ Center=�  -   $ labelFunctionalStatus��$��97��$��23��$��
17,346,0,0q�$ Functional Status��$ Right=�$ Center=�   WpfControls.UI.ComboBox  -     Name$ comboEhrFunctionalStatus��$	��210��$��21��$��118,348,0,0q�  -   $ label7��$	��150��$��17��$��333,322,0,0q�$ Only for CCD��$ Center=�  -   $ labelSnomedProblemType��$	��100��$��17��$��
12,322,0,0q�$ Problem Type��$ Right=�$ Center=�  -   $ comboSnomedProblemType��$	��209��$��21��$��118,321,0,0q�  -	   $ label6��$	��100��$��19��$��	14,90,0,0q�$ 	SNOMED CT��$ Right=�$ Center=�  -
   $ 
textSnomed��$	��322��$��20��$��
118,90,0,0q�$ 	#FFF0F0F0��   WpfControls.UI.Button  -   	  Name$	 butTodayStop��   WpfControls.UI.Button
   Click$
 butTodayStop_Click��$��64��$��23��$��263,167,0,0q�   Text$ Today��  -   $	 butTodayStart��$
 butTodayStart_Click��$��65��$��23��$��263,141,0,0q�$ Today��   WpfControls.UI.TextVDate  -     Name$ textVDateStop��$	��126��$��20��$��118,169,0,0q�  -   $ textVDateStart��$	��126��$��20��$��118,143,0,0q�  -   $ labelStatus��$	��111��$��15��$��	3,118,0,0q�$ Status��$ Right=�$ Center=�  -   $ comboStatus��$	��126��$��21��$��118,116,0,0q�  -   $ textIcd9��$	��321��$��20��$��
118,38,0,0q�$ 	#FFF0F0F0��  -   $ label3��$	��100��$��19��$��	14,39,0,0q�$
 ICD9��$ Right=�$ Center=�  -   $ textProblem��$	��199��$��20��$��
118,12,0,0q�$ 	#FFF0F0F0��  -   $	 	butDelete��$
 butDelete_Click��$��83��$��Bottom=�$��26��$��	12,0,0,12q�$ Delete��   Icon$ DeleteX=�  -   $ label5��$	��100��$��19��$��
14,169,0,0q�$ 	Stop Date��$ Right=�$ Center=�  -   $ label4��$	��100��$��19��$��
14,143,0,0q�$ 
Start Date��$ Right=�$ Center=�  -   $ label2��$	��100��$��19��$��	14,13,0,0q�$ Problem��$ Right=�$ Center=�  -   $ label1��$	��100��$��17��$��
12,195,0,0q�$
 Note��$ Right=�$ Center=�  -   $ textNote��$	��322��$	��120��$��118,195,0,0q�   IsMultiline .   -   $	 butSave��$
 butSave_Click��$��Right=�$��75��$��Bottom=�$��26��$��	0,0,12,12q�$ _Save��