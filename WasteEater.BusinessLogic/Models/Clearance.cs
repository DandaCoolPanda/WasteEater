using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteEater.BusinessLogic.Models
{
    public class Clearance
    {
        public Offer offer { get; set; }
        public Product product { get; set; }

        public string storeInfo { get; set; }

        public string storeId { get; set; }
    }
}
