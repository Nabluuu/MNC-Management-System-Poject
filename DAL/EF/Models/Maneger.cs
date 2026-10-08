using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EF.Models
{
    public class Maneger
    {
        [Key]
        public int MId { get; set; }
        public string ManName { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public Maneger() 
        {
            Employees = new List<Employee>();
        }
    }
}
