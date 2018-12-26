using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.MvcWebUI.Controllers
{
    public class _SampleController : Controller
    {
        public IActionResult _Index()
        {
            return View();
        }
    }
}