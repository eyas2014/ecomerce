using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myEcomerce.Data
{
    public class Order: BaseEntity
    {
        public int id { get; set; }
        public string type { get; set; }
        public string user_id { get; set; }
        public string status { get; set; }
        public string email { get; set; }
        public int address_id { get; set; }
        public List<Order_detail> order_details { get; set; }
        [ForeignKey("address_id")]
        public Address address { get; set; }
    }
}
