   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  !    OpenDental.FrmChildRoomEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��450��$	��205��   OpenDental.FrmODBase    Text$  Edit Child Room��   MinMaxBoxes .  .��� ���	#FFFCFDFE$��0,0,0,0q�.+�   WpfControls.UI.Label  -     Name$ labelRoomId��$��95��$��18��$��	40,17,0,0q�   Text$ Room ID��   HAlign$ Right=�   VAlign$ Center=�   WpfControls.UI.TextBox  -     Name$ 
textRoomId��$	��113��$��20��$��
135,16,0,0q�   
TabIndexOD$ 0��   WpfControls.UI.Button  -     Name$ butSave��   WpfControls.UI.Button	   Click$	 butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,10,10q�
   Text$
 _Save��  -   $ 
labelNotes��$��77��$��18��$��	58,93,0,0q�$ Notes��$ Right=�$ Center=�   WpfControls.UI.TextRich  -     Name$ 	textNotes��$	��208��$��
135,93,0,0q�$��72��   
TabIndexOD$ 2��  -   $ 
labelRatio��$	��132��$��18��$��3,44,0,0q�$ Child-Teacher Ratio��$ Right=�$ Center=�  -   $ 	textRatio��$��41��$��20��$��
135,43,0,0q�$ 1��  -   $ labelInstructions��$	��231��$��18��$��
181,45,0,0q�$, &Number of children allowed per teacher��$ Center=�   WpfControls.UI.CheckBox  -	     Name$ checkMixedRatio��$��	51,68,0,0q�$��20��$��97��   
CheckAlign$ MiddleRight=�   Text$ Mixed Ratio��