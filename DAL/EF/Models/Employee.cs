using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }

        public int Salary { get; set; }


        [ForeignKey("Dept")]
        public int DId { get; set; }

        public virtual Department Dept { get; set; }

        [ForeignKey("Man")]
        public int MId { get; set; }
        public virtual Maneger Man { get; set; }

        public EmployeeStatus Status { get; set; } = EmployeeStatus.Active;

        public virtual ICollection<EmployeeStatusHistory> StatusHistories { get; set; }
    }
}
