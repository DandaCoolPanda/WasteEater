using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteEater.BusinessLogic.Models;

namespace WasteEater.BusinessLogic
{
    public class DataParser
    {
        public static Root[] ParseData(string json)
        {
            return JsonConvert.DeserializeObject<Root[]>(json);
        }
    }
}
