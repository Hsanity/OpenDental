   M S B A M L   `   `   `  ���� H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  /clr-namespace:WpfControls.UIWpfControls.UI  "    OpenDental.FrmBackupReminder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OpenDental     +uiclr-namespace:WpfControls.UI     $	��612��$	��487��   OpenDental.FrmODBase    Text$  Backup Reminder��.��� ���	#FFFCFDFE.+�   WpfControls.UI.Label  -     Name$! labelSupplementalBackupPath��$	��463��$��32��$��
42,429,0,0q�   	ColorText$ 	#FFFF0000��   Text$� zWarning:  your Supplemental Backup Network Path is not set. It must be set in order to store Supplemental Backups locally.��  -   $% labelSupplementalBackupDisabled��$	��463��$��32��$��
42,392,0,0q�$ 	#FFFF0000��$� �Warning:  your Supplemental Backups are disabled, using Supplemental Backups in addition to your own backups is strongly recommended.��   WpfControls.UI.CheckBox  -     Name$ checkNoStrategy��$	��250��$��21��$��
45,369,0,0q�   Text$ No strategy��   
CheckAlign$ 
MiddleLeft=�  -   $" checkSecondaryMethodHardCopy��$	��312��$��21��$��
45,349,0,0q�$" Saved hardcopy paper reports��$ 
MiddleLeft=�  -   $! checkSecondaryMethodArchive��$	��352��$��21��$��
45,329,0,0q�$@ :Completely separate archives stored offsite (DVD, HD, etc)��$ 
MiddleLeft=�  -   $ labelStrategy��$	��523��$��18��$��
42,313,0,0q�$P JWhat secondary long-term mechanism do you use to ensure minimal data loss?��  -   $ checkNoProof��$	��250��$��21��$��
45,281,0,0q�$ No proof��$ 
MiddleLeft=�  -   $ checkRestoreServer��$	��250��$��21��$��
45,261,0,0q�$% Run backup from a second server��$ 
MiddleLeft=�  -	   $ checkRestoreHome��$	��352��$��21��$��
45,241,0,0q�$3 -Restore to home computer at least once a week��$ 
MiddleLeft=�  -
   $ 
labelProof��$	��523��$��18��$��
42,225,0,0q�$? 9What proof do you have that your recent backups are good?��  -   $ checkBackupMethodOther��$	��151��$��21��$��
45,171,0,0q�$ Other backup method��$ 
MiddleLeft=�  -   $ checkBackupMethodNetwork��$	��302��$��21��$��
45,151,0,0q�$2 ,Network (to another computer in your office)��$ 
MiddleLeft=�  -   $  checkBackupMethodRemovable��$	��530��$��21��$��
45,131,0,0q�$- 'Removable (external HD, USB drive, etc)��$ 
MiddleLeft=�  -   $ checkBackupMethodOnline��$	��200��$��21��$��
45,111,0,0q�$ Online��$ 
MiddleLeft=�  -   $ labelBackupMethod��$	��523��$��18��$��	42,95,0,0q�$; 5Do you make backups every single day?  Backup method:��  -   $ checkNoBackups��$	��151��$��21��$��
45,191,0,0q�$ 
No backups��$ 
MiddleLeft=�  -   $ labelDescription��$	��552��$��74��$��12,9,0,0q�$� �You must answer these questions in order to continue. You will be seeing this window once every month as a reminder of the importance of good backups. If someone else is in charge of backups, ask them for the answers. If your supervisor is not available, and you need to get through this window, it's OK to guess. But in that case, you must followup with your supervisor to ensure they are making good backups.��   WpfControls.UI.Button  -     Name$ butSave��   WpfControls.UI.Button   Click$ butSave_Click��$��Right=�$��75��$��Bottom=�$��24��$��	0,0,12,12q�	   Text$	 _Save��