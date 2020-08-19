using L05_Tests_HW2b.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L05_Tests_HW2b.Repositories
{
    public class ContextInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {
            Product testProduct = new Product(0, "TestProduct", "TestProduct", false);

            db.Products.Add(testProduct);
            db.SaveChanges();
        }
    }
}