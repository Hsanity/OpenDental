   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  '    !OpenDental.FrmFamilyBalancerSetup   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��272��$	��297��   OpenDental.FrmODBase    Text$)  #Family Balancer Automation Settings��   MinMaxBoxes .  .��� ���	#FFFCFDFE.+�   WpfControls.UI.CheckBox  -     Name$ checkEnabled��$��	79,27,0,0q�   Text$ Enabled��   
CheckAlign$ MiddleRight=�$��90��$��20��  -   $ checkDeleteAll��$��
29,226,0,0q�$ Delete All Transfers��$ MiddleRight=�$	��140��$��20��   WpfControls.UI.GroupBox  -     Name$ groupChangedSince��$��84��$	��198��   Text$ Changed Since Date��$
��Left=�$��
36,131,0,0q�.@�   WpfControls.UI.TextVInt  -     Name$ textVIntDays��$��
147,48,0,0q�$��20�� J� RenderTransformOrigin$ 	0.898,0.8&�$��36��    WpfControls.UI.RadioButton  -   	  Name$	 radioLastRunDate��    WpfControls.UI.RadioButton
   Click$
 radioLastRunDate_Click��$��	12,27,0,0q�   
CheckAlign$ MiddleRight=�$��20��$	��121��   Text$ Last Run Date��  -   $	 radioDaysBefore��$
 radioDaysBefore_Click��$��8,48,0,0q�$ MiddleRight=�$��20��$	��125��$ Days Before Today��  -   $	 	radioFIFO��$��	69,79,0,0q�$ MiddleRight=�$��20��$ Use FIFO��$	��100��  -   $	 radioRigorous��$��	45,99,0,0q�$ MiddleRight=�$��20��$ Use Rigorous��$	��124��   WpfControls.UI.Button  -	     Name$ butSave��   WpfControls.UI.Button   Click$ butSave_Click��$��	0,0,10,10q�$��75��$��24��   Text$ _Save��$��Right=�$��Bottom=�	   WpfControls.UI.Label	  -
    	 Name$ labelTimeRun��$��	59,52,0,0q�$��97��$��20�� 	  HAlign$ Right=� 	  VAlign$ Center=� 	  Text$ Time to Run��
   WpfControls.UI.TextBox
  -    
 Name$ textTimeRun��$��
156,52,0,0q�$��78��$��20��