   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      "    OpenDental.FrmReferralSelect   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $
��1029��5	      $	��696��6      OpenDental.FrmODBase    Text$  	Referrals��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5          WpfControls.UI.ComboClinic  -   5          Name$ comboClinicPicker��5      $��Right=�6.   $	��200��6J   $��21��6V   $��	0,13,14,0q�6b      
IncludeAll .    IncludeUnassigned . 6�      WpfControls.UI.GroupBox  5      -   5          Name$ 	groupBox1��5      $	��450��6#   $��33��6/   $��	359,3,0,0q�6;      Text$
 Show��6N   .@�5         WpfControls.UI.CheckBox  -   5          Name$ checkPreferred��5         WpfControls.UI.CheckBox   Click$ checkPreferred_Click��6�   $��94��6)   $��16��64   $��
261,13,0,0q�6@   	   Text$	 Preferred Only��6T   
   
CheckAlign$
 MiddleRight=�6j   6�     5      -   5        $ checkShowOther��5      $ checkShowOther_Click��6z   $��75��6)   $��16��64   $��
177,13,0,0q�6@   $	 Other��6T   $
 MiddleRight=�6a   6z     5      -   5        $ checkShowDoctor��5      $ checkShowDoctor_Click��6{   $��84��6*   $��16��65   $��	89,13,0,0q�6A   $	 Doctor��6T   $
 MiddleRight=�6b   6{     5      -   5        $ checkShowPat��5      $ checkShowPat_Click��6x   $��84��6'   $��16��62   $��3,13,0,0q�6>   $	 Patient��6P   $
 MiddleRight=�6_   6x     5      -   5        $ checkHidden��5      $ checkHidden_Click��6�   $��Right=�6&   $��75��6B   $��16��6M   $��	0,13,11,0q�6Y   $	 Hidden��6l   $
 MiddleRight=�6z   6�   5         WpfControls.UI.Label  5      -   5          Name$ labelResultCount��5      $	��108��6'   $��14��63   $��
258,17,0,0q�6?      Text$ # results found��6S      VAlign$ Center=�6j     5      -	   5        $ label1��5      $��50��6   $��14��6(   $��5,17,0,0q�64   $ Search��6F      HAlign$ Right=�6T   $ Center=�6c      WpfControls.UI.TextBox  5      -
   5          Name$ 
textSearch��5      $	��201��6#   $��20��6/   $��	56,14,0,0q�6;      
TabIndexOD$ 0��6N      WpfControls.UI.Grid  5      -   5          Name$ gridMain��5      $��Stretch=�6   $��Stretch=�6<   $��
8,42,14,44q�6X      Title$ Select Referral��6l      TranslationName$ TableSelectReferral��6�   	   WpfControls.UI.Button	  5      -   5         	 Name$ butAdd��5      
   WpfControls.UI.Button 
  Click$ butAdd_Click��6y   $��80��6   $��Bottom=�6)   $��24��6D   $��8,0,0,11q�6P    	  Text$
 _Add��6b    	  Icon$	 Add=�6n   6y   	  5      -   5        $ butOK��5      $ butOK_Click��6�   $��Right=�6   $��75��69   $��Bottom=�6D   $��24��6_   $��	0,0,14,11q�6k   $	 _OK��6~   6�   5      5      