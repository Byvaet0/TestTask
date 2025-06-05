using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;

namespace TestTask.Models
{
    [Class(Table = "employees")]
    public class Employee
    {
        [Id(Name = "Id", Column = "id", Type = "int")]
        [Generator(1, Class = "native")] 
        public virtual int Id { get; set; }

        [Property(Column = "full_name", NotNull = true)]
        public virtual string FullName { get; set; }

        [Property(Column = "post", NotNull = true, TypeType = typeof(NHibernate.Type.EnumStringType<Post>))]
        public virtual Post Post { get; set; }

        [Property(Column = "birth_date", NotNull = true)]
        public virtual DateTime BirthDate { get; set; }
    }


    public enum Post { Manager, Worker }

}
