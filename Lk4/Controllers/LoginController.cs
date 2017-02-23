using Lk4.Models;
using Lk4.Uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lk4.Controllers
{
    public class LoginController : Controller
    {
        Aluno aluno = new Aluno();
        WebService webService = new WebService();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autenticacao()
        {
            return RedirectToAction("Index", "Dashboard");
        }

        public ActionResult PrimeiroAcesso()
        {
            return View();
            //return RedirectToAction("PrimeiroAcesso", "Login");
        }

        public ActionResult ValidaToken(string token)
        {
            aluno = webService.MeusDados(token);
            int id = 1;

            if (aluno != null)
            {
                return RedirectToAction("Senha", "Aluno", new { id });
            }
            else
            {
                return RedirectToAction("PrimeiroAcesso", "Login");
            }
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
