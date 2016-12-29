using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using MyArch.Controllers;
using MyArch.Model;

namespace MyArch.ViewModel
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> EmpViewModels;
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public string Title { get; set; }


        public string Action
        {
            get
            {

                Expression<Func<HomeController, ActionResult>> Create = (c => c.CreateNew(this));

                Expression<Func<HomeController, ActionResult>> Update = (c => c.Update(this));


                var action=(Id !=0)? Update : Create;
                return (action.Body as MethodCallExpression).Method.Name;
            }
        }

        public IEnumerable<DepartmentViewModel> DepartmentsViewmodel;

    }
}