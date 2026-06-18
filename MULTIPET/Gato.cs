using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
 public class Gato : Mascota
{
public override void RealizarExamen()
 {
 Console.WriteLine($"[Felino] Revisando reflejos y pelaje de {Nombre}");
 }
 }
}
