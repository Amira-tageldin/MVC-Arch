using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyArch.Service;

namespace MyArch.Controllers.Api
{
    [AllowAnonymous]
    public class EmployeeController : ApiController
    {

        private IEmployeeService _employeeService;

        public EmployeeController( IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpDelete]
        public  IHttpActionResult DeleteEmployee(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            employee.IsDeleted = true;
            _employeeService.UpdateEmployee(employee);
            _employeeService.SaveChanges();




            return Ok();
        }

    }
}
