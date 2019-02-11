using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.MvcWebUI.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserReport()
        {
            return View();
        }
    }
}