using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolData.DAL;

namespace School.Controllers
{
    public class AccountController : Controller
    {
        SchoolContext ctx = new SchoolContext();
        public IActionResult SignUp(string username, string password, string email)
        {
            ctx.Users.Add(new User()
            {
                username = username,
                password = password,
                email = email
            });
            ctx.SaveChanges();
            return RedirectToAction("Login","Home");
        }
        public IActionResult Login(string username, string password)
        {
            if (ctx.Users.Any(a=>a.username==username && a.password==password))
            {
                return RedirectToAction("Profile", "Profile");
            }
            return RedirectToAction("Login", "Home");
        }
    }
}