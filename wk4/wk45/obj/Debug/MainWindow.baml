   M S B A M L   `   `   `  ����M  IControlsBasics-WPF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics'Microsoft.Samples.Kinect.ControlsBasics  5   	   8    2Microsoft.Samples.Kinect.ControlsBasics.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   \ XMicrosoft.Kinect.Toolkit.Controls, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OMicrosoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null2k(http://schemas.microsoft.com/kinect/2013   5   	   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   Clocal5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics   5   	   W SHelixToolkit.Wpf, Version=1.1.0.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  5   	   -   5        $��ControlsBasicsWindow��5	   	     � Title$  Controls Basics��5
   	   $	��500��5   	   $	��700��5   	   $��Segoe UI)�5   	    � 	Resources 5         ChevronGeometry  	ChevronUp �� Stretch
 �� Top �� FallbackValue �� Path �� RelativeSource �� AncestorType?  9Microsoft.Samples.Kinect.ControlsBasics.KinectHoverButton J� RenderTransformOrigin	 �� Angle  ChevronRight  ChevronDown  ChevronLeft  KinectHoverButtonStyle
 �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value " KinectHoverButtonScrollUpStyle �� BasedOn % !KinectHoverButtonScrollRightStyle $  KinectHoverButtonScrollDownStyle $	  KinectHoverButtonScrollLeftStyle��%�  &	       &	 �    7   &	 Y   7   &	 .   7   &	    7   &	 �    &	 �    7  7  &	 ?    7  7  &	 �    7  7  &		 �    7  7  B�5   
   miF1M150.001,146.9932L126.565,169.3822L126.565,153.5962L150.001,130.6182L173.435,153.5962L173.435,169.3822z�5      F� 5   
   $��48��6!   $��48��6-   $ Uniform=�68   $ 0��6J   8��  ��5      �� $ Black��$ 
Foreground� �� "  $ 0.5,0.5&�5   M   z�5      �� 5      $	 0Q�6"   5       F� 5"   
   $��48��6$   $��48��60   $ Uniform=�6;   $ 0��6M   8��  ��5$      �� $ Black��$ 
Foreground� �� "  $ 0.5,0.5&�5%   M   z�5&      �� 5'      $	 90Q�6"   5)      F� 5+   
   $��48��6#   $��48��6/   $ Uniform=�6:   $ 0��6L   8��  ��5-      �� $ Black��$ 
Foreground� �� "  $ 0.5,0.5&�5.   M   z�5/      �� 50      $		 180Q�6"   52      F� 54   
   $��48��6#   $��48��6/   $ Uniform=�6:   $ 0��6L   8��  ��56      �� $ Black��$ 
Foreground� �� "  $ 0.5,0.5&�57   M   z�58      �� 59      $		 270Q�6"   5;      �� 5=   
   "
  6/   .�5>      ��  � ��
 �����6+   �� 5?       � ��
 �����6,   �� 5@       � ��$ 0q�60   6<   �� 5A       � ��
 �����6;   �� 5B       � �� 5C      �� 5D      "  6&   .R�5E      � $��Stretch=�6   $��Stretch=�6=   #��z��6Y   #��z��6�   #��z��6�   .+�5F      �� #��z��6%   #��z��6Y   ._�5G   "   �� $��Stretch=�63   $��Stretch=�6Q   #��z��6m   6�   5H      5I      5J      5L       5M      P� 5N       � {� .  . �5O      ��  � ��
 �����63   �� 5P       � ��
 �����64   �� 5Q       � ��
 ���� 6I   5R      P� 5S       �@ IsHandPointerOver . . �5T      ��  � �� �#5A5B5B63   �� 5U       � ��
 �����63   5V      5X      �� 5Z   
   "
  67   8   .�5[      ��  � ��8  6(   5\      �� 5^   
   "
  6:   8   .�5_      ��  � ��8  6(   5`      �� 5b   
   "
  69   8   .�5c      ��  � ��8  6(   5d      �� 5f   
   "
  69   8   .�5g      ��  � ��8  6(   5h      5i      .��5k      �  � RowDefinitions 5l   
   �� 5m      $
��Auto �6   �� 5n      $��* �6   .+�5q   
   � $��0��6   $��
10 0 10 20q�6   .+�5r      �� $
��Left=�6   $��Bottom=�6/   $��Images\Logo.png��6J   $
��None=�6c   $��0 0 0 4q�6r   8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  5s      $	��100��6b   $��Center=�6o   $	��Top=�6�   4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion 6!   ��  �� ElementName$ kinectRegion��6�   4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  5t      -   5        $��sensorChooserUi��5t   [   $��Center=�6&   $	��Top=�6C   6[   �� 5u      $��Right=�6   $��0 0 -1 0q�64   $��Bottom=�6F    
 MediumGreyBrush#��[
 6a   $��18(�6�   Controls Basics6�   &   HelixToolkit.Wpf.HelixViewport3D  5v      $��
0,0,0,-140q�6       Children. 5w      $  HelixToolkit.Wpf.DefaultLights    HelixToolkit.Wpf.Teapot  5x       g� 	Transform 5y      �� 5z       �� Rotation 5{      �� 5|   "   -   5        Ro�� �� Axis$ 0 1 05�5|   B    �� Angle$ 45Q�6O   5}   #   5      5�      5�      5�        5�   
   -   5          Name$ kinectRegion��5�   &   $��1��6   $��	0,140,0,0q�6<   .��5�      � -   5         �Name$ kinectRegionGrid��5�      $��10,20,10,20q�6-    5�      �� 5�      $��* �6$   �� 5�      $	��170 �6$   .+�5�      :  4Microsoft.Kinect.Toolkit.Controls.KinectScrollViewer  -   5        $��scrollViewer��5�   4   $��0��6'   $��Visible=�6H   $��Disabled=�6p   .��5�      � -   5         �Name$ 	wrapPanel��5�   ;   $��Center=�6     � Orientation$ Vertical=�6N   .+�5�      8	  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton	   	  Label$ 1��6-   	  5�      $ 2��6-   	  5�      $ 3��6-   	  5�      $ 4��6-   	  5�      $ 5��6-   	  5�      $ 6��6-   	  5�      $ 7��6-   	  5�      $ 8��6-   	  5�      $ 9��6-   	  5�      $ 10��6-   5�      5�      � 5�      $��1��6   $��Stretch=�6$   $��Stretch=�6B   $��0, 10, 0, 10q�6^    � ColumnDefinitions 5�      �� 5�      $��* �6+   �� 5�      $��10 �6+   �� 5�      $��* �6+   .+�5�        ?
   9Microsoft.Samples.Kinect.ControlsBasics.KinectHoverButton  
  Click$  PageLeftButtonClick��6x   $��0��6.   #��[	 6>   {�6�   �� $ ControlsBasicsWindow��$ PageLeftEnabled�  5�      $  PageRightButtonClick��6y   $��2��6.   #��[ 6>   {�6�   �� $ ControlsBasicsWindow��$ PageRightEnabled�5�      5�      5�      5�      5�      