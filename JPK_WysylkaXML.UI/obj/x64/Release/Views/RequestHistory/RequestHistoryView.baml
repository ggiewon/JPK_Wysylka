   M S B A M L   `   `   `  ���� L  HJPK_WysylkaXML.UI, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:JPK_WysylkaXML.UI.ViewModel.RequestHistory*JPK_WysylkaXML.UI.ViewModel.RequestHistory  K*clr-namespace:JPK_WysylkaXML.UI.ConvertersJPK_WysylkaXML.UI.Converters  a ]UnitSoftware.Common.Wpf.Implementation, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null�oclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation1UnitSoftware.Common.Wpf.Implementation.Components W SJPK_WysylkaXML.UI.Components, Version=2.0.4.0, Culture=neutral, PublicKeyToken=null�Zclr-namespace:JPK_WysylkaXML.UI.Components.Resources;assembly=JPK_WysylkaXML.UI.Components&JPK_WysylkaXML.UI.Components.Resources qPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components 9    3JPK_WysylkaXML.UI.Views.RequestHistory.RequestsView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0ignorehttp://www.galasoft.ch/ignore     SrequestHistory8clr-namespace:JPK_WysylkaXML.UI.ViewModel.RequestHistory     A
converters*clr-namespace:JPK_WysylkaXML.UI.Converters     �
componentsoclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation     j	 fSyncfusion.SfBusyIndicator.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.SfGrid.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c896
Syncfusion!http://schemas.syncfusion.com/wpf 	 
  iresxZclr-namespace:JPK_WysylkaXML.UI.Components.Resources;assembly=JPK_WysylkaXML.UI.Components 	 
  fcomponents1Pclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components 	 
    � ShowInTaskbar$  False��$	��400��$	��900�� � WindowStartupLocation$ CenterOwner=� � Title 9  3JPK_WysylkaXML.UI.Components.TranslateXamlExtension  *HistoryView_Title+ � 	Resources  �� MergedDictionaries �� SourceD  >UnitSoftware.Common.Wpf.Implementation.Components.BindingProxy 	  Proxy   Data��  �� $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?��� $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�%   &	           �� .���  � RowDefinitions �� $��* ��� $
��Auto �.+�� $��0��.+�> 	 8Syncfusion.Windows.Controls.Notification.SfBusyIndicator     AnimationType$ Fluent=�	   IsBusy	 �� *IsWaitDisplayed+.���  �� $
��Auto ��� $��* �.+�]� $��0��$��Center=�$��5,5,5,5q�.+��� 
 �� Orientation$
 
Horizontal=�$
��Left=�$��Center=�$��5,5,5,5q�.+��� $��Center=���  *HistoryView_FromDateFilter+(  "System.Windows.Controls.DatePicker  $��5,0,5,0q�   SelectedDate �� *FilterViewModel.StartDate+�� $��Center=���  *HistoryView_ToDateFilter+   � ToolTip$ Data końcowa��$��5,0,5,0q� �� *FilterViewModel.EndDate+( 
 "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   $��1��( 
 "Syncfusion.UI.Xaml.Grid.SfGridBase   SelectionMode$ Single=�$|�False��   SelectionUnit$	 Row=�   
IsReadOnly$
 True��   AutoGenerateColumns$ False��   ColumnSizer$ AutoLastColumnFill=�   NavigationMode$	 Row=�   ShowRowHeader$
 True��   AllowGrouping$
 True��   ShowGroupDropArea$
 True��   GridCopyOption$ CopyData=�   RowDropIndicatorMode$ Arrow=�   ItemsSource �� *RequestList+   SelectedItem �� *SelectedItem+   	CellStyle ��  �� 
TargetType& 
  Syncfusion.UI.Xaml.Grid.GridCell"   �� Triggers ��  �� Binding �� *
LastStatus+ �� 	Converter 7   1JPK_WysylkaXML.UI.Converters.ErrorStatusConverter   �� Value True.a���   �� Property  � ��! �� Value
! �  ����   � ��
! �����^� " ^� 
Conditions" �� # �� Binding# �� $ �� Path$$ IsUpo�% �� Value% True�� # �� $$ Data.IsTestServer�& �� Source#& [  % True.0���   � ��
! ��d�^� " �� # �� $$ IsUpo�% True�� # �� $$ Data.IsTestServer�#& [  	% False.0���   � ��
! � � �'   Columns' ,	 
 &Syncfusion.UI.Xaml.Grid.GridTextColumn	  ,
 
 &Syncfusion.UI.Xaml.Grid.GridColumnBase( 
  Width$( 70Q�) 
  MappingName$) 
ServerType��* 
  TextAlignment$* Center=�+ 
  
HeaderText+   *HistoryView_ServerTypeHeader+	  $	( 240Q�$) ReferenceNo��+   *HistoryView_RefNoHeader+	  $	( 110Q�$) SendDate��( 
 "Syncfusion.UI.Xaml.Grid.GridColumn,   AllowResizing$
, True��$* Center=�+   *HistoryView_SendDateHeader+0 
 *Syncfusion.UI.Xaml.Grid.GridCheckBoxColumn  $( 60Q�$) IsUpo��-   AllowFiltering$
- True��+   *HistoryView_UpoHeader+	  $( 70Q�$) 
LastStatus��$
- True��$* Center=�+   *HistoryView_StatusHeader+	  $) LastStatusDescription��0 
 *Syncfusion.UI.Xaml.Grid.GridTextColumnBase.   TextTrimming$. CharacterEllipsis=�+   *HistoryView_DescriptionHeader+/ 
  	CellStyle/ �� "  .���   �@�ToolTip! �� *LastStatusDescription+ ��  �� *
LastStatus+    True.a���   � ��
! �  ����   � ��
! �����^� " �� # �� $$ IsUpo�% True�� # �� $$ Data.IsTestServer�#& [  % True.0���   � ��
! ��d�^� " �� # �� $$ IsUpo�% True�� # �� $$ Data.IsTestServer�#& [  	% False.0���   � ��
! � � ��� $��5,5,5,5q�$
 
Horizontal=�$��Right=�$��2��.+���   GenerateUpoTemplate#��[ $��5,0,5,0q�$! Wygeneruj Upo w postaci Pdf������ *GenerateUpoCommand+��   DownloadUpoTemplate#��[ $��5,0,5,0q�$ Zapisz Upo w postaci XML������ *DownloadUpoCommand+��   RefreshButtonTemplate#��[ $��5,0,5,0q�$ Odświerz statusy������ *RefreshAllCommand+��   CloseButtonTemplate#��[ $��5,0,5,0q�$ Zamknij okno������ *CloseCommand+0 J� InputBindings0 �� 
1 �� Key$1 Escape��2 �� Command2 �� *CloseCommand+