using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_Appshell_TabBarPage.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public double ProductRating { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductTypeId { get; set; }

    }
}
