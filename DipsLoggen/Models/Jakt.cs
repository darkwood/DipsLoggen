using System;
using System.Collections.Generic;

using DipsLoggen.Models;

namespace DipsLoggen.Models
{
    public class Jakt : EntityBase
    {
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
