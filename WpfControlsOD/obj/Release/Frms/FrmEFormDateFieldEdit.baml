   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  &     OpenDental.FrmEFormDateFieldEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��614��$	��550��   OpenDental.FrmODBase    Text$  Edit Date Field��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.Button  -     Name$ 	butDelete��   WpfControls.UI.Button   Click$ butDelete_Click��$��84��$��Bottom=�$��24��$��	28,0,0,18q�   Text$ Delete��   Icon$ DeleteX=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,28,18q�$ _Save��   WpfControls.UI.ComboBox  -     Name$ comboDbLink��$	��214��$��20��$��187,126,0,0q�   WpfControls.UI.Label  $��98��$��18��$��
86,126,0,0q�   Text$ Db Link��   HAlign$ Right=�	   VAlign$	 Center=�  $��18��$��404,128,0,0q�$&  Used to link to a database field��$	 Center=�$	��193��  $��98��$��18��$��	86,98,0,0q�$ Label��$ Right=�$	 Center=�  $��18��$��
404,98,0,0q�$# This shows above the text box��$	 Center=�$	��193��   WpfControls.UI.TextBox  -   
  Name$
 	textLabel��$	��214��$��20��$��
187,98,0,0q�   WpfControls.UI.CheckBox  -     Name$ checkIsHorizStacking��$��20��$��
70,153,0,0q�$	��130��   Text$ Horizontal Stacking��   
CheckAlign$ MiddleRight=�  -     Name$ labelStackable��$��18��$��206,154,0,0q�$$ compared to the previous field��$	 Center=�$	��193��  $��98��$��18��$��
88,199,0,0q�$ Width��$ Right=�$	 Center=�  $��18��$��245,199,0,0q�$  leave blank for full width��$	 Center=�$	��157��   WpfControls.UI.TextVInt  -     Name$ textVIntWidth��$��54��$��20��$��187,199,0,0q�   ShowZero .    $��98��$��18��$��
88,296,0,0q�$ 
Font Scale��$ Right=�$	 Center=�  $��18��$��245,296,0,0q�$ default is 100��$	 Center=�$	��228��  -   $ textVIntFontScale��$��54��$��20��$��187,295,0,0q�   MaxVal$	 300��   MinVal$ 50��  -	   $ checkIsRequired��$��20��$��
70,176,0,0q�$	��130��$ Required��$ MiddleRight=�	   WpfControls.UI.GroupBox	  $��80��$��
28,380,0,0q�$	��470�� 	  Text$0 *Conditional Logic. This field will show...��.@�  $	��128��$��18��$��	30,27,0,0q�$ ... if the parent field��$ Right=�$	 Center=�  -
   $
 textCondParent��$	��213��$��20��$��
159,25,0,0q�  $	��143��$��18��$��	15,51,0,0q�$! ... has the following value��$ Right=�$	 Center=�  -   $
 textCondValue��$	��213��$��20��$��
159,50,0,0q�  -   $ butPickParent��$ butPickParent_Click��$��66��$��24��$��
379,22,0,0q�$
 Pick��  -   $ butPickValue��$ butPickValue_Click��$��66��$��24��$��
379,48,0,0q�$
 Pick��  -   $
 textSpaceBelow��$��54��$��20��$��187,323,0,0q�  $��98��$��18��$��
88,323,0,0q�$ Space Below��$ Right=�$	 Center=�  -   $ labelSpaceDefault��$��18��$��245,323,0,0q�$- 'leave blank to use the default value of��$	 Center=�$	��264��  $	��130��$��18��$��
56,350,0,0q�$ Reportable Name��$ Right=�$	 Center=�  -   $
 textReportableName��$	��107��$��20��$��187,350,0,0q�  $	��344��$��18��$��
18,469,0,0q�$E ?This field is the conditional parent for this many child fields��$ Right=�$	 Center=�  -   $
 textCountChildren��$��20��$��365,469,0,0q�   ReadOnly .    	ColorBack$ 	#FFF0F0F0��$��30��  -   $ checkIsWidthPercentage��$��20��$��
41,222,0,0q�$	��159��$ Width Is Percentage��$ MiddleRight=�  -   $  labelWidthIsPercentageNote��$��18��$��205,223,0,0q�$6 0this applies to all fields in a horizontal stack��$	 Center=�$	��266��  -   $ labelMinWidth��$	��120��$��18��$��
66,247,0,0q�$ Minimum Width��$ Right=�$	 Center=�  -   $ textVIntMinWidth��$��54��$��20��$��187,247,0,0q� .    -   $ checkBorder��$��20��$��
41,272,0,0q�$	��159��$ Show Border Box��$ MiddleRight=�	  -    	 Name$ groupLanguage��$��72��$��	73,20,0,0q�$	��470��$ Language Translation��.@�  $��76��$��18��$��	37,47,0,0q�$ Label��$ Right=�$	 Center=�  -   $
 textLabelTranslated��$	��213��$��20��$��
114,45,0,0q�  -   $
 textLanguage��$	��163��$��20��$��
114,20,0,0q� . $ 	#FFF0F0F0��  -   $ labelLanguage��$��98��$��18��$��	15,20,0,0q�$ Language��$ Right=�$	 Center=�