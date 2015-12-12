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
    public class AvaliacaosController : Controller
    {
        private CanvasEntities2 db = new CanvasEntities2();

        // GET: Avaliacaos
        public ActionResult Index()
        {
            var avaliacaos = db.Avaliacaos.Include(a => a.Avaliacao2);
            return View(avaliacaos.ToList());
        }

        // GET: Avaliacaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            if (avaliacao == null)
            {
                return HttpNotFound();
            }
            return View(avaliacao);
        }

        // GET: Avaliacaos/Create
        public ActionResult Create()
        {
            ViewBag.Id_Avaliador_Projeto = new SelectList(db.Avaliacaos, "Id", "Id");
            return View();
        }

        // POST: Avaliacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_Avaliador_Projeto,Nota_Quadro_1,Nota_Quadro_2,Nota_Quadro_3,Nota_Quadro_4,Nota_Quadro_5,Nota_Quadro_6,Nota_Quadro_7,Nota_Quadro_8,Nota_Quadro_9")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                db.Avaliacaos.Add(avaliacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Avaliador_Projeto = new SelectList(db.Avaliacaos, "Id", "Id", avaliacao.Id_Avaliador_Projeto);
            return View(avaliacao);
        }

        // GET: Avaliacaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            if (avaliacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Avaliador_Projeto = new SelectList(db.Avaliacaos, "Id", "Id", avaliacao.Id_Avaliador_Projeto);
            return View(avaliacao);
        }

        // POST: Avaliacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id_Avaliador_Projeto,Nota_Quadro_1,Nota_Quadro_2,Nota_Quadro_3,Nota_Quadro_4,Nota_Quadro_5,Nota_Quadro_6,Nota_Quadro_7,Nota_Quadro_8,Nota_Quadro_9")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avaliacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Avaliador_Projeto = new SelectList(db.Avaliacaos, "Id", "Id", avaliacao.Id_Avaliador_Projeto);
            return View(avaliacao);
        }

        // GET: Avaliacaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            if (avaliacao == null)
            {
                return HttpNotFound();
            }
            return View(avaliacao);
        }

        // POST: Avaliacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            db.Avaliacaos.Remove(avaliacao);
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
