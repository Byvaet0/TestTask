   M S B A M L   `   `   `  ����C  ?TestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestTask.ViewsTestTask.Views  5   	   '    !TestTask.Views.EditEmployeeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestTask.Views     5   	     � Title$7  1Редактирование сотрудника��5   	   $	��228��6+   $	��513��68   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   .+�5   
   �� $��ФИО:��6   $��0��6    $��0��6-   $��Center=�6=   $��	0,0,10,10q�6X   �� 5   
   -   5         ��Name$ FullNameTextBox��5      $��0��6+   $��1��68   $��0,0,0,10q�6H   �� 5   
   $��Должность:��6   $��1��6&   $��0��63   $��Center=�6C   $��	0,0,10,10q�6^   �� 5   
   -   5         ��Name$ PostComboBox��5      $��1��6)   $��1��66   $��0,0,0,10q�6F   ��6X   �� *Posts+�� 5   
   $ ��Дата рождения:��6   $��2��6*   $��0��67   $��Center=�6G   $��	0,0,10,10q�6b   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ BirthDatePicker��5      $��2��6.   $��1��6;   $��0,0,0,10q�6K   �� 5!   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   �� 5"   
   -   5        $��Сохранить��5"      $��209,59,83,-78q�6%   $��1��6U   $��3��6e   �� 5#   
   -   5        $��Отмена��5#      $��1��6=   $��294,59,10,-78q�6M   $��3��6d   5$      5%      