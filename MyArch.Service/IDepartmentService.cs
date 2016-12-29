using MyArch.Model;
using System.Collections.Generic;

namespace MyArch.Service
{
    public  interface IDepartmentService
  {
      IEnumerable<Department> GetAllDepartments();
      void Add(Department department);

      void SaveChanges();

  }
}
