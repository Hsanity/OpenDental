   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI      OpenDental.FrmQuickPaste   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��986��$	��677��   OpenDental.FrmODBase    Text$  Quick Paste Notes��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.Grid  -     Name$ gridMain��$��Stretch=�$��Stretch=�$��184,28,12,48q�   Title$ Notes��   TranslationName$ 
TableNotes��   WpfControls.UI.Button  -     Name$ butDate��   WpfControls.UI.Button   Click$ butDate_Click��$��Right=�$��75��$��Bottom=�$��26��$��
0,0,174,10q�   Text$
 Date��  -   $ butEditNote��$ butEditNote_Click��$��79��$��Bottom=�$��26��$��
269,0,0,10q�$
 Edit��   BitmapFileName$ editPencil.gif��  -   $ 
butAddNote��$ butAddNote_Click��$��79��$��Bottom=�$��26��$��
184,0,0,10q�$	 Add��	   Icon$		 Add=�  -   $ butDownNote��$ butDownNote_Click��$��79��$��Bottom=�$��26��$��
439,0,0,10q�$
 Down��$ down.gif��  -   $ 	butUpNote��$ butUpNote_Click��$��79��$��Bottom=�$��26��$��
354,0,0,10q�$ Up��$ up.gif��  -   $ butDeleteCat��$ butDeleteCat_Click��$��79��$��26��$��	8,386,0,0q�$ Delete��$	 DeleteX=�  -   $ 	butAddCat��$ butAddCat_Click��$��79��$��26��$��	8,351,0,0q�$	 Add��$		 Add=�  -	   $ 
butDownCat��$ butDownCat_Click��$��79��$��26��$��
98,386,0,0q�$
 Down��$ down.gif��  -
   $ butUpCat��$ butUpCat_Click��$��79��$��26��$��
98,351,0,0q�$ Up��$ up.gif��   WpfControls.UI.Label  -   
  Name$
 label2��$	��100��$��19��$��	181,5,0,0q�   Text$
 Note��   VAlign$ Bottom=�  -   $
 label1��$	��100��$��19��$��6,7,0,0q�$ Category��$ Bottom=�  $	��167��$��36��$��	4,424,0,0q�$. (Categories are saved as changes are made��   WpfControls.UI.ListBox  -     Name$ listCat��$	��169��$	��316��$��8,28,0,0q�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��26��$��	0,0,12,10q�$ _Save��   WpfControls.UI.GroupBox  -     Name$ 	groupBox1��$	��207��$��Bottom=�$��39��$��	524,0,0,4q�   Text$   ��.@�    WpfControls.UI.RadioButton  -     Name$ radioSortByNote��$��85��$��17��$��	88,19,0,0q�   Text$
 Note��   
CheckAlign$ 
MiddleLeft=�  -   $ radioSortByAbbrev��$	��113��$��17��$��88,2,0,0q�$ Abbreviation��$ 
MiddleLeft=�   Checked .   -   $ butAlphabetize��$ butAlphabetize_Click��$��75��$��26��$��6,6,0,0q�$ Alphabetize��