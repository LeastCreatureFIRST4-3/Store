   M S B A M L   `   `   `  ����  WpfApplication6     WpfApplication6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Матрицы��5   	   $	��350��6   $	��525��6&   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5         AutoGenerateColumns .  $	��154��5   /   $
��Left=�5      $��	44,60,0,0q�6.   $	��Top=�5   $   $	��156��6<      CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns .     EnableRowVirtualization .     CanUserResizeColumns .  ��5	      ��  �� Path$ Table1.Columns�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� ��6'   �� $ Cells���5   "   �� 5   &   .R�5   *   �� 
 �� Orientation$
 
Horizontal=�65   5   +   5   '   ��5   "   �� 5   &   .R�5   *   �� $��2q�61   
���   �._�5   .   �� |�.  .+�5    2   �� $��25��6Q   $��25��6`   $��25��6n   $��25��6}   ��6:   �� *Value+6}   5!   /   5"   +   5#   '   5%      5&      5(      5,        5.   
   -   5        $��	dataGrid2��51       .  $	��154��5/      $
��Left=�6    $��
284,60,0,0q�50      $	��Top=�52      $	��153��53       .   .   .   .   .  ��54      �� $ Table2.Columns� 5;        5<      	 5=      �� 5>      .R�5?      �� ��6'   �� $ Cells���5@   "   �� 5A   &   .R�5B   *   �� $
 
Horizontal=�65   5D   +   5E   '   ��5G   "   �� 5H   &   .R�5I   *   �� $��2q�61   
���   �._�5J   .   �� |�.  .+�5K   2   �� $��25��6Q   $��25��6`   $��25��6n   $��25��6}   ��6:   �� *Value+6}   5L   /   5M   +   5N   '   5P      5Q      5S      5V      �� 5W   
   -   5        $��button1��5W   X   $��+��6   $��27��6   $
��Left=�6)   $��
231,94,0,0q�6D   $	��Top=�6g   $��27��6   6�   �� 5X   
   -   5        $��button2��5X   Y   $��*��6   $��27��6   $
��Left=�6)   $��231,147,0,0q�6D   $	��Top=�6h   $��27��6�   6�   �� 5Y   
   -   5        $��button3��5Y   {   $)��#Найти определитель��6   $��22��6@   $
��Left=�6L   $��
81,264,0,0q�6g   $	��Top=�6�   $��82��6�   $��8(�6�   �� 5Z   
   -   5        $��button4��5Z   i   $)��#Заполнить случайно��6   $��23��6.   $
��Left=�6:   $��
82,235,0,0q�6U   $	��Top=�6x   $��81��6�   $��8(�6�   6�   �� 5[   
   -   5        $��button6��5[   j   $)��#Заполнить случайно��6   $��23��6.   $
��Left=�6:   $��319,235,0,0q�6U   $	��Top=�6y   $��81��6�   $��8(�6�   6�   �� 5\   
   -   5        $��textBox1��5\   L   $��27��6   $
��Left=�6   $��	95,30,0,0q�69   $	��Top=�6\   $��30��6t   �� 5]   
   -	   5        $��textBox2��5]   M   $��27��6   $
��Left=�6   $��
195,30,0,0q�69   $	��Top=�6]   $��30��6u   �� 5^   
   -
   5        $��
textBlock1��5^   O   $��23��6   $
��Left=�6    $��
127,47,0,0q�6;   $"��Кол-во столбцов��6a   $	��Top=�6x   $��8(�6�   �� 5_   
   -   5        $��
textBlock2��5_   5   $��23��6   $��44,47,387,0q�6    $��Кол-во строк��6G   $	��Top=�6[   $��8(�6s   �� 5`   
   -   5        $��
textBlock3��5`   E   $
��Left=�6   $��284,17,0,271q�6/   $��Матрица 2��6W   $��8(�6h   �� 5a   
   -   5        $��
textBlock4��5a   N   $��23��6   $
��Left=�6    $��	44,17,0,0q�6;   $��Матрица 1��6`   $	��Top=�6q   $��8(�6�   �� 5b   
   -   5        $��
textBlock5��5b   O   $��23��6   $
��Left=�6    $��
284,47,0,0q�6;   $��Кол-во строк��6a   $	��Top=�6u   $��8(�6�   �� 5c   
   -   5        $��
textBlock6��5c   O   $��23��6   $
��Left=�6    $��
367,47,0,0q�6;   $"��Кол-во столбцов��6a   $	��Top=�6x   $��8(�6�   �� 5d   
   -   5        $��textBox3��5d   M   $��27��6   $
��Left=�6   $��
335,30,0,0q�69   $	��Top=�6]   $��30��6u   �� 5e   
   -   5        $��textBox4��5e   M   $��27��6   $
��Left=�6   $��
431,30,0,0q�69   $	��Top=�6]   $��30��6u   �� 5f   
   -   5        $��button8��5f   W   $�� ��6   $��11��6   $
��Left=�6(   $��
231,46,0,0q�6C   $	��Top=�6f   $��13��6~   6�   �� 5g   
   -   5        $��button9��5g   W   $�� ��6   $��11��6   $
��Left=�6(   $��
467,46,0,0q�6C   $	��Top=�6f   $��13��6~   6�   5h      5i      