   M S B A M L   `   `   `  ����W  SJPK_WysylkaXML.UI.Components, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  5   	   Q MJPK_WysylkaXML.EditXML, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E/JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E 5   	   K   EJPK_WysylkaXML.EditXML.Views.JPK_V7M.v2_1E.EditJpkFileSaleDetailsView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   g
componentsPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     5   	   Lvm=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E     5   	     � ShowInTaskbar$  False��5
   	    � SizeToContent$ WidthAndHeight=�5   	    � Title$ Edycja wiersza sprzedaży��5   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?�6%   �� 5      $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�6%   �� 5      $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?�6%   �� 5      $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�6%   %    5      .��5      �� $��5q�6   .+�5   
   � $��Stretch=�6   $��Stretch=�6-    � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $��* �6#   �� 5"      $��* �6#   �� 5#      $��* �6#   .+�5&      �� $��Stretch=�6   $��Stretch=�67   $��5q�6S   $��0��6^   .+�5'      ]�    FormLineDockPanel#��[  6   .+�5(      �� $��Lp Sprzedaży��6      TextBlockFormElement#��[ 64   �� 5)       �� 
IsReadOnly$
 True��6n   ��6   �� *LpSprzedazy+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 OneWay=�6n   5*      ]� 5+      #��[  6   .+�5,      �� $��NrKontrahenta��6    #��[ 65   �� 5-      ��6   �� *NrKontrahenta+$	 PropertyChanged=�5.      ]� 5/      #��[  6   .+�50      �� $��NazwaKontrahenta��6    #��[ 68   �� 51      ��6   �� *NazwaKontrahenta+$	 PropertyChanged=�52      ]� 53      #��[  6   .+�54      �� $��KodKrajuNadaniaTIN��6    #��[ 6:   �� 55      ��6   �� *KodKrajuNadaniaTIN+$	 PropertyChanged=�56      ]� 57      #��[  6   .+�58      �� $��DowodSprzedazy��6    #��[ 66   �� 59      ��6   �� *DowodSprzedazy+$	 PropertyChanged=�5:      ]� 5;      #��[  6   .+�5<      �� $��DataWystawienia��6    #��[ 67   (  "System.Windows.Controls.DatePicker  5=         SelectedDate 6!   �� *DataWystawienia+$	 PropertyChanged=�5>      ]� 5?      #��[  6   .+�5@      �� $��DataSprzedazy��6    #��[ 65   �� 5A        CheckBoxFormElement#��[ 6   $��0 0 5 0q�6y    d� 	IsChecked 6L   �� *DataSprzedazySpecified+6y     5B       6!   �� *DataSprzedazy+$	 PropertyChanged=�5C      ]� 5D      #��[  6   .+�5E      �� $��TypDokumentu��6    #��[ 64   �� 5F      #��[ 6   $��0 0 5 0q�6x    6L   �� *TypDokumentuSpecified+6x   �� 5G       �� 
IsEditable$ False��6m   ��6   �� *TypDokumentuList+$	 PropertyChanged=� �� Text 6�   �� *TypDokumentu+5H      ]� 5I      #��[  6   .+�5J      �� $��GTU_01��6    #��[ 6.   �� 5K      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_01+6i   5L      ]� 5M      #��[  6   .+�5N      �� $��GTU_02��6    #��[ 6.   �� 5O      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_02+6i   5P      ]� 5Q      #��[  6   .+�5R      �� $��GTU_03��6    #��[ 6.   �� 5S      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_03+6i   5T      ]� 5U      #��[  6   .+�5V      �� $��GTU_04��6    #��[ 6.   �� 5W      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_04+6i   5X      ]� 5Y      #��[  6   .+�5Z      �� $��GTU_05��6    #��[ 6.   �� 5[      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_05+6i   5\      ]� 5]      #��[  6   .+�5^      �� $��GTU_06��6    #��[ 6.   �� 5_      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_06+6i   5`      ]� 5a      #��[  6   .+�5b      �� $��GTU_07��6    #��[ 6.   �� 5c      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_07+6i   5d      ]� 5e      #��[  6   .+�5f      �� $��GTU_08��6    #��[ 6.   �� 5g      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_08+6i   5h      ]� 5i      #��[  6   .+�5j      �� $��GTU_09��6    #��[ 6.   �� 5k      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_09+6i   5l      ]� 5m      #��[  6   .+�5n      �� $��GTU_10��6    #��[ 6.   �� 5o      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_10+6i   5p      ]� 5q      #��[  6   .+�5r      �� $��GTU_11��6    #��[ 6.   �� 5s      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_11+6i   5t      ]� 5u      #��[  6   .+�5v      �� $��GTU_12��6    #��[ 6.   �� 5w      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_12+6i   5x      ]� 5y      #��[  6   .+�5z      �� $��GTU_13��6    #��[ 6.   �� 5{      #��[ 6   $��0 0 5 0q�6i    6L   �� *GTU_13+6i   5|      5~      �� 5�      $��Stretch=�6   $��Stretch=�67   $��5q�6S   $��1��6^   .+�5�      ]� #��[  6   .+�5�      �� $��WSTO_EE��6    #��[ 6/   �� 5�      #��[ 6   $��0 0 5 0q�6j    6L   �� *	WSTO_EE+6j   5�      ]� 5�      #��[  6   .+�5�      �� $	��IED��6    #��[ 6+   �� 5�      #��[ 6   $��0 0 5 0q�6f    6L   �� *IED+6f   5�      ]� 5�      #��[  6   .+�5�      �� $��TP��6    #��[ 6*   �� 5�      #��[ 6   $��0 0 5 0q�6e    6L   �� *TP+6e   5�      ]� 5�      #��[  6   .+�5�      �� $��TT_WNT��6    #��[ 6.   �� 5�      #��[ 6   $��0 0 5 0q�6i    6L   �� *TT_WNT+6i   5�      ]� 5�      #��[  6   .+�5�      �� $
��TT_D��6    #��[ 6,   �� 5�      #��[ 6   $��0 0 5 0q�6g    6L   �� *TT_D+6g   5�      ]� 5�      #��[  6   .+�5�      �� $
��MR_T��6    #��[ 6,   �� 5�      #��[ 6   $��0 0 5 0q�6g    6L   �� *MR_T+6g   5�      ]� 5�      #��[  6   .+�5�      �� $��MR_UZ��6    #��[ 6-   �� 5�      #��[ 6   $��0 0 5 0q�6h    6L   �� *MR_UZ+6h   5�      ]� 5�      #��[  6   .+�5�      �� $
��I_42��6    #��[ 6,   �� 5�      #��[ 6   $��0 0 5 0q�6g    6L   �� *I_42+6g   5�      ]� 5�      #��[  6   .+�5�      �� $
��I_63��6    #��[ 6,   �� 5�      #��[ 6   $��0 0 5 0q�6g    6L   �� *I_63+6g   5�      ]� 5�      #��[  6   .+�5�      �� $��B_SPV��6    #��[ 6-   �� 5�      #��[ 6   $��0 0 5 0q�6h    6L   �� *B_SPV+6h   5�      ]� 5�      #��[  6   .+�5�      �� $��B_SPV_DOSTAWA��6    #��[ 65   �� 5�      #��[ 6   $��0 0 5 0q�6p    6L   �� *B_SPV_DOSTAWA+6p   5�      ]� 5�      #��[  6   .+�5�      �� $��B_MPV_PROWIZJA��6    #��[ 66   �� 5�      #��[ 6   $��0 0 5 0q�6q    6L   �� *B_MPV_PROWIZJA+6q   5�      ]� 5�      #��[  6   .+�5�      �� $��KorektaPodstawyOpodt��6    #��[ 6<   �� 5�      #��[ 6   $��0 0 5 0q�6w    6L   �� *KorektaPodstawyOpodt+6w   5�      ]� 5�      #��[  6   .+�5�      �� $��Rodzaj daty��6    #��[ 63   �� 5�      $ False��6n   ��6   �� *ItemChoiceOptions+$	 PropertyChanged=� 6�   �� *ItemElementName+5�      ]� 5�      #��[  6   .+�5�      �� $
��Data��6    #��[ 6,     5�       6!   �� *Item+$	 PropertyChanged=�5�      5�      �� 5�      $��Stretch=�6   $��Stretch=�67   $��5q�6S   $��2��6^   .+�5�      ]� #��[  6   .+�5�      �� $
��K_10��6      ShortTextBlockFormElement#��[ 6,   1   +JPK_WysylkaXML.UI.Components.NumericTextBox  5�      $	��100��6�    �� TextAlignment$ Right=�6�     SimpleTextBox#��[ 6�      Value 60   ��  �� Path$
 K_10�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_10+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_11��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_11�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_11+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_12��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_12�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_12+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_13��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_13�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_13+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_14��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_14�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_14+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_15��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_15�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_15+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_16��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_16�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_16+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_17��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_17�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_17+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_18��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_18�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_18+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_19��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    � ToolTip$� �Wysokość podstawy opodatkowania wynikająca z dostawy towarów oraz świadczenia usług na terytorium kraju, opodatkowanych stawką 22% albo 23%, z uwzględnieniem korekty dokonanej zgodnie z art. 89a ust. 1 i 4 ustawy��6�    60   �� $
 K_19�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_19+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_20��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_20�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_20+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_21��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_21�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_21+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_22��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_22�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_22+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_23��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_23�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_23+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5�      �� $
��K_24��6    #��[ 6,     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_24�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_24+$
 OneWay=�6�   5�      ]� 5�      #��[  6   .+�5      �� $
��K_25��6    #��[ 6,     5     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_25�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_25+$
 OneWay=�6�   5     ]� 5     #��[  6   .+�5     �� $
��K_26��6    #��[ 6,     5     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_26�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_26+$
 OneWay=�6�   5     ]� 5     #��[  6   .+�5     �� $
��K_27��6    #��[ 6,     5	     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_27�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_27+$
 OneWay=�6�   5
     ]� 5     #��[  6   .+�5     �� $
��K_28��6    #��[ 6,     5     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_28�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_28+$
 OneWay=�6�   5     ]� 5     #��[  6   .+�5     �� $
��K_29��6    #��[ 6,     5     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_29�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_29+$
 OneWay=�6�   5     5     �� 5     $��Stretch=�6   $��Stretch=�67   $��5q�6S   $��3��6^   .+�5     ]� #��[  6   .+�5     �� $
��K_30��6    #��[ 6,     5     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_30�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_30+$
 OneWay=�6�   5     ]� 5     #��[  6   .+�5     �� $
��K_31��6    #��[ 6,     5     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_31�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_31+$
 OneWay=�6�   5     ]� 5     #��[  6   .+�5      �� $
��K_32��6    #��[ 6,     5!     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_32�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_32+$
 OneWay=�6�   5"     ]� 5#     #��[  6   .+�5$     �� $
��K_33��6    #��[ 6,     5%     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_33�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_33+$
 OneWay=�6�   5&     ]� 5'     #��[  6   .+�5(     �� $
��K_34��6    #��[ 6,     5)     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_34�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_34+$
 OneWay=�6�   5*     ]� 5+     #��[  6   .+�5,     �� $
��K_34��6    #��[ 6,     5-     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_34�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_34+$
 OneWay=�6�   5.     ]� 5/     #��[  6   .+�50     �� $
��K_35��6    #��[ 6,     51     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_35�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_35+$
 OneWay=�6�   52     ]� 53     #��[  6   .+�54     �� $
��K_36��6    #��[ 6,     55     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_36�$
 TwoWay=�$	 PropertyChanged=���6~   �� *K_36+$
 OneWay=�6�   56     ]� 57     #��[  6   .+�58     �� $��SprzedazVAT_Marza��6    #��[ 69     59     $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $ SprzedazVAT_Marza�$
 TwoWay=�$	 PropertyChanged=���6�   �� *SprzedazVAT_Marza+$
 OneWay=�6�   5:     5;     5<     �� 5=  
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Right=�6I   .+�5>     ��   SaveButtonTemplate#��[ 6   $��5,0,0,0q�6k   ��6K   �� *SaveCommand+6k   �� 5?       CancelButtonTemplate#��[ 6   $��5,0,5,0q�6o   ��6M   �� *CancelCommand+6o   5@     5A      J� InputBindings 5C     �� 5D  
   
 �� Key$ Escape��6    �� Command 6"   �� *CancelCommand+5F     