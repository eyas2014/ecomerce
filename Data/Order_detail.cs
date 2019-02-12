using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myEcomerce.Data
{
    public class Order_detail: BaseEntity
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int Orderid { get; set; }
        public int quantity { get; set; }
        public string status { get; set; }
        public int price { get; set; }
    }
}
