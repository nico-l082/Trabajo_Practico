using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    internal class Tanque
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int Año { get; set; }
        public int Peso { get; set; }
        public List<string> Aliados { get; set; }

        //------------------------------------------------------------------

        public Tanque(string nombre, string pais, int año, int peso, List<string> aliados)
        {
            Nombre = nombre;
            Pais = pais;
            Año = año;
            Peso = peso;
            Aliados = aliados;
        }

        //------------------------------------------------------------------

        public void Batalla(Tanque otroTanque)
        {
            Console.WriteLine($"Battle between {Nombre} and {otroTanque.Nombre}:");
            Console.WriteLine("\n");
            Console.WriteLine($"{Nombre} (Year: {Año}, Weight: {Peso}) vs {otroTanque.Nombre} (Year: {otroTanque.Año}, Weight: {otroTanque.Peso})");

            if (Año > otroTanque.Año)
            {
                Console.WriteLine($"{Nombre} wins because it is a more modern tank.");

            } else if (Año < otroTanque.Año)
            {
                Console.WriteLine($"{otroTanque.Nombre} wins because it is a more modern tank.");

            } else
            {
                if (Peso > otroTanque.Peso)
                {
                    Console.WriteLine($"{Nombre} wins by being heavier.");

                }else if (Peso < otroTanque.Peso)
                {
                    Console.WriteLine($"{otroTanque.Nombre} wins by being heavier.");

                } else
                {
                    Console.WriteLine("It's a tie.");
                }
            }
        }
    }
}
