   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  "    OpenDental.FrmEFormLabelEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��845��$	��710��   OpenDental.FrmODBase    Text$  
Edit Label��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.ToolBar  -     Name$ toolBarMain��$��25��$	��627��   WpfControls.UI.Button  -     Name$ 	butDelete��   WpfControls.UI.Button   Click$ butDelete_Click��$��84��$��Bottom=�$��24��$��	13,0,0,12q�   Text$ Delete��   Icon$ DeleteX=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,14,12q�$ _Save��   WpfControls.UI.CheckBox  -     Name$ checkIsHorizStacking��$��20��$��
55,415,0,0q�$	��130��   Text$ Horizontal Stacking��	   
CheckAlign$	 MiddleRight=�   WpfControls.UI.Label  -   
  Name$
 labelStackable��$��18��$��190,416,0,0q�   Text$$ compared to the previous field��   VAlign$ Center=�$	��193��  $��98��$��18��$��
73,441,0,0q�$ Width��   HAlign$ Right=�$ Center=�  $��18��$��229,441,0,0q�$  leave blank for full width��$ Center=�$	��193��   WpfControls.UI.TextVInt  -     Name$ textVIntWidth��$��54��$��20��$��172,440,0,0q�   ShowZero .     WpfControls.UI.ListBox  -     Name$ listBoxFields��$	��198��$��637,26,0,48q�$��Stretch=�  $��57��$��484,415,0,0q�$O IClick on the list to the right to insert a Field into the main text above��$	��147��$ Right=�	   WpfControls.UI.GroupBox	  $��80��$��
13,568,0,0q�$	��470�� 	  Text$0 *Conditional Logic. This field will show...��.@�  $	��128��$��18��$��	30,27,0,0q�$ ... if the parent field��$ Right=�$ Center=�
   WpfControls.UI.TextBox
  -    
 Name$ textCondParent��$	��213��$��20��$��
159,25,0,0q�  $	��143��$��18��$��	15,51,0,0q�$! ... has the following value��$ Right=�$ Center=�
  -	   $ textCondValue��$	��213��$��20��$��
159,50,0,0q�  -
   $ butPickParent��$ butPickParent_Click��$��66��$��24��$��
379,22,0,0q�$
 Pick��  -   $ butPickValue��$ butPickValue_Click��$��66��$��24��$��
379,48,0,0q�$
 Pick��
  -   $ textSpaceBelow��$��54��$��20��$��172,540,0,0q�  $��98��$��18��$��
73,540,0,0q�$ Space Below��$ Right=�$ Center=�  -   $
 labelSpaceDefault��$��18��$��229,540,0,0q�$- 'leave blank to use the default value of��$ Center=�$	��264��  -   $ checkIsWidthPercentage��$��20��$��
26,465,0,0q�$	��159��$ Width Is Percentage��$	 MiddleRight=�  -   $ 
 labelWidthIsPercentageNote��$��18��$��190,466,0,0q�$6 0this applies to all fields in a horizontal stack��$ Center=�$	��266��  -   $
 labelMinWidth��$	��120��$��18��$��
51,490,0,0q�$ Minimum Width��$ Right=�$ Center=�  -   $ textVIntMinWidth��$��54��$��20��$��172,490,0,0q� .    -   $ checkBorder��$��20��$��
26,515,0,0q�$	��159��$ Show Border Box��$	 MiddleRight=�	  -    	 Name$ groupLanguage��$	��209��$��0,26,0,0q�$	��627��$ Language Translation��.@�
  -   $ textLanguage��$	��163��$��20��$��
114,17,0,0q� 
  ReadOnly .  
  	ColorBack$ 	#FFF0F0F0��  -   $
 labelLanguage��$��98��$��18��$��	15,17,0,0q�$ Language��$ Right=�$ Center=�   WpfControls.UI.TextRich  -     Name$ textLabelTranslated��$	��165��$��5,40,0,0q�   FormattedTextAllowed .    SpellCheckIsEnabled .  $	��617��  -   $ 	textLabel��$	��165��$��	0,240,0,0q� .  .  $	��627��