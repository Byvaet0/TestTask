using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.ViewModel
{
    public class EditEmployeeViewModel
    {
        private Employee _employee;

        public EditEmployeeViewModel(Employee employee)
        {
            _employee = employee;
        }

        public void Save(string fullName, Post post, DateTime birthDate)
        {
            using (var session = NhibernateConfig.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                _employee.FullName = fullName;
                _employee.Post = post;
                _employee.BirthDate = birthDate;

                session.Update(_employee);
                transaction.Commit();
            }
        }
    }
}
