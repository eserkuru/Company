using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Manager.WebCoreUI.Areas.Helpdesk.Controllers
{
    [Area("Helpdesk")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}