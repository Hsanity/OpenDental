   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  #    WpfControls.UI.FrmColorDialog   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��370��$	��424��.��� ���	#FFFCFDFE.+�� $
��Left=�$	��Top=�$	��258��$	��258��$��	20,20,0,0q�.+��� 
�������$��1q�._�� -   $��gridSquareGradient��.+��� -   $��canvas������   �� 
StartPoint$	  0,0&� �� EndPoint$	 1,0&�.���  � Color$ White�� � Offset$ 0Q�� $	 Red��$ 1Q��� ���� $	  0,0&�$	 0,1&�.��� $ 	#00000000��$ 0Q�� $ Black��$ 1Q��� .+��� -   $��canvasEllipse�� �� Left$	 200��
 �� Top$	 200��.+�A� $ -5��$ -5��$��10��$��10��
���   �$��2��A� $
 -4.5��$
 -4.5��$��9��$��9��
�������$��1���� $
��Left=�$	��Top=�$	��360��$��15��$��
20,300,0,0q�.+��� -   $��	borderHue��
�������$��1q�
�������$	��360��$��15���� -   $��	canvasHue���� -   $��rectangleHueSlider��$ -3��$ -3��$��21��$��7��
���   �$��1��   WpfControls.UI.Button  -     Name$ butOK��   WpfControls.UI.Button   Click$ butOK_Click��$��75��$��24��$��	0,0,12,10q�   Text$ OK��$��Right=�$��Bottom=�   WpfControls.UI.Label  $��
285,26,0,0q�$��Right=�$��53��	   Text$		 Red��
   HAlign$
 Right=�   VAlign$ Center=�   WpfControls.UI.TextBox  -     Name$ textRed��   WpfControls.UI.TextBox   TextChanged$ textRed_TextChanged��$��
339,25,0,0q�   Text$  ��$��41��$��20��  $��
285,55,0,0q�$��Right=�$��53��$	 Green��$
 Right=�$ Center=�  -	   $ 	textGreen��$ textGreen_TextChanged��$��
339,54,0,0q�$  ��$��41��$��20��  $��
285,84,0,0q�$��Right=�$��53��$
	 Blue��$
 Right=�$ Center=�  -
   $ textBlue��$ textBlue_TextChanged��$��
339,83,0,0q�$  ��$��41��$��20��  $��285,125,0,0q�$��Right=�$��53��$		 Hex��$
 Right=�$ Center=�  -   $ textHex��$ textHex_TextChanged��$��339,124,0,0q�$  ��$��70��$��20��   WpfControls.UI.Panel  -     Name$ panelColorFinal��$��339,227,0,0q�$��41��$��41��   	ColorBack$ 	#FFEDEDED��  $��286,242,0,0q�$��Right=�$��52��$	 Final��$
 Right=�  -   $ panelColorInitial��$��339,188,0,0q�$��41��$��41��$ 	#FFB3A8A8��  $��286,202,0,0q�$��Right=�$��52��$	 Initial��$
 Right=�