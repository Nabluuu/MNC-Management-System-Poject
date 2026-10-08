using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    internal class EmployeeRepo : IRepo<Employee> , IEmployeeFilterFeature, IEmployeeStatusFeature
    {
        MNCContext db;
        internal EmployeeRepo(MNCContext db)
        {
            this.db = db;
        }

       
        public List<Employee> GetWithDeptId(int id)
        {
            return (from e in db.Employees where e.DId == id select e).ToList();
        }

        public List<Employee> GetWithManegerId(int id)
        {
            return (from e in db.Employees where e.MId == id select e).ToList();
        }

        public List<Employee> GetBySalary(int salary)
        {
            return (from e in db.Employees where e.Salary >= salary select e).ToList();
        }

        public List<Employee> GetByPosition(string position)
        {
            return (from e in db.Employees where e.Position == position select e).ToList();
        }
        public List<Employee> GetByPositionAndSalary(string position, int salary)
        {
            return (from e in db.Employees where e.Position == position && e.Salary >= salary select e).ToList();
        }

        //Crude Operations
        public bool Create(Employee obj)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        public bool UpdateStatus(int EmpId, EmployeeStatus newStatus)
        {
            var employee = db.Employees.Find(EmpId);
            if (employee == null)
                return false;

            if (employee.Status == newStatus)
                return false;

            var oldStatus = employee.Status;
            employee.Status = newStatus;

            var history = new EmployeeStatusHistory
            {
                Id = EmpId,
                OldStatus = oldStatus,
                NewStatus = newStatus,
                ChangedAt = DateTime.UtcNow
            };

            db.EmployeeStatusHistories.Add(history);
            db.SaveChanges();

            return true;
        }

        public List<EmployeeStatusHistory> GetStatusHistory(int EmpId)
        {
            var histories = db.EmployeeStatusHistories
                .Where(sh => sh.Id == EmpId)
                .ToList();

            return histories;
        }
    }
}
