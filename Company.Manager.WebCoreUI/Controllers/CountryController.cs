using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Core.Entities.Address;
using Company.Manager.Business.Abstract;
using Company.Manager.WebCoreUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Manager.WebCoreUI.Controllers
{
    public class CountryController : Controller
    {
        #region Injection

        private ICountryService _countryService;
        #endregion

        #region ctor

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        #endregion

        // GET: Country
        public IActionResult Index()
        {
            var model = new CountryListModel
            {
                Countries = _countryService.GetAll()
            };
            return View(model);
        }

        // GET: Country/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _countryService.Add(country);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Edit/5
        public IActionResult Edit(Guid id)
        {
            var model = new CountryUpdateModel
            {
                Country = _countryService.GetById(id)
            };

            return View(model);
        }

        // POST: Country/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _countryService.Update(country);
                    //TempData.Add("message", "Product was successfully updated");
                }

                return RedirectToAction(nameof(Edit));
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Delete/5
        public IActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Country/Delete/5
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