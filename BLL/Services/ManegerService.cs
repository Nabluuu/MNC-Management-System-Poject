using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ManegerService
    {
        DataAccessFactory factory;
            
        public ManegerService(DataAccessFactory factory)
        {
            this.factory = factory;
        }

        //Basic Crude opt.
        public List<ManegerDTO> Get()
        {
            return MapperConfig.GetMapper().Map<List<ManegerDTO>>(factory.ManegerData().Get());
        }
        public ManegerDTO Get(int id)
        {
            return MapperConfig. GetMapper().Map<ManegerDTO>(factory.ManegerData().Get(id));
        }
        public bool Update(ManegerDTO d)
        {
            var mappeed = MapperConfig.GetMapper().Map<Maneger>(d);
            return factory.ManegerData().Update(mappeed);
        }
        public bool Delete(int id)
        {
            return factory.ManegerData().Delete(id);
        }
        public bool Create(ManegerDTO d)
        {
            var mappeed = MapperConfig.GetMapper().Map<Maneger>(d);
            return factory.ManegerData().Create(mappeed);
        }


        //Features with Employee
        public List<ManegerEmployeeDTO> GetWithAllEmployee()
        {
            var data = factory.ManegerFeature().GetWithAllEmployee();
            var ret= MapperConfig.GetMapper().Map<List<ManegerEmployeeDTO>>(data);
            return ret; 
        }
        public ManegerEmployeeDTO GetWithEmployeeId(int id)
        {
            var data = factory.ManegerFeature().GetWithEmployeeId(id);
            var ret = MapperConfig.GetMapper().Map<ManegerEmployeeDTO>(data);
            return ret;
        }
        public ManegerEmployeeDTO FindByName(string Name)
        {
            var data = factory.ManegerFeature().FindByName(Name);
            var ret = MapperConfig.GetMapper().Map<ManegerEmployeeDTO>(data);
            return ret;
        }
        public ManegerEmployeeDTO FindbyNameWithEmployee(string name)
        {
            var data = factory.ManegerFeature().FindbyNameWithEmoployee(name);
            var ret = MapperConfig.GetMapper().Map<ManegerEmployeeDTO>(data);
            return ret;
        }
    }
}
