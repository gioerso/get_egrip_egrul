using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace APINalog
{
    internal class methods
    {
        public static async Task<stat.Rootobject> GetStats()
        {
            return null;
        }
        private static readonly HttpClient client = new HttpClient();
        
        
        
        public static async Task<stat.Rootobject> GetEgrul(string data)
        {
            var values = new Dictionary<string, string>
              {
                  { "user_id", "210700286" },
                  { "v", "5.131" },
                  { "access_token", "aa367035aa367035aa69ea765daa7763e3aaa36aa367035f28d1f52f6554906fc250b82" }
              };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://api.vk.com/method/users.get", content);

            var responseString = await response.Content.ReadAsStringAsync();

            var dataA = JsonConvert.DeserializeObject<stat.Rootobject>(responseString);

            return dataA;

            //WebRequest request = WebRequest.Create("https://api.vk.com/method/users.get");
            //request.Method = "GET";
            //string sName = "user_id=210700286&v=5.131&access_token=aa367035aa367035aa69ea765daa7763e3aaa36aa367035f28d1f52f6554906fc250b82";
            //byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(sName);
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = byteArray.Length;
            //WebResponse response = await request.GetResponseAsync();

            //string Answer = "";
            //using (Stream stream = response.GetResponseStream())
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        Answer = reader.ReadToEnd();
            //    }
            //    var dataA = JsonConvert.DeserializeObject<stat.Response>(Answer);

            //    return dataA;
            //}
            //response.Close();
        }
        public static async Task<egrip.Rootobject> GetEgrip(string data)
        {
            WebRequest request = WebRequest.Create($"https://api-fns.ru/api/egr?req={data}&key=54061fa60dc894b1a328de6343a2d29f5e52d2de");
            WebResponse response = await request.GetResponseAsync();
            string Answer = "";
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    Answer = reader.ReadToEnd();
                }

                var dataA = JsonConvert.DeserializeObject<egrip.Rootobject>(Answer);

                return dataA;
            }
            response.Close();
        }
        public static async Task<multireq.Rootobject> GetMulti(string data)
        {
            WebRequest request = WebRequest.Create($"https://api-fns.ru/api/multinfo?req={data}&key=54061fa60dc894b1a328de6343a2d29f5e52d2de");
            WebResponse response = await request.GetResponseAsync();
            string Answer = "";
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    Answer = reader.ReadToEnd();
                }

                var dataA = JsonConvert.DeserializeObject<multireq.Rootobject>(Answer);

                return dataA;
            }
            response.Close();
        }
    }
}
