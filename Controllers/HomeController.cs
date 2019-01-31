using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myEcomerce.Data;
using Newtonsoft.Json;

namespace myEcomerce.Controllers
{
    public class HomeController : Controller
    {
        public Info info = new Info { };

        private ApplicationDbContext _db { get; set; }


        public HomeController(ApplicationDbContext Db)
        {

            info.tabs = new string[] { "About Us", "Refunds Policy", "Terms and Conditions" };
            info.routes = new string[] { "about", "refunds", "terms" };
            _db = Db;

        }


        [Route("search")]
        public IActionResult Search(string q) {
            ViewData["searchResult"]=_db.Products.Where(product=>product.tags.Contains(q)).ToArray();
            return View("search");

        }

        [Route("test")]
        public IActionResult Test() {
            return View("test");
        }
        

        [Route("/")]
        public IActionResult Index()
        {
            var products = _db.Products.ToList();
            ViewData["topViewed"] = products.OrderByDescending(product=>product.view_counts).Take(4).ToArray();
            ViewData["topPurchased"] = products.OrderByDescending(product => product.sale_counts).Take(4).ToArray();
            ViewData["topRated"] = products.OrderByDescending(product => product.rate_count).Take(4).ToArray();
            ViewData["tags"] = getTags(products);

            return View();
        }

        private string[] getTags(List<Product> products) {

            Dictionary<string, int> tagDict = new Dictionary<string, int>();
            foreach (Product product in products)
            {
                string[] tags = product.tags.Split(",");
                foreach (string tag in tags)
                {
                    if (tagDict.ContainsKey(tag)) tagDict[tag]++;
                    else tagDict.Add(tag, 1);
                }
            }
            if (tagDict.Count < 50) return tagDict.Keys.ToArray();
            else
            {
                var tagArray = tagDict.OrderByDescending(tag => tag.Value).ToArray();
                string[] tags = new string[50];
                for (int i = 0; i < 50; i++)
                {
                    tags[i] = tagArray[i].Key;
                }
                return tags;
            }


        }


        [Route("/contact")]
        public IActionResult Contact()
        {

            return View("contact");


        }




        [Route("/about")]
        public IActionResult About()
        {
            info.content = "Distinctio eum omnis suscipit non earum. Dolorem officia enim laudantium minima sint ut praesentium amet. Molestiae perferendis soluta molestias ut excepturi alias saepe et. Neque est optio laudantium est. Quaerat voluptatem et nobis ut neque. Sint ratione ut odio et corporis explicabo est. Tempore quos animi adipisci ex et. Repudiandae ut consequatur error et blanditiis sapiente et.";

            ViewData.Model = info;

            info.index = 0;

            return View();
        }

        [Route("/refunds")]
        public IActionResult Refunds()
        {
            info.content = "Distinctio eum omnis suscipit non earum. Dolorem officia enim laudantium minima sint ut praesentium amet. Molestiae perferendis soluta molestias ut excepturi alias saepe et. Neque est optio laudantium est. Quaerat voluptatem et nobis ut neque. Sint ratione ut odio et corporis explicabo est. Tempore quos animi adipisci ex et. Repudiandae ut consequatur error et blanditiis sapiente et.";

            ViewData.Model = info;

            info.index = 1;

            return View("about");
        }


        [Route("/terms")]
        public IActionResult Terms()
        {

            info.content = "Distinctio eum omnis suscipit non earum. Dolorem officia enim laudantium minima sint ut praesentium amet. Molestiae perferendis soluta molestias ut excepturi alias saepe et. Neque est optio laudantium est. Quaerat voluptatem et nobis ut neque. Sint ratione ut odio et corporis explicabo est. Tempore quos animi adipisci ex et. Repudiandae ut consequatur error et blanditiis sapiente et.";

            ViewData.Model = info;

            info.index = 2;

            return View("about");
        }

    }


    public class Info
    {
        public string[] tabs { set; get; }

        public string content { set; get; }

        public string[] routes;

        public int index;
    }
}