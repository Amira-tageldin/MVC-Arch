using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Model
{
  public  class Department
    {
      public int Id { get; set; }
      public string Name { get; set; }
       IEnumerable<Employee> Employee { get; set; }
       

    //  public   ff { get; set; }

    }
}
