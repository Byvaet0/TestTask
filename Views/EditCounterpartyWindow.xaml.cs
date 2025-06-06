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
using TestTask.Data;
using TestTask.Models;
using TestTask.ViewModel;

namespace TestTask.Views
{

    public partial class EditCounterpartyWindow : Window
    {
        private EditCounterpartyViewModel _editCounterpartyViewModel;
        private Counterparty _counterparty;

        public ObservableCollection<Employee> Curators { get; set; }

        public EditCounterpartyWindow(Counterparty counterparty)
        {
            InitializeComponent();

            _counterparty = counterparty;
            _editCounterpartyViewModel = new EditCounterpartyViewModel(_counterparty);

            Curators = new ObservableCollection<Employee>(LoadEmployees());
            CuratorComboBox.ItemsSource = Curators;

            NameTextBox.Text = _counterparty.Name;
            InnTextBox.Text = _counterparty.Inn;
            CuratorComboBox.SelectedItem = Curators.FirstOrDefault(e => e.Id == _counterparty.Curator.Id);

            this.DataContext = this;
        }

       
        private ObservableCollection<Employee> LoadEmployees()
        {
            using (var session = NhibernateConfig.OpenSession())
            {
                var list = session.Query<Employee>().ToList();
                return new ObservableCollection<Employee>(list);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string inn = InnTextBox.Text.Trim();
            var curator = CuratorComboBox.SelectedItem as Employee;

            if (string.IsNullOrWhiteSpace(name)
                || string.IsNullOrWhiteSpace(inn)
                || curator == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return;
            }

            
            _editCounterpartyViewModel.Save(name, inn, curator);

            MessageBox.Show("Контрагент успешно обновлён.",
                            "Успех",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

            this.DialogResult = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

