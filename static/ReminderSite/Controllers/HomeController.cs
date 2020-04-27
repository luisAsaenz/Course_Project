using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReminderSite.Models;

namespace ReminderSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly ReminderSiteContext _context;
        public HomeController(ReminderSiteContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserInfo ui)
        {
            _context.Add(ui);
            _context.SaveChanges();
            ViewBag.message = ui.FirstName + "has registered.....!";
            return View();
        }
       
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Login(string UserName, string Password)
        {
            if (!string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password))
            {
                return RedirectToAction("Login");
            }
            if (UserName == "UserName" && Password == "Password")
            {

            }
            return View();
        }
        public async Task<IActionResult> UserStuff()
        {
            return View(await _context.UserInfos.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
