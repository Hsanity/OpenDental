   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmFaqPicker   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��772��5	      $	��402��6      OpenDental.FrmODBase    Text$  
FAQ Picker��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Grid  -   5          Name$ 
gridODMain��5      $	��655��6&   $	��291��62   $��	14,77,0,0q�6?      Title$
 FAQs��6R      WpfControls.UI.CheckBox  5   
   -   5          Name$ checkShowUnlinked��5      $	��268��61   $��17��6=   $��
14,375,0,0q�6I      Text$4 .Show Unlinked FAQs (Does not consider filters)��6]      
CheckAlign$ 
MiddleLeft=�6�      WpfControls.UI.Button  5   
   -   5          Name$ butAdd��5         WpfControls.UI.Button   Click$ ButAdd_Click��6\   $��74��6$   $��23��6/   $��684,210,0,0q�6;      Text$
 _Add��6P   6\     5   
   -   5        $ 
butRefresh��5      $ ButRefresh_Click��6b   $��75��6(   $��23��63   $��
684,78,0,0q�6?   $ Refresh��6S   6b      WpfControls.UI.TextBox  5   
   -   5        	  Name$	 textManualVersion��5      $	��100��60   $��20��6<   $��
472,15,0,0q�6H     5   
   -   5        $	 textManualPage��5      $	��196��6-   $��20��69   $��
132,15,0,0q�6E      WpfControls.UI.Label  5   
   -   5        
  Name$
 label2��5      $��90��6#   $��18��6.   $��
382,17,0,0q�6:      Text$ Manual Version:��6N      HAlign$ Right=�6e      VAlign$ Center=�6t     5   
   -   5        $
 label1��5      $	��132��6#   $��18��6/   $��0,17,0,0q�6;   $ Manual Page Name:��6M   $ Right=�6f   $ Center=�6u      WpfControls.UI.DatePicker  5   
   -	   5          Name$ datePickerFrom��5      $��
132,46,0,0q�60   $	��112��6D   $��21��6P     5   
   -
   5        $ datePickerTo��5      $��
358,46,0,0q�6.   $	��112��6B   $��21��6N     5   
   -   5        $
 label3��5      $��96��6#   $��18��6.   $��	36,47,0,0q�6:   $ Created From:��6M   $ Right=�6b   $ Center=�6q     5   
   -   5        $
 label4��5      $��96��6#   $��18��6.   $��
262,47,0,0q�6:   $ Created To:��6N   $ Right=�6a   $ Center=�6p   5      5      