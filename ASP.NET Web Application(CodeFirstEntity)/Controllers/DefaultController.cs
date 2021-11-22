using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ASP.NET_Web_Application_CodeFirstEntity_.Models.siniflar;

namespace ASP.NET_Web_Application_CodeFirstEntity_.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context con = new Context();
            var degerler = con.Yeteneklers.ToList();
            return View(degerler);
        }
    }
}