using System;

namespace MultiPet
{
    public class Gato : Mascota
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}