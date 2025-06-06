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
 
    public partial class EditOrderWindow : Window
    {
        private readonly MainViewModel _mainViewModel;
        private readonly Order _order;

        public EditOrderWindow(MainViewModel mainViewModel, Order order)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            _order = order;

            EmployeeComboBox.ItemsSource = _mainViewModel.Employees;
            CounterpartyComboBox.ItemsSource = _mainViewModel.Counterparties;

           
            OrderDatePicker.SelectedDate = _order.OrderDate;
            AmountTextBox.Text = _order.Amount.ToString();
            EmployeeComboBox.SelectedItem = _order.Employee;
            CounterpartyComboBox.SelectedItem = _order.Counterparty;
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
                    var orderToUpdate = session.Get<Order>(_order.Id);
                    if (orderToUpdate != null)
                    {
                        orderToUpdate.OrderDate = date;
                        orderToUpdate.Amount = amount;
                        orderToUpdate.Employee = employee;
                        orderToUpdate.Counterparty = counterparty;

                        session.Update(orderToUpdate);
                        transaction.Commit();
                    }
                }

                MessageBox.Show("Заказ успешно обновлён.");
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
