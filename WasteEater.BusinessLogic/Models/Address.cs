using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteEater.BusinessLogic.Models
{
    public class Address
    {
        public string city { get; set; }
        public string country { get; set; }
        public object extra { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
    }
}
