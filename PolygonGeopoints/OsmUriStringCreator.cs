using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonGeopoints
{
    public class OsmUriStringCreator : IUriStringCreator
    {

        public string GetString(string searchRequest)
        {
            return @"https://nominatim.openstreetmap.org/search?q=" + searchRequest + @"&format=json&polygon_geojson=1";
        }
    }
}
