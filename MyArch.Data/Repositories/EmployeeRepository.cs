using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArch.Data.Infrastructure;
using MyArch.Model;

namespace MyArch.Data.Repositories
{
  public  class EmployeeRepository :RepositoryPattern<Employee>,IEmployeeRepository
    {
      public EmployeeRepository(IDbfactory dbfactory) : base(dbfactory)
      {
      }
    }



    public interface IEmployeeRepository : IRepository<Employee>
    {
        



    }
}
