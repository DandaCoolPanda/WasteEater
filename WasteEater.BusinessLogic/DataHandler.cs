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
            Root[] data = DataParser.ParseData(response);

            List<Clearance> clearences = new List<Clearance>();

            foreach (Root root in data)
            {
                foreach (Clearance clearance in root.clearances) {
                    Clearance clearence_object = new Clearance();
                    clearence_object.storeInfo = root.store.brand + " " + root.store.address.street;
                    clearence_object.offer = clearance.offer;
                    clearence_object.product = clearance.product;

                    clearences.Add(clearence_object);
                }

            }

            return clearences.ToArray();
        }
    }
}
