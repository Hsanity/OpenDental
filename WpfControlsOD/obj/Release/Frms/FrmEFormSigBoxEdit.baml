   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  #    OpenDental.FrmEFormSigBoxEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��611��$	��380��   OpenDental.FrmODBase    Text$  Edit Signature Box��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.Button  -     Name$ 	butDelete��   WpfControls.UI.Button   Click$ butDelete_Click��$��84��$��Bottom=�$��24��$��	28,0,0,18q�   Text$ Delete��   Icon$ DeleteX=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,28,18q�$ _Save��   WpfControls.UI.Label  $��98��$��18��$��	86,98,0,0q�   Text$ Label��   HAlign$ Right=�   VAlign$ Center=�  $��18��$��
404,98,0,0q�$( "This shows above the signature box��$ Center=�$	��193��   WpfControls.UI.TextBox  -   	  Name$	 	textLabel��$	��213��$��20��$��
187,98,0,0q�  $��98��$��18��$��
88,173,0,0q�$ 
Font Scale��$ Right=�$ Center=�  $��18��$��245,173,0,0q�$ default is 100��$ Center=�$	��228��   WpfControls.UI.TextVInt  -   
  Name$
 textVIntFontScale��$��54��$��20��$��187,173,0,0q�   MaxVal$	 300��   MinVal$ 50��   WpfControls.UI.CheckBox  -     Name$ checkIsRequired��$��20��$��
86,123,0,0q�$	��114��   Text$ Required��   
CheckAlign$ MiddleRight=�   WpfControls.UI.GroupBox  $��80��$��
28,229,0,0q�$	��470��   Text$0 *Conditional Logic. This field will show...��.@�  $	��128��$��18��$��	30,27,0,0q�$ ... if the parent field��$ Right=�$ Center=�  -   $	 textCondParent��$	��213��$��20��$��
159,25,0,0q�  $	��143��$��18��$��	15,51,0,0q�$! ... has the following value��$ Right=�$ Center=�  -   $	 textCondValue��$	��213��$��20��$��
159,50,0,0q�  -   $ butPickParent��$ butPickParent_Click��$��66��$��24��$��
379,22,0,0q�$
 Pick��  -	   $ butPickValue��$ butPickValue_Click��$��66��$��24��$��
379,48,0,0q�$
 Pick��  -
   $	 textSpaceBelow��$��54��$��20��$��187,201,0,0q�  $��98��$��18��$��
88,201,0,0q�$ Space Below��$ Right=�$ Center=�  -     Name$ labelSpaceDefault��$��18��$��245,201,0,0q�$- 'leave blank to use the default value of��$ Center=�$	��265��  -   $ checkBorder��$��20��$��
41,148,0,0q�$	��159��$ Show Border Box��$ MiddleRight=�  -     Name$ groupLanguage��$��72��$��	73,20,0,0q�$	��470��$ Language Translation��.@�  $��76��$��18��$��	37,47,0,0q�$ Label��$ Right=�$ Center=�  -   $	 textLabelTranslated��$	��213��$��20��$��
114,45,0,0q�  -   $	 textLanguage��$	��163��$��20��$��
114,20,0,0q�   ReadOnly .    	ColorBack$ 	#FFF0F0F0��  -   $ labelLanguage��$��98��$��18��$��	15,20,0,0q�$ Language��$ Right=�$ Center=�