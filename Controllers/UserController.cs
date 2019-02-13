using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using myEcomerce.Data;

namespace myEcomerce.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public UserController(ApplicationDbContext Db,
                              SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager,
                              ILogger<UserController> logger)
        {
            _db = Db;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;

        }

        private string _user_id
        {
            get
            {
                return _userManager.GetUserId(User);
            }
        }

        private readonly ILogger _logger;

        private ApplicationDbContext _db { get; set; }

        private SignInManager<IdentityUser> _signInManager { get; set; }

        UserManager<IdentityUser> _userManager { get; set; }

        public IActionResult Index()
        {
            PersonalInfo personalInfo = _db.PersonalInfos.Single(u => u.email == User.Identity.Name);
            ViewData["info"] = personalInfo;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> updateProfile(List<IFormFile> myavatar, string id)
        {
            PersonalInfo personalInfo = _db.PersonalInfos.Single(u => u.email == User.Identity.Name);
            switch (id)
            {
                case "info":
                    string myfile = "wwwroot/images/avatar/myavatar.jpg";
                    foreach (var formFile in myavatar)
                    {
                        if (formFile.Length > 0)
                        {
                            using (var stream = new FileStream(myfile, FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                        }
                    }
                    personalInfo.first_name = Request.Form["firstname"];
                    personalInfo.last_name = Request.Form["lastname"];
                    personalInfo.nickname = Request.Form["nickname"];
                    personalInfo.gender = Request.Form["gender"];
                    personalInfo.birthday = DateTime.ParseExact(Request.Form["birthday"], "yyyy-MM-dd",
                                               System.Globalization.CultureInfo.InvariantCulture);

                    personalInfo.image = myfile;
                    _db.SaveChanges();
                    ViewData["info"] = personalInfo;
                    return View("index");
                case "social":
                    personalInfo.facebook = Request.Form["facebook"];
                    personalInfo.twitter = Request.Form["twitter"];
                    personalInfo.website = Request.Form["website"];
                    _db.SaveChanges();
                    ViewData["info"] = personalInfo;
                    return View("index");
                case "password":
                    ViewData["info"] = personalInfo;
                    string password1 = Request.Form["newpassword1"];
                    string password2 = Request.Form["newpassword2"];
                    string oldpassword = Request.Form["oldpassword"];
                    if (password1 == password2)
                    {
                        IdentityUser appUser = _db.Users.Find(_user_id);
                        var result = await _userManager.ChangePasswordAsync(appUser, oldpassword, password1);
                        if (result.Succeeded)
                        {
                            ViewData["changePassword"] = "success";
                            return View("index");
                        }
                        else if (result.ToString().Contains("PasswordMismatch"))
                        {
                            ViewData["changePassword"] = "Old password was incorrect!";
                            return View("index");
                        }
                        else {

                            ViewData["changePassword"] = "Failed to change password!";
                            return View("index");
                        }
                    }
                    else
                    {
                        ViewData["changePassword"] = "Different New Password!";
                        return View("index");
                    }
                default:
                    ViewData["info"] = personalInfo;
                    return View("index");
            }
        }

        [HttpPost]
        public  async Task<IActionResult> changePassword(string password1, string password2, string oldpassword) {

            


            if (password1 == password2)
            {
                IdentityUser appUser = _db.Users.Find(_user_id);

                var result = await _userManager.ChangePasswordAsync(appUser, "a", "b");

                ViewData["str"] = result.ToString();

                return View("test");

            }
            else
            {

                ViewData["str"] = "mismatch";



                return View("test");

            }
        }

        public IActionResult Addresses(string action)
        {
            ViewData["addresses"] = _db.Addresses.Where(u => u.user_id == _user_id).ToArray();
            ViewData["default"] = _db.Addresses.Where(a => a.user_id == _user_id).FirstOrDefault(a => a.isDefault == "true");
            return View("Addresses");
        }

        public IActionResult Orders(string id)
        {
            ViewData["orders"] = _db.Orders.Where(o => o.user_id == _user_id && o.type == "order")
                                            .Include(o => o.address)
                                            .Include(o => o.order_details)
                                                .ThenInclude(d => d.product)
                                          .ToArray();
            switch (id)
            {
                case "Closed":
                    ViewData["select"] = "Closed";
                    break;
                case "Canceled":
                    ViewData["select"] = "Canceled";
                    break;
                default:
                    ViewData["select"] = "Open";
                    break;
            }
            return View("Orders");
        }

        public IActionResult Summary()
        {
            Order[] orders = _db.Orders.Where(o => o.user_id == _user_id && o.type == "order")
                              .ToArray();
            int[] catagories = new int[4];
            catagories[0] = orders.Length;
            foreach (Order order in orders)
            {
                switch (order.status)
                {
                    case "open":
                        catagories[1]++;
                        break;
                    case "closed":
                        catagories[2]++;
                        break;
                    case "canceled":
                        catagories[3]++;
                        break;
                    default:
                        break;
                }
            }
            ViewData["catagories"] = catagories;
            return View("Summary");
        }

        [HttpPost]
        public void AddAddress(string id)
        {
            Address address = new Address()
            {
                user_id = _user_id,
                fullname = Request.Form["fullname"],
                city = Request.Form["city"],
                state = Request.Form["state"],
                line1 = Request.Form["line1"],
                line2 = Request.Form["line2"],
                zipcode = Request.Form["zipcode"],
                country = Request.Form["country"],
                isDefault = "false",
                phone = Request.Form["phonenumber"]
            };
            _db.Addresses.Add(address);
            _db.SaveChanges();
            Response.Redirect(Request.Form["source_path"]);
        }

        [HttpPost]
        public void updateAddress(string address_id)
        {
            Address address = _db.Addresses.Find(Int32.Parse(address_id));
            address.fullname = Request.Form["fullname"];
            address.city = Request.Form["city"];
            address.state = Request.Form["state"];
            address.line1 = Request.Form["line1"];
            address.line2 = Request.Form["line2"];
            address.zipcode = Request.Form["zipcode"];
            address.country = Request.Form["country"];
            address.isDefault = "false";
            address.phone = Request.Form["phonenumber"];
            _db.SaveChanges();
            Response.Redirect(Request.Form["source_path"]);
        }

        [HttpPost]
        public void deleteAddress()
        {
            int address_id = Int32.Parse(Request.Form["address_id"]);
            Address address = _db.Addresses.Find(address_id);
            _db.Addresses.Remove(address);
            _db.SaveChanges();
            Response.Redirect(Request.Form["source_path"]);
        }

        [HttpPost]
        public void setDefault(string address_id)
        {
            int id = Int32.Parse(address_id);
            List<Address> addresses = _db.Addresses.Where(a => a.user_id == _user_id && a.isDefault == "true").ToList();
            foreach (Address a in addresses) a.isDefault = "false";
            _db.Addresses.Find(id).isDefault = "true";
            _db.SaveChanges();

            System.Diagnostics.Debug.WriteLine("You changed default");
            _logger.LogInformation("logger working");
            Response.Redirect(Request.Form["source_path"]);
        }

        public IActionResult OrderDetail(int id)
        {
            Order order = _db.Orders
                .Include(o => o.address)
                .Include(o => o.order_details)
                    .ThenInclude(d => d.product)
                .First(o => o.id == id);
            int total = 0;
            foreach (Order_detail detail in order.order_details)
            {
                total = total + detail.quantity * detail.price;
            }
            ViewData["total"] = total;
            ViewData["order"] = order;
            return View("orderdetail");
        }
    }
}