using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.WebCoreUI.Controllers
{
    public class OrganisationController : Controller
    {
        // GET: Organisation
        public IActionResult Index()
        {
            return View();
        }

        // GET: Organisation/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Organisation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Organisation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Organisation/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Organisation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Organisation/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Organisation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}