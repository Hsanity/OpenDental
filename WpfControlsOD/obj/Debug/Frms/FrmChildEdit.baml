   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmChildEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��400��5	      $	��324��6      OpenDental.FrmODBase    Text$  
Edit Child��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE$��0,0,0,0q�6   .+�5         WpfControls.UI.Label  -   5          Name$ labelLastName��5      $��92��6$   $��18��6/   $��	18,42,0,0q�6;      Text$ 	Last Name��6N      HAlign$ Right=�6_     5      -   5        $ labelBirthdate��5      $��77��6%   $��18��60   $��	33,66,0,0q�6<   $ 	Birthdate��6O   $ Right=�6`     5      -   5        $ labelFirstName��5      $��95��6%   $��18��60   $��	15,18,0,0q�6<   $ 
First Name��6O   $ Right=�6a      WpfControls.UI.TextBox  5      -   5          Name$ textLastName��5      $	��127��6%   $��20��61   $��
110,41,0,0q�6=      
TabIndexOD$ 1��6Q      WpfControls.UI.TextVDate  5      -   5          Name$ textBirthdate��5      $��97��6(   $��20��63   $��
110,65,0,0q�6?      
TabIndexOD$ 2��6S     5      -   5        $ textFirstName��5      $	��127��6&   $��20��62   $��
110,17,0,0q�6>   $ 0��6R      WpfControls.UI.Button  5      -   5        	  Name$	 butSave��5         WpfControls.UI.Button
   Click$
 butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��24��6a   $��	0,0,10,10q�6m      Text$ _Save��6�   6�     5      -   5        $ 
labelNotes��5      $��77��6!   $��18��6,   $��
33,210,0,0q�68   $ Notes��6L   $ Right=�6Y      WpfControls.UI.TextRich  5      -	   5          Name$ 	textNotes��5      $	��180��6#   $��110,210,0,0q�6/   $��58��6D      
TabIndexOD$ 4��6P     5      -
   5        $ labelPrimaryRoom��5      $	��100��6'   $��18��63   $��
10,143,0,0q�6?   $ Primary Room��6S   $ Right=�6g     5      -   5        $ textPrimaryRoom��5      $	��127��6(   $��20��64   $��110,142,0,0q�6@   $	 100��6U      ReadOnly .    	ColorBack$ 	#FFF0F0F0��6v     5      -   5        $ labelAuthorized��5      $��95��6&   $��35��61   $��	15,90,0,0q�6=   $ Authorized for Pickup��6P   $ Right=�6m      WpfControls.UI.ListBox  5      -   5          Name$ listAuthorized��5      $��
110,90,0,0q�6'   $��47��6;   $	��127��6G     5      -   5        $	 butAdd��5      $
 butAdd_Click��6>   $��242,101,0,0q�6   $	 Add��63   $��54��6S   $��24��6^     5      -   5        $	 butRoomSelect��5      $
 butRoomSelect_Click��6H   $��242,140,0,0q�6%   $ Select��6:   $��54��6d   $��24��6o     5      -   5        $ labelBadgeId��5      $��92��6#   $��18��6.   $��
18,168,0,0q�6:   $ Badge ID��6N   $ Right=�6^     5      -   5        $ textBadgeId��5      $��60��6$   $��20��6/   $��110,167,0,0q�6;   $ 3��6P   	   WpfControls.UI.CheckBox	  5      -   5         	 Name$ checkHidden��5      $��
39,188,0,0q�6%    	  
CheckAlign$ MiddleRight=�69    	  Text$ Hidden��6R   $��85��6`   $��20��6k   5      5      