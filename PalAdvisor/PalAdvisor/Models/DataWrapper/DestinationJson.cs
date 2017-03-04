using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PalAdvisor.Models.DataWrapper
{
    public class DestinationJson
    {
        public int id { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float length { get; set; }
        public ICollection<GateJson> Gates {get;set;}
    }
}