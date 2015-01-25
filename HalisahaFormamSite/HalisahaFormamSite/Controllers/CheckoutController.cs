
using HalisahaFormamSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HalisahaFormamSite.Controllers
{
    public class CheckoutController : Controller
    {
        Database storeDB = new Database();
       
        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }
        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(Order orderadd)
        {
           if (Session["LogedUserFullname"] != null)
           {  var cart = ShoppingCart.GetCart(this.HttpContext);
                Database database = new Database();
                var order = database.Orders.Create();

                order.FirstName = orderadd.FirstName;
                order.UniFormName = orderadd.UniFormName;
                order.UniformNumber = orderadd.UniformNumber;
                order.UniformSize = orderadd.UniformSize;
                order.StateHands = orderadd.StateHands;
                order.Adress = orderadd.Adress;
                order.City = orderadd.City;
                order.Country = orderadd.Country;
                order.kargo = orderadd.kargo;
                order.UniformNumber = orderadd.UniformNumber;
                order.Phone = orderadd.Phone;
                order.OrderDate = DateTime.Now;
                order.Total = cart.GetTotal();
                database.Orders.Add(order);
                database.SaveChanges();

                cart.CreateOrder(order);
                return RedirectToAction("PayCard", new { id = order.OrderId });
        }
            else
               return RedirectToAction("Login","Account" );
        }
        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
         Order order =storeDB.Orders.Single(o => o.OrderId == id);

           
                return View(order);
           
        
           
        }

        public ActionResult PayCard(int id)
        {

            Order order = storeDB.Orders.Single(o => o.OrderId == id);


            return View(order);
        
        }


	}
}