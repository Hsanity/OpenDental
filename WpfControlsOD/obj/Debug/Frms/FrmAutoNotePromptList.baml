   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      &     OpenDental.FrmAutoNotePromptList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��530��5	      $	��361��6      OpenDental.FrmODBase    Text$  Prompt List��5
      |�. .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Button  -   5          Name$ butNext��5         WpfControls.UI.Button   Click$ butNext_Click��6�   $��Right=�6%   $��77��6A   $��Bottom=�6L   $��24��6g   $��	0,0,16,57q�6s      Text$ _Next��6�      Icon$ 
ArrowRight=�6�      
ImageAlign$ Right=�6�     5   
   -   5        $ butBack��5      $ butBack_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��
0,0,275,57q�6s   $ _Back��6�   $ 	ArrowLeft=�6�     5   
   -   5        $ 
butPreview��5      $ butPreview_Click��6�   $��Right=�6(   $��75��6D   $��Bottom=�6O   $��24��6j   $��
0,0,197,57q�6v   $ _Preview��6�   6�     5   
   -   5        $ butSelectAll��5      $ butSelectAll_Click��6�   $��Right=�6*   $��75��6F   $��Bottom=�6Q   $��20��6l   $��
0,0,96,293q�6x   $ Select _All��6�   6�     5   
   -   5        $ butSelectNone��5      $ butSelectNone_Click��6�   $��Right=�6+   $��75��6G   $��Bottom=�6R   $��20��6m   $��
0,0,16,293q�6y   $ Select N_one��6�   6�     5   
   -   5        $ butRemovePrompt��5      $ butRemovePrompt_Click��6�   $��Right=�6-   $��98��6I   $��Bottom=�6T   $��24��6o   $��	0,0,96,57q�6{   $ _Remove Prompt��6�   6�      WpfControls.UI.ListBox  5   
   -   5          Name$ listMain��5      $��Stretch=�6'   $��Stretch=�6E   $��11,70,16,87q�6a   |�. 6v      WpfControls.UI.Label  5   
   -   5          Name$ labelPrompt��5      $��Stretch=�6(   $��44��6F   $��	12,2,10,0q�6R      Text$ Prompt
Line 2
Line3��6e   	   VAlign$	 Bottom=�6�   
   IsWrap
 . 6�     5   
   -	   5        $ butExit��5      $ butExit_Click��6�   $��Right=�6%   $��75��6A   $��Bottom=�6L   $��24��6g   $��	0,0,16,10q�6s   $ _Exit��6�   6�   5      5      