using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.MvcWebUI.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }
    }
}