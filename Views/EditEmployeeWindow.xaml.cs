using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestTask.Models;
using TestTask.ViewModel;

namespace TestTask.Views
{
  
    public partial class EditEmployeeWindow : Window
    {

        private EditEmployeeViewModel _editEmployeeViewModel;
        public ObservableCollection<Post> Posts { get; set; }

        public EditEmployeeWindow(Employee employee)
        {
            InitializeComponent();

            _editEmployeeViewModel = new EditEmployeeViewModel(employee);
            Posts = new ObservableCollection<Post> { Post.Manager, Post.Worker };
            PostComboBox.ItemsSource = Posts;

            FullNameTextBox.Text = employee.FullName;
            PostComboBox.SelectedItem = employee.Post;
            BirthDatePicker.SelectedDate = employee.BirthDate;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fullName = FullNameTextBox.Text;
            Post? post = PostComboBox.SelectedItem as Post?;
            DateTime? birthDate = BirthDatePicker.SelectedDate;

            if (string.IsNullOrWhiteSpace(fullName) || post == null || birthDate == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            _editEmployeeViewModel.Save(fullName, post.Value, birthDate.Value);
            MessageBox.Show("Сотрудник успешно обновлен");   
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
