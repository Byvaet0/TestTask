using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.ViewModel
{
    public class EditCounterpartyViewModel
    {
        private Counterparty _counterparty;

        public EditCounterpartyViewModel(Counterparty counterparty)
        {
            _counterparty = counterparty;
        }

        public void Save(string name, string inn, Employee curator)
        {
            using (var session = NhibernateConfig.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
               
                _counterparty.Name = name;
                _counterparty.Inn = inn;
                _counterparty.Curator = curator;

                session.Update(_counterparty);
                transaction.Commit();
            }
        }
    }
}
