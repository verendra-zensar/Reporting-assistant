using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReportingAssistant.Models
{
    public class TasksDone
    {
        [Key]
        public long TaskDoneId { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Screen { get; set; }

        [StringLength(10000, MinimumLength = 2)]

        public string Description { get; set; }

        [Required]
        [ForeignKey("UserID")]

        public int UserID { get; set; }

        [Required]
        public DateTime DateOfTaskDone { get; set; }

        public string Image { get; set; }

        [Required]
        [ForeignKey("ProjectID")]

        public int ProjectID { get; set; }
    }
    //   4. "TasksDone" table:
    //  TaskDoneID: long, primary key, not null, unique, auto-generated
    //Screen: string, min 2 characters length, max 50 characters.
    //Description: string, min 2 characters length, max 100Tasks"00 characters.
    //  UserID: long, Foreign Key from "AspNetUsers" table of Asp.Net Identity; not null

   // DateOfTaskDone: datetime, not null
   //Attachment:  Allow file uploading; store image in some folder and store the image path in this column; allow null.
   //ProjectID: Foreign Key from "Projects" table
    }