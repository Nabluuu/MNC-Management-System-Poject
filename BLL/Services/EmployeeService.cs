using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class EmployeeService
    {
        DataAccessFactory factory;

        public EmployeeService(DataAccessFactory factory)
        {
            this.factory = factory;
        }

        public List<EmployeeDTO> Get()
        {
            return MapperConfig.GetMapper().Map<List<EmployeeDTO>>(factory.EmployeeData().Get());
        }
        public EmployeeDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<EmployeeDTO>(factory.EmployeeData().Get(id));
        }
        public bool Update(EmployeeDTO e)
        {
            var mappeed = MapperConfig.GetMapper().Map<Employee>(e);
            return factory.EmployeeData().Update(mappeed);
        }
        public bool Delete(int id)
        {
            return factory.EmployeeData().Delete(id);
        }
        public bool Create(EmployeeDTO e)
        {
            var mappeed = MapperConfig.GetMapper().Map<Employee>(e);
            return factory.EmployeeData().Create(mappeed);
        }



        public List<EmployeeDTO> GetWithManegerId(int id)
        {
            var data = factory.EmployeeFeature().GetWithManegerId(id);
            var ret = MapperConfig.GetMapper().Map<List<EmployeeDTO>>(data);
            return ret;
        }
        public List<EmployeeDTO> GetWithDeptId(int id)
        {
            var data = factory.EmployeeFeature().GetWithDeptId(id);
            var ret = MapperConfig.GetMapper().Map<List<EmployeeDTO>>(data);
            return ret;
        }
        public List<EmployeeDTO> GetBySalary(int salary)
        {
            var data = factory.EmployeeFeature().GetBySalary(salary);
            var ret = MapperConfig.GetMapper().Map<List<EmployeeDTO>>(data);
            return ret;
        }
        public List<EmployeeDTO> GetByPosition(string position)
        {
            var data = factory.EmployeeFeature().GetByPosition(position);
            var ret = MapperConfig.GetMapper().Map<List<EmployeeDTO>>(data);
            return ret;
        }
        public List<EmployeeDTO> GetPositionIDAndSalary(string position, int salary)
        {
            var data = factory.EmployeeFeature().GetByPositionAndSalary(position, salary);
            var ret = MapperConfig.GetMapper().Map<List<EmployeeDTO>>(data);
            return ret;

        }

        public bool UpdateStatus(int id, EmployeeStatusDTO dto)
        {
            var mappeed = MapperConfig.GetMapper().Map<EmployeeStatusDTO>(dto);
            return factory.EmployeeStatusFeature().UpdateStatus(id, mappeed.Status);
        }


        public List<EmployeeStatusHistoryDTO> GetStatusHistory(int Id)
        {
            var histories = new List<EmployeeStatusHistoryDTO>();
            var data = factory.EmployeeStatusFeature().GetStatusHistory(Id);
            foreach (var history in data)
            {
                var dto = new EmployeeStatusHistoryDTO
                {
                    OldStatus = MapperConfig.GetMapper().Map<EmployeeStatusDTO>(history.OldStatus).Status,
                    NewStatus = MapperConfig.GetMapper().Map<EmployeeStatusDTO>(history.NewStatus).Status,
                    ChangedAt = history.ChangedAt
                };
                histories.Add(dto);
            }
            return histories;
           
        }
    }
        
}

