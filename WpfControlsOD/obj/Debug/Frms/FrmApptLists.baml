   M S B A M L   `   `   `  ����H  DWpfControlsOD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OpenDental
OpenDental  5      /clr-namespace:WpfControls.UIWpfControls.UI  5          OpenDental.FrmApptLists   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      *localclr-namespace:OpenDental     5      +uiclr-namespace:WpfControls.UI     5      $	��666��5	      $	��494��6      OpenDental.FrmODBase    Text$  Appointment Lists��5
         MinMaxBoxes .  .��5      � ���	#FFFCFDFE.+�5   
      WpfControls.UI.Button  -   5          Name$ butInsVerify��5         WpfControls.UI.Button   Click$ butInsVerify_Click��6h   $	��100��6*   $��26��66   $��
28,386,0,0q�6B      Text$ 
Ins Verify��6V   6h      WpfControls.UI.Label  5   
   -   5          Name$ label8��5      $	��479��6#   $��47��6/   $��130,391,0,0q�6;      Text$B <A list of insurance verifications for upcoming appointments.��6P     5   
   -   5        $ butRadOrders��5      $ butRadOrders_Click��6g   $	��100��6*   $��26��66   $��
28,332,0,0q�6B   $ 	Radiology��6V   6g     5   
   -   5        $ label7��5      $	��479��6#   $��47��6/   $��130,324,0,0q�6;   $� �A list of radiology orders associated to appointments that have not been marked as CPOE.  This list allows providers to quickly approve radiology orders which will help meet EHR measures.��6P     5   
   -   5        $ butASAP��5      $ butASAP_Click��6]   $	��100��6%   $��26��61   $��
28,278,0,0q�6=   $
 ASAP��6Q   6]     5   
   -   5        $ label4��5      $	��491��6#   $��54��6/   $��130,269,0,0q�6;   $� �The short call list. A list of appointments and unscheduled recalls where the patient is available on short notice. To show this list, the "ASAP" checkbox must be checked on the appointment or on the Recalls for Patient.��6P     5   
   -   5        $ 
butUnsched��5      $ butUnsched_Click��6g   $	��100��6(   $��26��64   $��
28,224,0,0q�6@   $ Unscheduled��6T   6g     5   
   -   5        $ 
butPlanned��5      $ butPlanned_Click��6k   $	��100��6(   $��26��64   $��
28,170,0,0q�6@   $ Planned Tracker��6T   6k     5   
   -	   5        $ 
butConfirm��5      $ butConfirm_Click��6i   $	��100��6(   $��26��64   $��
28,116,0,0q�6@   $ Confirmations��6T   6i     5   
   -
   5        $ 	butRecall��5      $ butRecall_Click��6`   $	��100��6'   $��26��63   $��	28,62,0,0q�6?   $ Recall��6R   6`     5   
   -   5        $ label6��5      $	��519��6#   $��31��6/   $��	27,19,0,0q�6;   $� �These lists may be used for calling patients, sending postcards, running reports, etc..  Make sure to make good Commlog entries for everything.��6N      VAlign$ Bottom=�6�     5   
   -   5        $ label5��5      $	��479��6#   $��48��6/   $��130,216,0,0q�6;   $� �A short list of appointments that need to be followed up on.   Keep this list short by deleting any that don't get scheduled quickly.  You would then track them using the Planned Appointment Tracker.��6P     5   
   -   5        $ label3��5      $	��479��6#   $��47��6/   $��130,170,0,0q�6;   $� �Planned appointments are created in the Chart module.  Every patient should have one or be marked done.  This list is work that has been planned but never scheduled.��6P     5   
   -   5        $ label2��5      $	��479��6#   $��31��6/   $��130,114,0,0q�6;   $e _A list of scheduled appointments.  These patients need to be reminded about their appointments.��6P     5   
   -   5        $ label1��5      $	��479��6#   $��34��6/   $��
130,67,0,0q�6;   $[ UA list of due dates for patients who have previously been in for an exam or cleaning.��6O   5      5      