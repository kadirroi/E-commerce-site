using HalisahaFormamSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HalisahaFormamSite.Models
{
    public class AdminController : Controller
    {
        Database database;
        //
        // GET: /Admin/
        public ActionResult AdminMenu()
        {

            return View();
        
        }
        
        public ActionResult ProductList()
        {

            database = new Database();
            List<Product> product = database.Products.OrderBy(x => x.Name).ToList();

            return View(product);
        }

        public ActionResult OrderList()
        {

            database = new Database();
            List<Order> order = database.Orders.OrderBy(x => x.OrderId).ToList();

            return View(order);
        }

        public ActionResult OrderDetaileList()
        {

            database = new Database();
            List<OrderDetail> orderdetail = database.OrderDetails.OrderBy(x => x.OrderId).ToList();

            return View(orderdetail);
        }





        public ActionResult OrderEdit(int id)
        {
            using (var database = new Database())
            {
                var order = database.Orders.Single(m => m.OrderId == id);

                var ordert = new Order
                {
                    Status = order.Status,
                   
                };
                return View(ordert);
            }


        }

        public ActionResult OrderDelete(int id)
        {
            using (var database = new Database())
            {
                var order = database.Orders.Single(m => m.OrderId == id);
                database.Orders.Remove(order);
                database.SaveChanges();
            }

            return RedirectToAction("ProductList");
        }



        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product productadd)
        {
            using (var database = new Database())
            {
                var product = database.Products.Create();
                product.Name = productadd.Name;
                product.Description = productadd.Description;
                product.indirim = productadd.indirim;
                product.PictureUrl = productadd.PictureUrl;
                product.Price = productadd.Price;
               
                product.stars = productadd.stars;
                product.StokAdeti = productadd.StokAdeti;
               
                database.Products.Add(product);
                database.SaveChanges();


            }


            return RedirectToAction("ProductList");
        }

        public ActionResult Edit(int id)
        {
            using (var database = new Database())
            {
                var product = database.Products.Single(m => m.Id == id);

                var productt = new Product
                {
                    Name = product.Name,
                    PictureUrl = product.PictureUrl,
                    Price = product.Price,
                    indirim = product.indirim,
                    Description = product.Description,
                    StokAdeti=product.StokAdeti,
                    stars =product.stars,
                   
                    Id = product.Id,
                };
                return View(productt);
            }


        }
        [HttpPost]
        public ActionResult Edit(Product productEdit)
        {
            using (var database = new Database())
            {
                var product = database.Products.Single(m => m.Id == productEdit.Id);
                product.Name = productEdit.Name;
                product.Description = productEdit.Description;
                product.indirim = productEdit.indirim;
                product.PictureUrl = productEdit.PictureUrl;
                product.Price = productEdit.Price;

                database.SaveChanges();
            }
            return RedirectToAction("ProductList");
        }

        public ActionResult Delete(int id)
        {
            using (var database = new Database())
            {
                var product = database.Products.Single(m => m.Id == id);
                database.Products.Remove(product);
                database.SaveChanges();
            }

            return RedirectToAction("ProductList");
        }






    }
}