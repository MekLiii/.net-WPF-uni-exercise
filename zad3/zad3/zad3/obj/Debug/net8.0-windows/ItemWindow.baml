   M S B A M L   `   `   `  ����  zad3     MediaLibraryApp.ItemWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Item Details��5   	   $	��300��6   $	��400��6+   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Tytuł:��6   $��0��6"   $��0��6/   $��Center=�6?   �� 5   
   $��0��6.   $��1��6;   $��5q�6K   ��6   �� *
Item.Title+6K   �� 5   
   $��Reżyser/Autor:��6   $��1��6*   $��0��67   $��Center=�6G   �� 5   
   $��1��60   $��1��6=   $��5q�6M   ��6   �� *Item.Creator+6M   �� 5   
   $��Studio/Wydawca:��6   $��2��6+   $��0��68   $��Center=�6H   �� 5   
   $��2��62   $��1��6?   $��5q�6O   ��6   �� *Item.Publisher+6O   �� 5   
   $��Nośnik:��6   $��3��6#   $��0��60   $��Center=�6@   �� 5   
   $��3��6^   $��1��6k   $��5q�6{   ��6   �� *
MediaTypes+ �� SelectedItem 66   �� *Item.MediaType+6{   �� 5   
   $��Data Wydania:��6   $��4��6)   $��0��66   $��Center=�6F   (  "System.Windows.Controls.DatePicker  5   
   $��4��6?   $��1��6L   $��5q�6\      SelectedDate 6   �� *Item.ReleaseDate+6\   �� 5   
    �� Orientation$ 
Horizontal=�6   $��6��6.   $��2��6;   $��Center=�6O   $��10q�6l   .+�5      �� -   5        $��OK��5      $��5q�69   �� 5      -   5        $��Anuluj��5      $��5q�6A   5       5!      5"      