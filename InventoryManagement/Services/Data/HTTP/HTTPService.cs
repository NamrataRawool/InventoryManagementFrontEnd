using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using InventoryManagement.Services.Misc.Assert;
using System.Drawing;
using System.IO;

namespace InventoryManagement.Services.HTTP
{
    public class HTTPService
    {

        public static byte[] GETFile(string imageURL)
        {
            RestRequest Request = new RestRequest(imageURL);

            byte[] imageBytes = Client.DownloadData(Request);

            return imageBytes;
        }

        public static T GET<T>(string URL) where T: new()
        {
            RestRequest Request = new RestRequest(URL);

            var Response = Client.Get(Request);

            if (Response.StatusCode != System.Net.HttpStatusCode.OK && Response.StatusCode != System.Net.HttpStatusCode.NotFound)
            {
                Assert.Do();
                return default(T);
            }

            var Content = Response.Content;

            return JsonConvert.DeserializeObject<T>(Content);
        }

        /*
         * RETURN_TYPE : 'Get' model eg. 'ProductGet'
         * INPUT_TYPE : 'Post' model eg. 'ProductPost'
         */
        public static RETURN_TYPE POST<RETURN_TYPE, INPUT_TYPE>(string URL, INPUT_TYPE Obj, string filename) where INPUT_TYPE : new()
        {
            List<string> files = null;
            if (filename != null)
            {
                files = new List<string>();
                files.Add(filename);
            }
            return POST<RETURN_TYPE, INPUT_TYPE>(URL, Obj, files);
        }

        //public static RETURN_TYPE PUT<RETURN_TYPE, INPUT_TYPE>(string URL, INPUT_TYPE Obj, string filename) where INPUT_TYPE : new()
        //{
        //}

        public static RETURN_TYPE POST<RETURN_TYPE, INPUT_TYPE>(string URL, INPUT_TYPE Obj, List<string> filenames = null) where INPUT_TYPE : new()
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

            if (Response.StatusCode != System.Net.HttpStatusCode.OK && Response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                Assert.Do();
                return default(RETURN_TYPE);
            }

            var Content = Response.Content;
            return JsonConvert.DeserializeObject<RETURN_TYPE>(Content);
        }

        public static RETURN_TYPE PUT<RETURN_TYPE, INPUT_TYPE>(string URL, INPUT_TYPE Obj, List<string> filenames = null) where INPUT_TYPE : new()
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

            var Response = Client.Put(Request);

            if (Response.StatusCode != System.Net.HttpStatusCode.OK && Response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                Assert.Do();
                return default(RETURN_TYPE);
            }

            var Content = Response.Content;
            return JsonConvert.DeserializeObject<RETURN_TYPE>(Content);
        }

        private const string BaseURL = "http://localhost:5000";
        private static RestClient Client = new RestClient(BaseURL);
        
    }
}

