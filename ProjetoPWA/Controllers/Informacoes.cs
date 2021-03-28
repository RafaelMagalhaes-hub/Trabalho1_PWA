using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPWA.Controllers
{
    public class Informacoes : Controller
    {
        // GET: Informacoes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Informacoes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Termos(int id)
        {
            return View();
        }

        public ActionResult Privacidade(int id)
        {
            return View();
        }

        // GET: Informacoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Informacoes/Create
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

        // GET: Informacoes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Informacoes/Edit/5
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

        // GET: Informacoes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Informacoes/Delete/5
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
