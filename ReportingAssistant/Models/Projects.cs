using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReportingAssistant.Models
{
    public class Projects
    {
        [Key]
      
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int ProjectId { get; set; }

        [Index(IsUnique = true)]
        public    string ProjectName { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd yyy}")]
        public DateTime? DateOfStart { get; set; }  
        
        public bool AvailabilityStatus { get; set; }  
        
        public Categories Categories { get; set; }

        [ForeignKey("CategoryID")]
        public int?  CategoryId { get; set; }
        
        
        public string Image { get; set; } 

//        ProjectID: long, primary key, not null, unique, auto-generated
//ProjectName: string, allow alphabets, digits and spaces only, not null, unique
//DateOfStart: datetime, allow null
//   AvailabilityStatus: Only two options: "Available" and "Not Available"; radio button

        // CategoryID: Foreign key from "Categories" table, shown as dropdownlist; not null
        //   Photo: Allow file uploading; store image in some folder and store the image path in this column; allow null.
    }
}