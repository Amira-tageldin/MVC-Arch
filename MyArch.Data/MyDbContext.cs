using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArch.Data.Configration;
using MyArch.Model;
using System.Security.Claims;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace MyArch.Data
{

   
    public class MyDbContext: IdentityDbContext<ApplicationUser>
    {

        public MyDbContext():base("MyDbContext")
        {
                
        }


        public IDbSet<Employee> Employees{ get; set; }
        public IDbSet<Department> Departments { get; set; }

      


        public virtual void Commit()
        {

            base.SaveChanges();

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Configurations.Add(new EmployeeConfiguration());

            modelBuilder.Configurations.Add(new DepartmentConfiguration());

            base.OnModelCreating(modelBuilder);
        }


        public static MyDbContext Create()
        {
            return new MyDbContext();
        }
    }
}
