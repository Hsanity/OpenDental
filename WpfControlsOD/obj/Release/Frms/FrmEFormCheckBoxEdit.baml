   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  %    OpenDental.FrmEFormCheckBoxEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��615��$	��610��   OpenDental.FrmODBase    Text$  Edit CheckBox��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.Button  -     Name$ 	butDelete��   WpfControls.UI.Button   Click$ butDelete_Click��$��84��$��Bottom=�$��24��$��	28,0,0,18q�   Text$ Delete��   Icon$ DeleteX=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,28,18q�$ _Save��   WpfControls.UI.ComboBox  -     Name$ comboDbLink��$	��213��$��20��$��182,126,0,0q�   WpfControls.UI.Label  $��98��$��18��$��
83,126,0,0q�   Text$ Db Link��   HAlign$ Right=�	   VAlign$	 Center=�  $��18��$��399,128,0,0q�$&  Used to link to a database field��$	 Center=�$	��211��  $��98��$��18��$��	83,98,0,0q�$ Label��$ Right=�$	 Center=�  $��18��$��
399,98,0,0q�$+ %Displays to the right of the checkbox��$	 Center=�$	��211��   WpfControls.UI.TextBox  -   
  Name$
 	textLabel��$	��213��$��20��$��
182,98,0,0q�   
TabIndexOD$ 1��   WpfControls.UI.CheckBox  -     Name$ checkIsHorizStacking��$��20��$��
65,180,0,0q�$	��130��   Text$ Horizontal Stacking��   
CheckAlign$ MiddleRight=�  -     Name$ labelStackable��$��18��$��201,181,0,0q�$$ compared to the previous field��$	 Center=�$	��193��  -   $ labelAllergProb��$��98��$��18��$��
83,154,0,0q�$ LabelAllergProb��$ Right=�$	 Center=�  -   $
 textMedAllerProb��$	��213��$��20��$��182,154,0,0q�$ 1��  -	   $ 	butChange��$ butChange_Click��$��75��$��24��$��402,153,0,0q�$ Change��  $��98��$��18��$��
83,328,0,0q�$ 
Font Scale��$ Right=�$	 Center=�  $��18��$��240,328,0,0q�$ default is 100��$	 Center=�$	��228��   WpfControls.UI.TextVInt  -
     Name$ textVIntFontScale��$��54��$��20��$��182,328,0,0q�   MaxVal$	 300��   MinVal$ 50��  -   $ checkIsRequired��$��20��$��
65,203,0,0q�$	��130��$ Required��$ MiddleRight=�	   WpfControls.UI.GroupBox	  $��80��$��
23,444,0,0q�$	��470�� 	  Text$0 *Conditional Logic. This field will show...��.@�  $	��128��$��18��$��	30,27,0,0q�$ ... if the parent field��$ Right=�$	 Center=�  -   $
 textCondParent��$	��213��$��20��$��
159,25,0,0q�  $	��143��$��18��$��	15,51,0,0q�$! ... has the following value��$ Right=�$	 Center=�  -   $
 textCondValue��$��20��$��
159,50,0,0q�$	��213��  -   $ butPickParent��$ butPickParent_Click��$��66��$��24��$��
379,22,0,0q�$
 Pick��  -   $ butPickValue��$ butPickValue_Click��$��66��$��24��$��
379,48,0,0q�$
 Pick��  $	��344��$��18��$��
18,533,0,0q�$E ?This field is the conditional parent for this many child fields��$ Right=�$	 Center=�  -   $
 textCountChildren��$��20��$��365,533,0,0q�   ReadOnly .    	ColorBack$ 	#FFF0F0F0��$��30��  -   $
 textSpaceBelow��$��54��$��20��$��182,356,0,0q�  $��98��$��18��$��
83,356,0,0q�$ Space Below��$ Right=�$	 Center=�  -   $ labelSpaceDefault��$��18��$��240,356,0,0q�$- 'leave blank to use the default value of��$	 Center=�$	��264��  $	��130��$��18��$��
51,384,0,0q�$ Reportable Name��$ Right=�$	 Center=�  -   $
 textReportableName��$	��107��$��20��$��182,384,0,0q�  -   $ checkIsLocked��$��20��$��
65,410,0,0q�$	��130��$ Locked��$ MiddleRight=�  $��98��$��18��$��
83,228,0,0q�$ Width��$ Right=�$	 Center=�  $��18��$��240,228,0,0q�$  leave blank for full width��$	 Center=�$	��193��  -   $ textVIntWidth��$��54��$��20��$��182,228,0,0q�   ShowZero .    -   $ checkIsWidthPercentage��$��20��$��
36,253,0,0q�$	��159��$ Width Is Percentage��$ MiddleRight=�  -   $  labelWidthIsPercentageNote��$��18��$��200,254,0,0q�$6 0this applies to all fields in a horizontal stack��$	 Center=�$	��266��  -   $ labelMinWidth��$	��120��$��18��$��
61,278,0,0q�$ Minimum Width��$ Right=�$	 Center=�  -   $ textVIntMinWidth��$��54��$��20��$��182,278,0,0q� .    -   $ checkBorder��$��20��$��
36,303,0,0q�$	��159��$ Show Border Box��$ MiddleRight=�	  -    	 Name$ groupLanguage��$��72��$��	68,20,0,0q�$	��470��$ Language Translation��.@�  $��76��$��18��$��	37,47,0,0q�$ Label��$ Right=�$	 Center=�  -   $
 textLabelTranslated��$	��213��$��20��$��
114,45,0,0q�  -   $
 textLanguage��$	��163��$��20��$��
114,20,0,0q� . $ 	#FFF0F0F0��  -   $ labelLanguage��$��98��$��18��$��	15,20,0,0q�$ Language��$ Right=�$	 Center=�