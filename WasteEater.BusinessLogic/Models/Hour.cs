using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteEater.BusinessLogic.Models
{
    public class Hour
    {
        public string date { get; set; }
        public string type { get; set; }
        public DateTime open { get; set; }
        public DateTime close { get; set; }
        public bool closed { get; set; }
        public List<double> customerFlow { get; set; }
    }
}
