   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  !    OpenDental.FrmInsPlanSelect   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��987��$	��696��   OpenDental.FrmODBase    Text$  Insurance Plans��.��� ���	#FFFCFDFE.+�   WpfControls.UI.GroupBox  -     Name$ 	groupBox1��$	��960��$��61��$��	12,12,0,0q�   Text$ Filter��.@�   WpfControls.UI.TextBox  -     Name$ textEmployer��$	��140��$��20��$��	84,14,0,0q�   WpfControls.UI.Button  -     Name$ 	butGetAll��   WpfControls.UI.Button   Click$ butGetAll_Click��$��75��$��24��$��
854,12,0,0q�   Text$ Get All��  -   $ textPlanNum��$	��140��$��20��$��
540,36,0,0q�   WpfControls.UI.Label  -     Name$ labelEmployer��$��76��$��17��$��6,16,0,0q�   Text$ Employer��	   HAlign$	 Right=�
   VAlign$
 Center=�   WpfControls.UI.CheckBox  -     Name$ checkShowHidden��$��93��$��20��$��
837,37,0,0q�   Text$ Show Hidden��   
CheckAlign$ MiddleRight=�  -   $ labelInsPlanID��$��81��$��17��$��
457,38,0,0q�$ Ins Plan ID��$	 Right=�$
 Center=�  -   $ textCarrier��$	��140��$��20��$��
311,15,0,0q�  -	   $ labelCarrier��$��79��$��17��$��
230,17,0,0q�$ Carrier��$	 Right=�$
 Center=�  -
   $ 	groupBox2��$	��148��$��44��$��
688,12,0,0q�$ Order By��.@�    WpfControls.UI.RadioButton  -     Name$ radioOrderCarrier��$��65��$��18��$��	80,15,0,0q�   Text$ Carrier��   
CheckAlign$ 
MiddleLeft=�  -   $ radioOrderEmp��$��77��$��18��$��6,15,0,0q�$ Employer��$ 
MiddleLeft=�   Checked .   -   $ textGroupName��$	��140��$��20��$��
311,36,0,0q�  -   $ textGroupNum��$	��140��$��20��$��	84,35,0,0q�  -   $ textTrojanID��$	��140��$��20��$��
540,15,0,0q�  -   $ labelGroupName��$��78��$��17��$��
231,36,0,0q�$ 
Group Name��$	 Right=�$
 Center=�  -   $ labelTrojanID��$��81��$��17��$��
457,18,0,0q�$ 	Trojan ID��$	 Right=�$
 Center=�  -   $ labelGroupNum��$��76��$��17��$��6,37,0,0q�$ 	Group Num��$	 Right=�$
 Center=�	   WpfControls.UI.Grid	  -    	 Name$ gridMain��$��Stretch=�$��Stretch=�$��11,79,15,39q� 	  HScrollVisible .  	  SelectionMode$ MultiExtended=� 	  Title$ Insurance Plans�� 	  TranslationName$ TableInsurancePlans��  -   $ butOK��$ butOK_Click��$��Right=�$��78��$��Bottom=�$��24��$��0,0,15,8q�$	 _OK��  -   $ butBlank��$ butBlank_Click��$��87��$��Bottom=�$��24��$��	427,0,0,8q�$ 
Blank Plan��