using AutoMapper;
using OrganisationX.Data;
using OrganisationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Employees, EmployeesVM>().ReverseMap();
            CreateMap<Education, EducationVM>().ReverseMap();
            CreateMap<JobInfo, JobInfoVM>().ReverseMap();
            CreateMap<Salary, SalaryVM>().ReverseMap();
        }
    }
}
