   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  !    OpenDental.FrmMountItemEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��595��$	��455��   OpenDental.FrmODBase    Text$  Edit Mount Item��.��� ���	#FFFCFDFE.+�   WpfControls.UI.Label  -     Name$ label10��$	��286��$��25��$��273,141,0,0q�   Text$I CThis is just copied to the image.  Use those tooth numbers instead.��   VAlign$ Center=�  -   $ label9��$	��222��$��31��$��215,353,0,0q�$] WDecimals are allowed. Scale is mount pixels, so it will tend to be a very large number.��    WpfControls.UI.TextVDouble  -     Name$ textFontSize��$��42��$��20��$��164,356,0,0q�   MinVal$ 0Q�   MaxVal$ 	100000000Q�  -   $ label8��$��78��$��18��$��
85,356,0,0q�$ 	Font Size��   HAlign$ Right=�$ Center=�   WpfControls.UI.Button  -     Name$ butAddField��   WpfControls.UI.Button	   Click$	 butAddField_Click��$��74��$��24��$��
85,226,0,0q�
   Text$
 	Add Field��   WpfControls.UI.TextBox  -     Name$ textTextShowing��$	��395��$	��179��$��164,171,0,0q�   IsMultiline .   -   $ label7��$	��150��$��47��$��
13,173,0,0q�$N HText to show No images can be placed in a mount item that contains text.��$ Right=�  -   $ textToothNumbers��$	��106��$��20��$��164,142,0,0q�  -	   $ labelToothNums��$	��100��$��18��$��
63,144,0,0q�$ Tooth Numbers��$ Right=�  -
   $ label6��$	��193��$��17��$��215,122,0,0q�$) #Valid values are 0, 90, 180, or 270��$ Center=�   WpfControls.UI.TextVInt  -     Name$ 
textRotate��$��48��$��20��$��164,119,0,0q�   MinVal$ 0��   MaxVal$	 300��   ShowZero .    -   $ label5��$	��161��$��17��$��	3,119,0,0q�$! Rotate degrees when Acquire��$ Right=�$ Bottom=�  -   $ textYpos��$��48��$��20��$��
164,50,0,0q�$ 0��$ 10000��  -   $ label1��$��53��$��17��$��
109,50,0,0q�$ Y��$ Right=�$ Bottom=�  -   $ textXpos��$��48��$��20��$��
164,27,0,0q�$ 0��$ 20000��  -   $ label2��$��53��$��17��$��
109,27,0,0q�$ X��$ Right=�$ Bottom=�  -   $ 	butDelete��$	 butDelete_Click��$��75��$��Bottom=�$��24��$��	13,0,0,12q�$
 Delete��   Icon$ DeleteX=�  -   $ 
textHeight��$��48��$��20��$��
164,96,0,0q�$ 1��$ 10000��  -   $ label4��$��53��$��17��$��
110,96,0,0q�$ Height��$ Right=�$ Bottom=�  -   $ 	textWidth��$��48��$��20��$��
164,73,0,0q�$ 1��$ 20000��  -   $ label3��$��53��$��17��$��
110,73,0,0q�$ Width��$ Right=�$ Bottom=�  -   $ butSave��$	 butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,12,12q�$
 _Save��