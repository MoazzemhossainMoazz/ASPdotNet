using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            User auser = new User()
            {
                Id = 1,
                Name = "Moazz",
                age = 50,
                Salary = "35k"
            };
            return View(auser);
        }
    }
}