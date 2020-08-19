using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using L05_Tests_HW2b;
using L05_Tests_HW2b.Controllers;
using Moq;
using L05_Tests_HW2b.Models;
using L05_Tests_HW2b.Repositories;
using L05_Tests_HW2b.Contracts;

namespace L05_Tests_HW2b.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestProductTest()
        {
            // Arrange
            var mock = new Mock<IProductRepository>();
            mock.Setup(x => x.GetAll()).Returns(new List<Product>() {
                new Product(0, "TestProduct", "TestProduct", false)
            });

            var repository = new ProductRepository();

            // Act
            var products = repository.GetAll();

            // Assert
            Assert.IsTrue(mock.Object.GetAll().TrueForAll(x => products.Exists(y => y.Name == x.Name)));
        }
    }
}
