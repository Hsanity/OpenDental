   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI      OpenDental.FrmChildEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��400��$	��324��   OpenDental.FrmODBase    Text$  
Edit Child��   MinMaxBoxes .  .��� ���	#FFFCFDFE$��0,0,0,0q�.+�   WpfControls.UI.Label  -     Name$ labelLastName��$��92��$��18��$��	18,42,0,0q�   Text$ 	Last Name��   HAlign$ Right=�  -   $ labelBirthdate��$��77��$��18��$��	33,66,0,0q�$ 	Birthdate��$ Right=�  -   $ labelFirstName��$��95��$��18��$��	15,18,0,0q�$ 
First Name��$ Right=�   WpfControls.UI.TextBox  -     Name$ textLastName��$	��127��$��20��$��
110,41,0,0q�   
TabIndexOD$ 1��   WpfControls.UI.TextVDate  -     Name$ textBirthdate��$��97��$��20��$��
110,65,0,0q�   
TabIndexOD$ 2��  -   $ textFirstName��$	��127��$��20��$��
110,17,0,0q�$ 0��   WpfControls.UI.Button  -   	  Name$	 butSave��   WpfControls.UI.Button
   Click$
 butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,10,10q�   Text$ _Save��  -   $ 
labelNotes��$��77��$��18��$��
33,210,0,0q�$ Notes��$ Right=�   WpfControls.UI.TextRich  -	     Name$ 	textNotes��$	��180��$��110,210,0,0q�$��58��   
TabIndexOD$ 4��  -
   $ labelPrimaryRoom��$	��100��$��18��$��
10,143,0,0q�$ Primary Room��$ Right=�  -   $ textPrimaryRoom��$	��127��$��20��$��110,142,0,0q�$	 100��   ReadOnly .    	ColorBack$ 	#FFF0F0F0��  -   $ labelAuthorized��$��95��$��35��$��	15,90,0,0q�$ Authorized for Pickup��$ Right=�   WpfControls.UI.ListBox  -     Name$ listAuthorized��$��
110,90,0,0q�$��47��$	��127��  -   $	 butAdd��$
 butAdd_Click��$��242,101,0,0q�$	 Add��$��54��$��24��  -   $	 butRoomSelect��$
 butRoomSelect_Click��$��242,140,0,0q�$ Select��$��54��$��24��  -   $ labelBadgeId��$��92��$��18��$��
18,168,0,0q�$ Badge ID��$ Right=�  -   $ textBadgeId��$��60��$��20��$��110,167,0,0q�$ 3��	   WpfControls.UI.CheckBox	  -    	 Name$ checkHidden��$��
39,188,0,0q� 	  
CheckAlign$ MiddleRight=� 	  Text$ Hidden��$��85��$��20��