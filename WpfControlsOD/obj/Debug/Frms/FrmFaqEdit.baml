   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmFaqEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $
��1184��5	      $	��696��6      OpenDental.FrmODBase    Text$  FAQ Edit��5
      .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Label  -   5          Name$ label2��5      $	��100��6#   $��14��6/   $��
716,22,0,0q�6;      Text$ Preview��6O      VAlign$ Center=�6^      WpfControls.UI.WebBrowser  5   
   -   5          Name$ 
webPreview��5      $	��453��6,   $	��579��68   $��
719,41,0,0q�6E      WpfControls.UI.Button  5   
   -   5          Name$ 	butBullet��5         WpfControls.UI.Button   Click$ butBullet_Click��6^   $��55��6'   $��24��62   $��
278,35,0,0q�6>      Text$
 List��6R      BitmapFileName$ bullets_24x24.png��6v     5   
   -   5        $ butSave��5      $ butSave_Click��6_   $��75��6%   $��24��60   $��1097,658,0,0q�6<   $ _Save��6R   6_     5   
   -   5        $ 	butDelete��5      $ butDelete_Click��6`   $��75��6'   $��24��62   $��
18,656,0,0q�6>   $ Delete��6R   	   Icon$	 DeleteX=�6x      WpfControls.UI.ListBox  5   
   -   5        
  Name$
 listBoxLinkedPages��5      $	��186��61   $��99��6=   $��505,539,0,0q�6I     5   
   -   5        $ label3��5      $	��142��6#   $��18��6/   $��502,519,0,0q�6;   $ Linked Manual Pages��6P   $ Center=�6k     5   
   -   5        $ butLeft��5      $ butLeft_Click��6Y   $��35��6%   $��24��60   $��450,593,0,0q�6<   $  ��6Q   $	 	ArrowLeft=�6o     5   
   -	   5        $ butRight��5      $ butRight_Click��6Z   $��35��6&   $��24��61   $��450,563,0,0q�6=   $  ��6R   $	 
ArrowRight=�6q     5   
   -
   5        $
 listAvailableManualPages��5      $	��236��67   $��99��6C   $��195,539,0,0q�6O      WpfControls.UI.TextBox  5   
   -   5          Name$ textLinkPage��5      $	��139��6+   $��20��67   $��292,514,0,0q�6C     5   
   -   5        $ labelManualPageLink��5      $	��120��60   $��20��6<   $��171,514,0,0q�6H   $ Filter Page Names��6]      HAlign$ Right=�6v   $ Center=�6�     5   
   -   5        $ textEmbeddedMediaURL��5      $	��446��63   $��20��6?   $��195,485,0,0q�6K     5   
   -   5        $ labelEmbeddedMediaUrl��5      $	��176��62   $��21��6>   $��
16,485,0,0q�6J   $# Embedded Media URL (optional)��6^   $ Right=�6�   $ Center=�6�     5   
   -   5        $ textImagePath��5      $	��446��6,   $��20��68   $��195,461,0,0q�6D     5   
   -   5        $ labelImagePath��5      $	��120��6+   $��22��67   $��
71,460,0,0q�6C   $ Image URL (optional)��6W   $ Right=�6s   $ Center=�6�      WpfControls.UI.CheckBox  5   
   -   5          Name$ checkSticky��5      $	��113��6+   $��17��67   $��
96,439,0,0q�6C      Text$ Stickied to Top��6W      
CheckAlign$ MiddleRight=�6n     5   
   -   5        $ butVersionPick��5      $ butVersionPick_Click��6c   $��27��6,   $��20��67   $��296,416,0,0q�6C   $	 ...��6X   6c     5   
   -   5        $ textManualVersion��5      $	��100��60   $��20��6<   $��196,416,0,0q�6H      	ColorBack$ 	#FFF0F0F0��6]      ReadOnly . 6s     5   
   -   5        $ label1��5      $	��108��6#   $��21��6/   $��
81,415,0,0q�6;   $ Version��6O   $ Right=�6^   $ Center=�6m     5    
   -   5        $ buttonHyperlink��5       $ butHyperlink_Click��6f   $��64��6-   $��24��68   $��
339,35,0,0q�6D   $ a href��6X   $ ExternalLink.png��6�     5!   
   -   5        $ buttonUnderline��5!      $ butUnderline_Click��6b   $��24��6-   $��24��68   $��
248,35,0,0q�6D   $ _U��6X   6b     5"   
   -   5        $ buttonItalics��5"      $ butItalics_Click��6_   $��24��6+   $��24��66   $��
221,35,0,0q�6B   $ I��6V   $��Italic$�6x     5#   
   -   5        $ 
buttonBold��5#      $ butBold_Click��6\   $��24��6(   $��24��63   $��
194,35,0,0q�6?   $ B��6S   $
��Bold"�6r     5$   
   -   5        $ 
textAnswer��5$      $	��495��6)   $	��347��65   $��
195,62,0,0q�6B      IsMultiline . 6V     5%   
   -   5        $ labelAnswerText��5%      $	��115��6,   $��21��68   $��	77,56,0,0q�6D   $ Answer Content��6W   $ Right=�6m   $ Center=�6|     5&   
   -   5        $ textQuestion��5&      $	��365��6+   $��20��67   $��
194,11,0,0q�6C     5'   
   -   5        $ labelQuestion��5'      $	��100��6*   $��14��66   $��	92,14,0,0q�6B   $ Question Text��6U   $ Right=�6j   $ Center=�6y     5(   
   -   5        $ labelUserCreated��5(      $��56��6-   $��21��68   $��329,416,0,0q�6D   $ Created��6Y   $ Right=�6h   $ Center=�6w     5)   
   -   5        $ textUserCreated��5)      $	��100��6.   $��20��6:   $��385,416,0,0q�6F   $ 	#FFF0F0F0��6[    . 6q     5*   
   -   5        $ labelUserEdited��5*      $��56��6,   $��21��67   $��485,416,0,0q�6C   $ Edited��6X   $ Right=�6f   $ Center=�6u     5+   
   -    5        $ textUserEdited��5+      $	��100��6-   $��20��69   $��	0,416,0,0q�6E   $ 	#FFF0F0F0��6X    . $��Center=�6~   5,      5-      