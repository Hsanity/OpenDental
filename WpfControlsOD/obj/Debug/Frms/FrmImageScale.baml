   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmImageScale   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��339��5	      $	��320��6      OpenDental.FrmODBase    Text$  Image Scale��5
      .��5      � ���	#FFFCFDFE.+�5          WpfControls.UI.TextVDouble  -   5          Name$ 	textScale��5      $��66��6&   $��20��61   $��176,214,0,0q�6=      MinVal$ 1E-06Q�6R      MaxVal$ 1000000Q�6a      WpfControls.UI.TextVInt  5      -   5          Name$ textDecimals��5      $��66��6&   $��20��61   $��176,238,0,0q�6=      MinVal$ 0��6R      MaxVal$ 20��6]      WpfControls.UI.Label  5      -   5          Name$ label3��5      $	��112��6   $��18��6)   $��
62,240,0,0q�65      Text$ Decimal Places��6I   	   HAlign$	 Right=�6_   
   VAlign$
 Center=�6n     5      -   5        $ label5��5      $	��234��6   $��35��6)   $��	8,273,0,0q�65   $U OOnce you establish a scale, you can manually assign it to a mount or mount def.��6H   $	 Center=�6�   $
 Center=�6�      WpfControls.UI.GroupBox  5      -   5          Name$ groupBoxOD1��5      $	��246��6%   $	��124��61   $��	65,74,0,0q�6>      Text$ From clicking on a line��6Q   .@�5        -   5        $ label2��5      $	��230��6   $��18��6*   $��
13,100,0,0q�66   $- 'Or you can manually enter a scale below��6J   $	 Center=�6y   $
 Center=�6�      WpfControls.UI.Button  5      -   5          Name$ butCalculate��5         WpfControls.UI.Button   Click$ butCalculate_Click��6a   $��75��6%   $��24��60   $��
106,73,0,0q�6<      Text$ 	Calculate��6P   6a      WpfControls.UI.TextBox  5      -   5          Name$ textKnownLength��5      $��66��6)   $��20��64   $��
111,19,0,0q�6@      HAlign$ Center=�6T     5      -	   5        $ label4��5      $��84��6   $��18��6)   $��	25,46,0,0q�65   $ Pixels��6H   $	 Right=�6V   $
 Center=�6e     5      -
   5        $ label21��5      $	��107��6   $��18��6+   $��2,20,0,0q�67   $ Known Length��6I   $	 Right=�6]   $
 Center=�6l     5      -   5        $ 
textPixels��5      $��66��6$   $��20��6/   $��
111,45,0,0q�6;      	ColorBack$ 	#FFF0F0F0��6O      ReadOnly . $ Center=�6u     5      -   5        $ 
labelUnits��5      $��62��6"   $��18��6-   $��
181,20,0,0q�69   $ mm��6M   $
 Center=�6W   5        5      -   5        $ 
labelScale��5      $	��112��6!   $��18��6-   $��
62,214,0,0q�69   $ Scale, pixels per mm��6M   $	 Right=�6i   $
 Center=�6x     5      -   5        $ label1��5      $	��120��6   $��18��6)   $��	54,44,0,0q�65   $ Optional Units (mm)��6H   $	 Right=�6c   $
 Center=�6r     5      -   5        $ 	textUnits��5      $��66��6"   $��20��6-   $��
176,43,0,0q�69   $ Center=�6M     5      -   5        $ labelInstructions��5      $	��300��6(   $��31��64   $��8,9,0,0q�6@   $g aIf you don't know your scale, then cancel out of this window and click on a line of known length.��6Q     5      -   5        $ butSave��5      $ butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��24��6a   $��	0,0,12,12q�6m   $ _Save��6�   6�   5      5      