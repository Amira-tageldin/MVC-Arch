using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Model
{
  public  class Employee
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public bool IsDeleted { get; set; }
    
        


        
      
   
          public virtual   Department Department { get; set; }
        public int DepartmentId { get; set; }





    }
}
