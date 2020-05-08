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
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using ReminderSite.Models;

namespace ReminderSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly Models.ReminderSiteContext _context;
        public HomeController(Models.ReminderSiteContext context)
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
            
           
            IEnumerable<string> users = _context.UserInfos.Select(x => x.UserName);
            
            string usern = ui.UserName;
            if(String.IsNullOrEmpty(ui.UserName) || String.IsNullOrEmpty(ui.Password))
            {
                ViewBag.message3 = "Please fill in the above boxs";
                return View();
            }
            else if (users.Contains(usern))
            {
                ViewBag.message1 = "The user with the name of " + ui.UserName + " already exists";
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
        [HttpGet]
        public IActionResult Login()
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult Login(UserInfo ui)
        {
            IEnumerable<string> user = _context.UserInfos.Select(x => x.UserName);

            IEnumerable<string> passwords = _context.UserInfos.Select(us => us.Password);
            
            Dictionary<string, string> myusers = new Dictionary<string, string>();
            int j = 0;
            foreach (string i in user)
            {
                myusers.Add(i, passwords.ElementAt(j));
                j++;
            }
            if (String.IsNullOrEmpty(ui.UserName) || String.IsNullOrEmpty(ui.Password))
            {
                ViewBag.message3 = "Please fill in the above boxs";
                return View();
            }
            else if (user.Contains(ui.UserName))
            {
                using (MD5 md5hash = MD5.Create())
                {
                    string hash = Getmd5hash(md5hash, (ui.Password + ui.UserName));
                    ui.Password = hash;
                }
                
                if (myusers[ui.UserName] == ui.Password)
                {
                    ViewBag.message = ui.UserName + " has logged in";
                    return View();
                }
                else
                {
                    ViewBag.message1 = "The password you provided is incorrect.";
                    return View();
                }
            }
            else
            {
                ViewBag.message2 = "The Username you have provided is either incorrect or input incorrectly, please try again";
                return View();
            }
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
