using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace DotNet_Utilities
{
    public class WebRequestHelper
    {
        public static string RequestWebClient(string url, Encoding encode=null)
        {
            using (WebClient client = new WebClient())
            {
                if (encode != null)
                {
                    client.Encoding =encode;
                }
                var ret= client.DownloadString(url);
                return ret;
            }
        }




        public static void SendPostByWebClient(string url, string base64,
                                              string tonce, string postData)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json-rpc";
                client.Headers["Authorization"] = "Basic " + base64;
                client.Headers["Json-Rpc-Tonce"] = tonce;
                try
                {
                    byte[] response = client.UploadData(
                        url, "POST", Encoding.Default.GetBytes(postData));
                    Console.WriteLine("\nResponse: {0}", Encoding.UTF8.GetString(response));
                }
                catch (System.Net.WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string SendPostByWebRequest(string url, string base64,
                                                string tonce, string postData)
        {
            //WebRequest webRequest = WebRequest.Create(url);
            WebRequest webRequest = HttpWebRequest.Create(url);
            if (webRequest == null)
            {
                Console.WriteLine("Failed to create web request for url: " + url);
                return null;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(postData);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json-rpc";
            webRequest.ContentLength = bytes.Length;
            webRequest.Headers["Authorization"] = "Basic " + base64;
            webRequest.Headers["Json-Rpc-Tonce"] = tonce;
            try
            {
                // Send the json authentication post request
                using (Stream dataStream = webRequest.GetRequestStream())
                {
                    dataStream.Write(bytes, 0, bytes.Length);
                    dataStream.Close();
                }
                // Get authentication response
                using (WebResponse response = webRequest.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            string s = reader.ReadToEnd();
                            return s;
                            //MessageBox.Show(s);
                            //Console.WriteLine("Response: " + reader.ReadToEnd());
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


    }
}
