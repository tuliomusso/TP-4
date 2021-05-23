using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4
{
    class Comprobacion
    {

   
        public static void comprobacion()
        {
            foreach (var a in CreacionListas.listaPersonas)
            {
                int bandera = 0;
                Actividad acta = a.actividadQueRealiza;
                foreach (var b in CreacionListas.listaActividades)
                {
                    Actividad actb = b;
                    if (acta == actb)
                    {
                        bandera = 1;
                    }
                }
                if (bandera == 1)
                {
                    Console.WriteLine($"La persona {a.nombreApellido} realiza una actividad contemplada en la lista");
                    CreacionListas.personasAutorizadas.Add(a);

                }
                else Console.WriteLine($"La persona {a.nombreApellido} NO realiza una actividad contemplada en la lista");

            }
        }
        public static void sistemaGestor()
        {
            string numDNI;
            int ban = 0;
            int ban2 = 0;

            Console.WriteLine("\nIngrese el numero de DNI Para comprobar si la persona existe:");
            numDNI = Console.ReadLine();

            foreach (var e in CreacionListas.personasAutorizadas)
            {
                if (e.dni==numDNI)
                {
                    ban = 1;
                    if (DateTime.Now <= e.fechaVencimientoPermiso)
                    {
                        ban2 = 1;
                    }
                    else ban2 = 0;
                }

            }
            if (ban==1 && ban2==1)
            {
                Console.WriteLine($"\n---LA PERSONA EXISTE, ESTA EN LA PERSONAS AUTORIZADAS Y SU PERMISO NO ESTA VENCIDO POR LO QUE PUEDE INGRESAR AL AREA---");
            }
            if (ban==0) Console.WriteLine("\n---LA PERSONA NO EXISTE O NO ESTA EN LAS PERSONAS AUTORIZADAS POR LO QUE NO PUEDE INGRESAR AL AREA--- ");
            if (ban == 1 && ban2 != 1)
            {
                Console.WriteLine($"\n---LA PERSONA EXISTE, ESTA EN LA PERSONAS AUTORIZADAS PERO SU PERMISO ESTA VENCIDO POR LO QUE NO PUEDE INGRESAR AL AREA---");
            }
        }

    }
}
