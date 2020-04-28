using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
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
            List<UserInfo> dict = new List<UserInfo>();
            string usern = ui.UserName;
            
            if (!dict.Exists(x => x.UserName == usern))
            {
                ViewBag.message1 = "There is a user with this name please be a little more creative";
                return View();
            }
            else
            {

                using (MD5 md5hash = MD5.Create())
                {
                    string hash = Getmd5hash(md5hash, (ui.Password + ui.UserName));
                    ui.Password = hash;
                }
                _context.Add(ui);
                _context.SaveChanges();
                ViewBag.message = ui.FirstName + " has registered.....!";
                return View();
            }
            
        }


        private string Getmd5hash(MD5 md5hash, string password)
        {
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
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
