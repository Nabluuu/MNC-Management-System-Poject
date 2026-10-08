using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int Did { get; set; }
        public int Mid { get; set; }
        public int Status { get; set; }
        public string StatusName
        {
            get
            {
                return ((EmployeeStatus)Status).ToString();
            }
        }

    }
}
