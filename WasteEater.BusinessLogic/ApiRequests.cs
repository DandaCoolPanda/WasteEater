using System;
using System.IO;
using System.Net;

namespace WasteEater.BusinessLogic
{
    public class ApiRequests
    {
        public static string GetWasteFoodByZIPCode(int zip) 
        {
            var url = "https://api.sallinggroup.com/v1/food-waste/?zip="+zip;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer 50297c77-9a1a-4eb5-8867-12bff6caa9b2";


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;

        }



    }
}
