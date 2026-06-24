using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OopMvcApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public Product(int id, string name, decimal price, int qty)
        {
            ProductId = id; ProductName = name; Price = price; Qty = qty;
        }

        //public decimal CalculateTotal() => Price * Qty;
        public decimal CalculateTotal()
        {
            return Price * Qty;
        }
    }
}