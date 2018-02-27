using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Controllers
{
    public class road
    {
        public int id { get; set; }
        public Coordinate[] paths { get; set; }

        public string color { get; set; }
        public MetaData metaData { get; set; }
        public double distance { get; set; }
        public road(int id, Coordinate[] paths, double dist, string color, MetaData metaData)
        {
            this.id = id;
            this.paths = paths;
            this.distance = dist;
            this.color = color;
            this.metaData = metaData;
        }
    }

    public class Coordinate
    {
        public double lat { get; set; }
        public double lng { get; set; }
        public Coordinate(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }
    }

    public class MetaData
    {
        public string name { get; set; }
        public string direction { get; set; }
        public MetaData() { }
        public MetaData(string pname, string pdirection)
        {
            this.name = pname;
            this.direction = pdirection;
        }
    }
}
