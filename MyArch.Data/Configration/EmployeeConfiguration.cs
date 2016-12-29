using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArch.Model;

namespace MyArch.Data.Configration
{
   public class EmployeeConfiguration : EntityTypeConfiguration<Employee> {

       public EmployeeConfiguration()
       {
           Property(e => e.Name).IsRequired().HasMaxLength(88);

           Property(e => e.DepartmentId).IsRequired();
       }
    }
}
