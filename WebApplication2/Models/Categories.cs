﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Categories
    {
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        [Required]
        public Categories Category { get; set; }
    }
}
