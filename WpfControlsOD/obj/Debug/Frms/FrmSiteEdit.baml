   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmSiteEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��508��5	      $	��401��6      OpenDental.FrmODBase    Text$  	Edit Site��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Button  -   5          Name$ butPickProvider��5         WpfControls.UI.Button   Click$ butPickProvider_Click��6c   $��20��6-   $��22��68   $��
399,65,0,0q�6D      Text$	 ...��6X   6c     5   
   -   5        $ butSiteLink��5      $ butSiteLink_Click��6�   $��Right=�6)   $��75��6E   $��Bottom=�6P   $��26��6k   $��
0,0,170,12q�6w   $ 	Site Link��6�   6�      WpfControls.UI.Label  5   
   -   5          Name$ labelPriProv��5      $	��145��6)   $��14��65   $��	19,70,0,0q�6A      Text$ Provider��6T      HAlign$ Right=�6d      WpfControls.UI.ComboBox  5   
   -   5          Name$ 	comboProv��5      $	��230��6)   $��21��65   $��
165,66,0,0q�6A     5   
   -   5        $ label2��5      $	��148��6#   $��17��6/   $��	16,40,0,0q�6;   $ Place of Service��6N   $ Right=�6f   	   VAlign$	 Center=�6u     5   
   -   5        $ comboPlaceService��5      $	��254��61   $��21��6=   $��
165,39,0,0q�6I     5   
   -   5        $ 
butEditZip��5      $ butEditZip_Click��6e   $��73��6(   $��22��63   $��346,188,0,0q�6?   $ 	_Edit Zip��6T   6e      WpfControls.UI.TextBox  5   
   -   5        
  Name$
 textZip��5      $	��164��6&   $��20��62   $��165,189,0,0q�6>      
TabIndexOD$ 9��6S    K� ZIndex$ 1��6b     5   
   -	   5        $ comboZip��5      $	��178��6(   $��20��64   $��	0,189,0,0q�6@   $��Center=�6S     5   
   -
   5        $
 	textState��5      $��61��6(   $��20��63   $��165,165,0,0q�6?   $ 8��6T     5   
   -   5        $ labelST��5      $	��145��6$   $��14��60   $��
19,169,0,0q�6<   $ ST��6P   $ Right=�6Z     5   
   -   5        $
 textAddress��5      $	��254��6*   $��20��66   $��
165,93,0,0q�6B   $ 5��6V     5   
   -   5        $ labelAddress2��5      $	��145��6*   $��14��66   $��
19,121,0,0q�6B   $ Address2��6V   $ Right=�6f     5   
   -   5        $ 	labelCity��5      $	��145��6&   $��14��62   $��
19,145,0,0q�6>   $
 City��6R   $ Right=�6^     5   
   -   5        $
 textAddress2��5      $	��254��6+   $��20��67   $��165,117,0,0q�6C   $ 6��6X     5   
   -   5        $ labelZip��5      $	��145��6%   $��14��61   $��
19,193,0,0q�6=   $	 Zip��6Q   $ Right=�6\     5   
   -   5        $
 textCity��5      $	��254��6'   $��20��63   $��165,141,0,0q�6?   $ 7��6T     5   
   -   5        $ labelAddress��5      $	��145��6)   $��14��65   $��	19,97,0,0q�6A   $ Address��6T   $ Right=�6c     5   
   -   5        $
 textNote��5      $	��254��6'   $	��144��63   $��165,214,0,0q�6@      IsMultiline . $ 11��6h     5   
   -   5        $ label3��5      $	��144��6#   $��17��6/   $��
19,216,0,0q�6;   $
 Note��6O   $ Right=�6[     5    
   -   5        $ 	butDelete��5       $ butDelete_Click��6�   $��81��6'   $��Bottom=�62   $��26��6M   $��	12,0,0,12q�6Y   $ Delete��6l      Icon$ DeleteX=�6z   6�     5!   
   -   5        $
 textDescription��5!      $	��254��6.   $��20��6:   $��
165,15,0,0q�6F   $ 0��6Z     5"   
   -   5        $ butSave��5"      $ butSave_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��26��6g   $��	0,0,12,12q�6s   $ _Save��6�   6�     5#   
   -   5        $ label1��5#      $	��148��6#   $��17��6/   $��	16,15,0,0q�6;   $ Description��6N   $ Right=�6a   $	 Center=�6p   5$      5%      