using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Manager.WebCoreUI.Controllers
{
    public class EMailAddressController : Controller
    {
        // GET: EMailAddress
        public IActionResult Index()
        {
            return View();
        }

        // GET: EMailAddress/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: EMailAddress/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EMailAddress/Create
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

        // GET: EMailAddress/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: EMailAddress/Edit/5
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

        // GET: EMailAddress/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: EMailAddress/Delete/5
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