using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemonstration_2.Models;

namespace ViewsDemonstration_2.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> empList = new List<Employee>
            {
                new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345 },
                new Employee {Id=102,Name="Abhishek",Location="Chennai",Salary=23456 },
                new Employee {Id=103,Name="Akash",Location="Bangalore",Salary=34567 },
                new Employee {Id=104,Name="Akshay",Location="Chennai",Salary=45678 },
                new Employee {Id=105,Name="Anirudh",Location="Bangalore",Salary=56789 }
            };

        // GET: Home
        public ActionResult Index()
        {
            return View("Index", "~/Views/Shared/_BasicLayout.cshtml", empList);
            //return View("Index", "_BasicLayout", empList);
            //it is search first controller Views folder then Shared folder
        }

        public ActionResult EditEmployee(int Id)
        {
            var employee = empList.First(e => e.Id == Id);

            return View(employee);
        }

        public ActionResult ManageUser()
        {
            //var employee = empList.First(e => e.Id == Id);

            return View();
        }
    }
}