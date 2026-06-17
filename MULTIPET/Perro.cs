using System;

namespace MultiPet
{
    public class Perro : Mascota
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Guau Guau");
        }
    }
}