using Microsoft.EntityFrameworkCore;
using ReminderSite.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReminderSite.Models
{
    public class ReminderSiteContext : DbContext
    {
        public ReminderSiteContext (DbContextOptions<ReminderSiteContext> options) : base(options) 
        { }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Task> Task { get; set; }
    }
}
