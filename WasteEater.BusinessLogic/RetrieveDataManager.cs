using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteEater.BusinessLogic.Models;

namespace WasteEater.BusinessLogic
{
    public class RetrieveDataManager
    {
        public static Clearance[] RetrieveProductsByStoreId(Clearance[] products, string storeId)
        {
            return products.Where(x => x.storeId == storeId).ToArray();
        }
    }
}
