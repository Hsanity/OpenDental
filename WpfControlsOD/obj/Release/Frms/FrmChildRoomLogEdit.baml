   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  $    OpenDental.FrmChildRoomLogEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��462��$	��367��   OpenDental.FrmODBase    Text$  Edit Classroom Log��   MinMaxBoxes .  .��� ���	#FFFCFDFE$��0,0,0,0q�.+�   WpfControls.UI.Label  -     Name$ labelDateDisplayed��$	��131��$��18��$��	38,52,0,0q�   Text$ Date Time Displayed��   HAlign$ Right=�  -   $ labelDateEntered��$	��131��$��18��$��	38,28,0,0q�$ Date Time Entered��$ Right=�   WpfControls.UI.TextBox  -     Name$ textDateTDisplayed��$	��132��$��20��$��
169,51,0,0q�   
TabIndexOD$ 1��  -   $ textDateTEntered��$	��132��$��20��$��
169,27,0,0q�$ 0��   ReadOnly .    	ColorBack$ 	#FFF0F0F0��   WpfControls.UI.Button  -   	  Name$	 butSave��   WpfControls.UI.Button
   Click$
 butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,10,10q�   Text$ _Save��  -   $ labelChildRoom��$	��131��$��18��$��	38,77,0,0q�$ Going to Classroom��$ Right=�  -   $	 	butDelete��$
 butDelete_Click��$��Bottom=�$��24��$��	10,0,0,10q�$ _Delete��   Icon$ DeleteX=�$��75��   WpfControls.UI.ComboBox  -     Name$ comboChildRoom��$��
169,76,0,0q�$��20��$	��115�� J� RenderTransformOrigin$ 
0.448,0.55&�   WpfControls.UI.GroupBox  $��	0,110,0,0q�$��89��$	��304��   Text$ Child or Teacher Change��$��Center=�.@�  -	   $ 
labelChild��$��59��$��18��$��	31,24,0,0q�$ Child��$ Right=�  -
   $ 	textChild��$��98��$��20��$��	90,23,0,0q�$ 2�� . $ 	#FFF0F0F0��  -   $ labelEmployee��$��77��$��18��$��	13,49,0,0q�$ Teacher��$ Right=�  -   $ textEmployee��$��98��$��20��$ 2�� . $ 	#FFF0F0F0��$��	90,48,0,0q�  -   $	 butChildSelect��$
 butChildSelect_Click��$��
192,21,0,0q�$	 ...��$��25��$��24��  -   $	 butEmployeeSelect��$
 butEmployeeSelect_Click��$��
192,46,0,0q�$	 ...��$��25��$��24��  -   $	 butEmployeeClear��$
 butEmployeeClear_Click��$��
222,46,0,0q�$ Clear��$��36��$��24��$ 0.693,0.556&�  -   $	 butChildClear��$
 butChildClear_Click��$��
222,21,0,0q�$ Clear��$��36��$��24��$ 0.693,0.556&�  $��	0,230,0,0q�$��77��$	��306��$ Ratio Change��$��Center=�.@�  -   $ 
labelRatio��$��85��$��18��$��5,24,0,0q�$ Ratio Change��$ Right=�   VAlign$ Center=�  -   $ 	textRatio��$��40��$��20��$��	90,23,0,0q�$ 1��   WpfControls.UI.CheckBox  -     Name$ checkMixedRatio��$��6,48,0,0q�$��20��$��96��   
CheckAlign$ MiddleRight=�   Text$ Mixed Ratio��  -   $ labelChildRoom_Copy��$��48��$��18��$��
79,206,0,0q�$ or��