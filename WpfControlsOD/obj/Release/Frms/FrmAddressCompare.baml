   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  "    OpenDental.FrmAddressCompare   "localclr-namespace:OpenDental  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +UIclr-namespace:WpfControls.UI        OpenDental.FrmODBase    Text$  Address Compare��$	��265��$	��602��.��� 
�������.+�   WpfControls.UI.Label  -     Name$ labelUserAddress��$��18��$��3,66,0,0q�$��83��   Text$ Address��   IsWrap .    HAlign$ Right=�  -   $ labelUserEntered��$��18��$��	91,39,0,0q�$	��184��$ User Entered Address��  -   $ labelUSPSReccomended��$��18��$��
351,39,0,0q�$	��249��$! Address Reccomended By USPS��  -   $ labelHeading��$��18��$��0,3,0,0q�$	��597��$i cThe United States Postal Service has recommended the following changes to the address you provided.��$ Center=�$��Center=�   WpfControls.UI.Button  -     Name$ butYes��   WpfControls.UI.Button   Click$ butYes_Click��$��74��$��Bottom=�$��24��$��
394,0,0,16q�   Text$	 Yes��$��1��  -   $ butNo��$ butNo_Click��$��76��$��Bottom=�$��24��$��
125,0,0,16q�$ No��$��2��  -   $ labelQuestion��$��18��$��
22,198,0,0q�$	��562��$[ UWould you like to accept the changes recommended by the United States Postal Service?��$ Center=�  -   $ labelUserCity��$��18��$��	3,110,0,0q�$��83��$
 City�� . $ Right=�  -	   $ labelUserState��$��18��$��	3,131,0,0q�$��83��$ State�� . $ Right=�  -
   $ labelUserZIP��$��18��$��	3,151,0,0q�$��83��$ ZIP-Code�� . $ Right=�  -   $ labelDeliverabilityStatus��$��18��$��
54,175,0,0q�$	��500��$1 +This is where warnings from USPS will show.�� . 
���""��   WpfControls.UI.TextBox  -     Name$ textAddressUser��$	��156��$��20��$��	91,66,0,0q�	   Text$	  ��
   ReadOnly
 .   -   $ textCityUser��$	��156��$��20��$��
91,108,0,0q�$	  ��
 .   -   $ textStateUser��$	��156��$��20��$��
91,129,0,0q�$	  ��
 .   -   $ textZIPUser��$	��156��$��20��$��
91,150,0,0q�$	  ��
 .   -   $ labelUSPSAddress��$��18��$��
263,66,0,0q�$��83��$ Address�� . $ Right=�  -   $ labelUSPSCity��$��18��$��263,110,0,0q�$��83��$
 City�� . $ Right=�  -   $ labelUSPSState��$��18��$��263,131,0,0q�$��83��$ State�� . $ Right=�  -   $ labelUSPSZIP��$��18��$��263,151,0,0q�$��83��$ ZIP-Code�� . $ Right=�  -   $ textAddressUSPS��$	��156��$��20��$��
351,66,0,0q�$	  ��
 .   -   $ textCityUSPS��$	��156��$��20��$��351,108,0,0q�$	  ��
 .   -   $ textStateUSPS��$	��156��$��20��$��351,129,0,0q�$	  ��
 .   -   $ textZIPUSPS��$	��156��$��20��$��351,150,0,0q�$	  ��
 .   -   $ labelUserAddress2��$��18��$��3,87,0,0q�$��83��$ Address2�� . $ Right=�  -   $ textAddress2User��$	��156��$��20��$��	91,87,0,0q�$	  ��
 .   -   $ labelUSPSAddress2��$��18��$��
263,87,0,0q�$��83��$ Address2�� . $ Right=�  -   $ textAddress2USPS��$	��156��$��20��$��
351,87,0,0q�$	  ��
 . 