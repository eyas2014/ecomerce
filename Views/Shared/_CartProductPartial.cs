using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myEcomerce.Views.Shared
{
    public class _CartProductPartial
    {
        public int product_id { get; set; }
        public int detail_id { get; set; }
        public string name { get; set; }
        public int items { get; set; }
        public string price { get; set; }
        public string photo { get; set; }
        public string type { get; set; }
    }
}
