using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.MvcWebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Accounting()
        {
            return View();
        }

        public IActionResult HumanResources()
        {
            return View();
        }

        public IActionResult Inventory()
        {
            return View();
        }

        public IActionResult Invoicing()
        {
            return View();
        }
    }
}