   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5           OpenDental.FrmCommReferral   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��626��5	      $	��431��6      OpenDental.FrmODBase    Text$%  Communication Item for Referral��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.CheckBox  -   5          Name$ checkHidden��5      $	��115��6+   $��18��67   $��13,9,0,0q�6C      Text$ Hidden  ��6U      
CheckAlign$ MiddleRight=�6e     5   
   -   5        $ checkAnchored��5      $	��115��6-   $��18��69   $��	13,33,0,0q�6E   $ Anchored to top��6X   $ MiddleRight=�6o      WpfControls.UI.ListBox  5   
   -   5          Name$ listSentOrReceived��5      $	��101��61   $��43��6=   $��258,107,0,0q�6I    J� RenderTransformOrigin$ 0.475,1.884&�6^      WpfControls.UI.Label  5   
   -   5          Name$ labelSentorReceived��5      $	��142��60   $��18��6<   $��
258,87,0,0q�6H      Text$ Sent or Received��6\      VAlign$ Bottom=�6t   $ 0.373,-0.056&�6�     5   
   -   5        $ listMode��5      $	��125��6'   $	��108��63   $��116,107,0,0q�6@   $ -0.184,0.815&�6U     5   
   -   5        $ 	labelMode��5      $��82��6&   $��18��61   $��
115,84,0,0q�6=   $
 Mode��6Q   $ Bottom=�6]     5   
   -   5        $ 	labelNote��5      $��115,223,0,0q�6&   $
 Note��6;   $ Bottom=�6G   $��18��6W   $��82��6c      WpfControls.UI.TextRich  5   
   -   5        	  Name$	 textNote��5      $��116,246,0,80q�6(   
   HasAutoNotes
 .    QuickPasteType$ CommLog=�6R      
TabIndexOD$ 0��6k   $	��451��6z   $��Stretch=�6�      WpfControls.UI.TextBox  5   
   -	   5          Name$ textUser��5      $��Right=�6'   $	��119��6C   $��20��6O   $��	0,12,12,0q�6[      	ColorBack$ 	#FFF0F0F0��6n      ReadOnly .    
TabIndexOD$ 2��6�     5   
   -
   5        $ 	labelUser��5      $��Right=�6&   $��60��6B   $��18��6M   $��
0,13,137,0q�6Y   $
 User��6m      HAlign$ Right=�6y   $ Center=�6�     5   
   -   5        $ labelDateTimeCreated��5      $	��116��61   $��18��6=   $��0,58,0,0q�6I   $ Date/Time Created��6[   $ Right=�6t   $ Center=�6�     5   
   -   5        $ textDateTimeCreated��5      $	��205��62   $��20��6>   $��
116,57,0,0q�6J   $ 	#FFF0F0F0��6^    . $ 1��6�      WpfControls.UI.Button  5   
   -   5          Name$ butSave��5         WpfControls.UI.Button   Click$ butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��	0,0,10,10q�6s      Text$ _Save��6�   6�   5      5      