   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI       OpenDental.FrmDocumentSize   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��469��$	��223��   OpenDental.FrmODBase    Text$  
Image Size��.��� ���	#FFFCFDFE.+�   WpfControls.UI.Label  -     Name$ label10��$	��113��$��18��$��
264,18,0,0q�   Text$ (pixels)��   WpfControls.UI.TextBox  -     Name$ textRawSize��$��94��$��20��$��
164,15,0,0q�   	ColorBack$ 	#FFF0F0F0��   ReadOnly .   -   $ label6��$	��105��$��18��$��	58,16,0,0q�$ Raw Image Size��   HAlign$ Right=�   VAlign$ Center=�  -   $ labelResetAll��$	��235��$��18��$��234,130,0,0q�$7 1(this image has no crop, flip, or rotate applied)��   WpfControls.UI.Button  -     Name$ butResetAll��   WpfControls.UI.Button	   Click$	 butResetAll_Click��$��64��$��24��$��164,125,0,0q�
   Text$
 	Reset All��  -   $ labelCropInfo��$	��250��$��18��$��
234,99,0,0q�$&  (this image has no crop applied)��  -   $ butCropReset��$	 butCropReset_Click��$��64��$��24��$��
164,94,0,0q�$
 Reset��  -   $ 	labelCrop��$��82��$��18��$��	81,99,0,0q�$
 Crop��$ Right=�  -	   $ textDegreesRotated��$��43��$��20��$��
164,67,0,0q�  -
   $ label4��$	��106��$��16��$��	55,68,0,0q�$ Degrees Rotated��$ Right=�$ Center=�  -   $ label1��$	��252��$��18��$��
185,44,0,0q�$< 6(to flip vertically, combine this with a 180 rotation)��   WpfControls.UI.CheckBox  -     Name$ checkIsFlipped��   WpfControls.UI.CheckBox   Click$ checkIsFlipped_Click��$	��152��$��18��$��	25,43,0,0q�   Text$ Is Flipped Horizontally��   
CheckAlign$ MiddleRight=�  -   $ butSave��$	 butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,21,12q�$
 _Save��