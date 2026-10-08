using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
   public interface IEmployeeStatusFeature
    {
        bool UpdateStatus(int employeeId, EmployeeStatus newStatus);

        List<EmployeeStatusHistory> GetStatusHistory(int employeeId);
    }
}
