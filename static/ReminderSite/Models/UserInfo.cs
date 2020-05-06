using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ReminderSite.Models
{
    public class UserInfo 
    {
        [Key]
        [NotNull]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; } 
       
    }
}
