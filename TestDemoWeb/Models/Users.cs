using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemoWeb.Models
{
    public class Users
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        [Required]
        public int RoleID { get; set; }
        public Roles Role { get; set; }
    }
}
