using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DipsLoggen.Controllers
{
    public class ItemsController : ApiController
    {
        // GET api/items
        public IEnumerable<string> Get()
        {
            return new string[] { "item1", "item2" };
        }

        // GET api/items/5
        public string Get(int id)
        {
            return "item";
        }

        // POST api/items
        public void Post([FromBody]string item)
        {
        }

        // PUT api/items/5
        public void Put(int id, [FromBody]string item)
        {
        }

        // DELETE api/items/5
        public void Delete(int id)
        {
        }
    }
}
