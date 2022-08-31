using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemoWeb.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Roles> Role { get; set; }
        public DbSet<Users> User { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
