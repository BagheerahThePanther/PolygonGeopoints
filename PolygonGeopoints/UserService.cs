using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace PolygonGeopoints
{
    public static class UserService
    {
        private static readonly IUriStringCreator uriCreator = new OsmUriStringCreator();

        public static string RequestPolygon(string searchString)
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uriCreator.GetString(searchString));
                webRequest.UserAgent = @"PolygonGeopointsApp";
                webRequest.Method = "GET";
               
                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
                
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return "";
        }
    }
}
