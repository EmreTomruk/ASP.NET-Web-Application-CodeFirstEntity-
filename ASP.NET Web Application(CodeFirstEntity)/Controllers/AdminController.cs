using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ASP.NET_Web_Application_CodeFirstEntity_.Models.siniflar;

namespace ASP.NET_Web_Application_CodeFirstEntity_.Controllers
{
    public class AdminController : Controller
    {
        Context con = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = con.Yeteneklers.ToList();
            return View(degerler);
        }

        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler yeni)
        {
            con.Yeteneklers.Add(yeni);
            con.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = con.Yeteneklers.Find(id);
            con.Yeteneklers.Remove(deger);
            con.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekGetir(int id)
        {
            var deger = con.Yeteneklers.Find(id);
            return View("YetenekGetir", deger);
        }

        [HttpPost]
        public ActionResult YetenekGetir(Yetenekler y)
        {            
            var deger = con.Yeteneklers.Find(y.ID);
            deger.Aciklama = y.Aciklama;
            deger.Deger = y.Deger;
            con.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}