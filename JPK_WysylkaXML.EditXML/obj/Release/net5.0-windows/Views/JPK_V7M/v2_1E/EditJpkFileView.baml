   M S B A M L   `   `   `  ���� W  SJPK_WysylkaXML.UI.Components, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  Q MJPK_WysylkaXML.EditXML, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E/JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E a ]UnitSoftware.Common.Wpf.Implementation, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null�oclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation1UnitSoftware.Common.Wpf.Implementation.Components @   :JPK_WysylkaXML.EditXML.Views.JPK_V7M.v2_1E.EditJpkFileView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     hcomponents1Pclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     Lvm=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E     �
componentsoclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  a	 ]Syncfusion.SfGrid.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.Shared.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
Syncfusion!http://schemas.syncfusion.com/wpf 	 
   � ShowInTaskbar$  False��$	��650��$	��900�� � WindowStartupLocation$ CenterOwner=� � Title 9   3JPK_WysylkaXML.UI.Components.TranslateXamlExtension  *EditJPKView_Title+ � 	Resources  �� MergedDictionaries �� SourceD  >UnitSoftware.Common.Wpf.Implementation.Components.BindingProxy 	  Proxy   Data��  �� $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?��� $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?��� $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?��� $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?��� $a [pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/ToolBar.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�%   &	           �� .���  � RowDefinitions �� $��* ��� $
��Auto �.+��� $��0��.@��� ��  *EditJPKView_Header+.���� $��Stretch=�$��Stretch=�$��5q�.+�]�   FormLineDockPanel#��[ .+���   TextBlockFormElement#��[ ��  *EditJPKView_SystemCode+��  �� TextAlignment$ Right=�  SimpleTextBox#��[ $	��200������ *Naglowek.KodSystemowy+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� #��[  �� TextAlignment$ Right=���  *EditJPKView_SchemaVersion+�� $ Right=�#��[ ���� *Naglowek.WersjaSchemy+$	 TwoWay=�$
 PropertyChanged=�]� #��[ .+��� #��[ ��  * EditJPKView_ApplicationPurpose+��  �� DisplayMemberPath$ Item2�� �� SelectedValuePath$ Item1�� �� 
IsEditable$ False�� �� SelectedValue �� *Naglowek.CelZlozenia+$	 TwoWay=����� *Naglowek.CelZlozeniaItemList+$
 PropertyChanged=�]� #��[ .+��� #��[ ��  *EditJPKView_CreationDate+(  "System.Windows.Controls.DatePicker     SelectedDate �� *Naglowek.DataWytworzeniaJPK+$
 PropertyChanged=�]� #��[ .+��� #��[ ��  *EditJPKView_FormVersion+�� $ False�� �� SelectedItem �� *Naglowek.WariantFormularza+$	 TwoWay=����� *$"Naglowek.WariantFormularzaItemList+$
 PropertyChanged=�]� #��[ .+��� #��[ ��  *EditJPKView_Year+1   +JPK_WysylkaXML.UI.Components.NumericTextBox  $ Right=�#��[    Mask$ #0��$	��200��   Value ��  �� Path$ Naglowek.Rok�$	 TwoWay=�$
 PropertyChanged=����� *Naglowek.Rok+$	 OneWay=��� #��[ $ Right=���  *EditJPKView_Month+  $ Right=�#��[ $ #0�� �� $ Naglowek.Miesiac�$	 TwoWay=�$
 PropertyChanged=����� *Naglowek.Miesiac+$	 OneWay=�]� #��[ .+��� #��[ ��  *EditJPKView_SystemName+�� $ Right=�#��[ ���� *Naglowek.NazwaSystemu+$	 TwoWay=�$
 PropertyChanged=�]� #��[ .+��� #��[ ��  *EditJPKView_TaxOffice+�� $ Item2��$ Item1��$
 True�� �� IsTextSearchEnabled$
 True�� �� *Naglowek.KodUrzedu+$	 TwoWay=����� *Naglowek.KodUSItemList+$
 PropertyChanged=��� ��  *EditJPKView_Declarations+.���� $��5q�.+�� $��Stretch=�$��Stretch=� � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+��� $��Stretch=�$��Stretch=�$��5q�$��0��.+�]� #��[ .+��� $
��P_10��#��[   $ Right=�#��[  �� $ Deklaracje.P_10�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_10+$	 OneWay=�]� #��[ .+��� $
��P_11��#��[   $ Right=�#��[  �� $ Deklaracje.P_11�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_11+$	 OneWay=�]� #��[ .+��� $
��P_12��#��[   $ Right=�#��[  �� $ Deklaracje.P_12�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_12+$	 OneWay=�]� #��[ .+��� $
��P_13��#��[   $ Right=�#��[  �� $ Deklaracje.P_13�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_13+$	 OneWay=�]� #��[ .+��� $
��P_14��#��[   $ Right=�#��[  �� $ Deklaracje.P_14�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_14+$	 OneWay=�]� #��[ .+��� $
��P_15��#��[   $ Right=�#��[  �� $ Deklaracje.P_15�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_15+$	 OneWay=�]� #��[ .+��� $
��P_16��#��[   $ Right=�#��[  �� $ Deklaracje.P_16�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_16+$	 OneWay=�]� #��[ .+��� $
��P_17��#��[   $ Right=�#��[  �� $ Deklaracje.P_17�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_17+$	 OneWay=�]� #��[ .+��� $
��P_18��#��[   $ Right=�#��[  �� $ Deklaracje.P_18�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_18+$	 OneWay=�]� #��[ .+��� $
��P_19��#��[   $ Right=�#��[  �� $ Deklaracje.P_19�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_19+$	 OneWay=�]� #��[ .+��� $
��P_20��#��[   $ Right=�#��[  �� $ Deklaracje.P_20�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_20+$	 OneWay=�]� #��[ .+��� $
��P_21��#��[   $ Right=�#��[  �� $ Deklaracje.P_21�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_21+$	 OneWay=�]� #��[ .+��� $
��P_22��#��[   $ Right=�#��[  �� $ Deklaracje.P_22�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_22+$	 OneWay=�]� #��[ .+��� $
��P_23��#��[   $ Right=�#��[  �� $ Deklaracje.P_23�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_23+$	 OneWay=�]� #��[ .+��� $
��P_24��#��[   $ Right=�#��[  �� $ Deklaracje.P_24�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_24+$	 OneWay=�]� #��[ .+��� $
��P_25��#��[   $ Right=�#��[  �� $ Deklaracje.P_25�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_25+$	 OneWay=�]� #��[ .+��� $
��P_26��#��[   $ Right=�#��[  �� $ Deklaracje.P_26�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_26+$	 OneWay=�]� #��[ .+��� $
��P_27��#��[   $ Right=�#��[  �� $ Deklaracje.P_27�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_27+$	 OneWay=�]� #��[ .+��� $
��P_28��#��[   $ Right=�#��[  �� $ Deklaracje.P_28�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_28+$	 OneWay=�]� #��[ .+��� $
��P_29��#��[   $ Right=�#��[  �� $ Deklaracje.P_29�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_29+$	 OneWay=��� $��Stretch=�$��Stretch=�$��5q�$��1��.+�]� #��[ .+��� $
��P_30��#��[   $ Right=�#��[  �� $ Deklaracje.P_30�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_30+$	 OneWay=�]� #��[ .+��� $
��P_31��#��[   $ Right=�#��[  �� $ Deklaracje.P_31�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_31+$	 OneWay=�]� #��[ .+��� $
��P_32��#��[   $ Right=�#��[  �� $ Deklaracje.P_32�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_32+$	 OneWay=�]� #��[ .+��� $
��P_33��#��[   $ Right=�#��[  �� $ Deklaracje.P_33�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_33+$	 OneWay=�]� #��[ .+��� $
��P_34��#��[   $ Right=�#��[  �� $ Deklaracje.P_34�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_34+$	 OneWay=�]� #��[ .+��� $
��P_35��#��[   $ Right=�#��[  �� $ Deklaracje.P_35�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_35+$	 OneWay=�]� #��[ .+��� $
��P_36��#��[   $ Right=�#��[  �� $ Deklaracje.P_36�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_36+$	 OneWay=�]� #��[ .+��� $
��P_37��#��[   $ Right=�#��[  �� $ Deklaracje.P_37�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_37+$	 OneWay=�]� #��[ .+��� $
��P_38��#��[   $ Right=�#��[  �� $ Deklaracje.P_38�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_38+$	 OneWay=�]� #��[ .+��� $
��P_39��#��[   $ Right=�#��[  �� $ Deklaracje.P_39�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_39+$	 OneWay=�]� #��[ .+��� $
��P_40��#��[   $ Right=�#��[  �� $ Deklaracje.P_40�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_40+$	 OneWay=�]� #��[ .+��� $
��P_41��#��[   $ Right=�#��[  �� $ Deklaracje.P_41�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_41+$	 OneWay=�]� #��[ .+��� $
��P_42��#��[   $ Right=�#��[  �� $ Deklaracje.P_42�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_42+$	 OneWay=�]� #��[ .+��� $
��P_43��#��[   $ Right=�#��[  �� $ Deklaracje.P_43�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_43+$	 OneWay=�]� #��[ .+��� $
��P_44��#��[   $ Right=�#��[  �� $ Deklaracje.P_44�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_44+$	 OneWay=�]� #��[ .+��� $
��P_45��#��[   $ Right=�#��[  �� $ Deklaracje.P_45�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_45+$	 OneWay=�]� #��[ .+��� $
��P_46��#��[   $ Right=�#��[  �� $ Deklaracje.P_46�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_46+$	 OneWay=�]� #��[ .+��� $
��P_47��#��[   $ Right=�#��[  �� $ Deklaracje.P_47�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_47+$	 OneWay=�]� #��[ .+��� $
��P_48��#��[   $ Right=�#��[  �� $ Deklaracje.P_48�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_48+$	 OneWay=�]� #��[ .+��� $
��P_49��#��[   $ Right=�#��[  �� $ Deklaracje.P_49�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_49+$	 OneWay=��� $��Stretch=�$��Stretch=�$��5q�$��2��.+�]� #��[ .+��� $
��P_50��#��[   $ Right=�#��[  �� $ Deklaracje.P_50�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_50+$	 OneWay=�]� #��[ .+��� $
��P_51��#��[   $ Right=�#��[  �� $ Deklaracje.P_51�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_51+$	 OneWay=�]� #��[ .+��� $
��P_52��#��[   $ Right=�#��[  �� $ Deklaracje.P_52�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_52+$	 OneWay=�]� #��[ .+��� $
��P_53��#��[   $ Right=�#��[  �� $ Deklaracje.P_53�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_53+$	 OneWay=�]� #��[ .+��� $
��P_54��#��[   $ Right=�#��[  �� $ Deklaracje.P_54�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_54+$	 OneWay=�]� #��[ .+��� $��Rodzaj zwrotu��#��[ �� $ False������ *Deklaracje.ItemList+$
 PropertyChanged=� �� Text �� *Deklaracje.ItemElementName+��   CheckBoxFormElement#��[ $��5 0 0 0q� d� 	IsChecked �� *Deklaracje.Item+]� #��[ .+��� $
��P_59��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_59+]� #��[ .+��� $
��P_60��#��[   $ Right=�#��[  �� $ Deklaracje.P_60�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_60+$	 OneWay=�]� #��[ .+��� $
��P_61��#��[   $ Right=�#��[  �� $ Deklaracje.P_61�$	 TwoWay=�$
 PropertyChanged=� �� TargetNullValue$ 0������ *Deklaracje.P_61+$	 OneWay=�]� #��[ .+��� $
��P_62��#��[   $ Right=�#��[  �� $ Deklaracje.P_62�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_62+$	 OneWay=�]� #��[ .+��� $
��P_63��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_63+]� #��[ .+��� $
��P_64��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_64+]� #��[ .+��� $
��P_65��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_65+]� #��[ .+��� $
��P_66��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_66+]� #��[ .+��� $��P_660��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_660+]� #��[ .+��� $
��P_67��#��[ �� #��[ $��0 0 5 0q� �� *Deklaracje.P_67+]� #��[ .+��� $
��P_68��#��[   $ Right=�#��[  �� $ Deklaracje.P_68�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_68+$	 OneWay=�]� #��[ .+��� $
��P_69��#��[   $ Right=�#��[  �� $ Deklaracje.P_69�$	 TwoWay=�$
 PropertyChanged=����� *Deklaracje.P_69+$	 OneWay=�]� #��[ .+��� $��P_ORDZU��#��[ ��  �� 	MaxLength$	 240��$
 Left=�#��[ ���� *Deklaracje.P_ORDZU+$	 TwoWay=��� ��  *EditJPKView_Sale+.���  �� $
��Auto ��� $��* �.+�c� $��0�� J� 	AllowDrop$ False��  ToolBarStyle#��[  `� IsLocked$
 True��$��30��$��2��.@���   AddButtonTemplate#��[   ToolBarButton#��[ $	��Top=����� *AddNewSaleRowCommand+��    DeletePurchaseButtonTemplate#��[ #��[ $	��Top=����� *DeleteSaleRowCommand+��  	 DeleteAllRowsButtonTemplate#��[	 #��[ $	��Top=����� *DeleteAllSaleRowsCommand+�� ��  
 ImportRowsButtonTemplate#��[
 #��[ $	��Top=����� *ImportSaleRowsCommand+( 	 "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   $��SaleGrid��$��1��$��2��   AllowGrouping$
 True��( 	 "Syncfusion.UI.Xaml.Grid.SfGridBase   SelectionMode$ Single=�   AllowFrozenGroupHeaders$
 True��    NavigationMode$	  Row=�!   ShowRowHeader$
! True��"   ShowGroupDropArea$
" True��#   AllowFiltering$
# True��$   CanUseViewFilter$
$ True��$��Stretch=�$��Stretch=�%   
IsReadOnly$
% True��&   AllowResizingColumns$
& True��'   AllowDraggingColumns$
' True��(   HeaderRowHeight$( 26Q�)   ItemsSource) �� *
SaleList+*   SelectedItem* �� *SelectedSaleRow+$	 TwoWay=�$
 PropertyChanged=�+   Columns+ 0 	 *Syncfusion.UI.Xaml.Grid.GridCheckBoxColumn  , 	 &Syncfusion.UI.Xaml.Grid.GridColumnBase,   MappingName$#, KorektaPodstawyOpodtSpecified��-   IsHidden$
- True��  $, ItemElementNameSpecified��$
- True��  $, ItemSpecified��$
- True��*	  $Microsoft.Xaml.Behaviors.Interaction. 	  Triggers. +
  %Microsoft.Xaml.Behaviors.EventTrigger
  / 
  	EventName$/ MouseDoubleClick��*  $Microsoft.Xaml.Behaviors.TriggerBase0   Actions.0 2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  1   Command1 �� *Data.SaleDoubleClickCommand+$	 OneWay=�2 �� Source#2 [  �� $��Stretch=�$��Stretch=���  *EditJPKView_Purchase+.���  �� $
��Auto ��� $��* �.+�c� $��0��$ False��#��[ $
 True��$��30��.@���   AddPurchaseButtonTemplate#��[ #��[ $	��Top=����� *AddNewPurchaseRowCommand+�� #��[ #��[ $	��Top=����� *DeletePurchaseRowCommand+�� #��[	 #��[ $	��Top=����� *DeleteAllPurchaseRowsCommand+�� �� #��[
 #��[ $	��Top=����� *ImportPurchaseRowsCommand+  -   $��PurchaseGrid��$��1��$��2��$
 True��$ Single=�$
 True��$	  Row=�$
! True��$
" True��$
# True��$
$ True��$��Stretch=�$��Stretch=�$
% True��$
' True��$( 26Q�3   AutoGenerateColumns$
3 True��$
& True��) �� *PurchaseList+* �� *SelectedPurchaseRow+$	 TwoWay=�$
 PropertyChanged=�. 
  $/ MouseDoubleClick��.0   1 �� *PurchaseDoubleClickCommand+$	 OneWay=��� $��1��4 �� Orientation$4 
Horizontal=�$��Center=�$��Right=�$��10q�.+���   SaveButtonTemplate#��[ $��5,0,0,0q����� *SaveCommand+��   CancelButtonTemplate#��[ $��5,0,5,0q����� *CancelCommand+5 J� InputBindings5 �� 
6 �� Key$6 Escape��7 �� Command7 �� *CancelCommand+