using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DipsLoggen.Controllers
{
    public class HuntController : ApiController
    {
        // GET api/items
        public IEnumerable<Jakt> Get()
        {
            return new List<Jakt>
                   {
                       new Jakt {ID = 1, Sted = "Sted 1"},
                       new Jakt {ID = 2, Sted = "Sted 2"},
                   };
        }

        // GET api/items/5
        public string Get(int id)
        {
            return $"item {id}";
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

    public class Jakt
    {
        public int ID { get; set; }
        public string Sted { get; set; }
        public DateTime DatoFra { get; set; }
        public DateTime DatoTil { get; set; }
        public List<int> JegerIds { get; set; }
        public List<int> DogIds { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ImagePath { get; set; }
        public string Notes { get; set; }

    }
}
