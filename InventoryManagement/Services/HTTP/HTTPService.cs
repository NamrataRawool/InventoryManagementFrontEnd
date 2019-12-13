using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace InventoryManagement.Services.HTTP
{
    public class HTTPService
    {
        public static T GET<T>(string URL) where T: new()
        {
            RestRequest Request = new RestRequest(URL);

            var Response = Client.Get(Request).Content;

            return JsonConvert.DeserializeObject<T>(Response);
        }

        public static T POST<T>(string URL, T Obj, List<string> filenames = null) where T: new()
        {

            RestRequest Request = new RestRequest(URL);

            Request.AddObject(Obj);
            if (filenames != null)
            {
                foreach (var filename in filenames)
                    Request.AddFile("images", filename);
            }

            var Response = Client.Post(Request).Content;

            return JsonConvert.DeserializeObject<T>(Response);
        }


        private const string BaseURL = "http://localhost:5000";
        private static RestClient Client = new RestClient(BaseURL);
        
    }
}

