using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyStore.Models;
namespace ToyStore.Controllers
{
    public class HomeController : Controller
    {
        private ToyStoreDBEntities _dataModel = new ToyStoreDBEntities();
        public ActionResult Index()
        {
            return View(_dataModel.Products.ToList());            
            //return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}