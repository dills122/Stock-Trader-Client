   M S B A M L   `   `   `  ����I  ENewStockClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NewStockClientNewStockClient  5   	       NewStockClient.Client   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NewStockClient     5   	     � Title$  Client��5   	   $	��350��6   $	��500��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��	Buy Stock��6   $��	0,25,0,10q�6$   $��1��67   $��1��6D   $��Center=�6T   6s   �� 5   
   -   5        $��BuyCB��5      $��Center=�6    $��2��6=   $��1��6J   $��0,0,0,0q�6Z   $��50��6k   ��6w   �� 5      �� 5   
   -   5        $��BuyAmt��5      $��Center=�6    $��3��6=   $��1��6J   $��	0,10,0,10q�6Z   $��50��6m   6{   �� 5   
   -   5        $��Buybtn��5      $��Center=�6   $��1��6<   $��4��6L   $��Submit��6Y   $��	0,10,0,10q�6j   6�   �� 5   
   $��
Sell Stock��6   $��	0,25,0,10q�6%   $��1��68   $��3��6E   $��Center=�6U   6t   �� 5   
   -   5        $��SellCB��5      $��Center=�6!   $��2��6>   $��3��6K   $��0,0,0,0q�6[   $��50��6l   ��6x   �� 6�   �� 5    
   -   5        $��SellAmt��5       $��Center=�6!   $��3��6>   $��3��6K   $��	0,10,0,10q�6[   $��50��6n   6|   �� 5!   
   -   5        $��Sellbtn��5!      $��Center=�6    $��3��6=   $��4��6M   $��Submit��6Z   $��	0,10,0,10q�6k   6�   �� 5#   
   -   5        $��Translv��5#      $��2��6#   $��5��63    �� View 5$      �� 5%       �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Authors��66    �� ColumnHeaderContextMenu 5(      �� 5)      .@�5*      m� $��	Ascending��6'   m� 5+      $��
Descending��6'   5,      .P�5/      �� $�� Symbol��6%    �� Width$ 55��66    �� DisplayMemberBinding 6A   �� 	 �� Path$
	 Name��� 50      $�� Date��6%   $ 65��64    6?   �� $		 Age��� 51      $�� Amount��6%   $ 70��66    6A   �� $
	 Book��� 52      $�� Price��6%   $ 70��65    6@   �� $		 Mvp��� 53      $�� Method��6%   $ 70��66    6A   �� $		 Mvp�55      57      58      59      