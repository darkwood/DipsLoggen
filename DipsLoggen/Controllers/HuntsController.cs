using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DipsLoggen.DataContext;
using DipsLoggen.DataContext.Models;

namespace DipsLoggen.Controllers
{
    public class HuntsController : ApiController
    {
        public List<Hunt> HuntList => new List<Hunt>
                                      {
                                          new Hunt {ID = 1, Location = "Sted 1"},
                                          new Hunt {ID = 2, Location = "Sted 2"},
                                      };

        // GET api/hunt
        public IEnumerable<Hunt> Get()
        {
            return HuntList;
        }
        
        // GET api/hunt/5
        public Hunt Get(int id)
        {
            return HuntList.SingleOrDefault(j => j.ID == id);
        }

        // POST api/hunt
        public void Post([FromBody]Hunt Hunt)
        {
            using (var db = new DatabaseContext())
            {
                var hunt = new Hunt { Location = "Teststed 1" };
                db.Hunts.Add(hunt);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Hunts
                            select b;
                
                foreach (var item in query)
                {
                    
                }
            }
        }

        // PUT api/hunt/5
        public void Put(int id, [FromBody]Hunt Hunt)
        {
        }

        // DELETE api/hunt/5
        public void Delete(int id)
        {
        }
    }
}
