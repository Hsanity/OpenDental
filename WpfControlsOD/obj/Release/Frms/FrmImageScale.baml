   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI      OpenDental.FrmImageScale   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��339��$	��320��   OpenDental.FrmODBase    Text$  Image Scale��.��� ���	#FFFCFDFE.+�    WpfControls.UI.TextVDouble  -     Name$ 	textScale��$��66��$��20��$��176,214,0,0q�   MinVal$ 1E-06Q�   MaxVal$ 1000000Q�   WpfControls.UI.TextVInt  -     Name$ textDecimals��$��66��$��20��$��176,238,0,0q�   MinVal$ 0��   MaxVal$ 20��   WpfControls.UI.Label  -     Name$ label3��$	��112��$��18��$��
62,240,0,0q�   Text$ Decimal Places��	   HAlign$	 Right=�
   VAlign$
 Center=�  -   $ label5��$	��234��$��35��$��	8,273,0,0q�$U OOnce you establish a scale, you can manually assign it to a mount or mount def.��$	 Center=�$
 Center=�   WpfControls.UI.GroupBox  -     Name$ groupBoxOD1��$	��246��$	��124��$��	65,74,0,0q�   Text$ From clicking on a line��.@�  -   $ label2��$	��230��$��18��$��
13,100,0,0q�$- 'Or you can manually enter a scale below��$	 Center=�$
 Center=�   WpfControls.UI.Button  -     Name$ butCalculate��   WpfControls.UI.Button   Click$ butCalculate_Click��$��75��$��24��$��
106,73,0,0q�   Text$ 	Calculate��   WpfControls.UI.TextBox  -     Name$ textKnownLength��$��66��$��20��$��
111,19,0,0q�   HAlign$ Center=�  -	   $ label4��$��84��$��18��$��	25,46,0,0q�$ Pixels��$	 Right=�$
 Center=�  -
   $ label21��$	��107��$��18��$��2,20,0,0q�$ Known Length��$	 Right=�$
 Center=�  -   $ 
textPixels��$��66��$��20��$��
111,45,0,0q�   	ColorBack$ 	#FFF0F0F0��   ReadOnly . $ Center=�  -   $ 
labelUnits��$��62��$��18��$��
181,20,0,0q�$ mm��$
 Center=�  -   $ 
labelScale��$	��112��$��18��$��
62,214,0,0q�$ Scale, pixels per mm��$	 Right=�$
 Center=�  -   $ label1��$	��120��$��18��$��	54,44,0,0q�$ Optional Units (mm)��$	 Right=�$
 Center=�  -   $ 	textUnits��$��66��$��20��$��
176,43,0,0q�$ Center=�  -   $ labelInstructions��$	��300��$��31��$��8,9,0,0q�$g aIf you don't know your scale, then cancel out of this window and click on a line of known length.��  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,12,12q�$ _Save��