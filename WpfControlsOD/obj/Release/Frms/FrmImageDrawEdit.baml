   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  !    OpenDental.FrmImageDrawEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��441��$	��346��   OpenDental.FrmODBase    Text$  	Edit Text��.��� ���	#FFFCFDFE.+�   WpfControls.UI.CheckBox  -     Name$ checkTransparent��   WpfControls.UI.CheckBox   Click$ checkTransparent_Click��$	��166��$��21��$��175,231,0,0q�   Text$ Transparent��   
CheckAlign$ 
MiddleLeft=�   WpfControls.UI.Label  -     Name$ label4��$	��106��$��18��$��
30,232,0,0q�   Text$ Background Color��   HAlign$ Right=�   VAlign$ Center=�   WpfControls.UI.Panel  -   	  Name$	 panelColorBack��   WpfControls.UI.Panel
   Click$
 butColorBack_Click��$��30��$��24��$��137,230,0,0q�   ColorBorder$ 	#FF636363��   WpfControls.UI.GroupBox  -     Name$ groupBoxFont��$	��291��$��89��$��
30,106,0,0q�   Text$! Font (decimals are allowed)��.@�   WpfControls.UI.Button  -     Name$ butCalculateApparent��	   WpfControls.UI.Button 	  Click$  butCalculateApparent_Click��$	��106��$��24��$��
158,53,0,0q�   Text$ Calculate Apparent�� 
   WpfControls.UI.TextVDouble
  -    
 Name$ textFontSize��$��42��$��20��$��
107,25,0,0q� 
  MinVal$ 1Q� 
  MaxVal$ 	100000000Q�  -   $ butCalculateActual��$ butCalculateActual_Click��$	��106��$��24��$��
158,23,0,0q�$ Calculate Actual��  -   $ label3��$��90��$��18��$��	16,25,0,0q�$ Actual Size��$ Right=�$ Center=�  -	   $ label7��$��93��$��36��$��	13,46,0,0q�$# Apparent Size at Current Zoom��$ Right=�$ Center=�
  -
   $ textFontApparent��$��42��$��20��$��
107,55,0,0q�$ 1Q�$ 	100000000Q�   WpfControls.UI.TextVInt  -     Name$ textLocY��$��42��$��20��$��
137,79,0,0q�   MinVal$ 0��   MaxVal$ 	100000000��  -   $ label2��$��81��$��18��$��	55,79,0,0q�$ 
Location Y��$ Right=�$ Center=�  -   $ textLocX��$��42��$��20��$��
137,53,0,0q�$ 0��$ 	100000000��  -   $ label1��$��81��$��18��$��	55,53,0,0q�$ 
Location X��$ Right=�$ Center=�  -   $ label5��$��81��$��18��$��
55,204,0,0q�$ 
Text Color��$ Right=�$ Center=�   WpfControls.UI.TextBox  -     Name$ textDrawText��$	��281��$��20��$��
137,26,0,0q�   
TabIndexOD$ 0��  -   $	 
panelColor��$
 butColor_Click��$��30��$��24��$��137,201,0,0q� J� RenderTransformOrigin$ 
0.498,0.41&�$ 	#FF636363��  -   $ label6��$��81��$��18��$��	55,27,0,0q�$
 Text��$ Right=�$ Center=�  -   $ 	butDelete��$ butDelete_Click��$��75��$��Bottom=�$��24��$��	12,0,0,12q�$ Delete��   Icon$ DeleteX=�  -   $ butSave��$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��0,0,7,12q�$ _Save��