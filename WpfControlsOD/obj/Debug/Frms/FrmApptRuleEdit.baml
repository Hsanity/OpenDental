   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5           OpenDental.FrmApptRuleEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��448��5	      $	��202��6      OpenDental.FrmODBase    Text$  Edit Appointment Rule��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.TextBox  -   5          Name$ textRuleDesc��5      $	��297��6+   $��20��67   $��
125,25,0,0q�6C     5   
   -   5        $ textCodeStart��5      $	��113��6,   $��20��68   $��
125,51,0,0q�6D     5   
   -   5        $ textCodeEnd��5      $	��113��6*   $��20��66   $��
125,77,0,0q�6B      WpfControls.UI.CheckBox  5   
   -   5          Name$ checkIsEnabled��5      $	��130��6.   $��21��6:   $��	8,103,0,0q�6F      Text$ 
Is Enabled��6Y      
CheckAlign$ MiddleRight=�6k      WpfControls.UI.Label  5   
   -   5          Name$ label3��5      $	��111��6#   $��20��6/   $��	12,76,0,0q�6;      Text$ Code End��6N      HAlign$ Right=�6^   	   VAlign$	 Center=�6m     5   
   -   5        $ label2��5      $	��111��6#   $��20��6/   $��	12,50,0,0q�6;   $ 
Code Start��6N   $ Right=�6`   $	 Center=�6o      WpfControls.UI.Button  5   
   -   5        
  Name$
 	butDelete��5         WpfControls.UI.Button   Click$ butDelete_Click��6�   $��75��6'   $��Bottom=�62   $��26��6M   $��	23,0,0,18q�6Y      Text$ _Delete��6l      Icon$ DeleteX=�6{   6�     5   
   -   5        $ label1��5      $	��111��6#   $��20��6/   $��	12,24,0,0q�6;   $ Description��6N   $ Right=�6a   $	 Center=�6p     5   
   -	   5        $
 butSave��5      $ butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��26��6g   $��	0,0,26,18q�6s   $ _Save��6�   6�   5      5      