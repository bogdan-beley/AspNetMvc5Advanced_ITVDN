using L05_Tests_HW2b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Tests_HW2b.Contracts
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Create(Product product);
        void Delete(int id);
    }
}
