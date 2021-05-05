using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4
{
   public class Mostrar
    {
        public static void MostrarPersonasAutorizadas()
        {
            Console.WriteLine("\nLISTA DE PERSONAS AUTORIZADAS PREVIA VEREFICACION DE DNI");
            foreach (var a in CreacionListas.personasAutorizadas)
            {
                Console.WriteLine($"NombreApellido:{a.nombreApellido}\nDNI {a.dni}");
            }
        }
  
    }
}
