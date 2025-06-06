using System;
using System.Linq;
using System.Windows;
using TestTask.Models;
using TestTask.ViewModel;


namespace TestTask
{
    public partial class CreateEmployeeWindow : Window
    {
        private CreateEmployeeViewModel _viewModel = new CreateEmployeeViewModel();
        private MainViewModel _mainViewModel;
        public CreateEmployeeWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
            PostComboBox.ItemsSource = Enum.GetValues(typeof(Post)).Cast<Post>();

        
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string fullName = FullNameTextBox.Text.Trim();
            Post? post = PostComboBox.SelectedItem as Post?;
            DateTime? birthDate = BirthDatePicker.SelectedDate;

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Введите ФИО");
                return;
            }

            if (post == null)
            {
                MessageBox.Show("Выберите должность");
                return;
            }

            if (birthDate == null)
            {
                MessageBox.Show("Выберите дату рождения");
                return;
            }

            try
            {
                _viewModel.Save(fullName, post.Value, birthDate.Value);
                MessageBox.Show("Сотрудник успешно сохранён");
                _mainViewModel.LoadEmployees();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
