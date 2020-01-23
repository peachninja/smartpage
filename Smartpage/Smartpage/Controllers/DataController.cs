using Newtonsoft.Json.Linq;
using Smartpage.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Smartpage.Controllers
{
    class DataController : iDataController
    {
        public DataProduct DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public DataProduct GetProduct(int id)
        {
            using (var httpClient = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                var url = ConfigurationManager.AppSettings["baseApiUrl"] + "people/"+id;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "GET";
                httpWebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                var content = string.Empty;

                using (var response = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
                JObject json = JObject.Parse(content);

                DataProduct data = new DataProduct();
                data.Id = id;
                data.Name = json["name"].ToString();

                return data;
            }
        }

        public DataProduct PostProduct(DataProduct data)
        {
            throw new NotImplementedException();
        }

        public DataProduct UpdateProduct(DataProduct data)
        {
            throw new NotImplementedException();
        }
    }
}
