   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmQuickPaste   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��986��5	      $	��677��6      OpenDental.FrmODBase    Text$  Quick Paste Notes��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5         WpfControls.UI.Grid  -   5          Name$ gridMain��5      $��Stretch=�6   $��Stretch=�6<   $��184,28,12,48q�6X      Title$ Notes��6n      TranslationName$ 
TableNotes��6|      WpfControls.UI.Button  5      -   5          Name$ butDate��5         WpfControls.UI.Button   Click$ butDate_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��26��6a   $��
0,0,174,10q�6m      Text$
 Date��6�   6�     5      -   5        $ butEditNote��5      $ butEditNote_Click��6u   $��79��6#   $��Bottom=�6.   $��26��6I   $��
269,0,0,10q�6U   $
 Edit��6i      BitmapFileName$ editPencil.gif��6�     5      -   5        $ 
butAddNote��5      $ butAddNote_Click��6~   $��79��6"   $��Bottom=�6-   $��26��6H   $��
184,0,0,10q�6T   $	 Add��6h   	   Icon$		 Add=�6s   6~     5      -   5        $ butDownNote��5      $ butDownNote_Click��6u   $��79��6#   $��Bottom=�6.   $��26��6I   $��
439,0,0,10q�6U   $
 Down��6i   $ down.gif��6�     5      -   5        $ 	butUpNote��5      $ butUpNote_Click��6q   $��79��6!   $��Bottom=�6,   $��26��6G   $��
354,0,0,10q�6S   $ Up��6g   $ up.gif��6�     5      -   5        $ butDeleteCat��5      $ butDeleteCat_Click��6k   $��79��6$   $��26��6/   $��	8,386,0,0q�6;   $ Delete��6N   $	 DeleteX=�6\   6k     5      -   5        $ 	butAddCat��5      $ butAddCat_Click��6a   $��79��6!   $��26��6,   $��	8,351,0,0q�68   $	 Add��6K   $		 Add=�6V   6a     5      -	   5        $ 
butDownCat��5      $ butDownCat_Click��6Y   $��79��6"   $��26��6-   $��
98,386,0,0q�69   $
 Down��6M   $ down.gif��6r     5      -
   5        $ butUpCat��5      $ butUpCat_Click��6U   $��79��6    $��26��6+   $��
98,351,0,0q�67   $ Up��6K   $ up.gif��6l      WpfControls.UI.Label  5      -   5        
  Name$
 label2��5      $	��100��6   $��19��6)   $��	181,5,0,0q�65      Text$
 Note��6H      VAlign$ Bottom=�6T     5      -   5        $
 label1��5      $	��100��6   $��19��6)   $��6,7,0,0q�65   $ Category��6F   $ Bottom=�6V     5      $	��167��6   $��36��6   $��	4,424,0,0q�6%   $. (Categories are saved as changes are made��68      WpfControls.UI.ListBox  5      -   5          Name$ listCat��5      $	��169��6    $	��316��6,   $��8,28,0,0q�69     5      -   5        $ butSave��5      $ butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��26��6a   $��	0,0,12,10q�6m   $ _Save��6�   6�      WpfControls.UI.GroupBox  5      -   5          Name$ 	groupBox1��5      $	��207��6#   $��Bottom=�6/   $��39��6J   $��	524,0,0,4q�6V      Text$   ��6i   .@�5          WpfControls.UI.RadioButton  -   5          Name$ radioSortByNote��5      $��85��6-   $��17��68   $��	88,19,0,0q�6D      Text$
 Note��6W      
CheckAlign$ 
MiddleLeft=�6c     5      -   5        $ radioSortByAbbrev��5      $	��113��6/   $��17��6;   $��88,2,0,0q�6G   $ Abbreviation��6Y   $ 
MiddleLeft=�6m      Checked . 6�     5      -   5        $ butAlphabetize��5      $ butAlphabetize_Click��6b   $��75��6'   $��26��62   $��6,6,0,0q�6>   $ Alphabetize��6O   6b   5      5       5!      