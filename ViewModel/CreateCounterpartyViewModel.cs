using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.ViewModel
{
   public class CreateCounterpartyViewModel
   {
        public void Save(string name, string inn, Employee curator)
        {
            using (var session = NhibernateConfig.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var counterparty = new Counterparty
                {
                    Name = name,
                    Inn = inn,
                    Curator = curator
                };

                session.Save(counterparty);
                transaction.Commit();
            }
        }
   }
}
