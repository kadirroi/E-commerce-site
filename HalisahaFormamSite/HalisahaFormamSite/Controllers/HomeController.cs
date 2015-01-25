using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HalisahaFormamSite.Models;

namespace HalisahaFormam1.Controllers
{
    public class HomeController : Controller
    {
        Database database;
        
        
        // GET: /Home/
        public ActionResult Index()

        {



             database = new Database();
             List<Product> product = database.Products.OrderBy(x => x.Id).ToList();

            return View(product);
        }

       
       

        public ActionResult SProductAdd()
        {
            return View();
        }

      





	}
}