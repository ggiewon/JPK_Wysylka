   M S B A M L   `   `   `  ���� L  HJPK_WysylkaXML.UI, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:JPK_WysylkaXML.UI.ViewModelJPK_WysylkaXML.UI.ViewModel  W SJPK_WysylkaXML.UI.Components, Version=2.0.4.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.ComponentsJPK_WysylkaXML.UI.Components /    )JPK_WysylkaXML.UI.Views.ConfigurationView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?	viewModel)clr-namespace:JPK_WysylkaXML.UI.ViewModel     g
componentsPclr-namespace:JPK_WysylkaXML.UI.Components;assembly=JPK_WysylkaXML.UI.Components       � ShowInTaskbar$  False��$	��200��$	��500�� � WindowStartupLocation$ CenterOwner=� � Title 9  3JPK_WysylkaXML.UI.Components.TranslateXamlExtension  *ConfigurationView_Title+ � 	Resources  �� MergedDictionaries �� Source��  �� $W Qpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Skins/MainSkin.xaml?��� $k epack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ImageTemplates.xaml?��� $l fpack://application:,,,/JPK_WysylkaXML.UI.Components;component/Resources/Templates/ButtonTemplates.xaml?�%    .���  � RowDefinitions �� $
��Auto ��� $��* ��� $��30 �.+�]� $��0��.+��  �� $
��Auto ��� $
��Auto ��� $
��Auto �.+�]� .+�� $��Stretch=�$��Stretch=�$��10,10,10,10q� � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$
��Left=�$��Center=�$��	10,0,10,0q���  *#!ConfigurationView_DataFolderLabel+�� $��1��$
��Auto������ *
DataFolder+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� $��2��    SelectFilePathButtonTemplate#��[  $��Right=�$��5,0,0,0q����� *OpenFolderDialogCommand+]� $��1��.+�� $��Stretch=�$��Stretch=�$��10,10,10,10q� �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$
��Left=�$��Center=�$��	10,0,10,0q���  *!ConfigurationView_LanguageLabel+�� $
��Auto��$��1��
 �� SelectedValuePath$
 Value�� �� DisplayMemberPath$	 Key�� �� SelectedValue �� *
Language+$ TwoWay=����� *LanguageList+�� $��2�� �� Orientation$ 
Horizontal=�$��Center=�$��Right=�.+���   SaveButtonTemplate#��[ $��5,0,0,0q����� *SaveCommand+��   CancelButtonTemplate#��[ $��5,0,5,0q����� *CancelCommand+ J� InputBindings �� 
 �� Key$ Escape�� �� Command �� *CancelCommand+