using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReminderSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ReminderSite.Models
{
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using var context = new ReminderSiteContext(serviceProvider.GetRequiredService<DbContextOptions<ReminderSiteContext>>());
            // Looks and checks for any registeers
            if (context.UserInfos.Any())
            {
                return;   // if there is registeers than the database will not be seeded
            }

            context.UserInfos.AddRange(
                new UserInfo
                {
                    FirstName = "Steven",
                    LastName = "Smith",
                    UserName = "RomCom",
                    Email = "sdsdfas@gam.com",
                    Password = "dfas"
                },
                new UserInfo
                {
                    FirstName = "Jon",
                    LastName = "Richard",
                    UserName = "dde",
                    Email = "dfa@mo.com",
                    Password = "dfas"
                },
                new UserInfo
                {
                    FirstName = "Chu",
                    LastName = "Peek",
                    UserName = "Comrom",
                    Email = "dfasdfsad@tret.com",
                    Password = "dfas"
                },
                new UserInfo
                {
                    FirstName = "Lawn",
                    LastName = "Luck",
                    UserName = "duddd",
                    Email = "sadfdfas@asfdas.com",
                    Password = "dfas"
                }

            );
            context.SaveChanges();
        }
    }
}
