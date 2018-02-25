using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Map.Controllers
{
    [Route("api/[controller]")]
    public class MapController : Controller
    {
        private MapType mapType = new MapType();
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var roads = new List<road>()
            {
                new road(1, 21.017504, 105.781862, 21.015415, 105.778804, 0.5, "#f72727", "Busy"),
                new road(2, 21.018379, 105.781427, 21.017646, 105.781923, 0.5, "#f7551b", "Crowded"),
                new road(3, 21.017032, 105.779578, 21.018295, 105.779560, 0.5, "#41ff28", "Normal"),
                new road(4, 21.016594, 105.783340, 21.018446, 105.783493, 0.5, "#3859ff", "Empty"),
                new road(5, 21.019855, 105.780514, 21.017878, 105.782083, 0.5, "#3859ff", "Empty"),
                new road(6, 21.018291, 105.782906, 21.020160, 105.785594, 0.5, "#41ff28", "Normal"),
                new road(7, 21.017844, 105.782617, 21.019790, 105.785441, 0.5, "#41ff28", "Normal"),
                new road(8, 21.018095, 105.785008, 21.016112, 105.785555, 0.5, "#3859ff", "Empty")
            };

            return Ok(new Map(1,mapType.Google, roads, true));
        }
    }
    public class MapType
    {
        public int Google = 100;
        public int Microsoft = 200;
        public int Fabric = 300;
    }
    public class Map
    {
        public int id { get; set; }
        public int type { get; set; }
        public bool editMode { get; set; }
        public List<road> roads { get; set; }
        public Map(int id, int type, List<road> roads, bool editMode)
        {
            this.id = id;
            this.type = type;
            this.roads = roads;
            this.editMode = editMode;
        }
    }
}
