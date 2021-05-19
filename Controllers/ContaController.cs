using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControleEstoque.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var validar = UsuarioModel.ValidarUsuario(login.Usuario, login.Senha );
            
            if (validar)
            {
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
            }
            else
            {
                ModelState.AddModelError("", "Login invalido");
            }
            return RedirectToAction("GrupoProduto", "Cadastro");
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}