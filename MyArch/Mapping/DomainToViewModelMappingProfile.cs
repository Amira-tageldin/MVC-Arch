using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyArch.Model;
using MyArch.ViewModel;

namespace MyArch.Mapping
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }



        protected override void Configure()
        {
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
          //  CreateMap<Employee, EmployeeFormViewModel>().ReverseMap();


            //  Mapper.Map<Employee, Employee>()

        }
    }
}