   M S B A M L   `   `   `  ���� B  >NineApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Nine.Views.ControlsNine.Views.Controls  E ARadialMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM5clr-namespace:RadialMenu.Controls;assembly=RadialMenuRadialMenu.Controls T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls $    Nine.Views.Pages.FreeNotesPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  0Controls!clr-namespace:Nine.Views.Controls  F
RadialMenu5clr-namespace:RadialMenu.Controls;assembly=RadialMenu  IMahApps;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  -     � 	Resources     BottomSideBar �� 
TargetType �� Triggers �� Binding �� ElementName �� Value N� EnterActions �� TargetProperty O� KeyTime	 �� 	KeySpline
 O� Value N� ExitActions  LeftSideBar��%  &	        &	     �� " � ��  �� *DataContext.IsFullscreenMode+$ 
LayerStack�� True �� .���� .��U� $ Height�.\��� $ 0:0:0.75��$	 0.25,1,0.05,1��
 0 �� .���� .��U� $ Height�.\��� $ 0:0:0.75��$	 0.25,1,0.05,1��
 60�� " � ��  �� *DataContext.IsFullscreenMode+$ 
LayerStack�� True �� .���� .��U� $ Width�.\��� $ 0:0:0.75��$	 0.25,1,0.05,1��
 0 �� .���� .��U� $ Width�.\��� $ 0:0:0.75��$	 0.25,1,0.05,1��
 200.��]�   SideBarBackgroundBrush#��[ .+�� $��Bottom=�.+�    Nine.Views.Controls.AppBar  -     Name$ AppBar��$��0�� � DataContext �� *DataContext.AppBarState+$ 
LayerStack��
 � Tag �� *DataContext+$ 
LayerStack��� $��Bottom=�$��60��#��[  .+�'   !Nine.Views.Controls.BottomSideBar  -     Name$ BottomSideBar�� �� *DataContext+$ 
LayerStack��]� $	��Top=�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ PreviewTouchDown��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *DataContext.Close+$ AppBar��  $ PreviewMouseDown��.    �� *DataContext.Close+$ AppBar��.+�� $
��Left=�$	��200��#��[ .+�!   Nine.Views.Controls.SideBar  -     Name$ LessonSidebar�� �� *
LessonPage+� -   $��Right=�  ContentBackgroundBrush#��[ .+���  K� ZIndex$ 10��}�. .+�%   Nine.Views.Controls.RadialMenus  -     Name$ 
RadialMenu��$ 10�� �� *DataContext+$ 
LayerStack�� �� Left �� *RadialMenuState.LeftPosition+
 �� Top �� *RadialMenuState.TopPosition+/	   )Nine.Views.Controls.RadialMenuStateButton	  -    	 Name$ RadialMenuOpenButton��$ 0��$	 140�� �� Right$	 155�� �� $ LessonContainer�� �� *DataContext+$ 
LayerStack��+
   %Nine.Views.Controls.TouchScrollViewer
  -    
 Name$ LessonContainer��$ 0��# 
  IsContentManipulationEnabled .  
  HorizontalOffset �� *'%DataContext.Viewport.HorizontalOffset+$ 
LayerStack�� �� Mode$ TwoWay=� 
  VerticalOffset �� *%#DataContext.Viewport.VerticalOffset+$ 
LayerStack��$ TwoWay=�.��� -	     �Name$  LessonContent��! �� IsFlicksEnabled! .  " �� IsPressAndHoldEnabled" .  # �� IsTapFeedbackEnabled# .  $ �� IsTouchFeedbackEnabled$ .     $ PreviewTouchDown��.    �� *DataContext.CloseRadialMenu+$ 
LayerStack��  $ PreviewMouseDown��.    �� *DataContext.CloseRadialMenu+$ 
LayerStack��% � LayoutTransform% �� & �� ScaleX& �� *DataContext.Viewport.Scale+$ 
LayerStack��' �� ScaleY' �� *DataContext.Viewport.Scale+$ 
LayerStack��.+�/   )Nine.Views.Controls.DrawingAreaBackground  -
   (  Name$( DrawingAreaBound��$ 0��$
��2800��$
��2000��$   Nine.Views.Controls.LayerStack  -   )  Name$) 
LayerStack��$ 10�� �� *LayerStackDC+���� *Width+$ DrawingAreaBound������ *Height+$ DrawingAreaBound��