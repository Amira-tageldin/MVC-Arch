using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Microsoft.ApplicationInsights.WindowsServer;

namespace MyArch.Mapping
{
    public class AutoMapperConfiguration
    {


        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDominMappingProfile>();


            });



        }
    }
}