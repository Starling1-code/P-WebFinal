using System;
using System.Collections.Generic;

namespace P_WebFinal.Models
{
    public partial class Pelicula
    {
        public int IdP { get; set; }
        public string? TituloP { get; set; }
        public string? GeneroP { get; set; }
        public DateTime? AñoP { get; set; }
        public string? DirectorP { get; set; }
        public string? DescripcionP { get; set; }
    }
}
