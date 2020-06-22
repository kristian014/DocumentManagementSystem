﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DocumentManagementSystem.Models
{
    public class Category
    {
        

        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public int UsersUserId { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}