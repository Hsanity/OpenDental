   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridStyleOD  �� 
TargetType&     System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions � RowDefinitions	    SelectAllCommand
 �� 
ResourceId �� TypeInTargetAssembly7   1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG   ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value �� Mode �� ScrollableWidth,  �� %ComputedHorizontalScrollBarVisibility! �� ViewportWidth" �� Triggers# ]� 
Conditions$ �� Property% �� Value  DataGridColumnHeaderOD=   7System.Windows.Controls.Primitives.DataGridColumnHeader& ��Name  DataGridRowStyleOD)   #System.Windows.Controls.DataGridRow?   9System.Windows.Controls.Primitives.SelectiveScrollingGrid?   9System.Windows.Controls.Primitives.DataGridCellsPresenter'   
ItemsPanelA   ;System.Windows.Controls.Primitives.DataGridDetailsPresenter(   DetailsVisibility$)   SelectiveScrollingOrientation;   5System.Windows.Controls.SelectiveScrollingOrientation*   Vertical#+    RowDetailsScrollingConverter:	   4System.Windows.Controls.Primitives.DataGridRowHeader
,   Row- P� Property. P� Value  DataGridCellStyleOD*
   $System.Windows.Controls.DataGridCell/ �� Triggers0 �� 
TargetName�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      %�
  &	        &	 �    &	 j    &	 �    �� "    .���  � ��
 �������  � ��# � ����  � �� �	#FF688CAF��  � ��$ 1q���   �@  RowDetailsVisibilityMode$ VisibleWhenSelected=���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � �� �� "   .R��� #��z��#��z��#��z��# z�� . ._��� $ DG_ScrollViewer��|�.  ���� " ��.R��  �� $
��Auto ��� $��* ��� $
��Auto � �� $
��Auto ��� $��* ��� $
��Auto �.+��� #��Z	 |�.  ��C� *�� $"
 DataGridSelectAllButtonStyle��"   +y��� *HeadersVisibility+# Z # Z  �� "   ���� *CellsPanelHorizontalOffset+ �� "     $! PART_ColumnHeadersPresenter��$��1��y��� *HeadersVisibility+# Z # Z  �� "   �� $��2�����#DFEAF5$��0,0,0,1q�
��������� $! PART_ScrollContentPresenter��# z��$��2��$��1���� $ PART_VerticalScrollBar��$��2��# z $ Vertical=�$��1��#y�z # z  �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+� $��1��$��2�� �� ���� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� $��* �.+��� $ PART_HorizontalScrollBar��$��1��# z $ 
Horizontal=�#y�z  # z!  �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+.���� # z " ]� # �� $ �@��
IsGrouping% . �� "$ �@%�IsVirtualizingWhenGrouping% .  ./���  � �� .  �� "   .���  � ��$
 Bold"���  � �� �� "  .R�� .+��� $& columnHeaderBorder��$��0,0,1,1q�
����������#DFEAF5._��� $��Center=�$��Center=�# z �� "   .���  �@J�SnapsToDevicePixels . ��  �@=�ErrorTemplate Z� ��  �@ ValidationErrorTemplate �� .R��� 
���  ��$��2,0,0,0q�$��!��$��Center=���  � �� �� "  .R��� $& 
DGR_Border��#��z��#��z��#��z�� . ._�   �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��#��z' # z   $��1��$��1��#y�z( ) �� *AreRowDetailsFrozen+# Z* # Z+  �� "   	  $��2��$) Vertical=�y��� *HeadersVisibility+# Z, # Z  �� "   " P� - �@ 	IsNewItem. . . ���  � �� �� *NewItemMargin+ �� "   �� "  
 .���  � �� �� " 
 .R�� .+��� 
������� . ._��� # z �� $��borderSelectedAndHover��
������ / P� - �@J�IsMouseOver. . . ��� $0 borderSelectedAndHover�� � �� �	#08003ca0P� - �@
 
IsSelected. . . ��� $0 borderSelectedAndHover�� � �� �	#23003ca0" P� - � {�. .  . ���  � ��# � ��