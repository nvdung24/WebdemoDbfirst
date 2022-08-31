using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Categories> Category { get; set; }
        public DbSet<Products> Product { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
