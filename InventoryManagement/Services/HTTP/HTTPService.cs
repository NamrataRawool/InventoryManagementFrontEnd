using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using InventoryManagement.Services.Misc.Assert;

namespace InventoryManagement.Services.HTTP
{
    public class HTTPService
    {
        public static T GET<T>(string URL) where T: new()
        {
            RestRequest Request = new RestRequest(URL);

            var Response = Client.Get(Request);

            if (Response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Assert.Do();
                return default(T);
            }

            var Content = Response.Content;

            return JsonConvert.DeserializeObject<T>(Content);
        }

        public static T POST<T>(string URL, T Obj, string filename) where T : new()
        {
            List<string> files = null;
            if (filename != null)
            {
                files = new List<string>();
                files.Add(filename);
            }
            return POST(URL, Obj, files);
        }

        public static T POST<T>(string URL, T Obj, List<string> filenames = null) where T: new()
        {

            RestRequest Request = new RestRequest(URL);

            Request.AddObject(Obj);
            if (filenames != null)
            {
                foreach (var filename in filenames)
                {
                    if (filename != null && !filename.Equals(""))
                        Request.AddFile("images", filename);
                }
            }

            var Response = Client.Post(Request);

            if (Response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Assert.Do();
                return default(T);
            }

            var Content = Response.Content;
            return JsonConvert.DeserializeObject<T>(Content);
        }


        private const string BaseURL = "http://localhost:5000";
        private static RestClient Client = new RestClient(BaseURL);
        
    }
}

