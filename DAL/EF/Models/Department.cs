using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EF.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }
        public string DeptName { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }
    }
}
