using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Project.WebCoreUI.Areas.Invoicing.Controllers
{
    [Area("Invoicing")]
    public class InvoiceItemController : Controller
    {
        // GET: InvoiceItem
        public IActionResult Index()
        {
            return View();
        }

        // GET: InvoiceItem/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: InvoiceItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InvoiceItem/Create
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

        // GET: InvoiceItem/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceItem/Edit/5
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

        // GET: InvoiceItem/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceItem/Delete/5
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