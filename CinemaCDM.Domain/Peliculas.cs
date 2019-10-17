using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCDM.Domain
{
    public class Peliculas
    {
        public string Nombre { get; set; }
        public string FechaEstreno { get; set; }
        public string Recomendacion { get; set; }
        public string Imagen { get; set; }
        public string Duracion { get; set; }
        public List<Function> Funciones { get; set; }
    }
}
