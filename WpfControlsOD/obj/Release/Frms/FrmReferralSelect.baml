   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  "    OpenDental.FrmReferralSelect   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $
��1029��$	��696��   OpenDental.FrmODBase    Text$  	Referrals��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�    WpfControls.UI.ComboClinic  -     Name$ comboClinicPicker��$��Right=�$	��200��$��21��$��	0,13,14,0q�   
IncludeAll .    IncludeUnassigned .    WpfControls.UI.GroupBox  -     Name$ 	groupBox1��$	��450��$��33��$��	359,3,0,0q�   Text$
 Show��.@�   WpfControls.UI.CheckBox  -     Name$ checkPreferred��   WpfControls.UI.CheckBox   Click$ checkPreferred_Click��$��94��$��16��$��
261,13,0,0q�	   Text$	 Preferred Only��
   
CheckAlign$
 MiddleRight=�  -   $ checkShowOther��$ checkShowOther_Click��$��75��$��16��$��
177,13,0,0q�$	 Other��$
 MiddleRight=�  -   $ checkShowDoctor��$ checkShowDoctor_Click��$��84��$��16��$��	89,13,0,0q�$	 Doctor��$
 MiddleRight=�  -   $ checkShowPat��$ checkShowPat_Click��$��84��$��16��$��3,13,0,0q�$	 Patient��$
 MiddleRight=�  -   $ checkHidden��$ checkHidden_Click��$��Right=�$��75��$��16��$��	0,13,11,0q�$	 Hidden��$
 MiddleRight=�   WpfControls.UI.Label  -     Name$ labelResultCount��$	��108��$��14��$��
258,17,0,0q�   Text$ # results found��   VAlign$ Center=�  -	   $ label1��$��50��$��14��$��5,17,0,0q�$ Search��   HAlign$ Right=�$ Center=�   WpfControls.UI.TextBox  -
     Name$ 
textSearch��$	��201��$��20��$��	56,14,0,0q�   
TabIndexOD$ 0��   WpfControls.UI.Grid  -     Name$ gridMain��$��Stretch=�$��Stretch=�$��
8,42,14,44q�   Title$ Select Referral��   TranslationName$ TableSelectReferral��	   WpfControls.UI.Button	  -    	 Name$ butAdd��
   WpfControls.UI.Button 
  Click$ butAdd_Click��$��80��$��Bottom=�$��24��$��8,0,0,11q� 	  Text$
 _Add�� 	  Icon$	 Add=�	  -   $ butOK��$ butOK_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,14,11q�$	 _OK��