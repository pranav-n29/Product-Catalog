using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = GetProducts();
            return View(products);
        }

        // GET: Product/Details/1
        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();
            Product product = products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "Dell Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 25000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 3000,
                    Category = "Accessories"
                }
            };
        }
    }
}
