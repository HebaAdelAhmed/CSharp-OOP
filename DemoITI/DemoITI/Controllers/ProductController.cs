using DemoITI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoITI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductSampleDate productSampleDate = new ProductSampleDate();
            List<Product> products = productSampleDate.GetAll();
            return View("DesplayAllProduct" , products);
        }

        public IActionResult GetProductById(int id)
        {
            ProductSampleDate productSampleDate = new ProductSampleDate();
            Product Product = productSampleDate.GetById(id);
            return View("Details", Product);
        }
    }
}
