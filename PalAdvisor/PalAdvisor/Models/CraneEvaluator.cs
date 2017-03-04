using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PalAdvisor.Models
{
    public class CraneEvaluator
    {
        public IList<Crane> cranes { get; set; }

        public IList<Crane> EvaluateDestination(Destination destination)
        {
            IList<Crane> properCranes = new List<Crane>();

            foreach(var crane in cranes)
            {
                bool add = true;
               //evaluate gates
                foreach(var gate in destination.Gate)
                {
                    if (gate.B < crane.B) add = false;
                    if (gate.H != -1 && gate.H < crane.H) add = false;
                }

                //evaluate destination
                if (destination.B < crane.B) add = false;
                if (destination.L < crane.L) add = false;
                if (destination.H < crane.H) add = false;

                if (add) properCranes.Add(crane);
            }

            return properCranes;
        }
    }
}