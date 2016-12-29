using System.Collections.Generic;
using MyArch.Model;
using MyArch.ViewModel;


namespace MyArch.ViewModel
{
    public class EmployeeFormViewModel
    {
        public string Name { get; set; }



        public int DepartmentId { get; set; }
   public IEnumerable<EmployeeFormViewModel> Department { get; set; }



    }
}