   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      !    OpenDental.FrmImageDrawEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��441��5	      $	��346��6      OpenDental.FrmODBase    Text$  	Edit Text��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.CheckBox  -   5          Name$ checkTransparent��5         WpfControls.UI.CheckBox   Click$ checkTransparent_Click��6�   $	��166��60   $��21��6<   $��175,231,0,0q�6H      Text$ Transparent��6]      
CheckAlign$ 
MiddleLeft=�6p   6�      WpfControls.UI.Label  5   
   -   5          Name$ label4��5      $	��106��6#   $��18��6/   $��
30,232,0,0q�6;      Text$ Background Color��6O      HAlign$ Right=�6g      VAlign$ Center=�6v      WpfControls.UI.Panel  5   
   -   5        	  Name$	 panelColorBack��5         WpfControls.UI.Panel
   Click$
 butColorBack_Click��6o   $��30��6+   $��24��66   $��137,230,0,0q�6B      ColorBorder$ 	#FF636363��6W   6o      WpfControls.UI.GroupBox  5   
   -   5          Name$ groupBoxFont��5      $	��291��6,   $��89��68   $��
30,106,0,0q�6D      Text$! Font (decimals are allowed)��6X   .@�5         WpfControls.UI.Button  -   5          Name$ butCalculateApparent��5      	   WpfControls.UI.Button 	  Click$  butCalculateApparent_Click��6|   $	��106��66   $��24��6B   $��
158,53,0,0q�6N      Text$ Calculate Apparent��6b   6|    
   WpfControls.UI.TextVDouble
  5      -   5         
 Name$ textFontSize��5      $��42��63   $��20��6>   $��
107,25,0,0q�6J    
  MinVal$ 1Q�6^    
  MaxVal$ 	100000000Q�6i     5      -   5        $ butCalculateActual��5      $ butCalculateActual_Click��6x   $	��106��64   $��24��6@   $��
158,23,0,0q�6L   $ Calculate Actual��6`   6x     5      -   5        $ label3��5      $��90��6'   $��18��62   $��	16,25,0,0q�6>   $ Actual Size��6Q   $ Right=�6d   $ Center=�6s     5      -	   5        $ label7��5      $��93��6'   $��36��62   $��	13,46,0,0q�6>   $# Apparent Size at Current Zoom��6Q   $ Right=�6v   $ Center=�6�   
  5      -
   5        $ textFontApparent��5      $��42��67   $��20��6B   $��
107,55,0,0q�6N   $ 1Q�6b   $ 	100000000Q�6m   5         WpfControls.UI.TextVInt  5   
   -   5          Name$ textLocY��5      $��42��6(   $��20��63   $��
137,79,0,0q�6?      MinVal$ 0��6S      MaxVal$ 	100000000��6^     5   
   -   5        $ label2��5      $��81��6#   $��18��6.   $��	55,79,0,0q�6:   $ 
Location Y��6M   $ Right=�6_   $ Center=�6n     5   
   -   5        $ textLocX��5      $��42��6(   $��20��63   $��
137,53,0,0q�6?   $ 0��6S   $ 	100000000��6^     5   
   -   5        $ label1��5      $��81��6#   $��18��6.   $��	55,53,0,0q�6:   $ 
Location X��6M   $ Right=�6_   $ Center=�6n     5   
   -   5        $ label5��5      $��81��6#   $��18��6.   $��
55,204,0,0q�6:   $ 
Text Color��6N   $ Right=�6`   $ Center=�6o      WpfControls.UI.TextBox  5   
   -   5          Name$ textDrawText��5      $	��281��6+   $��20��67   $��
137,26,0,0q�6C      
TabIndexOD$ 0��6W     5   
   -   5        $	 
panelColor��5      $
 butColor_Click��6�   $��30��6'   $��24��62   $��137,201,0,0q�6>    J� RenderTransformOrigin$ 
0.498,0.41&�6S   $ 	#FF636363��6v   6�     5   
   -   5        $ label6��5      $��81��6#   $��18��6.   $��	55,27,0,0q�6:   $
 Text��6M   $ Right=�6Y   $ Center=�6h     5   
   -   5        $ 	butDelete��5      $ butDelete_Click��6�   $��75��6'   $��Bottom=�62   $��24��6M   $��	12,0,0,12q�6Y   $ Delete��6l      Icon$ DeleteX=�6z   6�     5    
   -   5        $ butSave��5       $ butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��0,0,7,12q�6s   $ _Save��6�   6�   5!      5"      