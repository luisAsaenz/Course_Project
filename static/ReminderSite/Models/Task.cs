﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ReminderSite.Models
{
    public class Task
    {
        [Key]
        [NotNull]
        public int TaskID { get; set; }
        [MaxLength(300, ErrorMessage = "Task can not be over 300 character")]
        public string Tasks { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TaskDue { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public UserInfo UserInfo { get; set; }
    }
}
