using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    internal class Bloque
    {
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }

        //------------------------------------------------------------------

        public Bloque(int largo, int ancho, int alto)
        {
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
        }

        public Bloque() { }

        //------------------------------------------------------------------

        public int ObtenerLargo() => Largo;
        public int ObtenerAncho() => Ancho;
        public int ObtenerAlto() => Alto;

        public int ObtenerVolumen()
        {
            return Largo * Ancho * Alto;
        }

        public int ObtenerAreaSuperficie()
        {
            return 2 * ( (Largo * Ancho) + (Largo * Alto) + (Ancho * Alto) );
        }
    }
}
