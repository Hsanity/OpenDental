   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5   	   /clr-namespace:WpfControls.UIWpfControls.UI  5   	   #    WpfControls.UI.FrmColorDialog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:OpenDental     5   	   +uiclr-namespace:WpfControls.UI     5   	   $	��370��5	   	   $	��424��6   .��5
      � ���	#FFFCFDFE.+�5      � $
��Left=�6	   $	��Top=�6$   $	��258��6<   $	��258��6H   $��	20,20,0,0q�6U   .+�5      �� 
�������$��1q�6#   ._�5      � -   5        $��gridSquareGradient��5      .+�5      �� -   5        $��canvas��5      ��5      �� 5   	     �� 
StartPoint$	  0,0&�6    �� EndPoint$	 1,0&�6.   .��5   
   �  � Color$ White��6    � Offset$ 0Q�6%   � 5   
   $	 Red��6   $ 1Q�6#   5   
   5      �� 5      ��5      �� 5   	   $	  0,0&�6   $	 0,1&�6.   .��5   
   � $ 	#00000000��6   $ 0Q�6)   � 5   
   $ Black��6   $ 1Q�6%   5   
   5      �� 5      .+�5      �� -   5        $��canvasEllipse��5       �� Left$	 200��6$   
 �� Top$	 200��66   .+�5    	   A� $ -5��6   $ -5��6"   $��10��62   $��10��6=   
���   �$��2��6X   A� 5!   	   $
 -4.5��6   $
 -4.5��6$   $��9��66   $��9��6@   
�������$��1��6Z   5"   	   5#      5$      5%      5&      �� 5'      $
��Left=�6   $	��Top=�6&   $	��360��6>   $��15��6J   $��
20,300,0,0q�6V   .+�5(      �� -   5        $��	borderHue��5(      
�������$��1q�64   
�������$	��360��6[   $��15��6g   �� 5)      -   5        $��	canvasHue��5)      6   �� 5*      -   5        $��rectangleHueSlider��5*      $ -3��6)   $ -3��69   $��21��6J   $��7��6V   
���   �$��1��6o   5+         WpfControls.UI.Button  5,      -   5          Name$ butOK��5,         WpfControls.UI.Button   Click$ butOK_Click��6�   $��75��6   $��24��6(   $��	0,0,12,10q�64      Text$ OK��6G   $��Right=�6Q   $��Bottom=�6m   6�      WpfControls.UI.Label  5-   
   $��
285,26,0,0q�6   $��Right=�6'   $��53��6J   	   Text$		 Red��6U   
   HAlign$
 Right=�6`      VAlign$ Center=�6o      WpfControls.UI.TextBox  5.      -   5          Name$ textRed��5.         WpfControls.UI.TextBox   TextChanged$ textRed_TextChanged��6G   $��
339,25,0,0q�6       Text$  ��64   $��41��6<   $��20��6i     5/      $��
285,55,0,0q�6   $��Right=�6!   $��53��6D   $	 Green��6O   $
 Right=�6\   $ Center=�6k     50      -	   5        $ 	textGreen��50      $ textGreen_TextChanged��6I   $��
339,54,0,0q�6"   $  ��66   $��41��6>   $��20��6m     51      $��
285,84,0,0q�6   $��Right=�6!   $��53��6D   $
	 Blue��6O   $
 Right=�6[   $ Center=�6j     52      -
   5        $ textBlue��52      $ textBlue_TextChanged��6H   $��
339,83,0,0q�6!   $  ��65   $��41��6=   $��20��6k     53      $��285,125,0,0q�6   $��Right=�6"   $��53��6E   $		 Hex��6P   $
 Right=�6[   $ Center=�6j     54      -   5        $ textHex��54      $ textHex_TextChanged��6H   $��339,124,0,0q�6    $  ��65   $��70��6=   $��20��6j      WpfControls.UI.Panel  55      -   5          Name$ panelColorFinal��55      $��339,227,0,0q�6&   $��41��6;   $��41��6F      	ColorBack$ 	#FFEDEDED��6R     56      $��286,242,0,0q�6   $��Right=�6"   $��52��6E   $	 Final��6P   $
 Right=�6]     57      -   5        $ panelColorInitial��57      $��339,188,0,0q�6(   $��41��6=   $��41��6H   $ 	#FFB3A8A8��6T     58      $��286,202,0,0q�6   $��Right=�6"   $��52��6E   $	 Initial��6P   $
 Right=�6_   59      5:      