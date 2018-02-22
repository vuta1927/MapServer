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
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var roads = new List<road>()
            {
                new road(1, 21.017504, 105.781862, 21.015415, 105.778804, 0.5, "#f72727", "Busy"),
                new road(2, 21.018379, 105.781427, 21.017646, 105.781923, 0.5, "#f7551b", "Crowded"),
                new road(3, 21.017032, 105.779578, 21.018295, 105.779560, 0.5, "#41ff28", "Normal"),
                new road(4, 21.016594, 105.783340, 21.018446, 105.783493, 0.5, "#3859ff", "Empty")
            };
            return Ok(roads);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
