   M S B A M L   `   `   `  ����C  ?TestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestTask.ViewsTestTask.Views  5   	   $    TestTask.Views.EditOrderWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestTask.Views     5   	     � Title$'  !Изменение заказов��5   	   $	��343��6#   $	��612��60   .��5	      � $��10,10,10,44q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0 0 0 10q�6,   .+�5      �� $��Дата заказа:��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ OrderDatePicker��5      $��29��62   5      �� 5   
   $��1��6   $ Vertical=�6"   $��0 0 0 10q�69   .+�5      �� $��Сумма:��6   �� 5      -   5         ��Name$ AmountTextBox��5      $��24��6-   5      �� 5   
   $��2��6   $ Vertical=�6"   $��0 0 0 10q�69   .+�5      �� $��Сотрудник:��6   �� 5      -   5         ��Name$ EmployeeComboBox��5       �� DisplayMemberPath$ FullName��61   5      �� 5!   
   $��3��6   $ Vertical=�6"   $��0 0 0 10q�69   .+�5"      �� $��Контрагент:��6   �� 5#      -   5        $ CounterpartyComboBox��5#      $
 Name��65   5$      �� 5&   
   $��4��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5'      �� -   5        $��Сохранить��5'      $��0 0 10 0q�6)   $	��100��6;   6G   �� 5(      -   5        $��Отмена��5(      $	��100��6&   62   5)      5*      5+      