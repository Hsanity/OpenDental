   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      !    OpenDental.FrmMountItemEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��595��5	      $	��455��6      OpenDental.FrmODBase    Text$  Edit Mount Item��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Label  -   5          Name$ label10��5      $	��286��6$   $��25��60   $��273,141,0,0q�6<      Text$I CThis is just copied to the image.  Use those tooth numbers instead.��6Q      VAlign$ Center=�6�     5   
   -   5        $ label9��5      $	��222��6#   $��31��6/   $��215,353,0,0q�6;   $] WDecimals are allowed. Scale is mount pixels, so it will tend to be a very large number.��6P       WpfControls.UI.TextVDouble  5   
   -   5          Name$ textFontSize��5      $��42��6/   $��20��6:   $��164,356,0,0q�6F      MinVal$ 0Q�6[      MaxVal$ 	100000000Q�6f     5   
   -   5        $ label8��5      $��78��6#   $��18��6.   $��
85,356,0,0q�6:   $ 	Font Size��6N      HAlign$ Right=�6_   $ Center=�6n      WpfControls.UI.Button  5   
   -   5          Name$ butAddField��5         WpfControls.UI.Button	   Click$	 butAddField_Click��6e   $��74��6)   $��24��64   $��
85,226,0,0q�6@   
   Text$
 	Add Field��6T   6e      WpfControls.UI.TextBox  5   
   -   5          Name$ textTextShowing��5      $	��395��6.   $	��179��6:   $��164,171,0,0q�6G      IsMultiline . 6\     5   
   -   5        $ label7��5      $	��150��6#   $��47��6/   $��
13,173,0,0q�6;   $N HText to show No images can be placed in a mount item that contains text.��6O   $ Right=�5   >     5   
   -   5        $ textToothNumbers��5      $	��106��6/   $��20��6;   $��164,142,0,0q�6G     5   
   -	   5        $ labelToothNums��5      $	��100��6+   $��18��67   $��
63,144,0,0q�6C   $ Tooth Numbers��6W   $ Right=�6l     5   
   -
   5        $ label6��5      $	��193��6#   $��17��6/   $��215,122,0,0q�6;   $) #Valid values are 0, 90, 180, or 270��6P   $ Center=�6{      WpfControls.UI.TextVInt  5   
   -   5          Name$ 
textRotate��5      $��48��6*   $��20��65   $��164,119,0,0q�6A      MinVal$ 0��6V      MaxVal$	 300��6a      ShowZero .  6n     5   
   -   5        $ label5��5      $	��161��6#   $��17��6/   $��	3,119,0,0q�6;   $! Rotate degrees when Acquire��6N   $ Right=�6q   $ Bottom=�6�     5   
   -   5        $ textYpos��5      $��48��6(   $��20��63   $��
164,50,0,0q�6?   $ 0��6S   $ 10000��6^     5   
   -   5        $ label1��5      $��53��6#   $��17��6.   $��
109,50,0,0q�6:   $ Y��6N   $ Right=�6W   $ Bottom=�6f     5   
   -   5        $ textXpos��5      $��48��6(   $��20��63   $��
164,27,0,0q�6?   $ 0��6S   $ 20000��6^     5   
   -   5        $ label2��5      $��53��6#   $��17��6.   $��
109,27,0,0q�6:   $ X��6N   $ Right=�6W   $ Bottom=�6f     5   
   -   5        $ 	butDelete��5      $	 butDelete_Click��6�   $��75��6'   $��Bottom=�62   $��24��6M   $��	13,0,0,12q�6Y   $
 Delete��6l      Icon$ DeleteX=�6z   6�     5   
   -   5        $ 
textHeight��5      $��48��6*   $��20��65   $��
164,96,0,0q�6A   $ 1��6U   $ 10000��6`     5   
   -   5        $ label4��5      $��53��6#   $��17��6.   $��
110,96,0,0q�6:   $ Height��6N   $ Right=�6\   $ Bottom=�6k     5    
   -   5        $ 	textWidth��5       $��48��6)   $��20��64   $��
164,73,0,0q�6@   $ 1��6T   $ 20000��6_     5!   
   -   5        $ label3��5!      $��53��6#   $��17��6.   $��
110,73,0,0q�6:   $ Width��6N   $ Right=�6[   $ Bottom=�6j     5"   
   -   5        $ butSave��5"      $	 butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��	0,0,12,12q�6s   $
 _Save��6�   6�   5#      5$      