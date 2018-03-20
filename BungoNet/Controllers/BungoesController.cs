using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BungoNet.Models;

namespace BungoNet.Controllers
{
    public class BungoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bungoes
        public ActionResult Index()
        {
            return View(db.Bungoes.ToList());
        }

        // GET: Bungoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bungo bungo = db.Bungoes.Find(id);
            if (bungo == null)
            {
                return HttpNotFound();
            }
            return View(bungo);
        }

        // GET: Bungoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bungoes/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,HowToRead,Meaning,Language,Tags,Source,Memo,RegistTime,UpdateTime")] Bungo bungo)
        {
            if (ModelState.IsValid)
            {
                db.Bungoes.Add(bungo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bungo);
        }

        // GET: Bungoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bungo bungo = db.Bungoes.Find(id);
            if (bungo == null)
            {
                return HttpNotFound();
            }
            return View(bungo);
        }

        // POST: Bungoes/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,HowToRead,Meaning,Language,Tags,Source,Memo,RegistTime,UpdateTime")] Bungo bungo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bungo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bungo);
        }

        // GET: Bungoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bungo bungo = db.Bungoes.Find(id);
            if (bungo == null)
            {
                return HttpNotFound();
            }
            return View(bungo);
        }

        // POST: Bungoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bungo bungo = db.Bungoes.Find(id);
            db.Bungoes.Remove(bungo);
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
