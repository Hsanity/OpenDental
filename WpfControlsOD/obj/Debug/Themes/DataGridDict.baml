   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridStyleOD  �� 
TargetType&     System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions � RowDefinitions	    SelectAllCommand
 �� 
ResourceId �� TypeInTargetAssembly7   1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG   ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value �� Mode �� ScrollableWidth,  �� %ComputedHorizontalScrollBarVisibility! �� ViewportWidth" �� Triggers# ]� 
Conditions$ �� Property% �� Value  DataGridColumnHeaderOD=   7System.Windows.Controls.Primitives.DataGridColumnHeader& ��Name  DataGridRowStyleOD)   #System.Windows.Controls.DataGridRow?   9System.Windows.Controls.Primitives.SelectiveScrollingGrid?   9System.Windows.Controls.Primitives.DataGridCellsPresenter'   
ItemsPanelA   ;System.Windows.Controls.Primitives.DataGridDetailsPresenter(   DetailsVisibility$)   SelectiveScrollingOrientation;   5System.Windows.Controls.SelectiveScrollingOrientation*   Vertical#+    RowDetailsScrollingConverter:	   4System.Windows.Controls.Primitives.DataGridRowHeader
,   Row- P� Property. P� Value  DataGridCellStyleOD*
   $System.Windows.Controls.DataGridCell/ �� Triggers0 �� 
TargetName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	 �    &	 
    &	 .    �� 5      "    6!   .�5      ��  � ��
 �����6!   �� 5       � ��# � ��6!   �� 5       � �� �	#FF688CAF6"   �� 5       � ��$ 1q�6&   �� 5	        �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�6/   �� 5
       � �� . 64   �� 5       �@��PanningMode$
 Both=�6/   �� 5       �@��IsFlicksEnabled .  6-   �� 5       � �� 5      �� 5      "   6   .R�5      �� #��z��6   #��z��6:   #��z��6n   # z��6�    . ._�5      �� $ DG_ScrollViewer��6   |�.  ��5   	   �� 5   
   " ��6   .R�5      �  5      �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    5      �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5      �� #��Z	 6   |�.  ��6T   C� *�� $"
 DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5       $! PART_ColumnHeadersPresenter��6+   $��1��6P   y�6`   �� *HeadersVisibility+# Z # Z  �� "   �� 5!      $��2��6   ���#DFEAF5$��0,0,0,1q�68   
�������6R   �� 5"      $! PART_ScrollContentPresenter��6#   # z��6H   $��2��6~   $��1��6�   �� 5#      $ PART_VerticalScrollBar��6   $��2��66   # z 6F   $ Vertical=�6s   $��1��6�   #y�z 6�   # z 69   6�   �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+69  � 5$      $��1��6   $��2��6!    5%      �� 5&      ��6   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5'      $��* �6   .+�5)      �� $ PART_HorizontalScrollBar��6   $��1��69   # z 6I   $ 
Horizontal=�6u   #y�z  6�   # z! 64   6�   �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+64  5*      5+      5,      .��5.   	   �� # z 6   5/   	   50      51      53      " 54      ]� 55      # 56      �� 57      $ �@��
IsGrouping% . 6'   �� 58      "$ �@%�IsVirtualizingWhenGrouping% .  6I   ./�5:      ��  � �� .  66   5;      5=      �� 5>      "   6(   .�5@      ��  � ��$
 Bold"�6!   �� 5A       � �� 5B      �� 5C      "  6   .R�5D      � .+�5E      �� $& columnHeaderBorder��6   $��0,0,1,1q�6+   
����������#DFEAF5._�5F   	   �� $��Center=�6   $��Center=�67   # z 5G      5H   	   5I      5J      5L      5M      �� 5N      "   6$   .�5P      ��  �@J�SnapsToDevicePixels . 6*   �� 5Q       �@=�ErrorTemplate 6/   Z� �� 5R       �@ ValidationErrorTemplate 5S      �� 5T      .R�5U      �� 
���  ��$��2,0,0,0q�6"   $��!��63   $��Center=�6<   5V      5X      �� 5Y       � �� 5Z      �� 5[      "  6   .R�5\      �� $& 
DGR_Border��6   #��z��6"   #��z��6L   #��z��6x    . ._�5]         5^   	   �� 5_   
   $
��Auto �6   �� 5`   
   $��* �6    5b   	   �� 5c   
   $��* �6   �� 5d   
   $
��Auto �6   .+�5f   	     $��1��6    #��z' 60   # z 6Z     5g   	   $��1��6"   $��1��62   #y�z( 6V  ) 6?   �� *AreRowDetailsFrozen+# Z* # Z+  �� "   6V  	  5h   	   $��2��6   $) Vertical=�6,   y�6l   �� *HeadersVisibility+# Z, # Z  �� "   5i   	   5j      5k      5m      " 5n      P� 5o      - �@ 	IsNewItem. . . �5p      ��  � �� 6   �� *NewItemMargin+ �� "   5q      5s      �� 5t      "  
 6%   .�5u      ��  � �� 5v      �� 5w      " 
 6   .R�5x      � .+�5y      �� 
������� . ._�5z   	   �� # z 6   5{   	   �� 5|      $��borderSelectedAndHover��6   
������ 6-   5}      / 5~      P� 5      - �@J�IsMouseOver. . . �5�   	   �� $0 borderSelectedAndHover��6    � �� �	#08003ca06J   5�   	   P� 5�      - �@
 
IsSelected. . . �5�   	   �� $0 borderSelectedAndHover��6    � �� �	#23003ca06J   5�   	   5�      5�      " 5�      P� 5�      - � {�. .  . �5�      ��  � ��# � ��6#   5�      5�      5�      