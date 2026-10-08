using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class EmployeeStatusHistory
    {
        [Key]
        public int HId { get; set; }

        [ForeignKey("Emp")]
        public int Id { get; set; }

        public virtual Employee Emp { get; set; }

        public EmployeeStatus OldStatus { get; set; }
        public EmployeeStatus NewStatus { get; set; }

        public DateTime ChangedAt { get; set; } = DateTime.Now;
    }
}
