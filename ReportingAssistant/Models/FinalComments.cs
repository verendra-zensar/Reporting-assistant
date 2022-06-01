using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReportingAssistant.Models
{
    public class FinalComments
    {
        [Key]
        [Index(IsUnique = true)]

        public long FinalCommentID { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Screen { get; set; }

        [StringLength(10000, MinimumLength = 2)]

        public string Description { get; set; }


        [Required]
        [ForeignKey("AdminUserID")]

        public int AdminUserID { get; set; }


        [Required]
        [ForeignKey("UserID")]

        public int UserID { get; set; }

        public DateTime DateOfFinalComment { get; set; }

        public string Image { get; set; }

        [Required]
        [ForeignKey("ProjectID")]

        public int ProjectID { get; set; }
    }

 //   5. "FinalComments" table:
 //  FinalCommentID: long, primary key, not null, unique, auto-generated
 //Screen: string, min 2 characters length, max 50 characters.
 //Description: string, min 2 characters length, max 10000 characters.
 //AdminUserID: long, Foreign key from "AspNetUsers" table of Asp.Net Identity; not null
 //  UserID: long, Foreign Key from "AspNetUsers" table of Asp.Net Identity; not null
 //  DateOfFinalComment: datetime, not null
 //  Attachment:  Allow file uploading; store image in some folder and store the image path in this column; allow null.
 //  ProjectID: Foreign Key from "Projects" table

    }