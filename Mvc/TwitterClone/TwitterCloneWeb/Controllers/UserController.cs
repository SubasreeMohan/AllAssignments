using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterCloneWeb.Models;

namespace TwitterCloneWeb.Controllers
{
    public class UserController : Controller
    {
        #region Login       


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Person user)
        {
            Person User_Login = new Person();
            string Validation_Message = string.Empty;
            bool IsUserExist = false;
            try
            {
                IsUserExist = true; //service call
                if (IsUserExist == true)
                    return RedirectToAction("Signup");
                else
                    ModelState.AddModelError(string.Empty,"UserName and Password doesn't exists");
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Signout()
        {
            return View();
        }

        #endregion Login

        #region Signup

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Person user)
        {
            Person User_Login = new Person();
            User_Login.Joined = DateTime.Now;
            User_Login.Active = true;
            string Validation_Message = string.Empty;
            bool IsSuccess = false;
            try
            {
                IsSuccess = true; //service call
                if (IsSuccess == true)
                    return RedirectToAction("Login");
                else
                    ModelState.AddModelError(string.Empty, "Singup Failed");
                return View();
            }
            catch
            {
                return View();
            }
        }

        #endregion Signup



    }
}
