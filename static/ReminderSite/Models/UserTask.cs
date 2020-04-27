using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ReminderSite.Models
{
    public class UserTask 
    {
        public int ID { get; set; }
        public string Task { get; set; }
        
        public DateTime DateOfTask { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
    }
}
