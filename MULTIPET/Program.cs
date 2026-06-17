using System;


namespace MultiPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro();
            perro1.Nombre = "Rocky";

            Gato gato1 = new Gato();
            gato1.Nombre = "Mishi";

            Console.WriteLine("=== SISTEMA VETERINARIA MULTIPET ===");

            Console.WriteLine("\nMascota: " + perro1.Nombre);
            perro1.HacerSonido();

            Console.WriteLine("\nMascota: " + gato1.Nombre);
            gato1.HacerSonido();

            Console.ReadKey();
        }
    }
}