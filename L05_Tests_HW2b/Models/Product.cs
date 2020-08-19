using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L05_Tests_HW2b.Models
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int id, string name, string description, bool isAvaliable)
        {
            Id = id;
            Name = name;
            Description = description;
            IsAvaliable = isAvaliable;
        }
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAvaliable { get; set; }
    }
}