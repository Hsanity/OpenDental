   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      !    OpenDental.FrmInsPlanSelect   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��987��5	      $	��696��6      OpenDental.FrmODBase    Text$  Insurance Plans��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.GroupBox  -   5          Name$ 	groupBox1��5      $	��960��6)   $��61��65   $��	12,12,0,0q�6A      Text$ Filter��6T   .@�5         WpfControls.UI.TextBox  -   5          Name$ textEmployer��5      $	��140��6/   $��20��6;   $��	84,14,0,0q�6G      WpfControls.UI.Button  5      -   5          Name$ 	butGetAll��5         WpfControls.UI.Button   Click$ butGetAll_Click��6e   $��75��6+   $��24��66   $��
854,12,0,0q�6B      Text$ Get All��6V   6e     5      -   5        $ textPlanNum��5      $	��140��6.   $��20��6:   $��
540,36,0,0q�6F      WpfControls.UI.Label  5      -   5          Name$ labelEmployer��5      $��76��6.   $��17��69   $��6,16,0,0q�6E      Text$ Employer��6W   	   HAlign$	 Right=�6g   
   VAlign$
 Center=�6v      WpfControls.UI.CheckBox  5      -   5          Name$ checkShowHidden��5      $��93��63   $��20��6>   $��
837,37,0,0q�6J      Text$ Show Hidden��6^      
CheckAlign$ MiddleRight=�6q     5      -   5        $ labelInsPlanID��5      $��81��6/   $��17��6:   $��
457,38,0,0q�6F   $ Ins Plan ID��6Z   $	 Right=�6m   $
 Center=�6|     5      -   5        $ textCarrier��5      $	��140��6.   $��20��6:   $��
311,15,0,0q�6F     5      -	   5        $ labelCarrier��5      $��79��6-   $��17��68   $��
230,17,0,0q�6D   $ Carrier��6X   $	 Right=�6g   $
 Center=�6v     5      -
   5        $ 	groupBox2��5      $	��148��6-   $��44��69   $��
688,12,0,0q�6E   $ Order By��6Y   .@�5          WpfControls.UI.RadioButton  -   5          Name$ radioOrderCarrier��5   !   $��65��6<   $��18��6G   $��	80,15,0,0q�6S      Text$ Carrier��6f      
CheckAlign$ 
MiddleLeft=�6u     5      -   5        $ radioOrderEmp��5   !   $��77��68   $��18��6C   $��6,15,0,0q�6O   $ Employer��6a   $ 
MiddleLeft=�6q      Checked . 6�   5        5      -   5        $ textGroupName��5      $	��140��60   $��20��6<   $��
311,36,0,0q�6H     5      -   5        $ textGroupNum��5      $	��140��6/   $��20��6;   $��	84,35,0,0q�6G     5      -   5        $ textTrojanID��5      $	��140��6/   $��20��6;   $��
540,15,0,0q�6G     5      -   5        $ labelGroupName��5      $��78��6/   $��17��6:   $��
231,36,0,0q�6F   $ 
Group Name��6Z   $	 Right=�6l   $
 Center=�6{     5      -   5        $ labelTrojanID��5      $��81��6.   $��17��69   $��
457,18,0,0q�6E   $ 	Trojan ID��6Y   $	 Right=�6j   $
 Center=�6y     5      -   5        $ labelGroupNum��5      $��76��6.   $��17��69   $��6,37,0,0q�6E   $ 	Group Num��6W   $	 Right=�6h   $
 Center=�6w   5      	   WpfControls.UI.Grid	  5    
   -   5         	 Name$ gridMain��5       $��Stretch=�6$   $��Stretch=�6B   $��11,79,15,39q�6^    	  HScrollVisible .  	  SelectionMode$ MultiExtended=�6�    	  Title$ Insurance Plans��6�    	  TranslationName$ TableInsurancePlans��6�     5!      -   5        $ butOK��5!      $ butOK_Click��6�   $��Right=�6   $��78��69   $��Bottom=�6D   $��24��6_   $��0,0,15,8q�6k   $	 _OK��6}   6�     5"      -   5        $ butBlank��5"      $ butBlank_Click��6w   $��87��6    $��Bottom=�6+   $��24��6F   $��	427,0,0,8q�6R   $ 
Blank Plan��6e   6w   5#      5$      