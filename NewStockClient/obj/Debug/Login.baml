   M S B A M L   `   `   `  ����I  ENewStockClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NewStockClientNewStockClient  5   	       NewStockClient.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NewStockClient     5   	     � Title$  Stock Trader��5   	   $	��200��6   $	��425��6+   .��5
      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��Auto �6   �� 5      $	��200 �6   .+�5   
   �� $��0��6   $��3��6   $��Center=�61   $%��Stock Trader Client V-1.0 ALPHA��6N   �� 5   
   $��1��6   $��1��6   $��	Username:��6-   �� 5   
   $��3��6   $��1��6   $��	Password:��6-   �� 5   
   -   5        $��Errorlb��5   L   $��4��6   $��1��6   $�� ��6-   $y�Hidden=�68   6L   �� 5   
   -   5        $��Usernametxt��5      $��1��6%   $��2��62   $��50,0,0,0q�6B   $	��150��6T   G� 5   
   -   5        $��Passwordtxt��5      $��3��6)   $��2��66   $��50,0,0,0q�6F   $	��150��6X   �� 5   
   -   5        $��	Submitbtn��5      $��4��6"   $��2��6/   $	��100��6?   $��	50,20,0,0q�6K   .��6v   Login6}   �� 5   
   -   5        $��
Newuserbtn��5      $��4��6#   $��1��60   $	��100��6@   $��Bottom=�6L   $
��Left=�6g   $��-20,0,0,-30q�6�   $��2��6�   .��6�   	New User?6�   �� 5    
   -   5        $��Forgotpassbtn��5       $��4��6&   $��2��63   $	��100��6C   $��Bottom=�6O   $��Right=�6j   $��0,0,-40,-30q�6�   .��6�   Forgot Password6�   5!      5"      