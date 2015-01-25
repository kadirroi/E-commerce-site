using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HalisahaFormamSite.Models
{
    public class Product
    {
        public int Id { get; set; }
       

        public string Name { get; set; }
        public int UniformNumber { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string StokAdeti { get; set; }
        public string PictureUrl { get; set; }
        public string indirim { get; set; }
        public string stars { get; set; }

        public virtual Team Team { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}