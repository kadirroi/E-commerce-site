using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HalisahaFormamSite.Models
{
    public class Order
    {
        public int OrderId { get; set; }
       
        public System.DateTime OrderDate { get; set; }
        public string FirstName { get; set; }
        public string UniFormName { get; set; }
        public int UniformNumber { get; set; }
        public string StateHands { get; set; }
        public string UniformSize { get; set; }
        public string City { get;set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string kargo { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
       
        public List<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }
      

    }
}