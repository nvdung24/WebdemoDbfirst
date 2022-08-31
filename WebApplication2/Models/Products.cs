using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Products
    {
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Cate_ID { get; set; }
        public ICollection<Products> Product { get; set; }
        public Categories Category { get; set; }

    }
}
