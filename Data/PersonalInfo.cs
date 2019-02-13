using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myEcomerce.Data
{
    public class PersonalInfo: BaseEntity
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birthday { get; set; }
        public string gender { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string image { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string website { get; set; }
    }
}
