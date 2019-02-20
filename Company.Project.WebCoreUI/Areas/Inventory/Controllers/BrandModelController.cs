using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.WebCoreUI.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class BrandModelController : Controller
    {
        // GET: BrandModel
        public IActionResult Index()
        {
            return View();
        }

        // GET: BrandModel/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandModel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BrandModel/Create
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

        // GET: BrandModel/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrandModel/Edit/5
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

        // GET: BrandModel/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrandModel/Delete/5
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