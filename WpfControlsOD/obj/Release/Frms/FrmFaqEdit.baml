   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI      OpenDental.FrmFaqEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $
��1184��$	��696��   OpenDental.FrmODBase    Text$  FAQ Edit��.��� ���	#FFFCFDFE.+�   WpfControls.UI.Label  -     Name$ label2��$	��100��$��14��$��
716,22,0,0q�   Text$ Preview��   VAlign$ Center=�   WpfControls.UI.WebBrowser  -     Name$ 
webPreview��$	��453��$	��579��$��
719,41,0,0q�   WpfControls.UI.Button  -     Name$ 	butBullet��   WpfControls.UI.Button   Click$ butBullet_Click��$��55��$��24��$��
278,35,0,0q�   Text$
 List��   BitmapFileName$ bullets_24x24.png��  -   $ butSave��$ butSave_Click��$��75��$��24��$��1097,658,0,0q�$ _Save��  -   $ 	butDelete��$ butDelete_Click��$��75��$��24��$��
18,656,0,0q�$ Delete��	   Icon$	 DeleteX=�   WpfControls.UI.ListBox  -   
  Name$
 listBoxLinkedPages��$	��186��$��99��$��505,539,0,0q�  -   $ label3��$	��142��$��18��$��502,519,0,0q�$ Linked Manual Pages��$ Center=�  -   $ butLeft��$ butLeft_Click��$��35��$��24��$��450,593,0,0q�$  ��$	 	ArrowLeft=�  -	   $ butRight��$ butRight_Click��$��35��$��24��$��450,563,0,0q�$  ��$	 
ArrowRight=�  -
   $
 listAvailableManualPages��$	��236��$��99��$��195,539,0,0q�   WpfControls.UI.TextBox  -     Name$ textLinkPage��$	��139��$��20��$��292,514,0,0q�  -   $ labelManualPageLink��$	��120��$��20��$��171,514,0,0q�$ Filter Page Names��   HAlign$ Right=�$ Center=�  -   $ textEmbeddedMediaURL��$	��446��$��20��$��195,485,0,0q�  -   $ labelEmbeddedMediaUrl��$	��176��$��21��$��
16,485,0,0q�$# Embedded Media URL (optional)��$ Right=�$ Center=�  -   $ textImagePath��$	��446��$��20��$��195,461,0,0q�  -   $ labelImagePath��$	��120��$��22��$��
71,460,0,0q�$ Image URL (optional)��$ Right=�$ Center=�   WpfControls.UI.CheckBox  -     Name$ checkSticky��$	��113��$��17��$��
96,439,0,0q�   Text$ Stickied to Top��   
CheckAlign$ MiddleRight=�  -   $ butVersionPick��$ butVersionPick_Click��$��27��$��20��$��296,416,0,0q�$	 ...��  -   $ textManualVersion��$	��100��$��20��$��196,416,0,0q�   	ColorBack$ 	#FFF0F0F0��   ReadOnly .   -   $ label1��$	��108��$��21��$��
81,415,0,0q�$ Version��$ Right=�$ Center=�  -   $ buttonHyperlink��$ butHyperlink_Click��$��64��$��24��$��
339,35,0,0q�$ a href��$ ExternalLink.png��  -   $ buttonUnderline��$ butUnderline_Click��$��24��$��24��$��
248,35,0,0q�$ _U��  -   $ buttonItalics��$ butItalics_Click��$��24��$��24��$��
221,35,0,0q�$ I��$��Italic$�  -   $ 
buttonBold��$ butBold_Click��$��24��$��24��$��
194,35,0,0q�$ B��$
��Bold"�  -   $ 
textAnswer��$	��495��$	��347��$��
195,62,0,0q�   IsMultiline .   -   $ labelAnswerText��$	��115��$��21��$��	77,56,0,0q�$ Answer Content��$ Right=�$ Center=�  -   $ textQuestion��$	��365��$��20��$��
194,11,0,0q�  -   $ labelQuestion��$	��100��$��14��$��	92,14,0,0q�$ Question Text��$ Right=�$ Center=�  -   $ labelUserCreated��$��56��$��21��$��329,416,0,0q�$ Created��$ Right=�$ Center=�  -   $ textUserCreated��$	��100��$��20��$��385,416,0,0q�$ 	#FFF0F0F0�� .   -   $ labelUserEdited��$��56��$��21��$��485,416,0,0q�$ Edited��$ Right=�$ Center=�  -    $ textUserEdited��$	��100��$��20��$��	0,416,0,0q�$ 	#FFF0F0F0�� . $��Center=�