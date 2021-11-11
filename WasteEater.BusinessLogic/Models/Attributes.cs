using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteEater.BusinessLogic.Models
{
    public class Attributes
    {
        public bool parkingRestrictions { get; set; }
        public bool? garden { get; set; }
        public bool? holidayOpen { get; set; }
        public bool? nonFood { get; set; }
        public bool? open247 { get; set; }
        public bool? petFood { get; set; }
        public bool? scanAndGo { get; set; }
        public string smileyscheme { get; set; }
    }
}
