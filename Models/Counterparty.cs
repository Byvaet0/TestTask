using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;

namespace TestTask.Models
{
    [Class(Table = "counterparties")]
    public class Counterparty
    {
        [Id(Name = "Id", Column = "id", Type = "int")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; set; }

        [Property(Column = "name", NotNull = true)]
        public virtual string Name { get; set; }

        [Property(Column = "inn", NotNull = true, Length = 12)]
        public virtual string Inn { get; set; }

        [ManyToOne(Column = "curator_id", NotNull = true)]
        public virtual Employee Curator { get; set; }
    }
}
