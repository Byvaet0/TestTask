   M S B A M L   `   `   `  ����C  ?TestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestTask.ViewsTestTask.Views  5   	   +    %TestTask.Views.EditCounterpartyWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestTask.Views     5   	     � Title$/  )Изменение контрагента��5   	   $	��204��6'   $	��775��64   .��5	      � $��
10,10,10,8q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   .+�5   
   �� $��Наименование:��6   $��0��6)   $��0��66   $��Center=�6F   $��	0,0,10,10q�6a   �� 5   
   -   5         ��Name$ NameTextBox��5      $��0��6'   $��1��64   $��0,0,0,10q�6D   �� 5   
   $��ИНН:��6   $��1��6    $��0��6-   $��Center=�6=   $��	0,0,10,10q�6X   �� 5   
   -   5        $ 
InnTextBox��5      $��1��6&   $��1��63   $��0,0,0,10q�6C   �� 5   
   $��Куратор:��6   $��2��6$   $��0��61   $��Center=�6A   $��	0,0,10,10q�6\   �� 5   
   -   5         ��Name$ CuratorComboBox��5      $��2��5       $��1��6    $��0,0,0,10q�5!       �� DisplayMemberPath$ FullName��5"      �� 5%   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   �� 5&   
   -   5        $��Сохранить��5&      $��449,43,100,-44q�6%   $��1��6V   $��3��6f   �� 5'   
   -   5        $��Отмена��5'      $��1��6=   $��555,43,0,-44q�6M   $��3��6c   5(      5)      