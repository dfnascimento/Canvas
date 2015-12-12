using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    public class PNAlunoesController : Controller
    {
        private CanvasEntities2 db = new CanvasEntities2();

        // GET: PNAlunoes
        public ActionResult Index()
        {
            return View(db.PNAlunoes.ToList());
        }

        // GET: PNAlunoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNAluno pNAluno = db.PNAlunoes.Find(id);
            if (pNAluno == null)
            {
                return HttpNotFound();
            }
            return View(pNAluno);
        }

        // GET: PNAlunoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PNAlunoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,email,senha,curso,periodo,campus,status")] PNAluno pNAluno)
        {
            if (ModelState.IsValid)
            {
                db.PNAlunoes.Add(pNAluno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pNAluno);
        }

        // GET: PNAlunoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNAluno pNAluno = db.PNAlunoes.Find(id);
            if (pNAluno == null)
            {
                return HttpNotFound();
            }
            return View(pNAluno);
        }

        // POST: PNAlunoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,email,senha,curso,periodo,campus,status")] PNAluno pNAluno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pNAluno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pNAluno);
        }

        // GET: PNAlunoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNAluno pNAluno = db.PNAlunoes.Find(id);
            if (pNAluno == null)
            {
                return HttpNotFound();
            }
            return View(pNAluno);
        }

        // POST: PNAlunoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PNAluno pNAluno = db.PNAlunoes.Find(id);
            db.PNAlunoes.Remove(pNAluno);
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
