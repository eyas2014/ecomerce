﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myEcomerce.Data
{
    public class Address: BaseEntity
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string user_id { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string isDefault { get; set; } = "false";
    }
}
