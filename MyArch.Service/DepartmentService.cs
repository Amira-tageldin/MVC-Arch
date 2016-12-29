using System.Collections.Generic;
using MyArch.Data.Infrastructure;
using MyArch.Data.Repositories;
using MyArch.Model;

namespace MyArch.Service
{
    public class DepartmentService : IDepartmentService
    {

        private IUnitOfWork _unitOfWork;
        private IDepartmentRepository _departmentRepository; 
        public DepartmentService( IUnitOfWork unitOfWork , IDepartmentRepository departmentRepository)
        {

            _unitOfWork = unitOfWork;
            _departmentRepository = departmentRepository;
        }
        public void Add(Department department)
        {
            _departmentRepository.Add(department);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }


        public void SaveChanges()
        {
            


            _unitOfWork.Commit();
        }
    }
}