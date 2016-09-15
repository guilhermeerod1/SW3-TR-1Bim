using SW3_TR_1Bim.Contexts;
using SW3_TR_1Bim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SW3_TR_1Bim.Controllers
{
    public class ClientesController : Controller
    {

        ClientesContext context = new ClientesContext();
        
        // GET: Clientes
        public ActionResult Index()
        {
            return View(context.Clientes.SqlQuery("select * from clientes"));
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(long? id)
        {
            return get(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long? id)
        {
            return get(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {

            if (ModelState.IsValid)
            {
                context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }

        public ActionResult Delete(long? id)
        {
            return get(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Cliente cliente = context.Clientes.Find(id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");        
        }

        private ActionResult get(long? id)
        {

            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Cliente cliente = context.Clientes.Find(id);

            if (cliente == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(cliente);

        }

    }
}