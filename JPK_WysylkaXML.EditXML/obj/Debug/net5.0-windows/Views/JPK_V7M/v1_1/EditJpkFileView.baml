   M S B A M L   `   `   `  ����W  SJPK_WysylkaXML.UI.Components, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  5	   	   Q MJPK_WysylkaXML.EditXML, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_1.JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_1 5
   	   a ]UnitSoftware.Common.Wpf.Implementation, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null�oclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation1UnitSoftware.Common.Wpf.Implementation.Components 5   	   ?   9JPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_1.EditJpkFileView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hi:http://schemas.microsoft.com/expression/2010/interactivity     5   	   4command http://www.galasoft.ch/mvvmlight     5   	   >c1/http://schemas.componentone.com/winfx/2006/xaml     5   	   hcomponents1Pclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     5	   	   Mv111<clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_1     5
   	   �
componentsoclr-namespace:UnitSoftware.Common.Wpf.Implementation.Components;assembly=UnitSoftware.Common.Wpf.Implementation     5   	     � ShowInTaskbar$  False��5   	   $	��650��5   	   $	��900��6    � Title$ Edycja pliku JPK��5   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries �� SourceD  >UnitSoftware.Common.Wpf.Implementation.Components.BindingProxy 	  Proxy   Data�� 5   
    5      �� 5      $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?�6%   �� 5      $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�6%   �� 5      $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?�6%   �� 5      $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?�6%   �� 5      $a [pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/ToolBar.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�6%   %&   &	          5       64   �� 5       .��5#      �  � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $
��Auto �6   .+�5)   
   �� $��0��6   .@�5*      �� $��
Deklaracje��6   .��5+      �� $��5q�6   .+�5,      � $��Stretch=�6   $��Stretch=�69    � ColumnDefinitions 5-      �� 5.      $��* �6/   �� 5/      $��* �6/   �� 50      $��* �6/   .+�53      �� $��Stretch=�6%   $��Stretch=�6C   $��5q�6_   $��0��6j   .+�55      ]�   FormLineDockPanel#��[ 6(   .+�56   "   �� $
��P_10��6,     TextBlockFormElement#��[ 68   1   +JPK_WysylkaXML.UI.Components.NumericTextBox  57   "   	 �� TextAlignment$	 Right=�6�     SimpleTextBox#��[ 6�   
   Value
 6=   ��  �� Path$ Deklaracje.P_10� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *Deklaracje.P_10+$ OneWay=�6�   58      ]� 59      #��[ 6(   .+�5:   "   �� $
��P_11��6,   #��[ 68     5;   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_11�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_11+$ OneWay=�6�   5<      ]� 5=      #��[ 6(   .+�5>   "   �� $
��P_12��6,   #��[ 68     5?   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_12�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_12+$ OneWay=�6�   5@      ]� 5A      #��[ 6(   .+�5B   "   �� $
��P_13��6,   #��[ 68     5C   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_13�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_13+$ OneWay=�6�   5D      ]� 5E      #��[ 6(   .+�5F   "   �� $
��P_14��6,   #��[ 68     5G   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_14�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_14+$ OneWay=�6�   5H      ]� 5I      #��[ 6(   .+�5J   "   �� $
��P_15��6,   #��[ 68     5K   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_15�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_15+$ OneWay=�6�   5L      ]� 5M      #��[ 6(   .+�5N   "   �� $
��P_16��6,   #��[ 68     5O   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_16�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_16+$ OneWay=�6�   5P      ]� 5Q      #��[ 6(   .+�5R   "   �� $
��P_17��6,   #��[ 68     5S   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_17�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_17+$ OneWay=�6�   5T      ]� 5U      #��[ 6(   .+�5V   "   �� $
��P_18��6,   #��[ 68     5W   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_18�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_18+$ OneWay=�6�   5X      ]� 5Y      #��[ 6(   .+�5Z   "   �� $
��P_19��6,   #��[ 68     5[   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_19�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_19+$ OneWay=�6�   5\      ]� 5]      #��[ 6(   .+�5^   "   �� $
��P_20��6,   #��[ 68     5_   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_20�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_20+$ OneWay=�6�   5`      ]� 5a      #��[ 6(   .+�5b   "   �� $
��P_21��6,   #��[ 68     5c   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_21�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_21+$ OneWay=�6�   5d      ]� 5e      #��[ 6(   .+�5f   "   �� $
��P_22��6,   #��[ 68     5g   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_22�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_22+$ OneWay=�6�   5h      ]� 5i      #��[ 6(   .+�5j   "   �� $
��P_23��6,   #��[ 68     5k   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_23�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_23+$ OneWay=�6�   5l      ]� 5m      #��[ 6(   .+�5n   "   �� $
��P_24��6,   #��[ 68     5o   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_24�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_24+$ OneWay=�6�   5p      ]� 5q      #��[ 6(   .+�5r   "   �� $
��P_25��6,   #��[ 68     5s   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_25�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_25+$ OneWay=�6�   5t      ]� 5u      #��[ 6(   .+�5v   "   �� $
��P_26��6,   #��[ 68     5w   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_26�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_26+$ OneWay=�6�   5x      ]� 5y      #��[ 6(   .+�5z   "   �� $
��P_27��6,   #��[ 68     5{   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_27�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_27+$ OneWay=�6�   5|      ]� 5}      #��[ 6(   .+�5~   "   �� $
��P_28��6,   #��[ 68     5   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_28�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_28+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_29��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_29�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_29+$ OneWay=�6�   5�      5�      �� 5�      $��Stretch=�6%   $��Stretch=�6C   $��5q�6_   $��1��6j   .+�5�      ]� #��[ 6(   .+�5�   "   �� $
��P_30��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_30�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_30+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_31��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_31�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_31+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_32��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_32�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_32+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_33��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_33�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_33+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_34��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_34�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_34+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_35��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_35�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_35+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_36��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_36�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_36+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_37��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_37�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_37+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_38��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_38�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_38+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_39��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_39�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_39+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_40��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_40�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_40+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_41��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_41�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_41+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_42��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_42�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_42+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_43��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_43�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_43+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_44��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_44�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_44+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_45��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_45�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_45+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_46��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_46�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_46+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_47��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_47�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_47+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_48��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_48�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_48+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_49��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_49�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_49+$ OneWay=�6�   5�      5�      �� 5�      $��Stretch=�6%   $��Stretch=�6C   $��5q�6_   $��2��6j   .+�5�      ]� #��[ 6(   .+�5�   "   �� $
��P_50��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_50�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_50+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_51��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_51�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_51+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_52��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_52�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_52+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_53��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_53�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_53+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_54��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_54�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_54+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $��Rodzaj zwrotu��6,   #��[ 6A   �� 5�   "    �� 
IsEditable$ False��6|   ��6+   �� *Deklaracje.ItemList+$ PropertyChanged=� �� Text 6�   �� *Deklaracje.ItemElementName+�� 5�   "     CheckBoxFormElement#��[ 6+   $��5 0 0 0q�6~    d� 	IsChecked 6X   �� *Deklaracje.Item+6~   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_59��6,   #��[ 68   �� 5�   "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_59+6~   5�      ]� 5�      #��[ 6(   .+�5�   "   �� $
��P_60��6,   #��[ 68     5�   "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_60�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_60+$ OneWay=�6�   5�      ]� 5�      #��[ 6(   .+�5   "   �� $
��P_61��6,   #��[ 68     5  "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_61�$ TwoWay=�$ PropertyChanged=� �� TargetNullValue$ 0����6�   �� *Deklaracje.P_61+$ OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_62��6,   #��[ 68     5  "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_62�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_62+$ OneWay=�6�   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_63��6,   #��[ 68   �� 5	  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_63+6~   5
     ]� 5     #��[ 6(   .+�5  "   �� $
��P_64��6,   #��[ 68   �� 5  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_64+6~   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_65��6,   #��[ 68   �� 5  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_65+6~   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_66��6,   #��[ 68   �� 5  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_66+6~   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_67��6,   #��[ 68   �� 5  "   #��[ 6+   $��0 0 5 0q�6~    6X   �� *Deklaracje.P_67+6~   5     ]� 5     #��[ 6(   .+�5  "   �� $
��P_68��6,   #��[ 68     5  "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_68�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_68+$ OneWay=�6�   5     ]� 5     #��[ 6(   .+�5   "   �� $
��P_69��6,   #��[ 68     5!  "   $	 Right=�6�   #��[ 6�   
 6=   �� $ Deklaracje.P_69�$ TwoWay=�$ PropertyChanged=���6�   �� *Deklaracje.P_69+$ OneWay=�6�   5"     ]� 5#     #��[ 6(   .+�5$  "   �� $��P_ORDZU��6,   #��[ 6;   �� 5%  "    �� 	MaxLength$	 240��6[   $
	 Left=�6k   #��[ 6�   ��6*   �� *Deklaracje.P_ORDZU+$ TwoWay=�6�   5&     5'     5)     5*     5+     �� 5,     $��	Sprzedaż��6   .��5-     �  5.     �� 5/     $
��Auto �6(   �� 50     $��* �6(   .+�52     c� $��0��6    J� 	AllowDrop$ False��6,     ToolBarStyle#��[ 6>    `� IsLocked$
 True��6d   $��30��6�   $��2��6�   .@�53     ��   AddButtonTemplate#��[ 54  !     ToolBarButton#��[ 55  !   $	��Top=�6H   ��53  !   �� *AddNewSaleRowCommand+55  H   �� 56        DeletePurchaseButtonTemplate#��[ 6J   #��[ 6�   $	��Top=�6�   ��6!   �� *DeleteSaleRowCommand+6�   57     59     5:     �� 5;     $��Zakupy��6   $��Stretch=�6&   $��Stretch=�6D   .��5<     �  5=     �� 5>     $
��Auto �6(   �� 5?     $��* �6(   .+�5B     c� $��0��6   $ False��6,   #��[ 6>   $
 True��6d   $��30��6�   .@�5C     ��  	 AddPurchaseButtonTemplate#��[	 6N   #��[ 6�   $	��Top=�6�   ��6!   �� *AddNewPurchaseRowCommand+6�   �� 5D     #��[ 6N   #��[ 6�   $	��Top=�6�   ��6!   �� *DeletePurchaseRowCommand+6�   5E     5H     5I     5J     �� 5K  
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Right=�6V   $��10q�6r   .+�5L     ��  
 SaveButtonTemplate#��[
 6   $��5,0,0,0q�6k   ��6K   �� *SaveCommand+6k   �� 5M       CancelButtonTemplate#��[ 6   $��5,0,5,0q�6o   ��6M   �� *CancelCommand+6o   5N     5O      J� InputBindings 5P     �� 5Q  
   
 �� Key$ Escape��6    �� Command 6"   �� *CancelCommand+5S     