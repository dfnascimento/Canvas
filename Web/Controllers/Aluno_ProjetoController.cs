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
    public class Aluno_ProjetoController : Controller
    {
        private CanvasEntities2 db = new CanvasEntities2();

        // GET: Aluno_Projeto
        public ActionResult Index()
        {
            var aluno_Projeto = db.Aluno_Projeto.Include(a => a.Aluno).Include(a => a.Projeto);
            return View(aluno_Projeto.ToList());
        }

        // GET: Aluno_Projeto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno_Projeto aluno_Projeto = db.Aluno_Projeto.Find(id);
            if (aluno_Projeto == null)
            {
                return HttpNotFound();
            }
            return View(aluno_Projeto);
        }

        // GET: Aluno_Projeto/Create
        public ActionResult Create()
        {
            ViewBag.Id_Aluno = new SelectList(db.Alunoes, "Id", "Curso");
            ViewBag.Id_Projeto = new SelectList(db.Projetoes, "Id", "Status");
            return View();
        }

        // POST: Aluno_Projeto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_Projeto,Id_Aluno")] Aluno_Projeto aluno_Projeto)
        {
            if (ModelState.IsValid)
            {
                db.Aluno_Projeto.Add(aluno_Projeto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Aluno = new SelectList(db.Alunoes, "Id", "Curso", aluno_Projeto.Id_Aluno);
            ViewBag.Id_Projeto = new SelectList(db.Projetoes, "Id", "Status", aluno_Projeto.Id_Projeto);
            return View(aluno_Projeto);
        }

        // GET: Aluno_Projeto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno_Projeto aluno_Projeto = db.Aluno_Projeto.Find(id);
            if (aluno_Projeto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Aluno = new SelectList(db.Alunoes, "Id", "Curso", aluno_Projeto.Id_Aluno);
            ViewBag.Id_Projeto = new SelectList(db.Projetoes, "Id", "Status", aluno_Projeto.Id_Projeto);
            return View(aluno_Projeto);
        }

        // POST: Aluno_Projeto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id_Projeto,Id_Aluno")] Aluno_Projeto aluno_Projeto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aluno_Projeto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Aluno = new SelectList(db.Alunoes, "Id", "Curso", aluno_Projeto.Id_Aluno);
            ViewBag.Id_Projeto = new SelectList(db.Projetoes, "Id", "Status", aluno_Projeto.Id_Projeto);
            return View(aluno_Projeto);
        }

        // GET: Aluno_Projeto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno_Projeto aluno_Projeto = db.Aluno_Projeto.Find(id);
            if (aluno_Projeto == null)
            {
                return HttpNotFound();
            }
            return View(aluno_Projeto);
        }

        // POST: Aluno_Projeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aluno_Projeto aluno_Projeto = db.Aluno_Projeto.Find(id);
            db.Aluno_Projeto.Remove(aluno_Projeto);
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
