using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Логика взаимодействия для CreateOrderWindow.xaml
    /// </summary>
    public partial class CreateOrderWindow : Window
    {
        private readonly MainViewModel _mainViewModel;

        public CreateOrderWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;

            EmployeeComboBox.ItemsSource = _mainViewModel.Employees;
            CounterpartyComboBox.ItemsSource = _mainViewModel.Counterparties;

            OrderDatePicker.SelectedDate = DateTime.Now;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var date = OrderDatePicker.SelectedDate ?? DateTime.Now;
            var amountText = AmountTextBox.Text.Trim();
            var employee = EmployeeComboBox.SelectedItem as Employee;
            var counterparty = CounterpartyComboBox.SelectedItem as Counterparty;

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Введите корректную сумму.");
                return;
            }

            if (employee == null || counterparty == null)
            {
                MessageBox.Show("Выберите сотрудника и контрагента.");
                return;
            }

            try
            {
                using (var session = Data.NhibernateConfig.OpenSession())
                using (var transaction = session.BeginTransaction())
                {
                    var newOrder = new Order
                    {
                        OrderDate = date,
                        Amount = amount,
                        Employee = employee,
                        Counterparty = counterparty
                    };

                    session.Save(newOrder);
                    transaction.Commit();
                }

                MessageBox.Show("Заказ успешно добавлен.");
                _mainViewModel.LoadOrders();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
