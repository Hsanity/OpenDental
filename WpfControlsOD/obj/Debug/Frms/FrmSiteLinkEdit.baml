   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5           OpenDental.FrmSiteLinkEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��725��5	      $	��587��6      OpenDental.FrmODBase    Text$  Site Link Edit��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.TextBox  -   5          Name$ textX��5      $��20��6$   $��28��60   $��
425,59,0,0q�6;      ReadOnly .    Text$ X��6_      HAlign$ Center=�6h      WpfControls.UI.Button  5   
   -   5          Name$ 
butDefault��5         WpfControls.UI.Button   Click$ ButDefault_Click��6}   $��Bottom=�6(   $��24��6C   $��75��6O   $��
342,0,0,12q�6Z      Text$ Default��6n   6}      WpfControls.UI.Grid  5   
   -   5          Name$ gridConnections��5      $��Stretch=�6+   $��Stretch=�6I   $��12,390,12,42q�6e   	   SelectionMode$	 OneCell=�6{   
   Title$
 Connection Overrides��6�      TranslationName$ TableConnectionOverrides��6�      WpfControls.UI.GroupBox  5   
   -   5          Name$ 	groupBox1��5      $	��216��6)   $	��256��66   $��224,168,0,0q�6B      Text$ Triage Counter Colors��6W   .@�5         WpfControls.UI.Panel  -   5          Name$ panelOpsCountPreview��5      $��
85,134,0,0q�65      	ColorBack$ 	#FFE0FFFF��6I      ColorBorder$ 	#FF0000FF��6_   $	��107��6w   $��70��6�   .@�5         WpfControls.UI.Label  -   5          Name$ labelOpsCountdownPreview��5      $��55��6=   $��66��6H   $��36,0,0,0q�6T      	ColorBack$ 	#FFE0FFFF��6f      Text$ 5��6|   $��48(�6�   $��Center=�6�   5        5      -   5        $ label10��5      $��	15,29,0,0q�6(   $ 
Fore Color��6;      HAlign$ Right=�6M      VAlign$ Center=�6\     5      -   5        $ label4��5      $��	15,63,0,0q�6'   $ Inner Color��6:   $ Right=�6M   $ Center=�6\     5      -	   5        $ label9��5      $��	15,97,0,0q�6'   $ Outer Color��6:   $ Right=�6M   $ Center=�6\     5      -
   5        $ panelInnerColor��5      $��24��60   $��24��6<   $��	86,59,0,0q�6G   $ 	#FF404040��6Z   5        5      -   5        $ butChangeColorInner��5      $ butChangeInnerColor_Click��6n   $��24��65   $��75��6A   $��
118,59,0,0q�6L   $ Change��6`   6n     5      -   5        $ butChangeForeColor��5      $ butChangeForeColor_Click��6m   $��24��64   $��75��6@   $��
118,25,0,0q�6K   $ Change��6_   6m     5      -   5        $ panelOuterColor��5      $��24��60   $��24��6<   $��	86,93,0,0q�6G   $ 	#FF404040��6Z   5        5      -   5        $ panelForeColor��5      $��24��6/   $��24��6;   $��	86,25,0,0q�6F   $ 	#FF404040��6Y   5        5      -   5        $ butChangeColorOuter��5      $ butChangeOuterColor_Click��6n   $��24��65   $��75��6A   $��
118,93,0,0q�6L   $ Change��6`   6n   5        5    
   -   5        $ label12��5       $��16��6$   $��422,135,0,0q�60   $" (escalation highlight color)��6E   $ Center=�6i     5!   
   -   5        $ butChangeSiteColor��5!      $ butChangeSiteColor_Click��6j   $��24��60   $��75��6<   $��341,131,0,0q�6G   $ Change��6\   6j     5"   
   -   5        $ panelSiteColor��5"      $��24��6+   $��24��67   $��309,131,0,0q�6B   $ 	#FF404040��6W   5#        5$   
   -   5        $ label11��5$      $��16��6$   $��
85,139,0,0q�60   $ 
Site Color��6D   $ Right=�6V   $ Center=�6e   $	��219��6u     5%   
   -   5        $ textSite��5%      $��20��6'   $	��144��63   $��
309,21,0,0q�6?      	ColorBack$ 	#FFF0F0F0��6S    . 6i   	   WpfControls.UI.ComboBox	  5&   
   -   5         	 Name$ comboTriageCoordinator��5&      $��21��66   $	��144��6B   $��
309,97,0,0q�6N     5'   
   -   5        $ label7��5'      $��16��6#   $��
29,100,0,0q�6/   $ Triage Coordinator��6C   $ Right=�6]   $ Center=�6l   $	��275��6|     5(   
   -   5        $ label6��5(      $��16��6#   $��
415,61,0,0q�6/   $ .��6C   $ Center=�6L   $ Center=�6\     5)   
   -   5        $ label5��5)      $��16��6#   $��
377,61,0,0q�6/   $ .��6C   $ Center=�6L   $ Center=�6\     5*   
   -   5        $ label1��5*      $��16��6#   $��	12,61,0,0q�6/   $% Starting Default Gateway Octets��6B   $ Right=�6i   $ Center=�6x   $	��292��6�     5+   
   -   5        $ 
textOctet2��5+      $��20��6)   $��28��65   $��
347,59,0,0q�6@      
TabIndexOD$ 1��6T     5,   
   -   5        $ 
textOctet3��5,      $��20��6)   $��28��65   $��
385,59,0,0q�6@   $ 2��6T     5-   
   -   5        $ 
textOctet1��5-      $��20��6)   $��28��65   $��
309,59,0,0q�6@   $ 0��6T     5.   
   -   5        $ label8��5.      $��16��6#   $��	94,25,0,0q�6/   $
 Site��6B   $ Right=�6N   $ Center=�6]   $	��210��6m     5/   
   -   5        $ butSave��5/      $ butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��	0,0,12,12q�6s   $ _Save��6�   6�     50   
   -   5        $ label3��50      $��16��6#   $��
338,61,0,0q�6/   $ .��6C   $ Center=�6L   $ Center=�6\   51      52      