using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class EmployeeStatusHistoryDTO 
    {
        public int Id { get; set; }
        public EmployeeStatus OldStatus { get; set; } 
        public EmployeeStatus NewStatus { get; set; } 
        public DateTime ChangedAt { get; set; }
    }
}
