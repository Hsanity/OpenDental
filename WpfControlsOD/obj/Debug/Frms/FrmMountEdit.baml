   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmMountEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��617��5	      $	��433��6      OpenDental.FrmODBase    Text$  Mount Information��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5         WpfControls.UI.CheckBox  -   5          Name$ checkTransparent��5         WpfControls.UI.CheckBox   Click$ checkTransparent_Click��6�   $	��158��6*   $��17��66   $��121,264,0,0q�6B      Text$ Text BackG Transparent��6W      
CheckAlign$ MiddleRight=�6u   6�     5      -   5        $ checkAdjModeAfterSeries��5      $	��144��61   $��17��6=   $��135,300,0,0q�6I   $ Adj Mode After Series��6^   $ MiddleRight=�6{     5      -   5        $ checkFlipOnAcquire��5      $	��121��6,   $��17��68   $��158,282,0,0q�6D   $ Flip on Acquire��6Y   $ MiddleRight=�6p      WpfControls.UI.Label  5      -   5          Name$ label10��5      $��Right=�6   $	��240��6:   $��0,221,75,164q�6F      Text$� These colors are defaults for drawing, and they are also the only way to change color for mount items that are displaying text.��6\   $��Stretch=�6�      WpfControls.UI.Panel  5      -   5          Name$ butColorTextBack��5         WpfControls.UI.Panel	   Click$	 butColorTextBack_Click��6o   $��Right=�6'   $��30��6C   $��20��6N   $��0,242,321,0q�6Z   
   ColorBorder$
 	#FF636363��6�     5      -   5        $ label9��5      $��Right=�6   $	��125��69   $��18��6E   $��0,242,354,0q�6Q   $ Text Background Color��6f      HAlign$ Right=�6�      VAlign$ Center=�6�     5      -   5        $ butColorFore��5      $	 butColorFore_Click��6k   $��Right=�6#   $��30��6?   $��20��6J   $��0,220,321,0q�6V   $
 	#FF636363��6�     5      -   5        $ label8��5      $��Right=�6   $	��125��69   $��18��6E   $��0,221,354,0q�6Q   $ Text and Line Color��6f   $ Right=�6�   $ Center=�6�     5      -	   5        $ butColorBack��5      $	 butColorBack_Click��6k   $��Right=�6#   $��30��6?   $��20��6J   $��0,198,321,0q�6V   $
 	#FF636363��6�     5      -
   5        $ 
labelColor��5      $��Right=�6!   $	��125��6=   $��0,200,354,0q�6I   $ Background Color��6^   $ Right=�6v   $ Center=�6�   $��18��6�      WpfControls.UI.Button  5      -   5          Name$ 	butLayout��5         WpfControls.UI.Button   Click$ butLayout_Click��6`   $��79��6!   $��24��6,   $��266,168,0,0q�68      Text$ Edit Layout��6M   6`   	   WpfControls.UI.ComboBox	  5      -   5         	 Name$ 	comboProv��5      $	��173��6#   $��21��6/   $��
266,71,0,0q�6;     5      -   5        $ label7��5      $��95��6   $��18��6(   $��
170,75,0,0q�64   $ Provider��6H   $ Right=�6X     5      -   5        $ label6��5      $	��271��6   $��Bottom=�6)   $��49��6D   $��	154,0,0,6q�6P   $u oThis information is only for the mount.  The individual images on the mount have their own information windows.��6c   
   WpfControls.UI.TextBox
  5      -   5         
 Name$ textTime��5      $	��104��6!   $��20��6-   $��
266,48,0,0q�69    
  
TabIndexOD$	 133��6M     5      -   5        $ label4��5      $��77��6   $��18��6(   $��
188,53,0,0q�64   $
 Time��6H   $ Right=�6T      WpfControls.UI.TextVDate  5      -   5          Name$ textDate��5      $	��104��6#   $��20��6/   $��
266,25,0,0q�6;      
TabIndexOD$	 130��6O     5      -   5        $ label5��5      $��82��6   $��18��6(   $��
183,30,0,0q�64   $
 Date��6H   $ Right=�6T     5      -   5        $ label3��5      $	��100��6   $��18��6)   $��	12,10,0,0q�65   $ Category��6H      WpfControls.UI.ListBox  5      -   5          Name$ listCategory��5      $	��104��6%   $��Stretch=�61   $��
12,26,0,91q�6M     5       -   5        $ label2��5       $��82��6   $��18��6(   $��183,119,0,0q�64   $
 Note��6I   $ Right=�6U     5!      -   5        $ label1��5!      $��82��6   $��18��6(   $��
183,94,0,0q�64   $ Description��6H   $ Right=�6[   $ Bottom=�6j   
  5"      -   5        $ textNote��5"      $	��339��6!   $��44��6-   $��266,118,0,0q�69    
  IsMultiline . $ 3��6a   
  5#      -   5        $ textDescription��5#      $	��339��6(   $��20��64   $��
266,95,0,0q�6@   $ 2��6T     5$      -   5        $ butSave��5$      $ butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��24��6a   $��	0,0,12,12q�6m   $ _Save��6�   6�   5%      5&      