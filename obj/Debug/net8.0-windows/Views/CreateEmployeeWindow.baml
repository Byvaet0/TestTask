   M S B A M L   `   `   `  ����C  ?TestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TestTaskTestTask  5   	   #    TestTask.CreateEmployeeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TestTask     5   	     � Title$+  %Создание сторудника��5   	   $	��217��6%   $	��570��62   .��5	      � $��10,10,10,20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   $��0��6@   .+�5      �� $��ФИО:��6   $	��100��6#   $��Center=�6/   �� 5      -   5         ��Name$ FullNameTextBox��5      $	��250��6/   5      �� 5   
   $ 
Horizontal=�6   $��0,0,0,10q�6.   $��1��6@   .+�5      �� $��Должность:��6   $	��100��6)   $��Center=�65   �� 5      -   5         ��Name$ PostComboBox��5      $	��250��6-   5      �� 5   
   $ 
Horizontal=�6   $��0,0,0,10q�6.   $��2��6@   .+�5      �� $ ��Дата рождения:��6   $	��100��6-   $��Center=�69   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ BirthDatePicker��5      $	��250��62   5      �� 5!   
   $ 
Horizontal=�6   $��Right=�6.   $��3��6J   $��0,39,0,0q�6W   $��2��6i   .+�5"      �� -   5        $��Сохранить��5"      $��90��6)   64   �� 5#      -   5        $��Отмена��5#      $��90��6&   $��5,0,0,0q�61   6B   5$      5%      5&      