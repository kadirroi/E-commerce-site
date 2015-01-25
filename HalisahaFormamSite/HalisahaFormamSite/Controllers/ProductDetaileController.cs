
using HalisahaFormamSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HalisahaFormam1.Controllers
{
    public class ProductDetaileController : Controller
    {
        //
        // GET: /ProductDetaile/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            Database database1 = new Database();

            Product productdetaiel = database1.Products.Single(prd => prd.Id == id);
           

            return View(productdetaiel);



        }


	}
}