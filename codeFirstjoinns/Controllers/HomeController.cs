using codeFirstjoinns.Models;
using codeFirstjoinns.Models.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codeFirstjoinns.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbcontext DB = new ApplicationDbcontext();
        // GET: Home 
        public ActionResult Index()
        {
            // var data = DB.products.ToList();
            var data = (from p in DB.products
                        join c in DB.categaris
                        on p.categari.id equals c.id
                        select new productlist()
                        {
                            Id=p.Id,
                            name=p.name,
                            Decs=p.Decs,
                            Quntety=p.Quntety,
                            categari=c.name

                        });
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var cat = DB.categaris.ToList();
            ViewBag.cat = cat;
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductViewmodel pro)
        {
            var cat = DB.categaris.SingleOrDefault(e => e.id == pro.categari);
            var obj = new product()
            {
                name=pro.name,
                Quntety=pro.Quntety,
                Decs=pro.Decs,
                categari=cat
            };
            DB.products.Add(obj);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var pro = DB.products.SingleOrDefault(e => e.Id == id);
            DB.products.Remove(pro);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var pro = DB.products.SingleOrDefault(e => e.Id == id);
            var cat = DB.categaris.ToList();
            ViewBag.cat = cat;
            

            return View(pro);
        }
        [HttpPost]
        public ActionResult Edit(product pro)
        {
            DB.Entry(pro).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}