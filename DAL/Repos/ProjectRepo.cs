using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    internal class ProjectRepo : IRepo<Project>, IProjectReportFeature
    {
        MNCContext db;
        public ProjectRepo(MNCContext db)
        {
            this.db = db;
        }

        public bool Create(Project p)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> Get()
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Project p)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectReports(int PId)
        {
            return db.Projects.Include(p => p.Employees).ToList();
        }
    }
}
