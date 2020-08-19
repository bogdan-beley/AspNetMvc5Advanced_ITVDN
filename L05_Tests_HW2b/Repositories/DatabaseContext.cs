using L05_Tests_HW2b.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L05_Tests_HW2b.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("L05_Tests_HW2b_Db") { }

        public DbSet<Product> Products { get; set; }
    }
}