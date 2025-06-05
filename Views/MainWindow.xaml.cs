using System.Text;
using System.Windows;
using System.Windows.Controls;
using TestTask.ViewModel;

namespace TestTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
    }
}