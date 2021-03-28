using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPWA.Controllers
{
    public class interno : Controller
    {
        // GET: interno
        public ActionResult Painel()
        {
            return View();
        }

        // GET: interno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Ajuda(int id)
        {
            return View();
        }

        // GET: interno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: interno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: interno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: interno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: interno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: interno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
