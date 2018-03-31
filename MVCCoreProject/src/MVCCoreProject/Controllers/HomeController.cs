using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreProject.Model;

namespace MVCCoreProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee()
            {
                FirstName = "Razi", LastName = "Ahmad"
            };
            return View(emp);
        }
    }
}
