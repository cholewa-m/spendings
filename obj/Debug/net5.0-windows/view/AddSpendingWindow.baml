   M S B A M L   `   `   `  ����H  Dspendings-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:spendings_WPF.viewspendings_WPF.view  5   	   *    $spendings_WPF.view.AddSpendingWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:spendings_WPF.view     5   	     � Title$   ��5   	   $	��450��6   $	��800��6    � 
ResizeMode$ NoResize=�6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $	��400 �6   �� 5      $��* �6   .+�5   
   �� $��Add Spending��6   $��0��6'   $��2��64   $��Center=�6D   $��Bottom=�6a   $��10q�6|   $��20(�6�   $��	ExtraBold"�6�   �� 5   
   $��Title:��6   $��1��6!   $��1��6.   $��DemiBold"�6>   �� 5   
   -   5         ��Name$ titleTextBox��5      $��1��6(   $��2��65   �� 5   
   $��Cost:��6   $��DemiBold"�6    $��2��66   $��1��6C   �� 5   
   -   5        $ costTextBox��5      $��2��6'   $��2��64   �� 5!   
   $��Date:��6   $��DemiBold"�6    $��3��66   $��1��6C   (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$ 
datePicker��5"      $��3��6)   $��2��66   �� 5$   
   -   5         ��Name$ 	addButton��5$      $	��Add��6$   $��4��6J   $��2��6W   $��25��6g   $��5q�6s   $��DemiBold"�6~   5%      5&      