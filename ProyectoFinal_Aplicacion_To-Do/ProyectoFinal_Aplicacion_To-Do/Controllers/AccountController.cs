using ProyectoFinal_Aplicacion_To_Do.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace ProyectoFinal_Aplicacion_To_Do.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Account/Login
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: Account/Login - ¡CORREGIDO!
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(model.Password, "SHA1");

                var usuario = db.Usuarios.FirstOrDefault(u =>
                    u.NombreUsuario == model.Usuario &&
                    u.Password == passwordHash);

                if (usuario != null)
                {
                    // ¡IMPORTANTE! Guardar en SESSION para persistencia
                    Session["UsuarioActual"] = usuario.NombreCompleto;
                    Session["UsuarioId"] = usuario.Id;

                    // También en TempData para la redirección inmediata
                    TempData["UsuarioActual"] = usuario.NombreCompleto;

                    // Autenticación Forms
                    FormsAuthentication.SetAuthCookie(usuario.NombreUsuario, model.RememberMe);

                    return RedirectToAction("Index", "Tareas");
                }
                else
                {
                    ModelState.AddModelError("", "Usuario o contraseña incorrectos");
                }
            }
            return View(model);
        }

        // GET: Account/Logout - ¡CORREGIDO!
        public ActionResult Logout()
        {
            // Limpiar TODO
            Session.Remove("UsuarioActual");
            Session.Remove("UsuarioId");
            Session.Abandon();

            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }

        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Register - ¡CORREGIDO!
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.Usuarios.Any(u => u.NombreUsuario == model.Usuario))
                {
                    ModelState.AddModelError("Usuario", "El nombre de usuario ya está en uso.");
                    return View(model);
                }

                var usuario = new Usuario
                {
                    NombreUsuario = model.Usuario,
                    Password = FormsAuthentication.HashPasswordForStoringInConfigFile(model.Password, "SHA1"),
                    Email = model.Email,
                    NombreCompleto = model.NombreCompleto,
                    FechaRegistro = DateTime.Now,
                    Activo = true
                };

                db.Usuarios.Add(usuario);
                db.SaveChanges();

                // ¡IMPORTANTE! Guardar en SESSION inmediatamente
                Session["UsuarioActual"] = usuario.NombreCompleto;
                Session["UsuarioId"] = usuario.Id;

                FormsAuthentication.SetAuthCookie(usuario.NombreUsuario, false);

                return RedirectToAction("Index", "Tareas");
            }
            return View(model);
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

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Usuario requerido")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Usuario requerido")]
        [Display(Name = "Nombre de Usuario")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        [Display(Name = "Confirmar Contraseña")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string Email { get; set; }

        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
    }
}