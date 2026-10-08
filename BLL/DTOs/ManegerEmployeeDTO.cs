using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class ManegerEmployeeDTO : ManegerDTO
    {
        public List<EmployeeDTO> Employees { get; set;}

        public ManegerEmployeeDTO() 
        { 
            Employees = new List<EmployeeDTO>();
        }
    }
}
