   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  M IOpenDentBusiness, Version=24.2.56.0, Culture=neutral, PublicKeyToken=nullG5clr-namespace:OpenDental.UI;assembly=OpenDentBusinessOpenDental.UI     OpenDental.FrmCommItem   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     Ioduiodb5clr-namespace:OpenDental.UI;assembly=OpenDentBusiness     $	��755��$	��617��   OpenDental.FrmODBase    Text$  Communication Item��.��� ���	#FFFCFDFE.+�   WpfControls.UI.Label  -     Name$ labelDateTimeCreated��$	��120��$��18��$��0,32,0,0q�   Text$ Date/Time Created��   HAlign$ Right=�   VAlign$ Center=�   WpfControls.UI.TextBox  -     Name$ textDateTimeCreated��$	��205��$��20��$��
120,31,0,0q�   	ColorBack$ 	#FFF0F0F0��   ReadOnly .    WpfControls.UI.Button  -     Name$ butCommlogHist��   WpfControls.UI.Button	   Click$	 butCommlogHist_Click��$��Right=�$��75��$��21��$��0,216,262,0q�
   Text$
 History��  -   $ butEditAutoNote��$	 butEditAutoNote_Click��$��Right=�$��82��$��21��$��0,216,174,0q�$
 Edit Auto Note��  -   $ butClearNote��$	 butClearNote_Click��$��Right=�$��75��$��21��$��
0,216,12,0q�$
 Clear��  -   $ butUserPrefs��$	 butUserPrefs_Click��$��Right=�$��75��$��21��$��0,7,12,0q�$
 
User Prefs��  -   $ butAutoNote��$	 butAutoNote_Click��$��Right=�$��75��$��21��$��
0,216,93,0q�$
 	Auto Note��  -   $ labelSavedManually��$��Right=�$	��106��$��Bottom=�$��16��$��	0,0,97,17q�   	ColorText$ 	#FFC00000��$ Saved��$ Right=�$ Center=�  -	   $ 	butNowEnd��$	 butNowEnd_Click��$��48��$��21��$��
331,79,0,0q�$	
 Now��  -
   $ textDateTimeEnd��$	��205��$��20��$��
120,79,0,0q�  -   $ labelDateTimeEnd��$��81��$��18��$��	39,80,0,0q�$	 End��$ Right=�$ Center=�  -   $ butNow��$	 butNow_Click��$��48��$��21��$��
331,55,0,0q�$	
 Now��(   "WpfControls.UI.SignatureBoxWrapper  -     Name$ signatureBoxWrapper��$	��364��$��Bottom=�$��81��$��
120,0,0,81q�$
��Left=�  -   $ textCommlogNum��$��Right=�$	��188��$��Bottom=�$��20��$��	0,0,12,43q�$ 	#FFF0F0F0�� .   -   $ labelCommlogNum��$��Right=�$��96��$��Bottom=�$��16��$��
0,0,201,45q�$ 
CommlogNum��$ Right=�$ Center=�  -   $ textUser��$��Right=�$	��119��$��20��$��0,7,93,0q�$ 	#FFF0F0F0�� .   -   $ label16��$��Right=�$��60��$��16��$��	0,9,214,0q�$
 User��$ Right=�$ Center=�  -   $ textPatientName��$	��205��$��20��$��	120,7,0,0q�$ 	#FFF0F0F0�� .   -   $ label5��$��78��$��18��$��42,8,0,0q�$ Patient��$ Right=�$ Center=�   WpfControls.UI.TextRich  -     Name$ textNote��   WpfControls.UI.TextRich   TextChanged$ ClearSignature_Handler��$��Stretch=�$��Stretch=�$��120,240,12,168q�   HasAutoNotes .    QuickPasteType$ CommLog=�	   WpfControls.UI.ListBox	  -    	 Name$ listSentOrReceived��$	��101��$��48��$��392,125,0,0q�  -   $ label4��$	��142��$��16��$��396,107,0,0q�$ Sent or Received��$ Bottom=�	  -   $ listMode��$	��125��$��95��$��254,125,0,0q�  -   $ label3��$��82��$��16��$��253,108,0,0q�$
 Mode��$ Bottom=�  -   $ textDateTime��$	��205��$��20��$��
120,55,0,0q�	  -   $ listType��$	��120��$��95��$��120,125,0,0q�  -   $ label2��$��82��$��16��$��117,223,0,0q�$
 Note��$ Bottom=�  -   $ 	butDelete��$	 butDelete_Click��$��75��$��Bottom=�$��25��$��	12,0,0,12q�$
 _Delete��   Icon$ DeleteX=�  -   $ butSave��$	 butSave_Click��$��Right=�$��75��$��Bottom=�$��25��$��	0,0,12,12q�$
 _Save��  -   $ label6��$��82��$��16��$��118,107,0,0q�$
 Type��$ Bottom=�  -   $ label1��$��81��$��18��$��	39,56,0,0q�$ Date / Time��$ Right=�$ Center=�