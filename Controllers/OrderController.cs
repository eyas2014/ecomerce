using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myEcomerce.Data;

namespace myEcomerce.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db { get; set; }
        private string _user_id { get {
                return _userManager.GetUserId(User);
            }
        }

        private UserManager<IdentityUser> _userManager { get; set; }

        public OrderController(ApplicationDbContext Db, UserManager<IdentityUser> userManager)
        {
            _db = Db;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Cart()
        {
            ViewData["cart"] = getCart("cart").order_details;
            ViewData["later"] = getCart("later").order_details;
            return View("cart");
        }

        public IActionResult Review(int address_id)
        {
            ViewData["cart"] = getCart("cart").order_details;
            ViewData["address"] = _db.Addresses.Find(address_id);
            return View("cart");
        }

        public void AddToCart(int product_id, int quantity)
        {
            Order basicCart = _db.Orders
                                 .Where(o => o.type == "cart")
                                 .Include(o => o.order_details)
                                 .FirstOrDefault(O => O.user_id == _user_id);

            if (basicCart == null)
            {
                basicCart = new Order()
                {
                    user_id = _user_id,
                    type = "cart",
                    status = "open",
                    order_details = new List<Order_detail>()
                };
                _db.Orders.Add(basicCart);
            }

            Product product = _db.Products.Find(product_id);

            Order_detail order_detail = new Order_detail()
            {
                quantity = quantity,
                product = product,
                status = "1"
            };

            basicCart.order_details.Add(order_detail);
            _db.SaveChanges();
            Response.Redirect("/order/cart");
        }

        [HttpPost]
        public void DeleteFromCart(string detail_id)
        {
            int id = Int32.Parse(detail_id);
            Order_detail itemToDelete = _db.Order_details.Find(id);
            _db.Order_details.Remove(itemToDelete);
            _db.SaveChanges();
            Response.Redirect("/order/cart");
        }

        [HttpPost]
        public void SaveForLater(string detail_id)
        {
            int id = Int32.Parse(detail_id);
            Order_detail itemToSave = _db.Order_details.Find(id);
            Order basicCart = _db.Orders
                                 .Where(o => o.type == "later")
                                 .FirstOrDefault(O => O.user_id == _user_id);

            itemToSave.Orderid = basicCart.id;
            _db.SaveChanges();
            Response.Redirect("/order/cart");
        }

        [HttpGet] 
        public void SaveForLater(int product_id)            
        {
            Product product = _db.Products.Find(product_id);
            Order_detail order_detail = new Order_detail()
            {
                quantity = 1,
                product = product,
                status = "1"
            };

            Order basicCart = _db.Orders
                                 .Where(o => o.type == "later")
                                 .Include(o => o.order_details)
                                 .FirstOrDefault(O => O.user_id == _user_id);

            if (basicCart == null)
            {
                basicCart = new Order()
                {
                    user_id = _user_id,
                    type = "cart",
                    status = "open",
                    order_details = new List<Order_detail>()
                };
                _db.Orders.Add(basicCart);
            }

            basicCart.order_details.Add(order_detail);
            _db.SaveChanges();
            Response.Redirect("/order/cart");
        }

        [HttpPost]
        public void MoveToCart(string detail_id)
        {
            int id = Int32.Parse(detail_id);
            Order_detail itemToMove = _db.Order_details.Find(id);
            Order basicCart = _db.Orders
                                 .Where(o => o.type == "cart")
                                 .FirstOrDefault(O => O.user_id == _user_id);

            itemToMove.Orderid = basicCart.id;
            _db.SaveChanges();
            Response.Redirect("/order/cart");
        }

        public IActionResult PlaceOrder() {
            int address_id = Int32.Parse(Request.Form["address_id"]);
            Order cart_order = _db.Orders
                                .Where(O => O.user_id == _user_id)
                                .First(o => o.type == "cart");
            cart_order.address_id = address_id;
            cart_order.type = "order";
            _db.SaveChanges();
            return View("success");
        }

        private Order getCart(string type)
        {
            Order cart = _db.Orders.Where(o => o.type == type)
                                    .Include(o => o.order_details)
                                        .ThenInclude(od => od.product)
                                    .FirstOrDefault(O => O.user_id == _user_id);
            if (cart == null)
            {
                cart = new Order()
                {
                    user_id = _user_id,
                    type = type,
                    status = "open",
                    order_details = new List<Order_detail>()
                };
                _db.Orders.Add(cart);
                _db.SaveChanges();
            }

            return cart;
        }
    }
}