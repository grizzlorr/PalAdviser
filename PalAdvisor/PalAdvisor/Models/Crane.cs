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
    using System.ComponentModel.DataAnnotations;

    public partial class Crane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double L { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double B { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double H { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double OpL { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double OpB { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double OpH { get; set; }
    }
}
