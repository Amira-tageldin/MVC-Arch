using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArch.Data.Infrastructure;
using MyArch.Model;

namespace MyArch.Data.Repositories
{

    public  class DepartmentRepository :RepositoryPattern<Department>,IDepartmentRepository
    {
        public DepartmentRepository(IDbfactory dbfactory) : base(dbfactory)
        {
        }
    }

    public   interface IDepartmentRepository : IRepository< Department>
    {


    }
}
