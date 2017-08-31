using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DipsLoggen.Models;

namespace DipsLoggen.Controllers
{
    public class HuntsController : ApiController
    {
        public List<Jakt> JaktList => new List<Jakt>
                                      {
                                          new Jakt {ID = 1, Sted = "Sted 1"},
                                          new Jakt {ID = 2, Sted = "Sted 2"},
                                      };

        // GET api/hunt
        public IEnumerable<Jakt> Get()
        {
            return JaktList;
        }
        
        // GET api/hunt/5
        public Jakt Get(int id)
        {
            return JaktList.SingleOrDefault(j => j.ID == id);
        }

        // POST api/hunt
        public void Post([FromBody]string item)
        {
        }

        // PUT api/hunt/5
        public void Put(int id, [FromBody]string item)
        {
        }

        // DELETE api/hunt/5
        public void Delete(int id)
        {
        }
    }
}
