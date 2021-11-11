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
        public DateTime created { get; set; }
        public object distance_km { get; set; }
        public List<Hour> hours { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string sapSiteId { get; set; }
        public string vikingStoreId { get; set; }
        public Attributes attributes { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }
}
