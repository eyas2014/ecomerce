using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using myEcomerce.Data;

namespace myEcomerce.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public UserController(ApplicationDbContext Db, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _db = Db;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        private ApplicationDbContext _db { get; set; }

        private SignInManager<IdentityUser> _signInManager { get; set; }

        UserManager<IdentityUser> _userManager { get; set; }

        public IActionResult Index()
        {
            PersonalInfo personalInfo = _db.PersonalInfos.Single(u => u.email == User.Identity.Name);
            ViewData["info"] = personalInfo;
            return View();
        }

        public IActionResult Addresses()
        {
            string userId = _userManager.GetUserId(User);
            Address[] addresses = _db.Addresses.ToArray();
            foreach (Address address in addresses)
            {
                address.user_id = userId;
                _db.Addresses.Update(address);
            }
            _db.SaveChanges();
            ViewData["address"] = _db.Addresses.Where(u => u.user_id == userId).ToArray();
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


        public void updateAddress()
        {
            PersonalInfo personalInfo = _db.PersonalInfos.Single(u => u.email == User.Identity.Name);
            string fullname = personalInfo.first_name +" "+personalInfo.last_name;
            Address address = new Address()
            {
                user_id = _userManager.GetUserId(User),
                fullname= Request.Form["fullname"],
                city = Request.Form["city"],
                state = Request.Form["state"],
                line1 = Request.Form["line1"],
                line2 = Request.Form["line2"],
                zipcode = Request.Form["zipcode"],
                country = Request.Form["country"],
                phone = Request.Form["phone"]
            };
            _db.Addresses.Add(address);
            _db.SaveChanges();
            Response.Redirect("/user/addresses");
        }

        [HttpPost]
        public void deleteAddress()
        {
            int address_id =Int32.Parse(Request.Form["id"]);
            Address address=_db.Addresses.Find(address_id);
            _db.Addresses.Remove(address);
            _db.SaveChanges();
            Response.Redirect("/user/addresses");
        }
    }
}