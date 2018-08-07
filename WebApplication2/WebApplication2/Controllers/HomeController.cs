using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        [AllowHtml]
        public string content { get; set; }
        public string excerpt { get; set; }
        public DateTime? date { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
        public int author { get; set; }
        public string images { get; set; }
        public string featured_image { get; set; }
    }

    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}