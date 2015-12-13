using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;

namespace Web.Controllers
{
    public class ProjetoesController : Controller
    {
        private CanvasEntities2 db = new CanvasEntities2();

        // GET: Projetoes
        public ActionResult Index()
        {
            return View(db.Projetoes.ToList());
        }

        // GET: Projetoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.Projetoes.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // GET: Projetoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projetoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Status,Resposta_1,Resposta_2,Resposta_3,Resposta_4,Resposta_5,Resposta_6,Resposta_7,Resposta_8,Resposta_9,Resposta_10,Resposta_11,Resposta_12,Resposta_13,Nome")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Projetoes.Add(projeto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projeto);
        }

        // GET: Projetoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.Projetoes.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // POST: Projetoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Status,Resposta_1,Resposta_2,Resposta_3,Resposta_4,Resposta_5,Resposta_6,Resposta_7,Resposta_8,Resposta_9,Resposta_10,Resposta_11,Resposta_12,Resposta_13,Nome")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projeto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projeto);
        }

        // GET: Projetoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.Projetoes.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // POST: Projetoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projeto projeto = db.Projetoes.Find(id);
            db.Projetoes.Remove(projeto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
