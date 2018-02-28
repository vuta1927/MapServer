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
                new road(1, new Coordinate[] {
                    new Coordinate(21.01751,105.78186000000001),
                    new Coordinate(21.01633,105.78019),
                    new Coordinate(21.016240000000003,105.78006),
                    new Coordinate(21.016280000000002,105.78002000000001),
                    new Coordinate(21.015900000000002,105.77951),
                    new Coordinate(21.015420000000002,105.7788)
                }, 0.5, "#f72727", new MetaData("Đoạn đường Mễ trì 1", new Direction("Dương Đình Nghệ --> Hệ thống đào tạo CNTT Quốc Tế karROX","Duong Dinh Nghe --> He thong dao tao CNTT Quoc Te karROX"))),
                new road(2, new Coordinate[] {
                    new Coordinate(21.01836,105.7814),
                    new Coordinate(21.017650000000003,105.78193)
                }, 0.5, "#f7551b", new MetaData("Đoạn đường Phạm Hùng 1", new Direction("MB ATM Phạm Hùng --> Ngã tư Mễ Trì","MB ATM Pham Hung"))),
                new road(3, new Coordinate[] {
                    new Coordinate(21.017030000000002,105.77958000000001),
                    new Coordinate(21.01723,105.77972000000001),
                    new Coordinate(21.01743,105.77980000000001),
                    new Coordinate(21.01763,105.77983),
                    new Coordinate(21.017850000000003,105.77983),
                    new Coordinate(21.01809,105.77972000000001),
                    new Coordinate(21.0183,105.77956)
                }, 0.5, "#41ff28", new MetaData("Đỗ Đình Thiện, Mỹ Đình 1", new Direction("Đỗ Đình Thiện","Do Dinh Thien"))),
                new road(4, new Coordinate[] {
                    new Coordinate(21.01658,105.78331000000001),
                    new Coordinate(21.01726,105.78275000000001),
                    new Coordinate(21.018,105.78288),
                    new Coordinate(21.01845,105.78349000000001)
                }, 0.5, "#3859ff", new MetaData("Dương Đình Nghệ - Phạm Hùng", new Direction("Dương Đình Nghệ --> Tòa nhà Keangnam, Phạm Hùng","Duong Dinh Nghe --> Toa nha Keangnam, Pham Hung"))),
                new road(5, new Coordinate[] {
                    new Coordinate(21.01788,105.78209000000001),
                    new Coordinate(21.01893,105.78127),
                    new Coordinate(21.01977,105.78059),
                    new Coordinate(21.01986,105.78052000000001),
                }, 0.5, "#3859ff", new MetaData("Dương Đình Nghệ 1", new Direction("Ngã tư Dương Đình Nghệ 1","Nga tu Duong Dinh Nghe 1"))),
                new road(6, new Coordinate[] {
                    new Coordinate(21.02016,105.7856),
                    new Coordinate(21.01827,105.78292)
                }, 0.5, "#41ff28", new MetaData("Dương Đình Nghệ 3", new Direction("Ngã tư Dương Đình Nghệ 3","Nga tu Duong Dinh Nghe 3"))),
                new road(7, new Coordinate[] {
                    new Coordinate(21.01783,105.78263000000001),
                    new Coordinate(21.019820000000003,105.78541000000001)
                }, 0.5, "#41ff28", new MetaData("Dương Đình Nghệ 2", new Direction("Ngã tư Dương Đình Nghệ 2","Nga tu Duong Dinh Nghe 2"))),
                new road(8, new Coordinate[] {
                    new Coordinate(21.0181,105.78503),
                    new Coordinate(21.017030000000002,105.78510000000001),
                    new Coordinate(21.016800000000003,105.78515),
                    new Coordinate(21.016550000000002,105.78527000000001),
                    new Coordinate(21.01631,105.78542),
                    new Coordinate(21.01612,105.78556)
                }, 0.5, "#3859ff", new MetaData("Khu đô thị CD2 Mễ Trì",new Direction("Khu đô thị CD2 Mễ Trì","Khu do thi CD2 Me Tri")))
            };

            return Ok(new Map(1, mapType.Google, roads, true));
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
