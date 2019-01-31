using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myEcomerce.Models;

namespace myEcomerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View("ProductDetail");
        }
    }
}