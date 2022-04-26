﻿using WebApI.Models;

namespace ECommerceDemo.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public int ProdCatId { get; set; }
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }

        public virtual ProductCategory ProdCat { get; set; }
       // public virtual List<ProductAttribute> ProdAttribute { get; set; }
    }
}
