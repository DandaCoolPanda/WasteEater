using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteEater.BusinessLogic.Models;

namespace WasteEater.BusinessLogic
{
    
    public class SortingDataManager
    {
        public static Clearance[] SortProductsByLastUpdate(Clearance[] products)
        {
            return products.OrderByDescending(x => x.offer.lastUpdate).ToArray();
        }
    }
}
