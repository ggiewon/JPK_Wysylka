   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   SimpleScrollBar  �� 
TargetType �� Property �� Value �� 
TargetType �Name � 	Resources  Key'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   Transitions%  System.Windows.VisualTransition	   GeneratedDuration
   
Storyboard �� 
TargetName �� TargetProperty	 �� To g� Duration	 W� To ��Name ��Name � ColumnDefinitions ��Name �� Interval  SmallChangeButton �� Stretch  LargeChangeButton n�Name  ThumbTemplate � RowDefinitions�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      %�
  &	        7  7  7  7  7  7  7  7  7  7  �� "  ��.���  � ��$ 18����  � ��$ 18����  � ��$ False����  � �� �� " ��.R�� $
 Root�� ���� LargeChangeButton " ��.R�� $
 Root��
������    CommonStates��.   
Normal���� SmallChangeButton " ��.R�� $
 Root��   CommonStates��   $	 0:0:0.1D�.   
Normal��  	MouseOver��.
 �� .���� $ 
Background��$1 +(Border.Background).(SolidColorBrush.Color)�	 #2000  Pressed��.
 �� .���� $ 
Background��$1 +(Border.Background).(SolidColorBrush.Color)�	 #4000  Disabled��.
 �� .��W� $ 0:0:0D�$ 
Background��$ Opacity� .7.+��� $ 
Background�����#0000._��� #��z���� ThumbTemplate " n�.R��    CommonStates��   $	 0:0:0.1D�.   
Normal��  	MouseOver��.
 �� .���� $ 0D�$ 
Background��$* $(Shape.Fill).(SolidColorBrush.Color)� 	#80C5E2EC  Pressed��.
 �� .���� $ 0D�$ 
Background��$* $(Shape.Fill).(SolidColorBrush.Color)� #A0A0A0  Disabled��.
 �� .��W� $ 0:0:0D�$ 
Background��$ Opacity� 0.+��� $ 
Background�����#D0D0D0���#404040$��1��   CommonStates��.   
Normal��  	MouseOver��  Disabled��.
 �� .��W� $ 0D�$
 Root��$ Opacity� 0.5.+�� $ HorizontalRoot�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto �.+��� $��5�����#F0F0F0�� $ HorizontalSmallDecrease��$��18��$��0��$ 50��$��False��8��  .��F� $��4��$��7��"����     � �@B @B �@B     	���#404040$
 Fill=��� $ HorizontalLargeDecrease��$��0��$��1��$ 50��$��False��8�� n� $ HorizontalThumb��$��18��$��2��$	��0,2q�8�� �� $ HorizontalLargeIncrease��$��3��$ 50��$��False��8�� �� $ HorizontalSmallIncrease��$��18��$��4��$ 50��$��False��8�� .��F� $��4��$��7��"����        �@B  � �    @B 	���#404040$
 Fill=�� $ VerticalRoot��$y�	Collapsed=� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto �.+��� $��5�����#F0F0F0�� $ VerticalSmallDecrease��$��16��$��0��$ 50��$��False��8�� .��F� $��7��$��4��"����    @B �@B @B � �     	���#404040$
 Fill=��� $ VerticalLargeDecrease��$��18��$��1��$ 50��$��False��8�� n� $ VerticalThumb��$��16��$��16��$��2��$	��2,0q�8�� �� $ VerticalLargeIncrease��$��3��$ 50��$��False��8�� �� $ VerticalSmallIncrease��$��18��$��4��$ 50��$��False��8��	 .��F� $��7��$��4��"����        �@B     � � @B 	���#404040$
 Fill=�