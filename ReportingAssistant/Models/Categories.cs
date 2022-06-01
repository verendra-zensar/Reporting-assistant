using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReportingAssistant.Models
{
    public class Categories
    {
        [Key]
        public long CategoryID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public string CategoryName { get; set; }    
    }
}