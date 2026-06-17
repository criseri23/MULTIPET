using System;

namespace MultiPet
{
    public class Mascota
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine("La mascota hace un sonido.");
        }
    }
}