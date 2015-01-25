using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HalisahaFormamSite.Models;
using HalisahaFormamSite.Models;
namespace HalisahaFormam1.Controllers
{
    public class SearchProductController : Controller
    {
        //
        // GET: /SearchProduct/
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Search( String nameProduct)
        {
            Database db = new Database();
        var searchproduct = from s in db.Products
                            select s;

        if (!String.IsNullOrEmpty(nameProduct))
        {
            searchproduct = searchproduct.Where(c => c.Name.Contains(nameProduct));
        }
        ViewBag.Message = searchproduct.Count();
        return View(searchproduct);
        
        }


	}
}