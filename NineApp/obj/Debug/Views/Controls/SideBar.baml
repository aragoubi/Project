   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      B >NineApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Nine.ViewModels.ControlsNine.ViewModels.Controls 5      !   Nine.Views.Controls.SideBar   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      8local&clr-namespace:Nine.ViewModels.Controls     5      .��5      �   � RowDefinitions  5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��65 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��70 �6#   �� 5      $��* �6#   .+�5      �� -   5        $��0��5         MetroCircleButtonStyle#���   6%   $��0��6V   $��50��6c   $��50��5      .��5      �� $��20��6   $��20��6'   
���   � J� OpacityMask 5      !� 5        appbar_lines_horizontal_4 !� Visual# [ 6&    j� Stretch$
 Fill=�6Z   5!      5"      (� 5$      $��1��6   $��40��6&   $
��Left=�65   .��5%      �� $��Segoe UI Light)�6   
������ $��0 0 15 0q�6Q   $��24(�5&   8   ��6   �� *
LessonName+68   5'      5(      �� 5*   
   $��1��6   $��Disabled=�6$   $��0 0 0 10q�6M    �� PanningMode$ VerticalFirst=�5+       �� PanningDeceleration$ 0.001Q�63   .��5.      �� -   5         ��Name$ ThumbsContainer��5.      ��64   �� *Thumbs+
 � Tag 6S   �� ��51      �� 52      .R�55      �� 	 �� Orientation$	 Vertical=�6%   57      ��5;      �� 5<      .R�5=      �� $��
10 10 10 0q�6B   ��6!   �� *Key+��5@      �� 5A   "   
 �� Path$
 Tag.GoToPage�6*    �� RelativeSource 5B   *   ��  �� AncestorType" ����5F      `� 5G   "     ItemsEqualToPageIndex `� 	Converter# [ 6/    `� ConverterParameter$ LessonThumb��5H   /   .1�5I   &   �� $	
 Key�6.   �� 5J   &   $
 Tag.CurrentPageIndex�6.    5K   .   �� " ���� 5L   &   $
 Tag.TeacherPageIndex�6.    5M   .   �� " ��5N   #   .��5R      � $��Stretch=�6#   
������ .+�5S   "   �� $	��100��6A   ��6(   �� *Value+6A   5T      5V      5W      5Z      5\      �� 5^   
   $��2��6   $	 Vertical=�6"   .+�5_      � $��Center=�6   $��Center=�60   .+�5`      )   #MahApps.Metro.Controls.ToggleSwitch     Header$ Synchronisation��6(      	IsChecked 6A   �� *IsSync+ �� Mode$ TwoWay=�5a      5b      5c      5d      