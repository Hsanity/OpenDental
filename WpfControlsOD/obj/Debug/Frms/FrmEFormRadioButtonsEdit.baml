   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      )    #OpenDental.FrmEFormRadioButtonsEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $
��1030��5	      $	��670��6      OpenDental.FrmODBase    Text$  Edit RadioButton Group��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5         WpfControls.UI.Button  -   5          Name$ 	butDelete��5         WpfControls.UI.Button   Click$ butDelete_Click��6�   $��84��6!   $��Bottom=�6,   $��24��6G   $��	22,0,0,18q�6S      Text$ Delete��6f      Icon$ DeleteX=�6t   6�     5      -   5        $ butSave��5      $ butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��24��6a   $��	0,0,28,18q�6m   $ _Save��6�   6�      WpfControls.UI.ComboBox  5      -   5          Name$ comboDbLink��5         WpfControls.UI.ComboBox   SelectionChangeCommitted$* $comboDbLink_SelectionChangeCommitted��6R   $	��213��6%   $��21��61   $��180,209,0,0q�6=   6R      WpfControls.UI.Label  5      $��98��6   $��18��6   $��
79,210,0,0q�6$      Text$ Db Link��68   	   HAlign$	 Right=�6G   
   VAlign$
 Center=�6V     5      $	��351��6   $��18��6   $��397,211,0,0q�6%   $E ?Used when this radio button group is linked to a database field��6:   $
 Center=�6�     5      $��98��6   $��18��6   $��	79,99,0,0q�6$   $ Label��67   $	 Right=�6D   $
 Center=�6S     5      $	��351��6   $��18��6   $��
397,99,0,0q�6%   $1 +This shows above the group of radio buttons��69   $
 Center=�6l      WpfControls.UI.TextBox  5      -   5          Name$ 	textLabel��5      $	��213��6"   $��20��6.   $��
180,98,0,0q�6:      WpfControls.UI.Grid  5      -   5          Name$ gridMain��5      $��557,267,0,0q�6      SelectionMode$ OneCell=�63   $	��445��6K      TitleVisible .  $	��286��6l      Title$ 	Pick List��6y      TranslationName$ TableEFormRadioButton��6�     5      -   5        $ butDeleteRow��5      $ butDeleteRow_Click��6q   $��96��6$   $��24��6/   $��557,559,0,0q�6;   $ 
Delete Row��6P   $ DeleteX=�6b   6q     5      -   5        $ 	butAddRow��5      $ butAddRow_Click��6g   $��84��6!   $��24��6,   $��661,559,0,0q�68   $ Add Row��6M   $	 Add=�6\   6g     5      -   5        $ butUp��5      $ butUp_Click��6S   $��68��6   $��24��6(   $��753,559,0,0q�64   $ Up��6I   6S     5      -	   5        $ butDown��5      $ butDown_Click��6W   $��79��6   $��24��6*   $��829,559,0,0q�66   $
 Down��6K   6W     5      -
   5        $ butHelp��5      $ butHelp_Click��6`   $��89��6   $��24��6*   $��913,236,0,0q�66   $ Advanced Help��6K   6`     5      $��98��6   $��18��6   $��
81,281,0,0q�6$   $ 
Font Scale��68   $	 Right=�6J   $
 Center=�6Y     5      $��18��6   $��238,281,0,0q�6   $ default is 100��6.   $
 Center=�6D   $	��228��6T   	   WpfControls.UI.TextVInt	  5      -   5         	 Name$ textVIntFontScale��5      $��54��6+   $��20��66   $��180,281,0,0q�6B    	  MaxVal$	 300��6W    	  MinVal$ 50��6d   
   WpfControls.UI.CheckBox
  5      -   5         
 Name$ checkIsRequired��5      $��20��6)   $��
79,258,0,0q�65   $	��114��6I    
  Text$ Required��6U    
  
CheckAlign$ MiddleRight=�6e      WpfControls.UI.GroupBox  5      $��80��6   $��
53,376,0,0q�6   $	��470��60      Text$0 *Conditional Logic. This field will show...��6<   .@�5        $	��128��6   $��18��6   $��	30,27,0,0q�6&   $ ... if the parent field��69   $	 Right=�6X   $
 Center=�6g     5       -   5        $ textCondParent��5       $	��213��6(   $��20��64   $��
159,25,0,0q�6@     5!      $	��143��6   $��18��6   $��	15,51,0,0q�6&   $! ... has the following value��69   $	 Right=�6\   $
 Center=�6k     5"      -   5        $ textCondValue��5"      $	��213��6'   $��20��63   $��
159,50,0,0q�6?     5#      -   5        $ butPickParent��5#      $ butPickParent_Click��6]   $��66��6&   $��24��61   $��
379,22,0,0q�6=   $
 Pick��6Q   6]     5$      -   5        $ butPickValue��5$      $ butPickValue_Click��6\   $��66��6%   $��24��60   $��
379,48,0,0q�6<   $
 Pick��6P   6\   5%        5&      $	��359��6   $��18��6   $��
33,468,0,0q�6%   $E ?This field is the conditional parent for this many child fields��69   $	 Right=�6�   $
 Center=�6�     5'      -   5        $ textCountChildren��5'      $��30��6*   $��20��65   $��395,467,0,0q�6A      ReadOnly .    	ColorBack$ 	#FFF0F0F0��6f     5(      -   5          Name$ labelAllergProb��5(      $��98��6&   $��18��61   $��
81,235,0,0q�6=   $ LabelAllergProb��6Q   $	 Right=�6h   $
 Center=�6w     5)      -   5        $ textMedAllerProb��5)      $	��213��6)   $��20��65   $��180,235,0,0q�6A      
TabIndexOD$ 1��6V     5*      -   5        $ 	butChange��5*      $ butChange_Click��6[   $��75��6!   $��24��6,   $��400,234,0,0q�68   $ Change��6M   6[   
  5+      -   5        $ checkLabelLeft��5+      $��20��6(   $��
79,119,0,0q�64   $	��114��6H   $ Label at Left��6T   $ MiddleRight=�6i     5,      -   5        $ 
labelWidth��5,      $��98��6!   $��18��6,   $��
81,163,0,0q�68   $ Width��6L   $	 Right=�6Y   $
 Center=�6h     5-      -   5        $ labelWidthComment��5-      $��18��6(   $��238,163,0,0q�64   $ only applies to label��6I   $
 Center=�6f   $	��193��6v   	  5.      -   5        $ textVIntWidth��5.      $��54��6'   $��20��62   $��180,163,0,0q�6>    	  ShowZero .  6S     5/      -   5        $ textSpaceBelow��5/      $��54��6'   $��20��62   $��180,306,0,0q�6>     50      $��98��6   $��18��6   $��
81,306,0,0q�6$   $ Space Below��68   $	 Right=�6K   $
 Center=�6Z     51      -   5        $ labelSpaceDefault��51      $��18��6(   $��238,306,0,0q�64   $- 'leave blank to use the default value of��6I   $
 Center=�6x   $	��265��6�     52      $	��130��6   $��18��6   $��
49,331,0,0q�6%   $ Reportable Name��69   $	 Right=�6P   $
 Center=�6_     53      -   5        $ textReportableName��53      $	��107��6+   $��20��67   $��180,331,0,0q�6C   
  54      -   5        $ checkLabelRight��54      $��20��6)   $��
79,139,0,0q�65   $	��114��6I   $ Label at Right��6U   $ MiddleRight=�6k     55      -   5        $! labelCheckLabelRightComment��55      $��18��62   $��198,140,0,0q�6>   $2 ,only useful when radiobuttons have no labels��6S   $
 Center=�6�   $	��292��6�   
  56      -   5        $ checkBorder��56      $��20��6%   $��
34,186,0,0q�61   $	��159��6E   $ Show Border Box��6Q   $ MiddleRight=�6h     57      -   5          Name$ groupLanguage��57      $��72��6'   $��	66,20,0,0q�63   $	��470��6F   $ Language Translation��6R   .@�58        $��76��6   $��18��6   $��	37,47,0,0q�6%   $ Label��68   $	 Right=�6E   $
 Center=�6T     59      -    5        $ textLabelTranslated��59      $	��213��6-   $��20��69   $��
114,45,0,0q�6E     5:      -!   5        $ textLanguage��5:      $	��163��6&   $��20��62   $��
114,20,0,0q�6>    . $ 	#FFF0F0F0��6b     5;      -"   5        $ labelLanguage��5;      $��98��6%   $��18��60   $��	15,20,0,0q�6<   $ Language��6O   $	 Right=�6_   $
 Center=�6n   5<      5=      5>      