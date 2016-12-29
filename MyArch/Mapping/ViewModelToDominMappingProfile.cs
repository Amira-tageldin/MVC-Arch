using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyArch.Model;
using MyArch.ViewModel;

namespace MyArch.Mapping
{
    public class ViewModelToDominMappingProfile:Profile
    {

        public  override string ProfileName
        { 


            get { return "DomainToViewModelMapping"; }
        }



        protected override void Configure()
        {

          // CreateMap<Employee,EmployeeFormViewModel>().ForMember(x => x.Department , opt => opt.Ignore())

            //   .ForMember(g => g.Name , map => map.MapFrom(vm => vm.Name ))
              // .ForMember(g => g.DepartmentId, map => map.MapFrom(vm => vm.DepartmentId ))
                //;


         


        }

    }
}