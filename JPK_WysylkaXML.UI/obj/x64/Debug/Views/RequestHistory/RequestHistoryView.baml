   M S B A M L   `   `   `  ����L  HJPK_WysylkaXML.UI, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:JPK_WysylkaXML.UI.ViewModel.RequestHistory*JPK_WysylkaXML.UI.ViewModel.RequestHistory  5   	   K*clr-namespace:JPK_WysylkaXML.UI.ConvertersJPK_WysylkaXML.UI.Converters  5   	   a ]UnitSoftware.Common.Wpf.Implementation, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null�oclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation1UnitSoftware.Common.Wpf.Implementation.Components 5	   	   W SJPK_WysylkaXML.UI.Components, Version=2.0.3.0, Culture=neutral, PublicKeyToken=null�Zclr-namespace:JPK_WysylkaXML.UI.Components.Resources;assembly=JPK_WysylkaXML.UI.Components&JPK_WysylkaXML.UI.Components.Resources 5   	   qPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components 5   	   9    3JPK_WysylkaXML.UI.Views.RequestHistory.RequestsView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   SrequestHistory8clr-namespace:JPK_WysylkaXML.UI.ViewModel.RequestHistory     5   	   A
converters*clr-namespace:JPK_WysylkaXML.UI.Converters     5   	   �
componentsoclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation     5	   	   j	 fSyncfusion.SfBusyIndicator.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.SfGrid.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c896
Syncfusion!http://schemas.syncfusion.com/wpf 	 
  5
   	   iresxZclr-namespace:JPK_WysylkaXML.UI.Components.Resources;assembly=JPK_WysylkaXML.UI.Components 	 
  5   	   fcomponents1Pclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components 	 
  5   	     � ShowInTaskbar$  False��5   	   $	��400��5   	   $	��900��6    � WindowStartupLocation$ CenterOwner=�5   	    � Title 5   	   9  3JPK_WysylkaXML.UI.Components.TranslateXamlExtension  *HistoryView_Title+ � 	Resources 5       �� MergedDictionaries �� SourceD  >UnitSoftware.Common.Wpf.Implementation.Components.BindingProxy 	  Proxy   Data�� 5   
    5      �� 5      $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?�6%   �� 5      $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�6%   %&   &	          5       64   �� 5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5       $
��Auto �6   .+�5#   
   � $��0��6   .+�5$      > 	 8Syncfusion.Windows.Controls.Notification.SfBusyIndicator     AnimationType$ Fluent=�6L   	   IsBusy	 6)   �� *IsWaitDisplayed+.��5%      �  5&      �� 5'      $
��Auto �6(   �� 5(      $��* �6(   .+�5+      ]� $��0��6    $��Center=�6-   $��5,5,5,5q�6H   .+�5,      �� 
 �� Orientation$
 
Horizontal=�6%   $
��Left=�6>   $��Center=�6Y   $��5,5,5,5q�6t   .+�5-      �� $��Center=�6f   ��6(     *HistoryView_FromDateFilter+6f   (  "System.Windows.Controls.DatePicker  5.      $��5,0,5,0q�6\      SelectedDate 6)   �� *FilterViewModel.StartDate+6\   �� 5/      $��Center=�6d   ��6(     *HistoryView_ToDateFilter+6d     50       � ToolTip$ Data końcowa��6Z   $��5,0,5,0q�6q    6)   �� *FilterViewModel.EndDate+6q   51      52      ( 
 "Syncfusion.UI.Xaml.Grid.SfDataGrid  54      -   5        $��1��54   ,   ( 
 "Syncfusion.UI.Xaml.Grid.SfGridBase   SelectionMode$ Single=�69   $|�False��6P      SelectionUnit$	 Row=�6b      
IsReadOnly$
 True��6v      AutoGenerateColumns$ False��6�      ColumnSizer$ AutoLastColumnFill=�6�      NavigationMode$	 Row=�55   ,      ShowRowHeader$
 True��6A      AllowGrouping$
 True��6V      ShowGroupDropArea$
 True��6k      GridCopyOption$ CopyData=�56   ,      RowDropIndicatorMode$ Arrow=�57   v      ItemsSource 6,   �� *RequestList+   SelectedItem 6P   �� *SelectedItem+   	CellStyle 58      �� 59       �� 
TargetType& 
  Syncfusion.UI.Xaml.Grid.GridCell"  6$    �� Triggers 5:   "   �� 5;   &    �� Binding 62   �� *
LastStatus+ �� 	Converter 7   1JPK_WysylkaXML.UI.Converters.ErrorStatusConverter   �� Value True6~   .a�5<   *   ��   �� Property  � ��! �� Value
! �  ��6G   �� 5=   *     � ��
! �����6G   5>   '   ^� 5@   &   " ^� 
Conditions" 5A   *   �� 5B   .   # �� Binding# 68   �� $ �� Path$$ IsUpo�% �� Value% True6W   �� 5C   .   # 68   �� $$ Data.IsTestServer�& �� Source#& [  % True6�   .0�5E   *   ��   � ��
! ��d�6G   5F   '   ^� 5G   &   " 5H   *   �� 5I   .   # 68   �� $$ IsUpo�% True6W   �� 5J   .   # 68   �� $$ Data.IsTestServer�#& [  	% False6�   .0�5L   *   ��   � ��
! � � �6G   5M   '   5P      '   Columns' 5S      ,	 
 &Syncfusion.UI.Xaml.Grid.GridTextColumn	  ,
 
 &Syncfusion.UI.Xaml.Grid.GridColumnBase( 
  Width$( 70Q�68   ) 
  MappingName$) 
ServerType��6�   * 
  TextAlignment$* Center=�6�   + 
  
HeaderText+ 6C     *HistoryView_ServerTypeHeader+6�   	  5T      $	( 240Q�6y   $) ReferenceNo��6�   + 68     *HistoryView_RefNoHeader+6�   	  5U      $	( 110Q�6|   $) SendDate��6�   ( 
 "Syncfusion.UI.Xaml.Grid.GridColumn,   AllowResizing$
, True��6�   $* Center=�6�   + 68     *HistoryView_SendDateHeader+6�   0 
 *Syncfusion.UI.Xaml.Grid.GridCheckBoxColumn  5V      $( 60Q�6{   $) IsUpo��6�   -   AllowFiltering$
- True��6�   + 6<     *HistoryView_UpoHeader+6�   	  5W      $( 70Q�6z   $) 
LastStatus��6�   $
- True��6�   $* Center=�6�   + 68     *HistoryView_StatusHeader+6�   	  5X      $) LastStatusDescription��6�   0 
 *Syncfusion.UI.Xaml.Grid.GridTextColumnBase.   TextTrimming$. CharacterEllipsis=�6�   + 68     *HistoryView_DescriptionHeader+/ 
  	CellStyle/ 5Y   "   �� 5Z   &   "  6,   .�5[   *   ��   �@�ToolTip! 6D   �� *LastStatusDescription+ 5\   *   �� 5]   .    6:   �� *
LastStatus+    True6�   .a�5^   2   ��   � ��
! �  ��6O   �� 5_   2     � ��
! �����6O   5`   /   ^� 5b   .   " 5c   2   �� 5d   6   # 6@   �� $$ IsUpo�% True6_   �� 5e   6   # 6@   �� $$ Data.IsTestServer�#& [  % True6�   .0�5g   2   ��   � ��
! ��d�6O   5h   /   ^� 5i   .   " 5j   2   �� 5k   6   # 6@   �� $$ IsUpo�% True6_   �� 5l   6   # 6@   �� $$ Data.IsTestServer�#& [  	% False6�   .0�5n   2   ��   � ��
! � � �6O   5o   /   5q   '   5s      5u      5v      5w      5x      �� 5z   
   $��5,5,5,5q�6   $
 
Horizontal=�6&   $��Right=�6?   $��2��6[   .+�5{      ��   GenerateUpoTemplate#��[ 6   $��5,0,5,0q�6s   $! Wygeneruj Upo w postaci Pdf��6�   ��6L   �� *GenerateUpoCommand+6�   �� 5|        DownloadUpoTemplate#��[ 6   $��5,0,5,0q�6s   $ Zapisz Upo w postaci XML��6�   ��6L   �� *DownloadUpoCommand+6�   �� 5}        RefreshButtonTemplate#��[ 6   $��5,0,5,0q�6t   $ Odświerz statusy��6�   ��6N   �� *RefreshAllCommand+6�   �� 5~        CloseButtonTemplate#��[ 6   $��5,0,5,0q�6m   $ Zamknij okno��6~   ��6L   �� *CloseCommand+6~   5      5�      0 J� InputBindings0 5�      �� 5�   
   
1 �� Key$1 Escape��6   2 �� Command2 6"   �� *CloseCommand+5�      