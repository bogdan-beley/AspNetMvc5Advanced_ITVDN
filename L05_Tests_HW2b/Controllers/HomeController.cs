using L05_Tests_HW2b.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_Tests_HW2b.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductRepository pr = new ProductRepository();
            var products = pr.GetAll();
            return View(products);
        }

      
    }
}