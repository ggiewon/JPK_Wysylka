   M S B A M L   `   `   `  ����L  HJPK_WysylkaXML.UI, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:JPK_WysylkaXML.UI.ViewModelJPK_WysylkaXML.UI.ViewModel  5   	   W SJPK_WysylkaXML.UI.Components, Version=2.0.3.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components 5   	   /    )JPK_WysylkaXML.UI.Views.ConfigurationView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?	viewModel)clr-namespace:JPK_WysylkaXML.UI.ViewModel     5   	   g
componentsPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components     5   	     � ShowInTaskbar$  False��5
   	   $	��200��5   	   $	��500��6    � WindowStartupLocation$ CenterOwner=�5   	    � Title 5   	   9  3JPK_WysylkaXML.UI.Components.TranslateXamlExtension  *ConfigurationView_Title+ � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?�6%   �� 5      $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?�6%   �� 5      $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5    
   ]� $��0��6   .+�5!      �  5"      �� 5#      $
��Auto �6$   �� 5$      $
��Auto �6$   �� 5%      $
��Auto �6$   .+�5'      ]� .+�5(      � $��Stretch=�6   $��Stretch=�69   $��10,10,10,10q�6U    � ColumnDefinitions 5)      �� 5*      $
��Auto �6/   �� 5+      $��* �6/   �� 5,      $
��Auto �6/   .+�5/      �� $��0��6$   $
��Left=�6x   $��Center=�6�   $��	10,0,10,0q�6�   ��64     *#!ConfigurationView_DataFolderLabel+6�   �� 50      $��1��6"   $
��Auto��6�   ��62   �� *
DataFolder+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 52      $��2��6!       SelectFilePathButtonTemplate#��[  61   $��Right=�6�   $��5,0,0,0q�6�   ��6q   �� *OpenFolderDialogCommand+6�   53      55      ]� 57      $��1��6   .+�58      � $��Stretch=�6   $��Stretch=�69   $��10,10,10,10q�6U    59      �� 5:      $
��Auto �6/   �� 5;      $��* �6/   �� 5<      $
��Auto �6/   .+�5?      �� $��0��6$   $
��Left=�6v   $��Center=�6�   $��	10,0,10,0q�6�   ��64     *!ConfigurationView_LanguageLabel+6�   �� 5@      $
��Auto��6#   $��1��60   
 �� SelectedValuePath$
 Value��6�    �� DisplayMemberPath$	 Key��6�    �� SelectedValue 6@   �� *
Language+$ TwoWay=���6p   �� *LanguageList+5B      5C      5E      5F      5G      �� 5H   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Right=�6V   .+�5I      ��   SaveButtonTemplate#��[ 6   $��5,0,0,0q�6k   ��6K   �� *SaveCommand+6k   �� 5J        CancelButtonTemplate#��[ 6   $��5,0,5,0q�6o   ��6M   �� *CancelCommand+6o   5K      5L       J� InputBindings 5N      �� 5O   
   
 �� Key$ Escape��6    �� Command 6"   �� *CancelCommand+5Q      