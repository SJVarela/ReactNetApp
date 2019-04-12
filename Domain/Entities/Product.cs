using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public Product()
        {
            //OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public byte[] Picture { get; set; }


        public Category Category { get; set; }
        //public ICollection<OrderDetail> OrderDetails { get; private set; }
    }
}

