using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    internal class Barco
    {

        public int Cargamento { get; set; }
        public int Tripulacion { get; set; }

        //------------------------------------------------------------------

        public Barco(int cargamento, int tripulacion)
        {
            this.Cargamento = cargamento;
            this.Tripulacion = tripulacion;
        }

        public Barco() { }


        //------------------------------------------------------------------

        public bool ValeLaPenaSaquear()
        {
            return (Cargamento - Tripulacion) > 20;

            /*
            if( (Cargamento - Tripulacion) > 20 )
            {
                return true;
            } else
            {
                return false;
            }
            */
        }
    }
}
