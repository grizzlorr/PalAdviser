using PalAdvisor.Models;
using PalAdvisor.Models.DataWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PalAdvisor.Controllers
{
    public class RestController : ApiController
    {
        // POST: api/Rest
        public void Post([FromBody]DestinationJson value)
        {
            PalAdviserDBEntities ent = new PalAdviserDBEntities();

            Destination item = new Destination()
            {
                B = value.width,
                H = value.height,
                L = value.length
            };
            
            foreach (var gate in value.Gates)
            {
                item.Gate.Add(new Gate()
                {
                    B = gate.width,
                    H = gate.height
                });
            }
            
            ent.Destination.Add(item);
            ent.SaveChanges();
        }

    }
}
