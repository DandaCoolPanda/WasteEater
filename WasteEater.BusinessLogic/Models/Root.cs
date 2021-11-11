using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteEater.BusinessLogic.Models
{
    public class Root
    {
        public List<Clearance> clearances { get; set; }
        public Store store { get; set; }
    }
}
