using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;

namespace MvcBasic_Clone.Controllers
{
    public class EmployeeController : Controller
    {
        private HRContext db = new HRContext();
        // GET: Employee
        public ActionResult Index()
        {
            var emp = db.Employees.ToList();
            return View(emp);
        }

        public ActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 10001, Name = "David", Phone = "0933-154228", Email ="david@gmail.com" },
                new Employee { Id = 10002, Name = "Mary", Phone = "0925-157886", Email ="mary@gmail.com" },
                new Employee { Id = 10003, Name = "John", Phone = "0921-335884", Email ="john@gmail.com" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0971-628322", Email ="cindy@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0933-154228",  Email ="rose@gmail.com" }
            };
            return View(employees);
        }

    }
}