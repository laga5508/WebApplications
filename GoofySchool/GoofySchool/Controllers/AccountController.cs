using GoofySchool.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GoofySchool.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        { }

        private IUserRepository userRepository;

        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ActionResult LogOut()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return Redirect("~/");
        }

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userRepository.LogIn(model.UserName, model.Password);
                if (user != null)
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    return Redirect(returnUrl);
                }

                ModelState.AddModelError("", "The user name or password provided is incorrect.");
            }

            return View(model);
        }

    }
}