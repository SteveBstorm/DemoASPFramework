using DemoASPFramework.Models;
using DemoASPFramework.Services;
using DemoASPFramework.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoASPFramework.Controllers
{
    public class UserController : Controller
    {
        private UserService _service;
        public UserController()
        {
            _service = new UserService();
        }
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
            try
            {
                User connectedUser = _service.Login(u.Email, u.Password);
                SessionTool.user = connectedUser;
            }
            catch(Exception e)
            {
                return View(u);
            }

            return RedirectToAction("Index", "Article");
        }

        public ActionResult LogOut()
        {
            SessionTool.Disconnect();
            return RedirectToAction("Index", "Article");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}