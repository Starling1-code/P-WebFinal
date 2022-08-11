using System;
using System.Collections.Generic;

namespace P_WebFinal.Models
{
    public partial class Pelicula
    {

        public int IdP { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public DateTime? Año { get; set; }
        public string? Director { get; set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
    }
}
