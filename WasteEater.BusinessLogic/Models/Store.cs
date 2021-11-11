using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteEater.BusinessLogic.Models
{
    public class Store
    {
        public Address address { get; set; }
        public string brand { get; set; }
        public List<double> coordinates { get; set; }
        public List<Hour> hours { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }
}
