﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.MvcWebUI.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}