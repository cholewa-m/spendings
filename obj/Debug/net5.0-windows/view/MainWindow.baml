   M S B A M L   `   `   `  ����H  Dspendings-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:spendings_WPF.viewspendings_WPF.view  5   	   #    spendings_WPF.view.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:spendings_WPF.view     5   	     � Title$   ��5   	   $	��450��6   $	��800��6    � 
ResizeMode$ CanMinimize=�6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��UrSpendings��6!   $
��Left=�64   $	��Top=�6O   $��10q�6g   $��30(�6s   $��
ExtraBlack"�6�   �� 5   
   -   5         ��Name$ totalSpendingsLabel��5   !   $��0��6   $��Total spendings: 0��6>   $��Right=�6X   $��Center=�6t   $��20q�6�   $��20(�6�   $
��Bold"�6�   
���  ��$��Italic$�6�   �� 5   
   -   5         ��Name$ addSpendingButton��5      $��1��6   $��Add Spending��69   $��15(�6P   $��DemiBold"�6^   $��Right=�6u   $	��Top=�6�   $	��200��6�   $��30��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ spendingDataGrid��5       $��2��6   $��Stretch=�6:   $��Stretch=�6X      AutoGenerateColumns$ False��6t      CanUserResizeColumns$ False��6�      CanUserReorderColumns$ False��6�   	   
IsReadOnly$
	 True��6�   
   SelectionMode$
 Extended=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Title+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Left=�6D   �� 5       � ��$ Center=�6B   �� 5       � ��$ DemiBold"�6;   �� 5       � ��$
 Wrap=�6=   5      5         5!      $
 Date��6%   $ 2* 6e    63   �� *Date+ �� StringFormat$ 
dd-MM-yyyy�� 5"      �� 5#      " ��6    .�5$      ��  � ��$
 Left=�6D   �� 5%       � ��$ Center=�6B   5&      5(        5)      $
 Cost��6%   $ 2* 6L    63   �� *Cost+ 5*      �� 5+      " ��6    .�5,      ��  � ��$
 Left=�6D   �� 5-       � ��$ Center=�6B   5.      50      4  .System.Windows.Controls.DataGridTemplateColumn  51      $ * 6)      CellTemplate 52      �� 53      .R�54      �� -   5        $
��Edit��54   %   $��2q�6M   55      57        58      $ * 6)    59      �� 5:      .R�5;      �� -   5        $��Delete��5;   %   $��2q�6Q   5<      5>      5@      5A      5B      