   M S B A M L   `   `   `  ���� W  SJPK_WysylkaXML.UI.Components, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  Q MJPK_WysylkaXML.EditXML, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E/JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E K   EJPK_WysylkaXML.EditXML.Views.JPK_V7M.v2_1E.EditJpkFileSaleDetailsView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     g
componentsPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     Lvm=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E       � ShowInTaskbar$  False�� � SizeToContent$ WidthAndHeight=� � Title$ Edycja wiersza sprzedaży�� � WindowStartupLocation$ CenterOwner=� � 	Resources  �� MergedDictionaries �� Source��  �� $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?��� $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?��� $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?��� $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�%    .���� $��5q�.+�� $��Stretch=�$��Stretch=� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Stretch=�$��Stretch=�$��5q�$��0��.+�]�    FormLineDockPanel#��[  .+��� $��Lp Sprzedaży��  TextBlockFormElement#��[ ��  �� 
IsReadOnly$
 True������ *LpSprzedazy+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 OneWay=�]� #��[  .+��� $��NrKontrahenta��#��[ �� ���� *NrKontrahenta+$	 PropertyChanged=�]� #��[  .+��� $��NazwaKontrahenta��#��[ �� ���� *NazwaKontrahenta+$	 PropertyChanged=�]� #��[  .+��� $��KodKrajuNadaniaTIN��#��[ �� ���� *KodKrajuNadaniaTIN+$	 PropertyChanged=�]� #��[  .+��� $��DowodSprzedazy��#��[ �� ���� *DowodSprzedazy+$	 PropertyChanged=�]� #��[  .+��� $��DataWystawienia��#��[ (  "System.Windows.Controls.DatePicker     SelectedDate �� *DataWystawienia+$	 PropertyChanged=�]� #��[  .+��� $��DataSprzedazy��#��[ ��   CheckBoxFormElement#��[ $��0 0 5 0q� d� 	IsChecked �� *DataSprzedazySpecified+   �� *DataSprzedazy+$	 PropertyChanged=�]� #��[  .+��� $��TypDokumentu��#��[ �� #��[ $��0 0 5 0q� �� *TypDokumentuSpecified+��  �� 
IsEditable$ False������ *TypDokumentuList+$	 PropertyChanged=� �� Text �� *TypDokumentu+]� #��[  .+��� $��GTU_01��#��[ �� #��[ $��0 0 5 0q� �� *GTU_01+]� #��[  .+��� $��GTU_02��#��[ �� #��[ $��0 0 5 0q� �� *GTU_02+]� #��[  .+��� $��GTU_03��#��[ �� #��[ $��0 0 5 0q� �� *GTU_03+]� #��[  .+��� $��GTU_04��#��[ �� #��[ $��0 0 5 0q� �� *GTU_04+]� #��[  .+��� $��GTU_05��#��[ �� #��[ $��0 0 5 0q� �� *GTU_05+]� #��[  .+��� $��GTU_06��#��[ �� #��[ $��0 0 5 0q� �� *GTU_06+]� #��[  .+��� $��GTU_07��#��[ �� #��[ $��0 0 5 0q� �� *GTU_07+]� #��[  .+��� $��GTU_08��#��[ �� #��[ $��0 0 5 0q� �� *GTU_08+]� #��[  .+��� $��GTU_09��#��[ �� #��[ $��0 0 5 0q� �� *GTU_09+]� #��[  .+��� $��GTU_10��#��[ �� #��[ $��0 0 5 0q� �� *GTU_10+]� #��[  .+��� $��GTU_11��#��[ �� #��[ $��0 0 5 0q� �� *GTU_11+]� #��[  .+��� $��GTU_12��#��[ �� #��[ $��0 0 5 0q� �� *GTU_12+]� #��[  .+��� $��GTU_13��#��[ �� #��[ $��0 0 5 0q� �� *GTU_13+�� $��Stretch=�$��Stretch=�$��5q�$��1��.+�]� #��[  .+��� $��WSTO_EE��#��[ �� #��[ $��0 0 5 0q� �� *	WSTO_EE+]� #��[  .+��� $	��IED��#��[ �� #��[ $��0 0 5 0q� �� *IED+]� #��[  .+��� $��TP��#��[ �� #��[ $��0 0 5 0q� �� *TP+]� #��[  .+��� $��TT_WNT��#��[ �� #��[ $��0 0 5 0q� �� *TT_WNT+]� #��[  .+��� $
��TT_D��#��[ �� #��[ $��0 0 5 0q� �� *TT_D+]� #��[  .+��� $
��MR_T��#��[ �� #��[ $��0 0 5 0q� �� *MR_T+]� #��[  .+��� $��MR_UZ��#��[ �� #��[ $��0 0 5 0q� �� *MR_UZ+]� #��[  .+��� $
��I_42��#��[ �� #��[ $��0 0 5 0q� �� *I_42+]� #��[  .+��� $
��I_63��#��[ �� #��[ $��0 0 5 0q� �� *I_63+]� #��[  .+��� $��B_SPV��#��[ �� #��[ $��0 0 5 0q� �� *B_SPV+]� #��[  .+��� $��B_SPV_DOSTAWA��#��[ �� #��[ $��0 0 5 0q� �� *B_SPV_DOSTAWA+]� #��[  .+��� $��B_MPV_PROWIZJA��#��[ �� #��[ $��0 0 5 0q� �� *B_MPV_PROWIZJA+]� #��[  .+��� $��KorektaPodstawyOpodt��#��[ �� #��[ $��0 0 5 0q� �� *KorektaPodstawyOpodt+]� #��[  .+��� $��Rodzaj daty��#��[ �� $ False������ *ItemChoiceOptions+$	 PropertyChanged=� �� *ItemElementName+]� #��[  .+��� $
��Data��#��[    �� *Item+$	 PropertyChanged=��� $��Stretch=�$��Stretch=�$��5q�$��2��.+�]� #��[  .+��� $
��K_10��  ShortTextBlockFormElement#��[ 1   +JPK_WysylkaXML.UI.Components.NumericTextBox  $	��100�� �� TextAlignment$ Right=�  SimpleTextBox#��[    Value ��  �� Path$
 K_10�$
 TwoWay=�$	 PropertyChanged=����� *K_10+$
 OneWay=�]� #��[  .+��� $
��K_11��#��[   $	��100��$ Right=�#��[  �� $
 K_11�$
 TwoWay=�$	 PropertyChanged=����� *K_11+$
 OneWay=�]� #��[  .+��� $
��K_12��#��[   $	��100��$ Right=�#��[  �� $
 K_12�$
 TwoWay=�$	 PropertyChanged=����� *K_12+$
 OneWay=�]� #��[  .+��� $
��K_13��#��[   $	��100��$ Right=�#��[  �� $
 K_13�$
 TwoWay=�$	 PropertyChanged=����� *K_13+$
 OneWay=�]� #��[  .+��� $
��K_14��#��[   $	��100��$ Right=�#��[  �� $
 K_14�$
 TwoWay=�$	 PropertyChanged=����� *K_14+$
 OneWay=�]� #��[  .+��� $
��K_15��#��[   $	��100��$ Right=�#��[  �� $
 K_15�$
 TwoWay=�$	 PropertyChanged=����� *K_15+$
 OneWay=�]� #��[  .+��� $
��K_16��#��[   $	��100��$ Right=�#��[  �� $
 K_16�$
 TwoWay=�$	 PropertyChanged=����� *K_16+$
 OneWay=�]� #��[  .+��� $
��K_17��#��[   $	��100��$ Right=�#��[  �� $
 K_17�$
 TwoWay=�$	 PropertyChanged=����� *K_17+$
 OneWay=�]� #��[  .+��� $
��K_18��#��[   $	��100��$ Right=�#��[  �� $
 K_18�$
 TwoWay=�$	 PropertyChanged=����� *K_18+$
 OneWay=�]� #��[  .+��� $
��K_19��#��[   $	��100��$ Right=�#��[  � ToolTip$� �Wysokość podstawy opodatkowania wynikająca z dostawy towarów oraz świadczenia usług na terytorium kraju, opodatkowanych stawką 22% albo 23%, z uwzględnieniem korekty dokonanej zgodnie z art. 89a ust. 1 i 4 ustawy�� �� $
 K_19�$
 TwoWay=�$	 PropertyChanged=����� *K_19+$
 OneWay=�]� #��[  .+��� $
��K_20��#��[   $	��100��$ Right=�#��[  �� $
 K_20�$
 TwoWay=�$	 PropertyChanged=����� *K_20+$
 OneWay=�]� #��[  .+��� $
��K_21��#��[   $	��100��$ Right=�#��[  �� $
 K_21�$
 TwoWay=�$	 PropertyChanged=����� *K_21+$
 OneWay=�]� #��[  .+��� $
��K_22��#��[   $	��100��$ Right=�#��[  �� $
 K_22�$
 TwoWay=�$	 PropertyChanged=����� *K_22+$
 OneWay=�]� #��[  .+��� $
��K_23��#��[   $	��100��$ Right=�#��[  �� $
 K_23�$
 TwoWay=�$	 PropertyChanged=����� *K_23+$
 OneWay=�]� #��[  .+��� $
��K_24��#��[   $	��100��$ Right=�#��[  �� $
 K_24�$
 TwoWay=�$	 PropertyChanged=����� *K_24+$
 OneWay=�]� #��[  .+��� $
��K_25��#��[   $	��100��$ Right=�#��[  �� $
 K_25�$
 TwoWay=�$	 PropertyChanged=����� *K_25+$
 OneWay=�]� #��[  .+��� $
��K_26��#��[   $	��100��$ Right=�#��[  �� $
 K_26�$
 TwoWay=�$	 PropertyChanged=����� *K_26+$
 OneWay=�]� #��[  .+��� $
��K_27��#��[   $	��100��$ Right=�#��[  �� $
 K_27�$
 TwoWay=�$	 PropertyChanged=����� *K_27+$
 OneWay=�]� #��[  .+��� $
��K_28��#��[   $	��100��$ Right=�#��[  �� $
 K_28�$
 TwoWay=�$	 PropertyChanged=����� *K_28+$
 OneWay=�]� #��[  .+��� $
��K_29��#��[   $	��100��$ Right=�#��[  �� $
 K_29�$
 TwoWay=�$	 PropertyChanged=����� *K_29+$
 OneWay=��� $��Stretch=�$��Stretch=�$��5q�$��3��.+�]� #��[  .+��� $
��K_30��#��[   $	��100��$ Right=�#��[  �� $
 K_30�$
 TwoWay=�$	 PropertyChanged=����� *K_30+$
 OneWay=�]� #��[  .+��� $
��K_31��#��[   $	��100��$ Right=�#��[  �� $
 K_31�$
 TwoWay=�$	 PropertyChanged=����� *K_31+$
 OneWay=�]� #��[  .+��� $
��K_32��#��[   $	��100��$ Right=�#��[  �� $
 K_32�$
 TwoWay=�$	 PropertyChanged=����� *K_32+$
 OneWay=�]� #��[  .+��� $
��K_33��#��[   $	��100��$ Right=�#��[  �� $
 K_33�$
 TwoWay=�$	 PropertyChanged=����� *K_33+$
 OneWay=�]� #��[  .+��� $
��K_34��#��[   $	��100��$ Right=�#��[  �� $
 K_34�$
 TwoWay=�$	 PropertyChanged=����� *K_34+$
 OneWay=�]� #��[  .+��� $
��K_34��#��[   $	��100��$ Right=�#��[  �� $
 K_34�$
 TwoWay=�$	 PropertyChanged=����� *K_34+$
 OneWay=�]� #��[  .+��� $
��K_35��#��[   $	��100��$ Right=�#��[  �� $
 K_35�$
 TwoWay=�$	 PropertyChanged=����� *K_35+$
 OneWay=�]� #��[  .+��� $
��K_36��#��[   $	��100��$ Right=�#��[  �� $
 K_36�$
 TwoWay=�$	 PropertyChanged=����� *K_36+$
 OneWay=�]� #��[  .+��� $��SprzedazVAT_Marza��#��[   $	��100��$ Right=�#��[  �� $ SprzedazVAT_Marza�$
 TwoWay=�$	 PropertyChanged=����� *SprzedazVAT_Marza+$
 OneWay=���  �� Orientation$ 
Horizontal=�$��Center=�$��Right=�.+���   SaveButtonTemplate#��[ $��5,0,0,0q����� *SaveCommand+��   CancelButtonTemplate#��[ $��5,0,5,0q����� *CancelCommand+ J� InputBindings �� 
 �� Key$ Escape�� �� Command �� *CancelCommand+