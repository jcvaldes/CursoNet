using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealityProductor.Models;

namespace RealityProductor.Controllers
{
    public class CompetitorsController : Controller
    {
        private RealityDbContext db = new RealityDbContext();

        //
        // GET: /Competitors/

        public ActionResult Index(string criterio)
        {
            var model = db.Competitors.Where(x => criterio == null || x.Name.StartsWith(criterio)).ToList();
            if (Request.IsAjaxRequest())
            {
                return PartialView("CompetitorsPartial", model);
            }
            return View(model);

            //return View(db.Competitors.ToList());
        }

        //
        // GET: /Competitors/Details/5

        public ActionResult Details(int id = 0)
        {
            Competitor competitor = db.Competitors.Find(id);
            if (competitor == null)
            {
                return HttpNotFound();
            }
            return View(competitor);
        }

        //
        // GET: /Competitors/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Competitors/Create

        [HttpPost]
        public ActionResult Create(Competitor competitor)
        {
            if (ModelState.IsValid)
            {
                db.Competitors.Add(competitor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(competitor);
        }

        //
        // GET: /Competitors/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Competitor competitor = db.Competitors.Find(id);
            if (competitor == null)
            {
                return HttpNotFound();
            }
            return View(competitor);
        }

        //
        // POST: /Competitors/Edit/5

        [HttpPost]
        public ActionResult Edit(Competitor competitor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(competitor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(competitor);
        }

        //
        // GET: /Competitors/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Competitor competitor = db.Competitors.Find(id);
            if (competitor == null)
            {
                return HttpNotFound();
            }
            return View(competitor);
        }

        //
        // POST: /Competitors/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Competitor competitor = db.Competitors.Find(id);
            db.Competitors.Remove(competitor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}