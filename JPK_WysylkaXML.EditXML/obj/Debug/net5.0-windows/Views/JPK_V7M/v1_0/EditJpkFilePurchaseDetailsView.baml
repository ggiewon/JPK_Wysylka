   M S B A M L   `   `   `  ����W  SJPK_WysylkaXML.UI.Components, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components  5   	   Q MJPK_WysylkaXML.EditXML, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0.JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0 5   	   N   HJPK_WysylkaXML.EditXML.Views.JPK_V7M.v1_0.EditJpkFilePurchaseDetailsView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   g
componentsPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     5   	   Mv101<clr-namespace:JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0     5   	     � ShowInTaskbar$  False��5
   	    � SizeToContent$ WidthAndHeight=�5   	    � Title$ Edycja wiersza zakupów��5   	    � Icon$ /AppIcon.ico��5   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?�6%   �� 5      $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�6%   �� 5      $d ^pack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/FormStyles.xaml?�6%   �� 5      $g apack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/TextBoxStyles.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Styles/SimpleScrollViewer.xaml?�6%   %    5      .��5      �� $��5q�6   .+�5   
   � $��Stretch=�6   $��Stretch=�6-    � ColumnDefinitions 5       �� 5!      $��* �6#   �� 5"      $��* �6#   .+�5%      �� $��Stretch=�6   $��Stretch=�67   $��5q�6S   $��0��6^   .+�5&      ]�    FormLineDockPanel#��[  6   .+�5'      �� $��LpZakupu��6      TextBlockFormElement#��[ 60   �� 5(      	 �� 
IsReadOnly$
	 True��6j   ��6   �� *
LpZakupu+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ OneWay=�6j   5)      ]� 5*      #��[  6   .+�5+      �� $��KodKrajuNadaniaTIN��6    #��[ 6:   �� 5,      ��6   �� *KodKrajuNadaniaTIN+$
 PropertyChanged=�5-      ]� 5.      #��[  6   .+�5/      �� $��
NrDostawcy��6    #��[ 62   �� 50      ��6   �� *
NrDostawcy+$
 PropertyChanged=�51      ]� 52      #��[  6   .+�53      �� $��NazwaDostawcy��6    #��[ 65   �� 54      ��6   �� *NazwaDostawcy+$
 PropertyChanged=�55      ]� 56      #��[  6   .+�57      �� $��DowodZakupu��6    #��[ 63   �� 58      ��6   �� *DowodZakupu+$
 PropertyChanged=�59      ]� 5;      #��[  6   .+�5<      �� $��
DataZakupu��6    #��[ 62   (  "System.Windows.Controls.DatePicker  5=         SelectedDate 6!   �� *
DataZakupu+$
 PropertyChanged=�5>      ]� 5?      #��[  6   .+�5@      �� $��
DataWplywu��6    #��[ 62   �� 5A        CheckBoxFormElement#��[ 6   $��0 0 5 0q�6v    d� 	IsChecked 6L   �� *DataWplywuSpecified+6v     5B       6!   �� *
DataWplywu+$
 PropertyChanged=�5C      ]� 5D      #��[  6   .+�5E      �� $��DokumentZakupu��6    #��[ 66   �� 5F      #��[ 6   $��0 0 5 0q�6z    6L   �� *DokumentZakupuSpecified+6z   �� 5G       �� 
IsEditable$ False��6o   ��6   �� *DokumentZakupuList+$
 PropertyChanged=� �� Text 6�   �� *DokumentZakupu+5H      ]� 5I      #��[  6   .+�5J      �� $	��MPP��6    #��[ 6+   �� 5K      #��[ 6    6L   �� *MPP+5L      ]� 5M      #��[  6   .+�5N      �� $	��IMP��6    #��[ 6+   �� 5O      #��[ 6    6L   �� *IMP+5P      ]� 5Q      #��[  6   .+�5R      �� $��ZakupVAT_Marza��6    #��[ 66   �� 5S      #��[ 6   $��0 0 5 0q�6z    6L   �� *ZakupVAT_MarzaSpecified+6z   1   +JPK_WysylkaXML.UI.Components.NumericTextBox  5T      $	��100��6�    �� TextAlignment$ Right=�6�     SimpleTextBox#��[ 6�      Value 60   ��  �� Path$ ZakupVAT_Marza�$ TwoWay=�$
 PropertyChanged=���6�   �� *ZakupVAT_Marza+$ OneWay=�6�   5U      5V      �� 5X      $��Stretch=�6   $��Stretch=�67   $��5q�6S   $��1��6^   .+�5Y      ]� #��[  6   .+�5Z      �� $
��K_40��6      ShortTextBlockFormElement#��[ 6,     5[      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_40�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_40+$ OneWay=�6�   5\      ]� 5^      #��[  6   .+�5_      �� $
��K_41��6    #��[ 6,     5`      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_41�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_41+$ OneWay=�6�   5a      ]� 5b      #��[  6   .+�5c      �� $
��K_42��6    #��[ 6,     5d      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_42�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_42+$ OneWay=�6�   5e      ]� 5f      #��[  6   .+�5g      �� $
��K_43��6    #��[ 6,     5h      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_43�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_43+$ OneWay=�6�   5i      ]� 5k      #��[  6   .+�5l      �� $
��K_44��6    #��[ 6,   �� 5m      #��[ 6   $��0 0 5 0q�6p    6L   �� *K_44Specified+6p     5n      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_44�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_44+$ OneWay=�6�   5o      ]� 5q      #��[  6   .+�5r      �� $
��K_45��6    #��[ 6,   �� 5s      #��[ 6   $��0 0 5 0q�6p    6L   �� *K_45Specified+6p     5t      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_45�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_45+$ OneWay=�6�   5u      ]� 5w      #��[  6   .+�5x      �� $
��K_46��6    #��[ 6,   �� 5y      #��[ 6   $��0 0 5 0q�6p    6L   �� *K_46Specified+6p     5z      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_46�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_46+$ OneWay=�6�   5{      ]� 5}      #��[  6   .+�5~      �� $
��K_47��6    #��[ 6,   �� 5      #��[ 6   $��0 0 5 0q�6p    6L   �� *K_47Specified+6p     5�      $	��100��6�   $ Right=�6�   #��[ 6�    60   �� $
 K_47�$ TwoWay=�$
 PropertyChanged=���6~   �� *K_47+$ OneWay=�6�   5�      5�      5�      �� 5�   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Right=�6I   .+�5�      ��   SaveButtonTemplate#��[ 6   $��5,0,0,0q�6k   ��6K   �� *SaveCommand+6k   �� 5�        CancelButtonTemplate#��[ 6   $��5,0,5,0q�6o   ��6M   �� *CancelCommand+6o   5�      5�       J� InputBindings 5�      �� 5�   
   
 �� Key$ Escape��6    �� Command 6"   �� *CancelCommand+5�      