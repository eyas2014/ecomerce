using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myEcomerce.Data
{
    public class Order
    {
        public int id { get; set; }
        public string type { get; set; }
        public string user_id { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public int address_id { get; set; }
        public int seller_id { get; set; }
        public List<Order_detail> order_details { get; set; }
    }
}
