   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  )    #OpenDental.FrmEFormRadioButtonsEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $
��1030��$	��670��   OpenDental.FrmODBase    Text$  Edit RadioButton Group��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.Button  -     Name$ 	butDelete��   WpfControls.UI.Button   Click$ butDelete_Click��$��84��$��Bottom=�$��24��$��	22,0,0,18q�   Text$ Delete��   Icon$ DeleteX=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,28,18q�$ _Save��   WpfControls.UI.ComboBox  -     Name$ comboDbLink��   WpfControls.UI.ComboBox   SelectionChangeCommitted$* $comboDbLink_SelectionChangeCommitted��$	��213��$��21��$��180,209,0,0q�   WpfControls.UI.Label  $��98��$��18��$��
79,210,0,0q�   Text$ Db Link��	   HAlign$	 Right=�
   VAlign$
 Center=�  $	��351��$��18��$��397,211,0,0q�$E ?Used when this radio button group is linked to a database field��$
 Center=�  $��98��$��18��$��	79,99,0,0q�$ Label��$	 Right=�$
 Center=�  $	��351��$��18��$��
397,99,0,0q�$1 +This shows above the group of radio buttons��$
 Center=�   WpfControls.UI.TextBox  -     Name$ 	textLabel��$	��213��$��20��$��
180,98,0,0q�   WpfControls.UI.Grid  -     Name$ gridMain��$��557,267,0,0q�   SelectionMode$ OneCell=�$	��445��   TitleVisible .  $	��286��   Title$ 	Pick List��   TranslationName$ TableEFormRadioButton��  -   $ butDeleteRow��$ butDeleteRow_Click��$��96��$��24��$��557,559,0,0q�$ 
Delete Row��$ DeleteX=�  -   $ 	butAddRow��$ butAddRow_Click��$��84��$��24��$��661,559,0,0q�$ Add Row��$	 Add=�  -   $ butUp��$ butUp_Click��$��68��$��24��$��753,559,0,0q�$ Up��  -	   $ butDown��$ butDown_Click��$��79��$��24��$��829,559,0,0q�$
 Down��  -
   $ butHelp��$ butHelp_Click��$��89��$��24��$��913,236,0,0q�$ Advanced Help��  $��98��$��18��$��
81,281,0,0q�$ 
Font Scale��$	 Right=�$
 Center=�  $��18��$��238,281,0,0q�$ default is 100��$
 Center=�$	��228��	   WpfControls.UI.TextVInt	  -    	 Name$ textVIntFontScale��$��54��$��20��$��180,281,0,0q� 	  MaxVal$	 300�� 	  MinVal$ 50��
   WpfControls.UI.CheckBox
  -    
 Name$ checkIsRequired��$��20��$��
79,258,0,0q�$	��114�� 
  Text$ Required�� 
  
CheckAlign$ MiddleRight=�   WpfControls.UI.GroupBox  $��80��$��
53,376,0,0q�$	��470��   Text$0 *Conditional Logic. This field will show...��.@�  $	��128��$��18��$��	30,27,0,0q�$ ... if the parent field��$	 Right=�$
 Center=�  -   $ textCondParent��$	��213��$��20��$��
159,25,0,0q�  $	��143��$��18��$��	15,51,0,0q�$! ... has the following value��$	 Right=�$
 Center=�  -   $ textCondValue��$	��213��$��20��$��
159,50,0,0q�  -   $ butPickParent��$ butPickParent_Click��$��66��$��24��$��
379,22,0,0q�$
 Pick��  -   $ butPickValue��$ butPickValue_Click��$��66��$��24��$��
379,48,0,0q�$
 Pick��  $	��359��$��18��$��
33,468,0,0q�$E ?This field is the conditional parent for this many child fields��$	 Right=�$
 Center=�  -   $ textCountChildren��$��30��$��20��$��395,467,0,0q�   ReadOnly .    	ColorBack$ 	#FFF0F0F0��  -     Name$ labelAllergProb��$��98��$��18��$��
81,235,0,0q�$ LabelAllergProb��$	 Right=�$
 Center=�  -   $ textMedAllerProb��$	��213��$��20��$��180,235,0,0q�   
TabIndexOD$ 1��  -   $ 	butChange��$ butChange_Click��$��75��$��24��$��400,234,0,0q�$ Change��
  -   $ checkLabelLeft��$��20��$��
79,119,0,0q�$	��114��$ Label at Left��$ MiddleRight=�  -   $ 
labelWidth��$��98��$��18��$��
81,163,0,0q�$ Width��$	 Right=�$
 Center=�  -   $ labelWidthComment��$��18��$��238,163,0,0q�$ only applies to label��$
 Center=�$	��193��	  -   $ textVIntWidth��$��54��$��20��$��180,163,0,0q� 	  ShowZero .    -   $ textSpaceBelow��$��54��$��20��$��180,306,0,0q�  $��98��$��18��$��
81,306,0,0q�$ Space Below��$	 Right=�$
 Center=�  -   $ labelSpaceDefault��$��18��$��238,306,0,0q�$- 'leave blank to use the default value of��$
 Center=�$	��265��  $	��130��$��18��$��
49,331,0,0q�$ Reportable Name��$	 Right=�$
 Center=�  -   $ textReportableName��$	��107��$��20��$��180,331,0,0q�
  -   $ checkLabelRight��$��20��$��
79,139,0,0q�$	��114��$ Label at Right��$ MiddleRight=�  -   $! labelCheckLabelRightComment��$��18��$��198,140,0,0q�$2 ,only useful when radiobuttons have no labels��$
 Center=�$	��292��
  -   $ checkBorder��$��20��$��
34,186,0,0q�$	��159��$ Show Border Box��$ MiddleRight=�  -     Name$ groupLanguage��$��72��$��	66,20,0,0q�$	��470��$ Language Translation��.@�  $��76��$��18��$��	37,47,0,0q�$ Label��$	 Right=�$
 Center=�  -    $ textLabelTranslated��$	��213��$��20��$��
114,45,0,0q�  -!   $ textLanguage��$	��163��$��20��$��
114,20,0,0q� . $ 	#FFF0F0F0��  -"   $ labelLanguage��$��98��$��18��$��	15,20,0,0q�$ Language��$	 Right=�$
 Center=�