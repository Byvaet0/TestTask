using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        public ObservableCollection<Counterparty> Counterparties { get; set; } = new ObservableCollection<Counterparty>();
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();

        private ObservableCollection<object> _currentItems;
        public ObservableCollection<object> CurrentItems
        {
            get => _currentItems;
            set
            {
                _currentItems = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
          
            LoadEmployees();
        }


        public void LoadEmployees()
        {
            using (var session = NhibernateConfig.OpenSession())
            {
                var employees = session.Query<Employee>().ToList();
                Employees.Clear();
                foreach (var e in employees)
                    Employees.Add(e);

                
                CurrentItems = new ObservableCollection<object>(Employees);
            }
        }

        public void LoadCounterparties()
        {
            using (var session = NhibernateConfig.OpenSession())
            {
                var counterparties = session.Query<Counterparty>()
                                    .Fetch(c => c.Curator)  
                                    .ToList();

                Counterparties.Clear();
                foreach (var c in counterparties)
                    Counterparties.Add(c);


                CurrentItems = new ObservableCollection<object>(Counterparties);
            }
        }


        public void LoadOrders()
        {
            using (var session = NhibernateConfig.OpenSession())
            {
                var orders = session.Query<Order>()
                           .Fetch(o => o.Employee)        
                           .Fetch(o => o.Counterparty)    
                           .ToList();
                Orders.Clear();
                foreach (var o in orders)
                    Orders.Add(o);

                CurrentItems = new ObservableCollection<object>(Orders);
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
