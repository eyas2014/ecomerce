using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myEcomerce.Data;

namespace myEcomerce.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _db { get; set; }

        public OrderController( ApplicationDbContext Db) {
            _db = Db;
        }


        public IActionResult Product(int id) {

            Product product=_db.Products.Find(id);

            ViewData["product"] = product;
            ViewData["related"] = relatedProducts(product.tags);

            return View("productdetail");

        }

        private Product[] relatedProducts(string tags) {
            string[] tagsArray = tags.Split(",");
            Product[] products = _db.Products.ToArray();
            int size = products.Length;
            Dictionary<int, int> similarity = new Dictionary<int, int>();
            for (int i = 0; i < 150; i++) similarity[i] = 0;
            foreach (string tag in tagsArray) {
                for (int i = 0; i < size; i++) {
                    if (products[i].tags.Contains(tag)) similarity[i]++;
                }
            }
            var HighRelated=similarity.OrderByDescending(node => node.Value).ToArray();

            Product[] related=new Product[4];
            for (int i = 0; i < 4; i++) {
                related[i]=_db.Products.Find(HighRelated.ElementAt(i).Key);
            }

            return related;
             
        }
    }
}