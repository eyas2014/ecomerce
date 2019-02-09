using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Addresses(string action)
        {
            string userId = _userManager.GetUserId(User);
            ViewData["addresses"] = _db.Addresses.Where(u => u.user_id == userId).ToArray();
            ViewData["default"] = _db.Addresses.Where(a => a.user_id == userId).FirstOrDefault(a => a.isDefault == "true");
            return View("Addresses");
        }

        public IActionResult Orders()
        {
            return View("Orders");
        }

        public IActionResult Summary()
        {
            return View("Summary");
        }

        [HttpPost]
        public void AddAddress(string id)
        {
        //    PersonalInfo personalInfo = _db.PersonalInfos.Single(u => u.email == User.Identity.Name);
        //    string fullname = personalInfo.first_name + " " + personalInfo.last_name;
            Address address = new Address()
            {
                user_id = _userManager.GetUserId(User),
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
            Address address=_db.Addresses.Find(Int32.Parse(address_id));
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
            int address_id =Int32.Parse(Request.Form["address_id"]);
            Address address=_db.Addresses.Find(address_id);
            _db.Addresses.Remove(address);
            _db.SaveChanges();
            Response.Redirect(Request.Form["source_path"]);
        }

        [HttpPost]
        public void setDefault(string address_id) {
            int id = Int32.Parse(address_id);
            string userId = _userManager.GetUserId(User);
            List<Address> addresses = _db.Addresses.Where(a => a.user_id == userId && a.isDefault == "true").ToList();
            foreach (Address a in addresses) a.isDefault = "false";
            _db.Addresses.Find(id).isDefault="true";
            _db.SaveChanges();

            System.Diagnostics.Debug.WriteLine("You changed default");
            _logger.LogInformation("logger working");
            Response.Redirect(Request.Form["source_path"]);
        }
    }
}