   M S B A M L   `   `   `  ����W  SJPK_WysylkaXML.UI.Components, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  5   	   Q MJPK_WysylkaXML.EditXML, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E/JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E 5   	   a ]UnitSoftware.Common.Wpf.Implementation, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null�oclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation1UnitSoftware.Common.Wpf.Implementation.Components 5   	   @   :JPK_WysylkaXML.EditXML.Views.JPK_V7M.v2_1E.EditJpkFileView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   hcomponents1Pclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     5   	   Lvm=clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E     5   	   �
componentsoclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5
   	   a	 ]Syncfusion.SfGrid.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.Shared.WPF, Version=19.3500.0.48, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
Syncfusion!http://schemas.syncfusion.com/wpf 	 
 5   	     � ShowInTaskbar$  False��5   	   $	��650��5   	   $	��900��6    � WindowStartupLocation$ CenterOwner=�5   	    � Title 5   	   9   3JPK_WysylkaXML.UI.Components.TranslateXamlExtension  *EditJPKView_Title+ � 	Resources 5       �� MergedDictionaries �� SourceD  >UnitSoftware.Common.Wpf.Implementation.Components.BindingProxy 	  Proxy   Data�� 5   
    5      �� 5      $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?�6%   �� 5      $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�6%   �� 5      $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?�6%   �� 5      $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?�6%   �� 5      $a [pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/ToolBar.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�6%   %&   &	          5       64   �� 5       .��5#      �  � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $
��Auto �6   .+�5)   
   �� $��0��6   .@�5*      �� ��6     *EditJPKView_Header+.��5+      �� $��Stretch=�6   $��Stretch=�6;   $��5q�6W   .+�5,      ]�   FormLineDockPanel#��[ 6    .+�5-      ��   TextBlockFormElement#��[ 6^   ��6$     *EditJPKView_SystemCode+6^   �� 5.       �� TextAlignment$ Right=�5/   "     SimpleTextBox#��[ 68   $	��200��6_   ��5.   "   �� *Naglowek.KodSystemowy+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5/   _   �� 50      #��[ 6a    �� TextAlignment$ Right=�6�   ��6$     *EditJPKView_SchemaVersion+6�   �� 51      $ Right=�52   "   #��[ 68   ��51   "   �� *Naglowek.WersjaSchemy+$	 TwoWay=�$
 PropertyChanged=�52   8   53      ]� 54      #��[ 6    .+�55      �� #��[ 6f   ��6$     * EditJPKView_ApplicationPurpose+6f   �� 56       �� DisplayMemberPath$ Item2��6_    �� SelectedValuePath$ Item1��6y    �� 
IsEditable$ False��6�    �� SelectedValue 6#   �� *Naglowek.CelZlozenia+$	 TwoWay=���6�   �� *Naglowek.CelZlozeniaItemList+$
 PropertyChanged=�6�   57      ]� 58      #��[ 6    .+�59      �� #��[ 6`   ��6$     *EditJPKView_CreationDate+6`   (  "System.Windows.Controls.DatePicker  5:         SelectedDate 6%   �� *Naglowek.DataWytworzeniaJPK+$
 PropertyChanged=�5;      ]� 5<      #��[ 6    .+�5=      �� #��[ 6_   ��6$     *EditJPKView_FormVersion+6_   �� 5>      $ False��6�    �� SelectedItem 6#   �� *Naglowek.WariantFormularza+$	 TwoWay=���6d   �� *$"Naglowek.WariantFormularzaItemList+$
 PropertyChanged=�6�   5?      ]� 5@      #��[ 6    .+�5A      �� #��[ 6X   ��6$     *EditJPKView_Year+6X   1   +JPK_WysylkaXML.UI.Components.NumericTextBox  5B      $ Right=�6�   #��[ 6�      Mask$ #0��6�   $	��200��6�      Value 65   ��  �� Path$ Naglowek.Rok�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Naglowek.Rok+$	 OneWay=�6�   �� 5C      #��[ 6Y   $ Right=�6�   ��6$     *EditJPKView_Month+6�     5D      $ Right=�6�   #��[ 6�   $ #0��6�    65   �� $ Naglowek.Miesiac�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Naglowek.Miesiac+$	 OneWay=�6�   5E      ]� 5G      #��[ 6    .+�5H      �� #��[ 6^   ��6$     *EditJPKView_SystemName+6^   �� 5I      $ Right=�5J   5   #��[ 6K   ��5I   "   �� *Naglowek.NazwaSystemu+$	 TwoWay=�$
 PropertyChanged=�5J   K   5K      ]� 5L      #��[ 6    .+�5M      �� #��[ 6]   ��6$     *EditJPKView_TaxOffice+6]   �� 5N      $ Item2��6]   $ Item1��6w   $
 True��5O   #    �� IsTextSearchEnabled$
 True��65    5N   #   �� *Naglowek.KodUrzedu+$	 TwoWay=���6�   �� *Naglowek.KodUSItemList+$
 PropertyChanged=�5O   5   5Q      5R      5S      �� 5T      ��6     *EditJPKView_Declarations+.��5U      �� $��5q�6   .+�5V      � $��Stretch=�6   $��Stretch=�69    � ColumnDefinitions 5W      �� 5X      $��* �6/   �� 5Y      $��* �6/   �� 5Z      $��* �6/   .+�5]      �� $��Stretch=�6%   $��Stretch=�6C   $��5q�6_   $��0��6j   .+�5_      ]� #��[ 6(   .+�5`   "   �� $
��P_10��6,   #��[ 68     5a   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_10�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_10+$	 OneWay=�6�   5b      ]� 5c      #��[ 6(   .+�5d   "   �� $
��P_11��6,   #��[ 68     5e   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_11�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_11+$	 OneWay=�6�   5f      ]� 5g      #��[ 6(   .+�5h   "   �� $
��P_12��6,   #��[ 68     5i   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_12�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_12+$	 OneWay=�6�   5j      ]� 5k      #��[ 6(   .+�5l   "   �� $
��P_13��6,   #��[ 68     5m   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_13�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_13+$	 OneWay=�6�   5n      ]� 5o      #��[ 6(   .+�5p   "   �� $
��P_14��6,   #��[ 68     5q   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_14�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_14+$	 OneWay=�6�   5r      ]� 5s      #��[ 6(   .+�5t   "   �� $
��P_15��6,   #��[ 68     5u   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_15�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_15+$	 OneWay=�6�   5v      ]� 5w      #��[ 6(   .+�5x   "   �� $
��P_16��6,   #��[ 68     5y   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_16�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_16+$	 OneWay=�6�   5z      ]� 5{      #��[ 6(   .+�5|   "   �� $
��P_17��6,   #��[ 68     5}   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_17�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_17+$	 OneWay=�6�   5~      ]� 5      #��[ 6(   .+�5�   "   �� $
��P_18��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_18�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_18+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_19��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_19�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_19+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_20��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_20�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_20+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_21��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_21�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_21+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_22��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_22�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_22+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_23��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_23�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_23+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_24��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_24�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_24+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_25��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_25�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_25+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_26��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_26�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_26+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_27��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_27�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_27+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_28��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_28�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_28+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_29��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_29�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_29+$	 OneWay=�6�   5�      5�      �� 5�      $��Stretch=�6%   $��Stretch=�6C   $��5q�6_   $��1��6j   .+�5�      ]� #��[ 6(   .+�5�   "   �� $
��P_30��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_30�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_30+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_31��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_31�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_31+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_32��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_32�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_32+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_33��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_33�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_33+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_34��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_34�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_34+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_35��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_35�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_35+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_36��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_36�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_36+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_37��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_37�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_37+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_38��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_38�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_38+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_39��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_39�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_39+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_40��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_40�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_40+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_41��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_41�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_41+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_42��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_42�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_42+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_43��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_43�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_43+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_44��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_44�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_44+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_45��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_45�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_45+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_46��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_46�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_46+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_47��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_47�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_47+$	 OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_48��6,   #��[ 68     5�   "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_48�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_48+$	 OneWay=�6�   5�      ]� 5      #��[ 6(   .+�5  "   �� $
��P_49��6,   #��[ 68     5  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_49�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_49+$	 OneWay=�6�   5     5     �� 5     $��Stretch=�6%   $��Stretch=�6C   $��5q�6_   $��2��6j   .+�5     ]� #��[ 6(   .+�5	  "   �� $
��P_50��6,   #��[ 68     5
  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_50�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_50+$	 OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_51��6,   #��[ 68     5  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_51�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_51+$	 OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_52��6,   #��[ 68     5  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_52�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_52+$	 OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_53��6,   #��[ 68     5  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_53�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_53+$	 OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_54��6,   #��[ 68     5  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_54�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_54+$	 OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $��Rodzaj zwrotu��6,   #��[ 6A   �� 5  "   $ False��6|   ��6+   �� *Deklaracje.ItemList+$
 PropertyChanged=� �� Text 6�   �� *Deklaracje.ItemElementName+�� 5  "     CheckBoxFormElement#��[ 6+   $��5 0 0 0q�6~    d� 	IsChecked 6X   �� *Deklaracje.Item+6~   5      ]� 5!     #��[ 6(   .+�5"  "   �� $
��P_59��6,   #��[ 68   �� 5#  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_59+6~   5$     ]� 5%     #��[ 6(   .+�5&  "   �� $
��P_60��6,   #��[ 68     5'  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_60�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_60+$	 OneWay=�6�   5(     ]� 5)     #��[ 6(   .+�5*  "   �� $
��P_61��6,   #��[ 68     5+  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_61�$	 TwoWay=�$
 PropertyChanged=� �� TargetNullValue$ 0����6�   �� *Deklaracje.P_61+$	 OneWay=�6�   5,     ]� 5-     #��[ 6(   .+�5.  "   �� $
��P_62��6,   #��[ 68     5/  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_62�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_62+$	 OneWay=�6�   50     ]� 51     #��[ 6(   .+�52  "   �� $
��P_63��6,   #��[ 68   �� 53  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_63+6~   54     ]� 55     #��[ 6(   .+�56  "   �� $
��P_64��6,   #��[ 68   �� 57  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_64+6~   58     ]� 59     #��[ 6(   .+�5:  "   �� $
��P_65��6,   #��[ 68   �� 5;  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_65+6~   5<     ]� 5=     #��[ 6(   .+�5>  "   �� $
��P_66��6,   #��[ 68   �� 5?  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_66+6~   5@     ]� 5A     #��[ 6(   .+�5B  "   �� $��P_660��6,   #��[ 69   �� 5C  "   #��[ 6+   $��0 0 5 0q�6    6X   �� *Deklaracje.P_660+6   5D     ]� 5E     #��[ 6(   .+�5F  "   �� $
��P_67��6,   #��[ 68   �� 5G  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_67+6~   5H     ]� 5I     #��[ 6(   .+�5J  "   �� $
��P_68��6,   #��[ 68     5K  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_68�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_68+$	 OneWay=�6�   5L     ]� 5M     #��[ 6(   .+�5N  "   �� $
��P_69��6,   #��[ 68     5O  "   $ Right=�6�   #��[ 6�    6=   �� $ Deklaracje.P_69�$	 TwoWay=�$
 PropertyChanged=���6�   �� *Deklaracje.P_69+$	 OneWay=�6�   5P     ]� 5Q     #��[ 6(   .+�5R  "   �� $��P_ORDZU��6,   #��[ 6;   �� 5S  "    �� 	MaxLength$	 240��6[   $
 Left=�6k   #��[ 6�   ��6*   �� *Deklaracje.P_ORDZU+$	 TwoWay=�6�   5T     5U     5W     5X     5Y     �� 5Z     ��6     *EditJPKView_Sale+.��5[     �  5\     �� 5]     $
��Auto �6(   �� 5^     $��* �6(   .+�5`     c� $��0��6    J� 	AllowDrop$ False��6,     ToolBarStyle#��[ 6>    `� IsLocked$
 True��6d   $��30��6�   $��2��6�   .@�5a     ��   AddButtonTemplate#��[ 6J     ToolBarButton#��[ 6   $	��Top=�6�   ��6!   �� *AddNewSaleRowCommand+6�   �� 5b        DeletePurchaseButtonTemplate#��[ 6J   #��[ 6�   $	��Top=�6�   ��6!   �� *DeleteSaleRowCommand+6�   �� 5c      	 DeleteAllRowsButtonTemplate#��[	 6N   #��[ 6�   $	��Top=�6�   ��6!   �� *DeleteAllSaleRowsCommand+6�   �� 5e     �� 5f      
 ImportRowsButtonTemplate#��[
 5g  !   #��[ 5h  !   $	��Top=�6H   ��5f  !   �� *ImportSaleRowsCommand+5h  H   5j     ( 	 "Syncfusion.UI.Xaml.Grid.SfDataGrid  5k     -   5        $��SaleGrid��5k  �   $��1��6,   $��2��69      AllowGrouping$
 True��6M   ( 	 "Syncfusion.UI.Xaml.Grid.SfGridBase   SelectionMode$ Single=�6c      AllowFrozenGroupHeaders$
 True��6z       NavigationMode$	  Row=�5l  ,   !   ShowRowHeader$
! True��6A   "   ShowGroupDropArea$
" True��6W   #   AllowFiltering$
# True��6p   $   CanUseViewFilter$
$ True��6�   $��Stretch=�5m  ,   $��Stretch=�6H   %   
IsReadOnly$
% True��6f   &   AllowResizingColumns$
& True��6x   '   AllowDraggingColumns$
' True��5n  ,   (   HeaderRowHeight$( 26Q�6H   )   ItemsSource) 5o  ,   �� *
SaleList+*   SelectedItem* 5p  ,   �� *SelectedSaleRow+$	 TwoWay=�$
 PropertyChanged=�+   Columns+ 5r     0 	 *Syncfusion.UI.Xaml.Grid.GridCheckBoxColumn  , 	 &Syncfusion.UI.Xaml.Grid.GridColumnBase,   MappingName$#, KorektaPodstawyOpodtSpecified��6<   -   IsHidden$
- True��6h     5s     $, ItemElementNameSpecified��6<   $
- True��6c     5t     $, ItemSpecified��6<   $
- True��6X   *	  $Microsoft.Xaml.Behaviors.Interaction. 	  Triggers. 5v     +
  %Microsoft.Xaml.Behaviors.EventTrigger
  5w     / 
  	EventName$/ MouseDoubleClick��6-   *  $Microsoft.Xaml.Behaviors.TriggerBase0   Actions.0 5x  "   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  1   Command1 68   �� *Data.SaleDoubleClickCommand+$	 OneWay=�2 �� Source#2 [  5y     5{     5}     5~     �� 5     $��Stretch=�6P   $��Stretch=�6n   ��6     *EditJPKView_Purchase+.��5�     �  5�     �� 5�     $
��Auto �6(   �� 5�     $��* �6(   .+�5�     c� $��0��6   $ False��6,   #��[ 6>   $
 True��6d   $��30��6�   .@�5�     ��   AddPurchaseButtonTemplate#��[ 6N   #��[ 6�   $	��Top=�6�   ��6!   �� *AddNewPurchaseRowCommand+6�   �� 5�     #��[ 6N   #��[ 6�   $	��Top=�6�   ��6!   �� *DeletePurchaseRowCommand+6�   �� 5�     #��[	 6R   #��[ 6�   $	��Top=�6�   ��6!   �� *DeleteAllPurchaseRowsCommand+6�   �� 5�     �� 5�     #��[
 5�  !   #��[ 5�  !   $	��Top=�6H   ��5�  !   �� *ImportPurchaseRowsCommand+5�  H   5�       5�     -   5        $��PurchaseGrid��5�  �   $��1��6,   $��2��69   $
 True��6M   $ Single=�6c   $
 True��6z   $	  Row=�5�  ,   $
! True��6A   $
" True��6W   $
# True��6p   $
$ True��6�   $��Stretch=�5�  ,   $��Stretch=�6H   $
% True��6f   $
' True��6x   $( 26Q�6�   3   AutoGenerateColumns$
3 True��6�   $
& True��6�   ) 5�  ,   �� *PurchaseList+* 5�  ,   �� *SelectedPurchaseRow+$	 TwoWay=�$
 PropertyChanged=�. 5�     
  5�     $/ MouseDoubleClick��6-   .0 5�  "     1 68   �� *PurchaseDoubleClickCommand+$	 OneWay=�5�     5�     5�     5�     5�     �� 5�  
   $��1��6   4 �� Orientation$4 
Horizontal=�6"   $��Center=�6;   $��Right=�6V   $��10q�6r   .+�5�     ��   SaveButtonTemplate#��[ 6   $��5,0,0,0q�6k   ��6K   �� *SaveCommand+6k   �� 5�       CancelButtonTemplate#��[ 6   $��5,0,5,0q�6o   ��6M   �� *CancelCommand+6o   5�     5�     5 J� InputBindings5 5�     �� 5�  
   
6 �� Key$6 Escape��6   7 �� Command7 6"   �� *CancelCommand+5�     