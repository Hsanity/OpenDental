   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI      OpenDental.FrmMountEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��617��$	��433��   OpenDental.FrmODBase    Text$  Mount Information��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.CheckBox  -     Name$ checkTransparent��   WpfControls.UI.CheckBox   Click$ checkTransparent_Click��$	��158��$��17��$��121,264,0,0q�   Text$ Text BackG Transparent��   
CheckAlign$ MiddleRight=�  -   $ checkAdjModeAfterSeries��$	��144��$��17��$��135,300,0,0q�$ Adj Mode After Series��$ MiddleRight=�  -   $ checkFlipOnAcquire��$	��121��$��17��$��158,282,0,0q�$ Flip on Acquire��$ MiddleRight=�   WpfControls.UI.Label  -     Name$ label10��$��Right=�$	��240��$��0,221,75,164q�   Text$� These colors are defaults for drawing, and they are also the only way to change color for mount items that are displaying text.��$��Stretch=�   WpfControls.UI.Panel  -     Name$ butColorTextBack��   WpfControls.UI.Panel	   Click$	 butColorTextBack_Click��$��Right=�$��30��$��20��$��0,242,321,0q�
   ColorBorder$
 	#FF636363��  -   $ label9��$��Right=�$	��125��$��18��$��0,242,354,0q�$ Text Background Color��   HAlign$ Right=�   VAlign$ Center=�  -   $ butColorFore��$	 butColorFore_Click��$��Right=�$��30��$��20��$��0,220,321,0q�$
 	#FF636363��  -   $ label8��$��Right=�$	��125��$��18��$��0,221,354,0q�$ Text and Line Color��$ Right=�$ Center=�  -	   $ butColorBack��$	 butColorBack_Click��$��Right=�$��30��$��20��$��0,198,321,0q�$
 	#FF636363��  -
   $ 
labelColor��$��Right=�$	��125��$��0,200,354,0q�$ Background Color��$ Right=�$ Center=�$��18��   WpfControls.UI.Button  -     Name$ 	butLayout��   WpfControls.UI.Button   Click$ butLayout_Click��$��79��$��24��$��266,168,0,0q�   Text$ Edit Layout��	   WpfControls.UI.ComboBox	  -    	 Name$ 	comboProv��$	��173��$��21��$��
266,71,0,0q�  -   $ label7��$��95��$��18��$��
170,75,0,0q�$ Provider��$ Right=�  -   $ label6��$	��271��$��Bottom=�$��49��$��	154,0,0,6q�$u oThis information is only for the mount.  The individual images on the mount have their own information windows.��
   WpfControls.UI.TextBox
  -    
 Name$ textTime��$	��104��$��20��$��
266,48,0,0q� 
  
TabIndexOD$	 133��  -   $ label4��$��77��$��18��$��
188,53,0,0q�$
 Time��$ Right=�   WpfControls.UI.TextVDate  -     Name$ textDate��$	��104��$��20��$��
266,25,0,0q�   
TabIndexOD$	 130��  -   $ label5��$��82��$��18��$��
183,30,0,0q�$
 Date��$ Right=�  -   $ label3��$	��100��$��18��$��	12,10,0,0q�$ Category��   WpfControls.UI.ListBox  -     Name$ listCategory��$	��104��$��Stretch=�$��
12,26,0,91q�  -   $ label2��$��82��$��18��$��183,119,0,0q�$
 Note��$ Right=�  -   $ label1��$��82��$��18��$��
183,94,0,0q�$ Description��$ Right=�$ Bottom=�
  -   $ textNote��$	��339��$��44��$��266,118,0,0q� 
  IsMultiline . $ 3��
  -   $ textDescription��$	��339��$��20��$��
266,95,0,0q�$ 2��  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,12,12q�$ _Save��