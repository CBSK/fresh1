using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fresh1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public class Test
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            string[] s = new string[] { "value1", "value2" };
            Test t = new Test() { id = "123", name = "CBSK" };
            //return s;

            return new JsonResult(t);
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