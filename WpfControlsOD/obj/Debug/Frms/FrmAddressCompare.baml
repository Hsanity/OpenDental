   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      "    OpenDental.FrmAddressCompare   5      "localclr-namespace:OpenDental  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +UIclr-namespace:WpfControls.UI     5         OpenDental.FrmODBase    Text$  Address Compare��5
      $	��265��5      $	��602��6   .��5      � 
�������.+�5         WpfControls.UI.Label  -   5          Name$ labelUserAddress��5      $��18��6'   $��3,66,0,0q�63   $��83��6E      Text$ Address��5         IsWrap .    HAlign$ Right=�6      5      -   5        $ labelUserEntered��5      $��18��6'   $��	91,39,0,0q�63   $	��184��6F   $ User Entered Address��6R     5      -   5        $ labelUSPSReccomended��5      $��18��6+   $��
351,39,0,0q�67   $	��249��6K   $! Address Reccomended By USPS��6W     5      -   5        $ labelHeading��5      $��18��6#   $��0,3,0,0q�6/   $	��597��6@   $i cThe United States Postal Service has recommended the following changes to the address you provided.��6L   $ Center=�6�   $��Center=�6�      WpfControls.UI.Button  5      -   5          Name$ butYes��5         WpfControls.UI.Button   Click$ butYes_Click��6o   $��74��6   $��Bottom=�6)   $��24��6D   $��
394,0,0,16q�6P      Text$	 Yes��6d   $��1��6�     5      -   5        $ butNo��5      $ butNo_Click��6m   $��76��6   $��Bottom=�6(   $��24��6C   $��
125,0,0,16q�6O   $ No��6c   $��2��6�     5      -   5        $ labelQuestion��5      $��18��6$   $��
22,198,0,0q�60   $	��562��6D   $[ UWould you like to accept the changes recommended by the United States Postal Service?��6P   $ Center=�6�     5      -   5        $ labelUserCity��5      $��18��6$   $��	3,110,0,0q�60   $��83��6C   $
 City��5       . $ Right=�6     5      -	   5        $ labelUserState��5      $��18��6%   $��	3,131,0,0q�61   $��83��6D   $ State��5       . $ Right=�6     5      -
   5        $ labelUserZIP��5      $��18��6#   $��	3,151,0,0q�6/   $��83��6B   $ ZIP-Code��5       . $ Right=�6"     5      -   5        $ labelDeliverabilityStatus��5      $��18��60   $��
54,175,0,0q�6<   $	��500��6P   $1 +This is where warnings from USPS will show.��5       . 
���""��6E      WpfControls.UI.TextBox  5      -   5          Name$ textAddressUser��5      $	��156��6(   $��20��64   $��	91,66,0,0q�6@   	   Text$	  ��6S   
   ReadOnly
 . 6[     5      -   5        $ textCityUser��5      $	��156��6%   $��20��61   $��
91,108,0,0q�6=   $	  ��6Q   
 . 6Y     5      -   5        $ textStateUser��5      $	��156��6&   $��20��62   $��
91,129,0,0q�6>   $	  ��6R   
 . 6Z     5       -   5        $ textZIPUser��5       $	��156��6$   $��20��60   $��
91,150,0,0q�6<   $	  ��6P   
 . 6X     5!      -   5        $ labelUSPSAddress��5!      $��18��6'   $��
263,66,0,0q�63   $��83��6G   $ Address��5"       . $ Right=�6!     5#      -   5        $ labelUSPSCity��5#      $��18��6$   $��263,110,0,0q�60   $��83��6E   $
 City��5$       . $ Right=�6     5%      -   5        $ labelUSPSState��5%      $��18��6%   $��263,131,0,0q�61   $��83��6F   $ State��5&       . $ Right=�6     5'      -   5        $ labelUSPSZIP��5'      $��18��6#   $��263,151,0,0q�6/   $��83��6D   $ ZIP-Code��5(       . $ Right=�6"     5)      -   5        $ textAddressUSPS��5)      $	��156��6(   $��20��64   $��
351,66,0,0q�6@   $	  ��6T   
 . 6\     5*      -   5        $ textCityUSPS��5*      $	��156��6%   $��20��61   $��351,108,0,0q�6=   $	  ��6R   
 . 6Z     5+      -   5        $ textStateUSPS��5+      $	��156��6&   $��20��62   $��351,129,0,0q�6>   $	  ��6S   
 . 6[     5,      -   5        $ textZIPUSPS��5,      $	��156��6$   $��20��60   $��351,150,0,0q�6<   $	  ��6Q   
 . 6Y     5-      -   5        $ labelUserAddress2��5-      $��18��6(   $��3,87,0,0q�64   $��83��6F   $ Address2��5.       . $ Right=�6"     5/      -   5        $ textAddress2User��5/      $	��156��6)   $��20��65   $��	91,87,0,0q�6A   $	  ��6T   
 . 6\     50      -   5        $ labelUSPSAddress2��50      $��18��6(   $��
263,87,0,0q�64   $��83��6H   $ Address2��51       . $ Right=�6"     52      -   5        $ textAddress2USPS��52      $	��156��6)   $��20��65   $��
351,87,0,0q�6A   $	  ��6U   
 . 6]   53      54      