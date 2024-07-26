using Microsoft.AspNetCore.Mvc;
using Webapp_July.Models;
using System.Collections.Generic; // Make sure to import this for List<T>

namespace Webapp_July.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Create a list of products
            var products = new List<Product>
            {
                new Product("Samsung"),
                new Product("Redmi"),
                new Product("OPPO")
            };

            // Pass the products to the view
            return View(products); // Make sure the view expects a model of type IEnumerable<Product>
        }
    }
}
