   M S B A M L   `   `   `  ���� W  SJPK_WysylkaXML.UI.Components, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  Q MJPK_WysylkaXML.EditXML, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0.JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0 N   HJPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_0.EditJpkFilePurchaseDetailsView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     g
componentsPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     Mv101<clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0       � ShowInTaskbar$  False�� � SizeToContent$ WidthAndHeight=� � Title$ Edycja wiersza zakupów�� � Icon$ /AppIcon.ico�� � WindowStartupLocation$ CenterOwner=� � 	Resources  �� MergedDictionaries �� Source��  �� $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?��� $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?��� $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?��� $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�%    .���� $��5q�.+�� $��Stretch=�$��Stretch=� � ColumnDefinitions �� $��* ��� $��* �.+��� $��Stretch=�$��Stretch=�$��5q�$��0��.+�]�    FormLineDockPanel#��[  .+��� $��LpZakupu��  TextBlockFormElement#��[ �� 	 �� 
IsReadOnly$
	 True������ *
LpZakupu+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ OneWay=�]� #��[  .+��� $��KodKrajuNadaniaTIN��#��[ �� ���� *KodKrajuNadaniaTIN+$
 PropertyChanged=�]� #��[  .+��� $��
NrDostawcy��#��[ �� ���� *
NrDostawcy+$
 PropertyChanged=�]� #��[  .+��� $��NazwaDostawcy��#��[ �� ���� *NazwaDostawcy+$
 PropertyChanged=�]� #��[  .+��� $��DowodZakupu��#��[ �� ���� *DowodZakupu+$
 PropertyChanged=�]� #��[  .+��� $��
DataZakupu��#��[ (  "System.Windows.Controls.DatePicker     SelectedDate �� *
DataZakupu+$
 PropertyChanged=�]� #��[  .+��� $��
DataWplywu��#��[ ��   CheckBoxFormElement#��[ $��0 0 5 0q� d� 	IsChecked �� *DataWplywuSpecified+   �� *
DataWplywu+$
 PropertyChanged=�]� #��[  .+��� $��DokumentZakupu��#��[ �� #��[ $��0 0 5 0q� �� *DokumentZakupuSpecified+��  �� 
IsEditable$ False������ *DokumentZakupuList+$
 PropertyChanged=� �� Text �� *DokumentZakupu+]� #��[  .+��� $	��MPP��#��[ �� #��[  �� *MPP+]� #��[  .+��� $	��IMP��#��[ �� #��[  �� *IMP+]� #��[  .+��� $��ZakupVAT_Marza��#��[ �� #��[ $��0 0 5 0q� �� *ZakupVAT_MarzaSpecified+1   +JPK_WysylkaXML.UI.Components.NumericTextBox  $	��100�� �� TextAlignment$ Right=�  SimpleTextBox#��[    Value ��  �� Path$ ZakupVAT_Marza�$ TwoWay=�$
 PropertyChanged=����� *ZakupVAT_Marza+$ OneWay=��� $��Stretch=�$��Stretch=�$��5q�$��1��.+�]� #��[  .+��� $
��K_40��  ShortTextBlockFormElement#��[   $	��100��$ Right=�#��[  �� $
 K_40�$ TwoWay=�$
 PropertyChanged=����� *K_40+$ OneWay=�]� #��[  .+��� $
��K_41��#��[   $	��100��$ Right=�#��[  �� $
 K_41�$ TwoWay=�$
 PropertyChanged=����� *K_41+$ OneWay=�]� #��[  .+��� $
��K_42��#��[   $	��100��$ Right=�#��[  �� $
 K_42�$ TwoWay=�$
 PropertyChanged=����� *K_42+$ OneWay=�]� #��[  .+��� $
��K_43��#��[   $	��100��$ Right=�#��[  �� $
 K_43�$ TwoWay=�$
 PropertyChanged=����� *K_43+$ OneWay=�]� #��[  .+��� $
��K_44��#��[ �� #��[ $��0 0 5 0q� �� *K_44Specified+  $	��100��$ Right=�#��[  �� $
 K_44�$ TwoWay=�$
 PropertyChanged=����� *K_44+$ OneWay=�]� #��[  .+��� $
��K_45��#��[ �� #��[ $��0 0 5 0q� �� *K_45Specified+  $	��100��$ Right=�#��[  �� $
 K_45�$ TwoWay=�$
 PropertyChanged=����� *K_45+$ OneWay=�]� #��[  .+��� $
��K_46��#��[ �� #��[ $��0 0 5 0q� �� *K_46Specified+  $	��100��$ Right=�#��[  �� $
 K_46�$ TwoWay=�$
 PropertyChanged=����� *K_46+$ OneWay=�]� #��[  .+��� $
��K_47��#��[ �� #��[ $��0 0 5 0q� �� *K_47Specified+  $	��100��$ Right=�#��[  �� $
 K_47�$ TwoWay=�$
 PropertyChanged=����� *K_47+$ OneWay=���  �� Orientation$ 
Horizontal=�$��Center=�$��Right=�.+���   SaveButtonTemplate#��[ $��5,0,0,0q����� *SaveCommand+��   CancelButtonTemplate#��[ $��5,0,5,0q����� *CancelCommand+ J� InputBindings �� 
 �� Key$ Escape�� �� Command �� *CancelCommand+