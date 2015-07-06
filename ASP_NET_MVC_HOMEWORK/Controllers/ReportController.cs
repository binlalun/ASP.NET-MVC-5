using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_HOMEWORK.Models;

namespace ASP_NET_MVC_HOMEWORK.Controllers
{
    public class ReportController : Controller
    {
        private CustomEntities db = new CustomEntities();

        // GET: Report
        public ActionResult Index()
        {
            return View(db.View1.ToList());
        }

        //// GET: Report/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    View1 view1 = db.View1.Find(id);
        //    if (view1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(view1);
        //}

        //// GET: Report/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Report/Create
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "客戶名稱,銀行帳戶數量,聯絡人數量")] View1 view1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.View1.Add(view1);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(view1);
        //}

        //// GET: Report/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    View1 view1 = db.View1.Find(id);
        //    if (view1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(view1);
        //}

        //// POST: Report/Edit/5
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "客戶名稱,銀行帳戶數量,聯絡人數量")] View1 view1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(view1).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(view1);
        //}

        //// GET: Report/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    View1 view1 = db.View1.Find(id);
        //    if (view1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(view1);
        //}

        //// POST: Report/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    View1 view1 = db.View1.Find(id);
        //    db.View1.Remove(view1);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
