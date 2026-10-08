using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class EmployeeFilterDTO
    {
        public List<EmployeeDTO> Employees { get; set; }

        public EmployeeFilterDTO()
        {
            Employees = new List<EmployeeDTO>();
        }

        public int Did { get; set; }
        public int Mid { get; set; }



    }
}
