using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEcommerceAdmin.Models;
namespace MyEcommerceAdmin.Controllers
{
    public class HomeController : Controller
    {
        MyEcommerceDbContext db = new MyEcommerceDbContext();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.VegProduct = db.Products.Where(x => x.Category.Name.Equals("Vegitables")).ToList();
            ViewBag.FruitProduct = db.Products.Where(x => x.Category.Name.Equals("Fruits")).ToList();
            ViewBag.DairyProduct = db.Products.Where(x => x.Category.Name.Equals("Dairy Products")).ToList();
            ViewBag.PickProduct = db.Products.Where(x => x.Category.Name.Equals("Pickles")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            return View();
        }
    }
}