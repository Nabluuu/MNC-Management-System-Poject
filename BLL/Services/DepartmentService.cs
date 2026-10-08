using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepartmentService
    {
        DataAccessFactory factory;

        public DepartmentService(DataAccessFactory factory)
        {
            this.factory = factory;
        }

        public List<DepartmentDTO> Get()
        {
            return MapperConfig.GetMapper().Map<List<DepartmentDTO>>(factory.DepartmentData().Get());
        }
        public DepartmentDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<DepartmentDTO>(factory.DepartmentData().Get(id));
        }
        public bool Update(DepartmentDTO d)
        {
            var mappeed = MapperConfig.GetMapper().Map<Department>(d);
            return factory.DepartmentData().Update(mappeed);
        }
        public bool Delete(int id)
        {
            return factory.DepartmentData().Delete(id);
        }
        public bool Create(DepartmentDTO d)
        {
            var mappeed = MapperConfig.GetMapper().Map<Department>(d);
            return factory.DepartmentData().Create(mappeed);
        }
    }
}
