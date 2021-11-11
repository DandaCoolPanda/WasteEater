using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteEater.BusinessLogic.Models;

namespace WasteEater.BusinessLogic
{
    public class DataHandler
    {

        public static Clearance[] GetProductDataByZIPCode(int zip)
        {
            string response = ApiRequests.GetWasteFoodByZIPCode(zip);
            Root[] data = DataParser.ParseRoots(response);

            List<Clearance> clearences = new List<Clearance>();

            foreach (Root root in data)
            {
                foreach (Clearance clearance in root.clearances) {
                    Clearance clearence_object = new()
                    {
                        storeInfo = root.store.brand + " " + root.store.address.street,
                        storeId = root.store.id,
                        offer = clearance.offer,
                        product = clearance.product
                    };

                    clearences.Add(clearence_object);
                }

            }

            return clearences.ToArray();
        }


        public static Clearance[] GetProductDataByStoreId(string id)
        {
            string response = ApiRequests.GetProductsFromStore(id);
            Root data = DataParser.ParseRoot(response);

            List<Clearance> clearences = new List<Clearance>();

                foreach (Clearance clearance in data.clearances)
                {
                    Clearance clearence_object = new()
                    {
                        storeInfo = data.store.brand + " " + data.store.address.street,
                        storeId = data.store.id,
                        offer = clearance.offer,
                        product = clearance.product
                    };

                    clearences.Add(clearence_object);
                }

           

            return clearences.ToArray();
        }

        public static Store[] GetStores(int zip)
        {
            string response = ApiRequests.GetStores(zip);
            Store[] data = DataParser.ParseStores(response);
            
            return data.ToArray();
        }
    }
}
