using L05_Tests_HW2b.Contracts;
using L05_Tests_HW2b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace L05_Tests_HW2b.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext db = new DatabaseContext();
        public void Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            Product product = db.Products.Find(id);
            return product;
        }
    }
}