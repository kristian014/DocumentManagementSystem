using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DocumentManagementSystem.Models
{
    public class Document
    {

        [Key]
        public int DocumentId { get; set; }
        [Required]
        public string DocumentPath { get; set; }
        [Required]
        public string DocumentName { get; set; }
        [Required]
        public string DocumentTags { get; set; }
        public int CategoryId { get; set; }
        public int UsersUserId { get; set; }

        public virtual Category Category { get; set; }
    }
}