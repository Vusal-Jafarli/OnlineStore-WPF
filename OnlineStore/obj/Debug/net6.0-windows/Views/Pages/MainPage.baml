   M S B A M L   `   `   `  ����F  BOnlineStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:OnlineStore.Views.PagesOnlineStore.Views.Pages  5      &     OnlineStore.Views.Pages.MainPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:OnlineStore.Views.Pages     5        N� Title$  MainPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      �� 5      $��7* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��0.55* �6    �� 5      �� 5      �� 5      .+�5      �� $��0��6   $/��)../../Multimedia/MainPhotos/mcdonalds.png��6!   $��50��6T   $��50��6`   $��-5 0 0 0q�6l   �� 5      -   5        $��beverage_button��5      
��� ���
�������$��1��6R   .��5      �� $��1��6   $/��)../../Multimedia/MainPhotos/Beverages.jpg��6%   5      �� 5      -   5        $��menu_button��5      
��� ���
�������$��2��6N   .��5       �� $��2��6   $-��'../../Multimedia/MainPhotos/Burgers.jpg��6%   5!      �� 5#      -   5        $��fries_sides_button��5#      
��� ���
�������$��3��6U   .��5$      �� $��3��6   $3��-../../Multimedia/MainPhotos/FriesandSides.jpg��6%   5&      5'      � 5)   
   $��1��6    5*      �� 5+      $��0.17* �6    �� 5,      .+�5:      �� -   5        $��45��5:      $��45��6    $��0q�6,   
�������$��	730,0,0,0q�6S   .��5<      �� $7��1../../Multimedia/MainPhotos/shopping-cart (2).png��6   $��30��6P   $��30��6[   $��UniformToFill=�6g   5=      �� 5>      $��15��6   $��15��6    
��� ��� �� CornerRadius$ 20��6@   $��765,-28,0,0q�6R   $��Center=�6g   $��Center=�6�   ._�5?      �� $
��Bold"�6   $��8(�6J   $��Center=�6W   $	��Top=�6{   
���   �$��0 -4 0 0q�6�   ��6*   �� *order_count+6�   5@      � 5A      $��1��6   .+�5B      � -   5        $��	wrappanel��5B      .+�5C      �� ��6#   �� *Foods+��5D      �� 5E      .R�5F   "   �  � Orientation$ 
Horizontal=�6,   5G      ��5J      �� 5K      .R�5L   "   �� $ 9��6)   $��20 5 0 0q�6:   
�������
��� ���$��1q�5N   5   $	��180��5O   5   $	��150��5P   5   ._�5R   &   � .+�5S   *   �� $	��140��6J   $	��140��6V   $��Center=�6c   $	��Top=�6�   ��60   �� *image+6�   �� 5T   *   $ 9��61   $��Bottom=�6B   $
��Left=�6]   $	��150��6x   $��30��6�   
��� ���._�5U   .   �� $��label1��64   $��14(�5V   <   $��SemiBold"�5W   <   
���   �$��Center=�5Y   <   $��Bottom=�5Z   <   ��5U   B   �� *name+5Z   <   5[   +   �� 5\   *   $.��(../../Multimedia/MainPhotos/plus (2).png��61   $��25��6d   $��25��6o   $��UniformToFill=�6{   $	��Top=�6�   $��Right=�6�   $��0 5 5 0q�6�   �� 5]   *   -   5        $	��0.1(�5]   J   $��30��6Y   $��30��6d   
������ $��0q�6�   $	��Top=�6�   $��Right=�6�   $��0 5 5 0q�6�   ��61   �� *name+6�   5a   '   5b   #   5c      5e      5f      5g      5j      5l      5m      