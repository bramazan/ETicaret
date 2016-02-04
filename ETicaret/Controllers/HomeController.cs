using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ETicaret.Models;

namespace ETicaret.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities ent = new NorthwindEntities();
        public ActionResult Index()
        {
            AnasayfaDTO obj = new AnasayfaDTO();

            return View();
        }
        public ActionResult error()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
        public ActionResult aboutus()
        {
            return View();
        }
        public ActionResult blogpost()
        {
            return View();
        }
        public ActionResult category()
        {
            return View();
        }
        public ActionResult categorylayout()
        {
            return View();
        }
        public ActionResult checkout()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult indexlayout()
        {
            return View();
        }
        public ActionResult loginregister()
        {
            return View();
        }
        public ActionResult indexnavlayout()
        {
            return View();
        }
        public class AnasayfaDTO
        {
            public List<Orders> Order { get; set; }
            public List<Customers> Customer { get; set; }
            public List<Order_Details> OrderDetail { get; set; }
            public List<Alphabetical_list_of_products> Product { get; set; }
            public List<Category_Sales_for_1997> Category { get; set; }

        }
    }
}