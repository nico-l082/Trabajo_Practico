using System;
using Trabajo_Practico.Models;

class Program
{
    static void Main(string[] args)
    {
        
        Persona persona = new Persona("Juan", 30, "male");
        Bloque bloque = new Bloque(3, 4, 5);
        Barco barco = new Barco(100, 50);
        Tanque tanque1 = new Tanque("M1 Abrams", "USA", 2020, 70, new List<string> { "USA", "UK" });
        Tanque tanque2 = new Tanque("VT-4", "China", 2019, 90, new List<string> { "Russia", "Japon" });

        persona.Hablar();

        Console.WriteLine("\n---------------------------------------------------------------------\n");
        

        Console.WriteLine($"Is it worth looting the ship? { barco.ValeLaPenaSaquear() }");

        Console.WriteLine("\n---------------------------------------------------------------------\n");
 
        tanque1.Batalla(tanque2);

        Console.WriteLine("\n---------------------------------------------------------------------\n");

        Console.WriteLine($"The block volume is: { bloque.ObtenerVolumen() }");
        Console.WriteLine($"The block surface area is: { bloque.ObtenerAreaSuperficie() }");

        Console.WriteLine("\n---------------------------------------------------------------------\n");
    }
}
