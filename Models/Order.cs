using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;

namespace TestTask.Models
{
    [Class(Table = "orders")]
    public class Order
    {
        [Id(Name = "Id", Column = "id", Type = "int")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; set; }

        [Property(Column = "order_date", NotNull = true)]
        public virtual DateTime OrderDate { get; set; }

        [Property(Column = "amount", NotNull = true)]
        public virtual decimal Amount { get; set; }

        [ManyToOne(Column = "employee_id", NotNull = true)]
        public virtual Employee Employee { get; set; }

        [ManyToOne(Column = "contractor_id", NotNull = true)]
        public virtual Counterparty Contractor { get; set; }
    }

}
