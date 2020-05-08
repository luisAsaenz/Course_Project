using Microsoft.EntityFrameworkCore;
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
        public DbSet<UserTask> Task { get; set; }
    }
}
