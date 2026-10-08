using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Project
    {
        [Key]
        public int PId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



        public virtual List<Employee> Employees { get; set; }

        public Project()
        {
            Employees = new List<Employee>();
        }
    }
}
