   M S B A M L   `   `   `  ����C  ?TestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestTask.ViewsTestTask.Views  5   	   -    'TestTask.Views.CreateCounterpartyWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestTask.Views     5   	     � Title$  CreateCounterpartyWindow��5   	   $	��250��6*   $	��804��67   .��5	      � $��
10,10,10,5q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Название:��6   $��0,0,0,5q�6%   �� 5   
   -   5         ��Name$ NameTextBox��5      $��0��6'   $��0,20,0,5q�64   �� 5   
   $��ИНН:��6   $��1��6    $��0,0,0,5q�6-   �� 5   
   -   5        $ 
InnTextBox��5      $��1��6&   $��0,20,0,5q�63   �� 5   
   $��Куратор:��6   $��2��6$   $��0,0,0,5q�61   �� 5   
   -   5         ��Name$ CuratorComboBox��5      $��2��6,   $��0,20,0,5q�69    �� DisplayMemberPath$ FullName��5      �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,26,0,0q�6W   $	��213��6i   .+�5      �� -   5        $��Сохранить��5      $	��100��6)   $��0,0,10,0q�65   $��26��6`   �� 5      -   5        $��Отмена��5      $��82��6&   $��25��6L   5      5      5       