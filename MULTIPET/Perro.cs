using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{   
 public class Perro : Mascota
 {
 public bool EsEntrenado { get; set; }
public override void RealizarExamen()
  {
   Console.WriteLine($"[Canino] Revisando articulaciones y vacunas de {Nombre}");
      }
 }
    
}
