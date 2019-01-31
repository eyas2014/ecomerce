using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myEcomerce.Views.Shared
{
    public class _FormcontrolPartial
    {
        public string placeholder { get; set; }
        public string title { get; set; }
        public string color { get; set; } = "secondary";
        public string input_type { get; set; } = "text";
        public string[] data { get; set; }
        public string icon { get; set; } = "oi oi-menu";
    }
}
