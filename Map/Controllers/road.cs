using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Controllers
{
    public class road
    {
        public int id { get; set; }
        public double slat { get; set; }
        public double slng { get; set; }
        public double elat { get; set; }
        public double elng { get; set; }

        public string color { get; set; }
        public string description { get; set; }
        public double distance { get; set; }
        public road(int id, double slat, double slng, double elat, double elng, double dist, string color, string des)
        {
            this.id = id;
            this.slat = slat; 
            this.slng = slng;
            this.elng = elng;
            this.elat = elat;
            this.distance = dist;
            this.color = color;
            this.description = des;
        }
    }
}
