   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5      "    OpenDental.FrmBackupReminder   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��612��5	      $	��487��6      OpenDental.FrmODBase    Text$  Backup Reminder��5
      .��5      � ���	#FFFCFDFE.+�5         WpfControls.UI.Label  -   5          Name$! labelSupplementalBackupPath��5      $	��463��62   $��32��6>   $��
42,429,0,0q�6J      	ColorText$ 	#FFFF0000��6^      Text$� zWarning:  your Supplemental Backup Network Path is not set. It must be set in order to store Supplemental Backups locally.��6t     5      -   5        $% labelSupplementalBackupDisabled��5      $	��463��66   $��32��6B   $��
42,392,0,0q�6N   $ 	#FFFF0000��6b   $� �Warning:  your Supplemental Backups are disabled, using Supplemental Backups in addition to your own backups is strongly recommended.��6x      WpfControls.UI.CheckBox  5      -   5          Name$ checkNoStrategy��5      $	��250��6)   $��21��65   $��
45,369,0,0q�6A      Text$ No strategy��6U      
CheckAlign$ 
MiddleLeft=�6h     5      -   5        $" checkSecondaryMethodHardCopy��5      $	��312��66   $��21��6B   $��
45,349,0,0q�6N   $" Saved hardcopy paper reports��6b   $ 
MiddleLeft=�6�     5      -   5        $! checkSecondaryMethodArchive��5      $	��352��65   $��21��6A   $��
45,329,0,0q�6M   $@ :Completely separate archives stored offsite (DVD, HD, etc)��6a   $ 
MiddleLeft=�6�     5      -   5        $ labelStrategy��5      $	��523��6$   $��18��60   $��
42,313,0,0q�6<   $P JWhat secondary long-term mechanism do you use to ensure minimal data loss?��6P     5      -   5        $ checkNoProof��5      $	��250��6&   $��21��62   $��
45,281,0,0q�6>   $ No proof��6R   $ 
MiddleLeft=�6b     5      -   5        $ checkRestoreServer��5      $	��250��6,   $��21��68   $��
45,261,0,0q�6D   $% Run backup from a second server��6X   $ 
MiddleLeft=�6     5      -	   5        $ checkRestoreHome��5      $	��352��6*   $��21��66   $��
45,241,0,0q�6B   $3 -Restore to home computer at least once a week��6V   $ 
MiddleLeft=�6�     5      -
   5        $ 
labelProof��5      $	��523��6!   $��18��6-   $��
42,225,0,0q�69   $? 9What proof do you have that your recent backups are good?��6M     5      -   5        $ checkBackupMethodOther��5      $	��151��60   $��21��6<   $��
45,171,0,0q�6H   $ Other backup method��6\   $ 
MiddleLeft=�6w     5      -   5        $ checkBackupMethodNetwork��5      $	��302��62   $��21��6>   $��
45,151,0,0q�6J   $2 ,Network (to another computer in your office)��6^   $ 
MiddleLeft=�6�     5      -   5        $  checkBackupMethodRemovable��5      $	��530��64   $��21��6@   $��
45,131,0,0q�6L   $- 'Removable (external HD, USB drive, etc)��6`   $ 
MiddleLeft=�6�     5      -   5        $ checkBackupMethodOnline��5      $	��200��61   $��21��6=   $��
45,111,0,0q�6I   $ Online��6]   $ 
MiddleLeft=�6k     5      -   5        $ labelBackupMethod��5      $	��523��6(   $��18��64   $��	42,95,0,0q�6@   $; 5Do you make backups every single day?  Backup method:��6S     5      -   5        $ checkNoBackups��5      $	��151��6(   $��21��64   $��
45,191,0,0q�6@   $ 
No backups��6T   $ 
MiddleLeft=�6f     5      -   5        $ labelDescription��5      $	��552��6'   $��74��63   $��12,9,0,0q�6?   $� �You must answer these questions in order to continue. You will be seeing this window once every month as a reminder of the importance of good backups. If someone else is in charge of backups, ask them for the answers. If your supervisor is not available, and you need to get through this window, it's OK to guess. But in that case, you must followup with your supervisor to ensure they are making good backups.��6Q      WpfControls.UI.Button  5!      -   5          Name$ butSave��5!         WpfControls.UI.Button   Click$ butSave_Click��6�   $��Right=�6   $��75��6;   $��Bottom=�6F   $��24��6a   $��	0,0,12,12q�6m   	   Text$	 _Save��6�   6�   5"      5#      