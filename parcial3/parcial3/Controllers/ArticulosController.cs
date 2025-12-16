using parcial3.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace parcial3.Controllers
{
    public class ArticulosController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Articulos
        public ActionResult Index()
        {
            try
            {
                var ultimosArticulos = db.MM_Articulos
                    .OrderByDescending(a => a.FechaRegistro)
                    .Take(5)
                    .ToList();

                return View(ultimosArticulos);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los artículos: " + ex.Message;
                return View(Enumerable.Empty<Articulo>().ToList());
            }
        }

        public ActionResult Lista(string buscar, string sortOrder)
        {
            try
            {
                ViewBag.TituloSortParm = string.IsNullOrEmpty(sortOrder) ? "titulo_desc" : "";
                ViewBag.EstadoSortParm = sortOrder == "estado" ? "estado_desc" : "estado";
                ViewBag.FechaSortParm = sortOrder == "fecha" ? "fecha_desc" : "fecha";
                ViewBag.CurrentFilter = buscar;

                var articulos = db.MM_Articulos.AsQueryable();

                if (!string.IsNullOrEmpty(buscar))
                {
                    articulos = articulos.Where(a =>
                        a.Titulo.Contains(buscar) ||
                        (a.Autores != null && a.Autores.Contains(buscar)) ||
                        (a.PalabrasClave != null && a.PalabrasClave.Contains(buscar)));
                }

                switch (sortOrder)
                {
                    case "titulo_desc":
                        articulos = articulos.OrderByDescending(a => a.Titulo);
                        break;
                    case "estado":
                        articulos = articulos.OrderBy(a => a.Estado);
                        break;
                    case "estado_desc":
                        articulos = articulos.OrderByDescending(a => a.Estado);
                        break;
                    case "fecha":
                        articulos = articulos.OrderBy(a => a.FechaPublicacion);
                        break;
                    case "fecha_desc":
                        articulos = articulos.OrderByDescending(a => a.FechaPublicacion);
                        break;
                    default:
                        articulos = articulos.OrderByDescending(a => a.FechaPublicacion);
                        break;
                }

                return View(articulos.ToList());
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar la lista: " + ex.Message;
                return View(Enumerable.Empty<Articulo>().ToList());
            }
        }

        public ActionResult Detalles(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                Articulo articulo = db.MM_Articulos.Find(id);
                if (articulo == null)
                {
                    return HttpNotFound();
                }

                if (articulo.UsuarioID > 0)
                {
                    db.Entry(articulo).Reference(a => a.Usuario).Load();
                }

                return View(articulo);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar los detalles: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Crear()
        {
            try
            {
                ViewBag.UsuarioID = new SelectList(db.MM_Usuarios, "UsuarioID", "Nombre");
                return View();
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar el formulario: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Articulo articulo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Validar que exista un usuario
                    var usuarioExistente = db.MM_Usuarios.FirstOrDefault();

                    if (usuarioExistente == null)
                    {
                        // Crear usuario por defecto si no existe
                        var usuarioDefault = new Usuario
                        {
                            Nombre = "Usuario Sistema",
                            Email = "sistema@example.com",
                            Contrasena = "123456",
                            Rol = "Administrador"
                        };

                        db.MM_Usuarios.Add(usuarioDefault);
                        db.SaveChanges();

                        articulo.UsuarioID = usuarioDefault.UsuarioID;
                    }
                    else
                    {
                        articulo.UsuarioID = usuarioExistente.UsuarioID;
                    }

                    // Asignar fecha de registro
                    articulo.FechaRegistro = DateTime.Now;

                    // DEBUG: Verificar valores
                    System.Diagnostics.Debug.WriteLine($"Guardando artículo - Título: {articulo.Titulo}");
                    System.Diagnostics.Debug.WriteLine($"UsuarioID: {articulo.UsuarioID}");

                    db.MM_Articulos.Add(articulo);
                    db.SaveChanges();

                    TempData["Mensaje"] = "Artículo creado exitosamente";
                    return RedirectToAction("Lista");
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                ModelState.AddModelError("", "Error de validación: " + fullErrorMessage);
                System.Diagnostics.Debug.WriteLine($"Validation Error: {fullErrorMessage}");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var innerException = ex.InnerException?.InnerException ?? ex.InnerException ?? ex;
                ModelState.AddModelError("", "Error al guardar en BD: " + innerException.Message);
                System.Diagnostics.Debug.WriteLine($"DB Update Error: {innerException.Message}");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error: " + ex.Message);
                System.Diagnostics.Debug.WriteLine($"General Error: {ex.Message}");
            }


            ViewBag.UsuarioID = new SelectList(db.MM_Usuarios, "UsuarioID", "Nombre", articulo.UsuarioID);
            return View(articulo);
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                Articulo articulo = db.MM_Articulos.Find(id);
                if (articulo == null)
                {
                    return HttpNotFound();
                }

                ViewBag.UsuarioID = new SelectList(db.MM_Usuarios, "UsuarioID", "Nombre", articulo.UsuarioID);
                return View(articulo);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar para edición: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Articulo articulo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var articuloExistente = db.MM_Articulos
                        .AsNoTracking()
                        .Where(a => a.ArticuloID == articulo.ArticuloID)
                        .Select(a => new { a.FechaRegistro })
                        .FirstOrDefault();

                    if (articuloExistente != null)
                    {
                        articulo.FechaRegistro = articuloExistente.FechaRegistro;
                    }

                    db.Entry(articulo).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Mensaje"] = "Artículo actualizado exitosamente";
                    return RedirectToAction("Detalles", new { id = articulo.ArticuloID });
                }

                ViewBag.UsuarioID = new SelectList(db.MM_Usuarios, "UsuarioID", "Nombre", articulo.UsuarioID);
                return View(articulo);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al actualizar: " + ex.Message);
                ViewBag.UsuarioID = new SelectList(db.MM_Usuarios, "UsuarioID", "Nombre", articulo.UsuarioID);
                return View(articulo);
            }
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                Articulo articulo = db.MM_Articulos.Find(id);
                if (articulo == null)
                {
                    return HttpNotFound();
                }

                return View(articulo);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al cargar para eliminación: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarConfirmado(int id)
        {
            try
            {
                Articulo articulo = db.MM_Articulos.Find(id);
                if (articulo != null)
                {
                    db.MM_Articulos.Remove(articulo);
                    db.SaveChanges();
                    TempData["Mensaje"] = "Artículo eliminado exitosamente";
                }

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar: " + ex.Message;
                return RedirectToAction("Eliminar", new { id = id });
            }
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