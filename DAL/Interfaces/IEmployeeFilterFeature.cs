using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IEmployeeFilterFeature
    {
        List<Employee> GetWithDeptId(int id);
        List<Employee> GetWithManegerId(int id);
        List<Employee> GetBySalary(int salary);
        List<Employee> GetByPosition(string position);

        List<Employee> GetByPositionAndSalary(string position, int salary);
    }
}
