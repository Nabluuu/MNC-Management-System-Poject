using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DataAccessFactory
    {
        MNCContext db;
        public DataAccessFactory(MNCContext db) 
        {
            this.db = db;
        }
        public IRepo<Maneger> ManegerData()
        {
            return new Repository<Maneger>(db);
        }
        public IRepo<Employee> EmployeeData() 
        {
            return new Repository<Employee>(db);
        }
        public IRepo<Department> DepartmentData() 
        {
            return new Repository<Department>(db);
        }
        public IRepo<Project> ProjectData() 
        {
            return new Repository<Project>(db);
        }
       
        
        
        
        public IManagerFeature ManegerFeature()
        {
            return new ManegerRepo(db);
        }
        public IEmployeeFilterFeature EmployeeFeature()
        {
            return new EmployeeRepo(db);
        }
        public IEmployeeStatusFeature EmployeeStatusFeature()
        {
            return new EmployeeRepo(db);
        }
        public IProjectReportFeature ProjectReportFeature()
        {
            return new ProjectRepo(db);
        }

    }
}
