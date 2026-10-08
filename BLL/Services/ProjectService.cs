using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ProjectService
    {
        DataAccessFactory factory;

        public ProjectService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<ProjectDTO> Get()
        {
            return MapperConfig.GetMapper().Map<List<ProjectDTO>>(factory.ProjectData().Get());
        }
        public ProjectDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<ProjectDTO>(factory.ProjectData().Get(id));
        }
        public bool Update(ProjectDTO p)
        {
            var mappeed = MapperConfig.GetMapper().Map<Project>(p);
            return factory.ProjectData().Update(mappeed);
        }
        public bool Delete(int id)
        {
            return factory.ProjectData().Delete(id);
        }
        public bool Create(ProjectDTO p)
        {
            var mappeed = MapperConfig.GetMapper().Map<Project>(p);
            return factory.ProjectData().Create(mappeed);
        }

        public List<ProjectDTO> GetProjectReports(int PId)
        {
            var repo = factory.ProjectReportFeature();
            var data = repo.GetProjectReports(PId);
            return MapperConfig.GetMapper().Map<List<ProjectDTO>>(data);
        }
    }
}
