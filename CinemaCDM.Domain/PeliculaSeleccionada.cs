using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaCDM.Domain
{
    public class PeliculaSeleccionada
    {
        public string Nombre { get; set; }
        public string FechaEstreno { get; set; }
        public string Imagen { get; set; }
        public int Tiquetes { get; set; }
        public double PrecioTotal { get; set; }
        public Function FuncionSeleccionada { get; set; }
    }
}
