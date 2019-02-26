using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Manager.WebCoreUI.Controllers
{
    public class PhoneNumberController : Controller
    {
        // GET: PhoneNumber
        public IActionResult Index()
        {
            return View();
        }

        // GET: PhoneNumber/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: PhoneNumber/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhoneNumber/Create
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

        // GET: PhoneNumber/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhoneNumber/Edit/5
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

        // GET: PhoneNumber/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhoneNumber/Delete/5
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