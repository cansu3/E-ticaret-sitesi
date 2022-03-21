using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.db;

namespace WebApplication1.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.Account.RegisterModels user)
        {
            try
            {
                if (user.rePassword != user.Member.şifre)
                {
                    throw new Exception("Şifreler aynı değildir");
                }

                user.Member.kayıt_tarihi = DateTime.Now;
                context.Üye.Add(user.Member);
                context.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {
                ViewBag.ReError = ex.Message;
                return View();
            }

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Account.LoginModels model)

        {
            try
            {
                var user = context.Üye.FirstOrDefault(x => x.şifre == model.Member.şifre && x.email == model.Member.email);
                if (user != null)
                {
                    Session["LogonUser"] = user;
                    return RedirectToAction("index", "i");
                }
                else
                {
                    ViewBag.ReError = "Kullanici Bilgileriniz yanlış";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.ReError = ex.Message;
                return View();
            }
        }
        public ActionResult Logout()
        {
            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }
    }
}