using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
 public class Mascota
    {
 private string _nombre;

 public string Nombre
   {
  get { return _nombre; }
 set { _nombre = value; }
}

   public virtual void RealizarExamen()
   {
    Console.WriteLine($"Realizando chequeo general a {Nombre}...");
     }
 }
}
}
