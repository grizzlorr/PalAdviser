//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PalAdvisor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gate
    {
        public int Id { get; set; }
        public double B { get; set; }
        public double H { get; set; }
        public int DesId { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}