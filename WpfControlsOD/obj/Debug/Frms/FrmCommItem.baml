   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      M IOpenDentBusiness, Version=24.2.56.0, Culture=neutral, PublicKeyToken=nullG5clr-namespace:OpenDental.UI;assembly=OpenDentBusinessOpenDental.UI 5          OpenDental.FrmCommItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      Ioduiodb5clr-namespace:OpenDental.UI;assembly=OpenDentBusiness     5      $	��755��5
      $	��617��6      OpenDental.FrmODBase    Text$  Communication Item��5      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Label  -   5          Name$ labelDateTimeCreated��5      $	��120��61   $��18��6=   $��0,32,0,0q�6I      Text$ Date/Time Created��6[      HAlign$ Right=�6t      VAlign$ Center=�6�      WpfControls.UI.TextBox  5   
   -   5          Name$ textDateTimeCreated��5      $	��205��62   $��20��6>   $��
120,31,0,0q�6J      	ColorBack$ 	#FFF0F0F0��6^      ReadOnly . 6t      WpfControls.UI.Button  5   
   -   5          Name$ butCommlogHist��5         WpfControls.UI.Button	   Click$	 butCommlogHist_Click��6�   $��Right=�6,   $��75��6H   $��21��6S   $��0,216,262,0q�6_   
   Text$
 History��6t   6�     5   
   -   5        $ butEditAutoNote��5      $	 butEditAutoNote_Click��6�   $��Right=�6-   $��82��6I   $��21��6T   $��0,216,174,0q�6`   $
 Edit Auto Note��6u   6�     5   
   -   5        $ butClearNote��5      $	 butClearNote_Click��6~   $��Right=�6*   $��75��6F   $��21��6Q   $��
0,216,12,0q�6]   $
 Clear��6q   6~     5   
   -   5        $ butUserPrefs��5      $	 butUserPrefs_Click��6�   $��Right=�6*   $��75��6F   $��21��6Q   $��0,7,12,0q�6]   $
 
User Prefs��6o   6�     5   
   -   5        $ butAutoNote��5      $	 butAutoNote_Click��6�   $��Right=�6)   $��75��6E   $��21��6P   $��
0,216,93,0q�6\   $
 	Auto Note��6p   6�     5   
   -   5        $ labelSavedManually��5      $��Right=�6/   $	��106��6K   $��Bottom=�6W   $��16��6r   $��	0,0,97,17q�6~      	ColorText$ 	#FFC00000��6�   $ Saved��6�   $ Right=�6�   $ Center=�6�     5   
   -	   5        $ 	butNowEnd��5      $	 butNowEnd_Click��6]   $��48��6'   $��21��62   $��
331,79,0,0q�6>   $	
 Now��6R   6]     5   
   -
   5        $ textDateTimeEnd��5      $	��205��6.   $��20��6:   $��
120,79,0,0q�6F     5   
   -   5        $ labelDateTimeEnd��5      $��81��6-   $��18��68   $��	39,80,0,0q�6D   $	 End��6W   $ Right=�6b   $ Center=�6q     5   
   -   5        $ butNow��5      $	 butNow_Click��6Z   $��48��6$   $��21��6/   $��
331,55,0,0q�6;   $	
 Now��6O   6Z   (   "WpfControls.UI.SignatureBoxWrapper  5   
   -   5          Name$ signatureBoxWrapper��5   !   $	��364��6>   $��Bottom=�6J   $��81��6e   $��
120,0,0,81q�6q   $
��Left=�6�     5   
   -   5        $ textCommlogNum��5      $��Right=�6-   $	��188��6I   $��Bottom=�6U   $��20��6p   $��	0,0,12,43q�6|   $ 	#FFF0F0F0��6�    . 6�     5   
   -   5        $ labelCommlogNum��5      $��Right=�6,   $��96��6H   $��Bottom=�6S   $��16��6n   $��
0,0,201,45q�6z   $ 
CommlogNum��6�   $ Right=�6�   $ Center=�6�     5   
   -   5        $ textUser��5      $��Right=�6'   $	��119��6C   $��20��6O   $��0,7,93,0q�6[   $ 	#FFF0F0F0��6m    . 6�     5   
   -   5        $ label16��5      $��Right=�6$   $��60��6@   $��16��6K   $��	0,9,214,0q�6W   $
 User��6j   $ Right=�6v   $ Center=�6�     5   
   -   5        $ textPatientName��5      $	��205��6.   $��20��6:   $��	120,7,0,0q�6F   $ 	#FFF0F0F0��6Y    . 6o     5   
   -   5        $ label5��5      $��78��6#   $��18��6.   $��42,8,0,0q�6:   $ Patient��6L   $ Right=�6[   $ Center=�6j      WpfControls.UI.TextRich  5    
   -   5          Name$ textNote��5          WpfControls.UI.TextRich   TextChanged$ ClearSignature_Handler��6�   $��Stretch=�6(   $��Stretch=�6F   $��120,240,12,168q�6b      HasAutoNotes .    QuickPasteType$ CommLog=�6�   6�   	   WpfControls.UI.ListBox	  5!   
   -   5         	 Name$ listSentOrReceived��5!      $	��101��61   $��48��6=   $��392,125,0,0q�6I     5"   
   -   5        $ label4��5"      $	��142��6#   $��16��6/   $��396,107,0,0q�6;   $ Sent or Received��6P   $ Bottom=�6h   	  5#   
   -   5        $ listMode��5#      $	��125��6'   $��95��63   $��254,125,0,0q�6?     5$   
   -   5        $ label3��5$      $��82��6#   $��16��6.   $��253,108,0,0q�6:   $
 Mode��6O   $ Bottom=�6[     5%   
   -   5        $ textDateTime��5%      $	��205��6+   $��20��67   $��
120,55,0,0q�6C   	  5&   
   -   5        $ listType��5&      $	��120��6'   $��95��63   $��120,125,0,0q�6?     5'   
   -   5        $ label2��5'      $��82��6#   $��16��6.   $��117,223,0,0q�6:   $
 Note��6O   $ Bottom=�6[     5(   
   -   5        $ 	butDelete��5(      $	 butDelete_Click��6�   $��75��6'   $��Bottom=�62   $��25��6M   $��	12,0,0,12q�6Y   $
 _Delete��6l      Icon$ DeleteX=�6{   6�     5)   
   -   5        $ butSave��5)      $	 butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��25��6g   $��	0,0,12,12q�6s   $
 _Save��6�   6�     5*   
   -   5        $ label6��5*      $��82��6#   $��16��6.   $��118,107,0,0q�6:   $
 Type��6O   $ Bottom=�6[     5+   
   -   5        $ label1��5+      $��81��6#   $��18��6.   $��	39,56,0,0q�6:   $ Date / Time��6M   $ Right=�6`   $ Center=�6o   5,      5-      