


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyArch.Model;
using MyArch.Service;
using MyArch.ViewModel;
using AutoMapper;

namespace MyArch.Controllers
{
    public class HomeController : Controller
    {

        private IEmployeeService _employeeService;

        private IDepartmentService _departmentService;

        public HomeController(IEmployeeService employeeService , IDepartmentService departmentService)
        {
            _employeeService = employeeService;

            _departmentService = departmentService;

        }

        public ActionResult Index( string sortOrder , string sortBy, string Page, string searchTerm =null  )
        {
            ViewBag.sortorder = sortOrder;

            ViewBag.sortBy = sortBy;




            EmployeeViewModel EmpViewModel = new EmployeeViewModel();


            EmpViewModel.EmpViewModels = _employeeService.GetAllEmployee().ToList().Where(e=> e.IsDeleted != true);

            ViewBag.totalPages = Math.Ceiling(EmpViewModel.EmpViewModels.Count()/ 3.0);

          

            switch ( sortBy)
            {

                case "Name":


                    switch (sortOrder)
                    {

                        case "Desc":
                            EmpViewModel.EmpViewModels = EmpViewModel.EmpViewModels.OrderByDescending(e => e.Name).ToList();
                            break;
                        case "Asc":

                            EmpViewModel.EmpViewModels = EmpViewModel.EmpViewModels.OrderBy(e => e.Name).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case "Department":
                    switch (sortOrder)
                    {

                        case "Desc":
                            EmpViewModel.EmpViewModels = EmpViewModel.EmpViewModels.OrderByDescending(e => e.Department.Name).ToList();
                            break;
                        case "Asc":

                            EmpViewModel.EmpViewModels = EmpViewModel.EmpViewModels.OrderBy(e => e.Department.Name).ToList();
                            break;
                        default:
                            break;
                    }

                    break;


                default:
                    break;


            }
            if (!String.IsNullOrEmpty(searchTerm))
            {
                EmpViewModel.EmpViewModels = EmpViewModel.EmpViewModels.Where(
                    e => e.Name.ToLower().Contains(searchTerm.ToLower()) || e.Department.Name.ToLower().Contains(searchTerm.ToLower()));
            }


            int page = int.Parse(Page == null ? "1" : Page);

            ViewBag.Page = page;
            EmpViewModel.EmpViewModels = EmpViewModel.EmpViewModels.Skip((page - 1) * 3).Take(3);

            return View(EmpViewModel);
        }

    

        [Authorize]
    public ActionResult Create()
    {

        var empViewModel = new EmployeeViewModel()
        {
            DepartmentsViewmodel = Mapper.Map< IEnumerable<Department>,
          IEnumerable<DepartmentViewModel>>(_departmentService.GetAllDepartments().ToList())
          ,
            Title = "Add New Employee"
           
        };          

       return View("Create", empViewModel );
        }


        [HttpPost]
       [ValidateAntiForgeryToken]
       [Authorize]
        public ActionResult CreateNew(EmployeeViewModel model)
        {

            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<EmployeeViewModel, Employee>(model);
                _employeeService.Add(employee);

                _employeeService.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
               model.DepartmentsViewmodel = Mapper.Map<IEnumerable<Department>,IEnumerable<DepartmentViewModel>>( _departmentService.GetAllDepartments().ToList());

                return View("Create",model);
            }

           


        }



        public ActionResult Edit( int id)
        {
            var EmployeeModel = _employeeService.GetEmployee(id);


            var EmpViewmodel = Mapper.Map<Employee, EmployeeViewModel>(EmployeeModel);
            EmpViewmodel.DepartmentsViewmodel = Mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(_departmentService.GetAllDepartments().ToList());
            EmpViewmodel.Title = "Update Employee Data";

            return View("Create" , EmpViewmodel);
        }


        [HttpPost]
        public ActionResult Update(EmployeeViewModel model)
        {

            var employee = Mapper.Map<EmployeeViewModel, Employee>(model);
            _employeeService.UpdateEmployee(employee);

            _employeeService.SaveChanges();


            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}