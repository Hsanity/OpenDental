   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5           OpenDental.FrmProviderPick   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��558��5	      $	��670��6      OpenDental.FrmODBase    Text$  	Providers��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.TextRich  -   5          Name$ 
textFilter��5      $	��158��6*   $��20��66   $��88,5,0,0q�6B      AllowsCarriageReturns .     QuickPasteType$ ProviderSearchFilter=�6r      
TabIndexOD$ 0��6�      WpfControls.UI.Label  5   
   -   5          Name$ label3��5      $��71��6#   $��18��6.   $��16,6,0,0q�6:      Text$ Search��6L      HAlign$ Right=�6Z   	   VAlign$	 Center=�6i      WpfControls.UI.CheckBox  5   
   -   5        
  Name$
 checkShowAll��5         WpfControls.UI.CheckBox   Click$ checkShowAll_Click��6   $��88��6,   $��21��67   $��	253,7,0,0q�6C      Text$ Show All��6V      
CheckAlign$ MiddleRight=�6f   6      WpfControls.UI.Button  5   
   -   5          Name$ butSelectNone��5         WpfControls.UI.Button   Click$ butSelectNone_Click��6q   $��Right=�6+   $��75��6G   $��	0,0,22,68q�6R      Text$
 None��6e   $��24��6�   $��Bottom=�6�      WpfControls.UI.GroupBox  5   
   -   5          Name$ groupDentalSchools��5      $��Right=�62   $	��200��6N   $	��110��6Z   $��0,32,8,0q�6g      
TabIndexOD$ 3��6y      Text$ Dental School Filters��6�   .@�5        -   5        $ 
labelClass��5      $��68��6+   $��18��66   $��6,82,0,0q�6B   $ Class��6T   $ Right=�6a   $	 Center=�6p   	   WpfControls.UI.ComboBox	  5      -   5         	 Name$ 
comboClass��5      $	��118��6.   $��21��6:   $��	76,82,0,0q�6F   
   WpfControls.UI.TextBox
  5      -   5         
 Name$ 	textLName��5      $	��118��6,   $��20��68   $��	76,40,0,0q�6D    
  
TabIndexOD$ 1��6W     5      -	   5        $ label2��5      $��68��6'   $��18��62   $��6,40,0,0q�6>   $ LName��6P   $ Right=�6]   $	 Center=�6l   
  5      -
   5        $ 	textFName��5      $	��118��6,   $��20��68   $��	76,61,0,0q�6D   $ 2��6W     5      -   5        $ label1��5      $��68��6'   $��18��62   $��6,61,0,0q�6>   $ FName��6P   $ Right=�6]   $	 Center=�6l   
  5      -   5        $ textProvNum��5      $	��118��6.   $��20��6:   $��	76,19,0,0q�6F   $ 0��6Y     5      -   5        $ labelProvNum��5      $��68��6-   $��18��68   $��6,19,0,0q�6D   $ ProvNum��6V   $ Right=�6e   $	 Center=�6t   5        5   
   -   5        $ butSave��5      $ butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��	0,0,22,16q�6s   $ _Save��6�   6�      WpfControls.UI.Grid  5   
   -   5          Name$ gridMain��5      $��Stretch=�6$   $��Stretch=�6B   $��16,30,217,16q�6^      Title$ 	Providers��6t      TranslationName$ TableProviders��6�   5      5      