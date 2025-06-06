using System;
using System;
using System.Linq;
using System.Windows;
using TestTask.Models;
using TestTask.ViewModel;

namespace TestTask.Views
{
   
    public partial class CreateCounterpartyWindow : Window
    {
        private readonly CreateCounterpartyViewModel _viewModel;
        private readonly MainViewModel _mainViewModel;

        public CreateCounterpartyWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            _viewModel = new CreateCounterpartyViewModel();

            CuratorComboBox.ItemsSource = _mainViewModel.Employees;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string inn = InnTextBox.Text.Trim();
            Employee curator = CuratorComboBox.SelectedItem as Employee;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(inn) || curator == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            if (inn.Length != 12 || !inn.All(char.IsDigit))
            {
                MessageBox.Show("ИНН должен содержать ровно 12 цифр");
                return;
            }

            try
            {
                _viewModel.Save(name, inn, curator);
                MessageBox.Show("Контрагент успешно добавлен");
                _mainViewModel.LoadCounterparties();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
