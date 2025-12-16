using ProyectoFinal_Aplicacion_To_Do.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal_Aplicacion_To_Do.Controllers
{
    public class TareasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        private string ObtenerUsuarioActual()
        {
            
            if (Session["UsuarioActual"] != null)
                return Session["UsuarioActual"].ToString();

            
            if (TempData["UsuarioActual"] != null)
            {
                var usuarioTemp = TempData["UsuarioActual"].ToString();
                
                Session["UsuarioActual"] = usuarioTemp;
                return usuarioTemp;
            }

            
            return null;
        }

        // GET: Tareas
        public ActionResult Index()
        {
            // Siempre pasar el usuario al layout
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();

            var tareas = db.Tareas
                .OrderByDescending(t => t.Prioridad)
                .ThenBy(t => t.FechaVencimiento)
                .ToList();
            return View(tareas);
        }

        // GET: Tareas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return HttpNotFound();

            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
                return HttpNotFound();

           
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();

            return View(tarea);
        }

        // GET: Tareas/Create
        public ActionResult Create()
        {
            
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();
            return View();
        }

        // POST: Tareas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                tarea.FechaCreacion = DateTime.Now;
                tarea.Completada = false;

                db.Tareas.Add(tarea);
                db.SaveChanges();

                TempData["SuccessMessage"] = "Tarea creada exitosamente!";
                return RedirectToAction("Index");
            }

            
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();
            return View(tarea);
        }

        // GET: Tareas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();

            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
                return HttpNotFound();

            
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();

            return View(tarea);
        }

        // POST: Tareas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarea).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                TempData["SuccessMessage"] = "Tarea actualizada exitosamente!";
                return RedirectToAction("Index");
            }

            
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();
            return View(tarea);
        }

        // GET: DetallesModal
        public ActionResult DetallesModal(int id)
        {
            var tarea = db.Tareas.Find(id);
            if (tarea == null)
                return HttpNotFound();

            
            ViewData["UsuarioLayout"] = ObtenerUsuarioActual();

            return PartialView("_DetallesModal", tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarDirecto(int id)  // ← Solo "int id", no "int? id"
        {
            try
            {
                var tarea = db.Tareas.Find(id);
                if (tarea != null)
                {
                    db.Tareas.Remove(tarea);
                    db.SaveChanges();

                    TempData["SuccessMessage"] = $"Tarea '{tarea.Titulo}' eliminada exitosamente!";
                }
                else
                {
                    TempData["ErrorMessage"] = "La tarea no existe o ya fue eliminada.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error al eliminar la tarea: {ex.Message}";
            }

            return RedirectToAction("Index");
        }

        // AJAX: Eliminar tarea
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult EliminarTarea(int id)
        {
            try
            {
                var tarea = db.Tareas.Find(id);
                if (tarea != null)
                {
                    db.Tareas.Remove(tarea);
                    db.SaveChanges();

                    return Json(new
                    {
                        success = true,
                        message = "Tarea eliminada exitosamente!"
                    });
                }

                return Json(new
                {
                    success = false,
                    message = "La tarea no fue encontrada"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = "Error al eliminar: " + ex.Message
                });
            }
        }

        // AJAX: ToggleCompletada
        [HttpPost]
        public JsonResult ToggleCompletada(int id)
        {
            try
            {
                var tarea = db.Tareas.Find(id);
                if (tarea != null)
                {
                    tarea.Completada = !tarea.Completada;
                    db.SaveChanges();
                    return Json(new { success = true, completada = tarea.Completada });
                }
                return Json(new { success = false, message = "Tarea no encontrada" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}