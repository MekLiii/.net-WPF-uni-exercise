   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         ButtonColor �� Color  ButtonHoverColor  ButtonPressColor  
LabelColor  
LabelStyle �� 
TargetType �� Property �� Value  SpecialLabelStyle �� BasedOn  ButtonStyle  WrapPanelButtonStyle �� Triggers P� Property	 P� Value��%�  &	        &	      &	 <     &	 Z     &	 x     &	 �     7  7  &	 /    7   &	 �    7  7  7  �� 5
   
   $
 #EEE��6.   �� 5   
   $
 #99D��63   �� 5   
   $
 #99F��63   �� 5   
   $
 #900��6-   �� 5   
   " ��6#   .�5      ��  � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6*   8   .�5      ��  � ��8  6+   5      �� 5   
   " ��6$   .�5      ��  � ��8   6+   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��6-   8    5      P� 5       �@J�IsMouseOver$
	 True��61   . �5       ��  � ��8  63   5!      P� 5"       � ��$
	 True��6/   . �5#      ��  � ��8  63   5$      5&      5'      .��5)      � 
 � RowDefinitions
 5*   
   �� 5+      $
��Auto �6   �� 5,      .+�5/   
   � $��0��6    � Orientation$ 
Horizontal=�6!   .+�51      �� #��[ 6   .��6C   
Przycisk 16O   �� 52      #��[ 6   .��6C   
Przycisk 26O   53      �� 55   
   $��1��6    �� Orientation$ Vertical=�6"   .+�57      �� #��[ 6   .��68   
Etykieta6C   �� 58      #��[ 6   .��6?   
Etykieta 26K   59      5:      5;      