using System;
using TestTask.Models;
using TestTask.Data; // NHibernateHelper

namespace TestTask.ViewModel
{
    public class CreateEmployeeViewModel
    {
        public void Save(string fullName, Post post, DateTime birthDate)
        {
            using (var session = NhibernateConfig.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var employee = new Employee
                {
                    FullName = fullName,
                    Post = post,
                    BirthDate = birthDate
                };

                session.Save(employee);
                transaction.Commit();
            }
        }
    }
}
