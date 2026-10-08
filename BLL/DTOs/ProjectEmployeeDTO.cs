using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class ProjectEmployeeDTO : ProjectDTO
    {
        public List<EmployeeDTO> Employees { get; set; }

        public ProjectEmployeeDTO()
        {
            Employees = new List<EmployeeDTO>();
        }
    }
}
