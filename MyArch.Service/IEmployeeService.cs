using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArch.Data.Infrastructure;
using MyArch.Data.Repositories;
using MyArch.Model;

namespace MyArch.Service
{
  public  interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployee();
        void Add(Employee Employee);
      void UpdateEmployee(Employee employee);

      Employee GetEmployee(int id);




        void SaveChanges();

    }


    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _unitOfWork;


        private IEmployeeRepository  _employeeRepository;


        public EmployeeService(IUnitOfWork unitOfWork, IEmployeeRepository employeeRepository)
        {
            _unitOfWork = unitOfWork;


            _employeeRepository = employeeRepository;

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeRepository.GetAll();
        }

        public void Add(Employee Employee)
        {
            _employeeRepository.Add(Employee);
        }

        public void SaveChanges()
        {
        _unitOfWork.Commit();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
        }
    }
}
