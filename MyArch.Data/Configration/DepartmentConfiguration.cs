using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArch.Model;

namespace MyArch.Data.Configration
{
  public  class DepartmentConfiguration :EntityTypeConfiguration<Department>
    {


      public DepartmentConfiguration()
      {
          Property(d => d.Name).IsRequired();
      }
    }
}
