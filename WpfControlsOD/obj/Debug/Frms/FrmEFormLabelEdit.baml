   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      "    OpenDental.FrmEFormLabelEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��845��5	      $	��710��6      OpenDental.FrmODBase    Text$  
Edit Label��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5         WpfControls.UI.ToolBar  -   5          Name$ toolBarMain��5      $��25��6$   $	��627��60      WpfControls.UI.Button  5      -   5          Name$ 	butDelete��5         WpfControls.UI.Button   Click$ butDelete_Click��6�   $��84��6!   $��Bottom=�6,   $��24��6G   $��	13,0,0,12q�6S      Text$ Delete��6f      Icon$ DeleteX=�6t   6�     5      -   5        $ butSave��5      $ butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��24��6a   $��	0,0,14,12q�6m   $ _Save��6�   6�      WpfControls.UI.CheckBox  5      -   5          Name$ checkIsHorizStacking��5      $��20��6.   $��
55,415,0,0q�6:   $	��130��6N      Text$ Horizontal Stacking��6Z   	   
CheckAlign$	 MiddleRight=�6u      WpfControls.UI.Label  5      -   5        
  Name$
 labelStackable��5      $��18��6%   $��190,416,0,0q�61      Text$$ compared to the previous field��6F      VAlign$ Center=�6l   $	��193��6|     5      $��98��6   $��18��6   $��
73,441,0,0q�6$   $ Width��68      HAlign$ Right=�6E   $ Center=�6T     5      $��18��6   $��229,441,0,0q�6   $  leave blank for full width��6.   $ Center=�6P   $	��193��6`      WpfControls.UI.TextVInt  5      -   5          Name$ textVIntWidth��5      $��54��6'   $��20��62   $��172,440,0,0q�6>      ShowZero .  6S      WpfControls.UI.ListBox  5      -   5          Name$ listBoxFields��5      $	��198��6&   $��637,26,0,48q�62   $��Stretch=�6G     5      $��57��6   $��484,415,0,0q�6   $O IClick on the list to the right to insert a Field into the main text above��6.   $	��147��6   $ Right=�6�   	   WpfControls.UI.GroupBox	  5      $��80��6   $��
13,568,0,0q�6   $	��470��60    	  Text$0 *Conditional Logic. This field will show...��6<   .@�5        $	��128��6   $��18��6   $��	30,27,0,0q�6&   $ ... if the parent field��69   $ Right=�6X   $ Center=�6g   
   WpfControls.UI.TextBox
  5      -   5         
 Name$ textCondParent��5      $	��213��6(   $��20��64   $��
159,25,0,0q�6@     5      $	��143��6   $��18��6   $��	15,51,0,0q�6&   $! ... has the following value��69   $ Right=�6\   $ Center=�6k   
  5      -	   5        $ textCondValue��5      $	��213��6'   $��20��63   $��
159,50,0,0q�6?     5      -
   5        $ butPickParent��5      $ butPickParent_Click��6]   $��66��6&   $��24��61   $��
379,22,0,0q�6=   $
 Pick��6Q   6]     5      -   5        $ butPickValue��5      $ butPickValue_Click��6\   $��66��6%   $��24��60   $��
379,48,0,0q�6<   $
 Pick��6P   6\   5      
  5      -   5        $ textSpaceBelow��5      $��54��6'   $��20��62   $��172,540,0,0q�6>     5      $��98��6   $��18��6   $��
73,540,0,0q�6$   $ Space Below��68   $ Right=�6K   $ Center=�6Z     5       -   5        $
 labelSpaceDefault��5       $��18��6(   $��229,540,0,0q�64   $- 'leave blank to use the default value of��6I   $ Center=�6x   $	��264��6�     5!      -   5        $ checkIsWidthPercentage��5!      $��20��60   $��
26,465,0,0q�6<   $	��159��6P   $ Width Is Percentage��6\   $	 MiddleRight=�6w     5"      -   5        $ 
 labelWidthIsPercentageNote��5"      $��18��61   $��190,466,0,0q�6=   $6 0this applies to all fields in a horizontal stack��6R   $ Center=�6�   $	��266��6�     5#      -   5        $
 labelMinWidth��5#      $	��120��6$   $��18��60   $��
51,490,0,0q�6<   $ Minimum Width��6P   $ Right=�6e   $ Center=�6t     5$      -   5        $ textVIntMinWidth��5$      $��54��6*   $��20��65   $��172,490,0,0q�6A    .  6V     5%      -   5        $ checkBorder��5%      $��20��6%   $��
26,515,0,0q�61   $	��159��6E   $ Show Border Box��6Q   $	 MiddleRight=�6h   	  5&      -   5         	 Name$ groupLanguage��5&      $	��209��6'   $��0,26,0,0q�64   $	��627��6F   $ Language Translation��6R   .@�5'      
  -   5        $ textLanguage��5'      $	��163��6&   $��20��62   $��
114,17,0,0q�6>    
  ReadOnly .  
  	ColorBack$ 	#FFF0F0F0��6b     5(      -   5        $
 labelLanguage��5(      $��98��6%   $��18��60   $��	15,17,0,0q�6<   $ Language��6O   $ Right=�6_   $ Center=�6n      WpfControls.UI.TextRich  5)      -   5          Name$ textLabelTranslated��5)      $	��165��6.   $��5,40,0,0q�6;      FormattedTextAllowed .    SpellCheckIsEnabled .  $	��617��6�   5*        5+      -   5        $ 	textLabel��5+      $	��165��6#   $��	0,240,0,0q�60    .  .  $	��627��6{   5,      5-      