using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class MapperConfig
    {
        static MapperConfiguration cfg = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
            cfg.CreateMap<Employee, EmployeeDTO>().ReverseMap();
            cfg.CreateMap<Maneger, ManegerDTO>().ReverseMap();
            cfg.CreateMap<Project, ProjectDTO>().ReverseMap();

            cfg.CreateMap<Maneger, ManegerEmployeeDTO>().ReverseMap();
            cfg.CreateMap<Project, ProjectEmployeeDTO>().ReverseMap();

            cfg.CreateMap<EmployeeStatus, EmployeeStatusDTO>().ReverseMap();
           //cfg.CreateMap<EmployeeStatusDTO, EmployeeStatusHistoryDTO>().ReverseMap();
            cfg.CreateMap<EmployeeStatusHistory, EmployeeStatusHistoryDTO>().ReverseMap();


        });

        public static Mapper GetMapper()
        {
            return new Mapper(cfg);
        }
    }
}