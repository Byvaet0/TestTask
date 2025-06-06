using System.Text;
using System.Windows;
using System.Windows.Controls;
using TestTask.Data;
using TestTask.Models;
using TestTask.ViewModel;
using TestTask.Views;

namespace TestTask
{
  
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            this.DataContext = _viewModel;
           
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl tabControl)
            {
                var selectedTab = (TabItem)tabControl.SelectedItem;

                if (selectedTab.Header.ToString() == "Сотрудники")
                    _viewModel.LoadEmployees();
                else if (selectedTab.Header.ToString() == "Контрагенты")
                    _viewModel.LoadCounterparties();
                else if (selectedTab.Header.ToString() == "Заказы")
                    _viewModel.LoadOrders();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeGrid.IsVisible)
            {
                var createEmployeeWindow = new CreateEmployeeWindow(_viewModel);
                createEmployeeWindow.ShowDialog();
            }
            else if (CounterpartyGrid.IsVisible)
            {
                var createCounterpartyWindow = new CreateCounterpartyWindow(_viewModel);
                createCounterpartyWindow.ShowDialog();
            }
            else if (OrderGrid.IsVisible)
            {
                var createOrderWindow = new CreateOrderWindow(_viewModel);
                createOrderWindow.ShowDialog();
            }



        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeGrid.IsVisible)
            {
                var selectedEmployee = EmployeeGrid.SelectedItem as Employee;
                if (selectedEmployee == null)
                {
                    MessageBox.Show("Пожалуйста, выберите сотрудника для редактирования.");
                    return;
                }

                var editEmployeeWindow = new EditEmployeeWindow(selectedEmployee);
                editEmployeeWindow.ShowDialog();

                _viewModel.LoadEmployees();
            }
            else if (CounterpartyGrid.IsVisible)
            {
                var selectedCounterparty = CounterpartyGrid.SelectedItem as Counterparty;
                if (selectedCounterparty == null)
                {
                    MessageBox.Show("Пожалуйста, выберите контрагента для редактирования.");
                    return;
                }

                var editCounterpartyWindow = new EditCounterpartyWindow(selectedCounterparty);
                if (editCounterpartyWindow.ShowDialog() == true)
                {
                    _viewModel.LoadCounterparties();
                }
            }
            else if (OrderGrid.IsVisible)
            {
                var selectedOrder = OrderGrid.SelectedItem as Order;
                if (selectedOrder == null)
                {
                    MessageBox.Show("Пожалуйста, выберите заказ для редактирования.");
                    return;
                }

                var editOrderWindow = new EditOrderWindow(_viewModel, selectedOrder);
                editOrderWindow.ShowDialog();
            }

        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeGrid.IsVisible)
            {
                var selectedEmployee = EmployeeGrid.SelectedItem as Employee;
                if (selectedEmployee == null)
                {
                    MessageBox.Show("Пожалуйста, выберите сотрудника для удаления.");
                    return;
                }

                var result = MessageBox.Show($"Вы уверены, что хотите удалить сотрудника \"{selectedEmployee.FullName}\"?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    using (var session = NhibernateConfig.OpenSession())
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(selectedEmployee);
                        transaction.Commit();
                    }

                    MessageBox.Show("Сотрудник успешно удалён.");
                }

                
                _viewModel.LoadEmployees();
            }
            else if(CounterpartyGrid.IsVisible)
            {
                var selectedCounterparty = CounterpartyGrid.SelectedItem as Counterparty;
                if (selectedCounterparty == null)
                {
                    MessageBox.Show("Пожалуйста, выберите контрагента для удаления.");
                    return;
                }

                var result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить контрагента \"{selectedCounterparty.Name}\"?",
                    "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    using (var session = NhibernateConfig.OpenSession())
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(selectedCounterparty);
                        transaction.Commit();
                    }

                    MessageBox.Show("Контрагент успешно удалён.");
                }

                _viewModel.LoadCounterparties();
            }
            if (OrderGrid.IsVisible)
            {
                var selectedOrder = OrderGrid.SelectedItem as Order;
                if (selectedOrder == null)
                {
                    MessageBox.Show("Пожалуйста, выберите заказ для удаления.");
                    return;
                }

                var result = MessageBox.Show($"Вы уверены, что хотите удалить заказ от {selectedOrder.OrderDate:d} на сумму {selectedOrder.Amount}?","Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        using (var session = Data.NhibernateConfig.OpenSession())
                        using (var transaction = session.BeginTransaction())
                        {
                            session.Delete(selectedOrder);
                            transaction.Commit();
                        }

                        MessageBox.Show("Заказ успешно удалён.");
                        _viewModel.LoadOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении: " + ex.Message);
                    }
                }
            }

        }

        
    }
}