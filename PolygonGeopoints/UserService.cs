using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace PolygonGeopoints
{
    public static class UserService
    {

        public static string RequestPolygon(string searchString)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(@"https://nominatim.openstreetmap.org/search?q=" + searchString + @"&format=json&polygon_geojson=1");
                webRequest.UserAgent = @"PolygonGeopointsApp";
                webRequest.Method = "GET";
               
                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        string response = streamReader.ReadToEnd();
                        Console.WriteLine(response);
                        return response;
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
