using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonGeopoints
{
     interface IUriStringCreator
    {
         string GetString(string searchRequest);
    }
}
