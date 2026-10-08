using DAL.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class MNCContext : DbContext
    {
        public MNCContext(DbContextOptions<MNCContext>options)
        : base(options){ }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.Maneger> Manegers { get; set; }
        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<EmployeeStatusHistory> EmployeeStatusHistories { get; set; }
        //public DbSet<EmployeeStatus>  { get; set; }

    }
}
