   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  %    OpenDental.FrmDocumentSizeMount   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��426��$	��246��   OpenDental.FrmODBase    Text$%  Item Size and Rotation on Mount��.��� ���	#FFFCFDFE.+�   WpfControls.UI.Button  -     Name$ but100��   WpfControls.UI.Button   Click$ but100_Click��$��63��$��Bottom=�$��24��$��	25,0,0,12q�   Text$ 100% Pix��   WpfControls.UI.Label  -     Name$ label3��$	��232��$��18��$��191,155,0,0q�   Text$" (relative to original image)��   WpfControls.UI.TextBox  -     Name$ textZoomOrig��$��43��$��20��$��142,151,0,0q�   	ColorBack$ 	#FFF0F0F0��   ReadOnly .   -   $ label9��$	��105��$��18��$��
36,152,0,0q�$ 	Zoom Orig��	   HAlign$	 Right=�
   VAlign$
 Center=�  -   $ butExpandFill��$ butExpandFill_Click��$��74��$��Bottom=�$��24��$��
163,0,0,12q�$ Expand Fill��  -   $ label10��$	��113��$��18��$��
242,19,0,0q�$ (pixels)��  -   $ label8��$	��124��$��18��$��
242,45,0,0q�$ (pixels)��  -   $ textMountSize��$��94��$��20��$��
142,42,0,0q�$ 	#FFF0F0F0�� .   -	   $ label7��$	��105��$��18��$��	36,43,0,0q�$ Mount Item Size��$	 Right=�$
 Center=�  -
   $ textRawSize��$��94��$��20��$��
142,16,0,0q�$ 	#FFF0F0F0�� .   -   $ label6��$	��105��$��18��$��	36,17,0,0q�$ Raw Image Size��$	 Right=�$
 Center=�  -   $ label5��$	��232��$��18��$��191,129,0,0q�$ (relative to Fit)��  -   $ textZoomFit��$��43��$��20��$��142,125,0,0q�  -   $ butFit��$ butFit_Click��$��63��$��Bottom=�$��24��$��	94,0,0,12q�$	 Fit��  -   $ 	labelCrop��$��82��$��18��$��
59,126,0,0q�$ Zoom Fit��$	 Right=�$
 Center=�  -   $ textDegreesRotated��$��43��$��20��$��
142,97,0,0q�  -   $ label4��$	��106��$��16��$��	33,98,0,0q�$ Degrees Rotated��$	 Right=�$
 Center=�  -   $ label1��$	��252��$��18��$��
161,74,0,0q�$< 6(to flip vertically, combine this with a 180 rotation)��   WpfControls.UI.CheckBox  -     Name$ checkIsFlipped��$	��152��$��18��$��3,73,0,0q�   Text$ Is Flipped Horizontally��   
CheckAlign$ MiddleRight=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,12,12q�$ _Save��