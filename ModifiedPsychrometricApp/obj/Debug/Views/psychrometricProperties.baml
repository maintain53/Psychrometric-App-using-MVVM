   M S B A M L   `   `   `  ����S  OModifiedPsychrometricApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ModifiedPsychrometricApp.ViewsModifiedPsychrometricApp.Views  5      <    6ModifiedPsychrometricApp.Views.psychrometricProperties   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ModifiedPsychrometricApp.Views     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius J� Opacity �� RelativeTransform	 T� Y
 � Offset � Color �� 
StartPoint �� EndPoint �� Triggers P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions �� 
TargetName��%  '��       �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@J�SnapsToDevicePixels . 64   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ BackgroundBorder��6%   $��1q�6?   
����������#696969$ 4��6}   �� 5      $ 
GlowBorder��6%   $	 1.5��6:   $��2q�6M   $ 0Q�6X   ��5   "   
� 5   &    5   *   T� 5   .   $		 0.6Q�6A   .��5   *   � $	
 0.2Q�67   $ #86AF��6D   � 5   *   $	
 1.2Q�67   $ #06AF��6D   5   '   5"      �� 5%      $ HighlightBorder��6%   $	 1.5��6>   $��2q�6Q   $��1q�6\   ��5&   "   �� 5'   &   $	 0,0&�6:   $	 0,1&�6K   .��5(   *   � $
 0Q�67   $ #AFFF��6B   � 5)   *   $	
 0.5Q�67   $ #4FFF��6D   � 5*   *   $	
 0.5Q�67   $ #0FFF��6D   � 5+   *   $	
 1.0Q�67   $ #2FFF��6D   5,   '   ��5/   "   �� 50   &   $	 0,0&�6:   $	 0,1&�6K   .��51   *   � $
 0Q�67   $ #DFFF��6B   � 52   *   $	
 0.5Q�67   $ #4FFF��6D   � 53   *   $	
 1.0Q�67   $ #7AFF��6D   54   '   57      �� 59      $��0,0,0,2q�6/   $��Center=�6@   $��Center=�6[   5;       5<      P� 5>       �@J�IsMouseOver .  5?   "   �� 5@   &   .��5A   *   �� .��5B   .   W� $ 
GlowBorder��5C      $ Opacity�5D      $ 1X�5E      $ 0:0:0.1D�5F      5G   +   5H   '    5K   "   �� 5L   &   .��5M   *   �� .��5N   .   W� $ 
GlowBorder��5O      $ Opacity�5P      $ 0:0:0.6D�5Q      5R   +   5S   '   5U      P� 5W       � �� . . �5X   "   �� $ HighlightBorder��6)    � �� 5Y   &   �� 5Z   *   $	 0,0&�6>   $	 0,1&�6O   .��5[   .   � $
 0Q�6;   $ Coral��6F   � 5\   .   $	
 0.4Q�6;   $ #2FFF��6H   � 5]   .   $	
 0.6Q�6;   $ #0FFF��6H   � 5^   .   $	
 1.0Q�6;   $ #1FFF��6I   5_   +   5a   #   �� 5b   "   $ HighlightBorder��6)    � �� �#6FFF6]   5c      5f      5h      5i      5k      .��5m      �  � RowDefinitions 5n   
   �� 5o      $
��Auto �6   6-   �� 5p      $
��Auto �6   6.   �� 5q      $��* �6   6+   �� 5r      $
��Auto �6   6-   .+�5u   
   ��  �� Orientation$ Vertical=�6   $��0��6,   .+�5v      ��  K� Capitals$ AllSmallCaps=�6   $��32(�6;   $
��Bold"�6I   $��Center=�5w      $��WrapWithOverflow=�62   $3��-**Select the given property from the dropdown��5x      $��0,0,0,5q�6G   �� 5y      $	��300��6   $��15(�6#   $
��Bold"�61   ��6C   �� *ComboProperties+ �� SelectedIndex 6m   �� *SelectedIndex+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5z      � 5|   
   $��1��6    5}      �� 5~      $
��Auto �6    61   �� 5      $
��Auto �6!   62   �� 5�      $
��Auto �6!   62   �� 5�      $
��Auto �6    61    � ColumnDefinitions 5�      �� 5�      $
��Auto �6#   64   �� 5�      $
��Auto �6#   64   �� 5�      $
��Auto �6#   63   .+�5�      �� $��Dry Bulb Temperature (oC)��6   $��0��69   $��0��6F   $��Center=�6V   $��5,0,0,0q�6q   $��16(�6�   �� 5�      -   5         ��Name$ DryBulb��5�      $
��Left=�6)   $��1��6E   $��0��6R   $	��100��6b   
���   �$��30��6�   $��16(�6�   $��40,0,0,0q�6�   ��6�   �� *	DryBulb+$ TwoWay=�$ PropertyChanged=��� 5�      $��Wet Bulb Temperature (oC)��6   $��0��69   $��1��6F   $��Center=�6�   $��5,0,0,0q�6�   $��16(�6�   y�6W   �� *WetBulbVisibility2+6�   �� 5�      -   5        $ Wetbulb��5�      $
��Left=�6(   $	��100��6C   $��30��6O   
���   �$��1��6o   $��16(�6|   $��1��6�   $��40,0,0,0q�5�      y�6#   �� *WetBulbVisibility+��6N   �� *	WetBulb+$ TwoWay=�$ PropertyChanged=��� 5�      $��Relative humidty (%)��6   $��0��64   $��1��6A   $��Center=�6Q   $��5,0,0,0q�6�   $��16(�6�   y�6l   �� *RelHumidityVisibility2+6�   �� 5�      -   5        $ Relhumidity��5�      $��40,0,0,0q�6Z   $��30��6l   $
��Left=�6x   $	��100��6�   
���   �$��1��6�   $��16(�6�   $��1��6�   y�6,   �� *RelHumidityVisibility+��5�      ��   �� Path$  RelHumidity�$ TwoWay=�$ PropertyChanged=��� 5�      $��DewPoint Temperature (oC)��6   $��0��69   $��1��6F   $��Center=�6�   $��5,0,0,0q�6�   $��16(�6�   y�6V   �� *DewPointVisibility2+6�   �� 5�      -   5        $ DewPoint��5�      $
��Left=�5�      $	��100��60   $��1��6<   $��1��6I   $��30��6Y   
���   �$��16(�6y   $��40,0,0,0q�6�   y�5�   (   �� *DewPointVisibility+��6S   �� *
DewPoint+$ TwoWay=�$ PropertyChanged=�5�   �   �� 5�      -   5        ! ��Name$! reset��5�      $��15(�6%   $
��Bold"�63   $��Oblique$�6g   $��Reset��6{   $��
40,15,78,0q�5�      $	��Top=�6*   $��36��6B   $��0��6N   $��2��6^   ��5�   E   �� $  ResetBtn�5�   ^   �� 5�      -   5        $! 	calculate��5�      $��15(�6)   $
��Bold"�67   $��	Calculate��6I   $��Oblique$�6]   $��
40,15,85,0q�6r   $	��Top=�5�      $	��100��6-   $��36��69   $��1��6k   $��2��6{   ��6E   �� $  CalculateBtn�6{   5�      &   System.Windows.Controls.DataGrid  5�   
   -   5        $��DataGrid��5�       $��2��6   $��5,20,5,2q�60   "   AutoGenerateColumns" .  #   CanUserAddRows# .  $   
IsReadOnly$ . %   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
% Auto 5�   )   $��16(�6<   $&   HorizontalScrollBarVisibility$
& Auto=�6J   ��5�   B   �� *DataGridDetails+'   Columns' 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn(   Header$( Enthalpy(kJ/Kg)��6%   1  +System.Windows.Controls.DataGridBoundColumn)   Binding) 6>   �� $  Enthalpy�$ TwoWay=�  5�      $( Specific Volume(m3/kg)��6%   ) 6E   �� $  Volume�$ TwoWay=�  5�      $( Humidity Ratio(Kg/kg)��6%   ) 6D   �� $  HumidityRatio�$ TwoWay=�  5�      $( Saturated Pressure(KPa)��6%   ) 6F   �� $  SatPressure�$ TwoWay=�  5�      $( Partial Pressure(Kpa)��6%   ) 6D   �� $  PartialPressure�$ TwoWay=�  5�      $( Density(kg/m3)��6%   ) 6=   �� $  Density�$ TwoWay=�  5�      $( WetBulb Temperature(oC)��6%   ) 6F   �� $  WetBulb�$ TwoWay=�  5�      $( Relative Humidity(%)��6%   ) 6C   �� $  RelHumidity�$ TwoWay=�  5�      $( DewPoint Temperature(oC)��6%   ) 6G   �� $  DewPoint�$ TwoWay=�5�      � 5�   
   $��3��6   .+�5�      �� $��13(�6   $��  Copyright MAINTAIN 2018��6'   5�      5�      5�      