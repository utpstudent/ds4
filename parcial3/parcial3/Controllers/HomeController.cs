using parcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parcial3.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.TotalArticulos = db.MM_Articulos.Count();
            ViewBag.TotalUsuarios = db.MM_Usuarios.Count();
            return View();
        }
    }
}