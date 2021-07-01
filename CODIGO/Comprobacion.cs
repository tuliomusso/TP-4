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
            int fiebre = 0;

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
                    if (e.temperatura>37)
                    {
                        fiebre = 1;
                    }
                    else fiebre = 0;
                }

            }
            if (ban==1 && ban2==1 && fiebre==0)
            {
                Console.WriteLine($"\n---LA PERSONA EXISTE, ESTA EN LA PERSONAS AUTORIZADAS, SU PERMISO NO ESTA VENCIDO Y SU TEMPERATURA ES MENOR A 37 POR LO QUE PUEDE INGRESAR AL AREA---");
            }
            if (ban==0) Console.WriteLine("\n---LA PERSONA NO EXISTE O NO ESTA EN LAS PERSONAS AUTORIZADAS POR LO QUE NO PUEDE INGRESAR AL AREA--- ");
            if (ban == 1 && ban2 != 1 && fiebre==0)
            {
                Console.WriteLine($"\n---LA PERSONA EXISTE, ESTA EN LA PERSONAS AUTORIZADAS PERO SU PERMISO ESTA VENCIDO POR LO QUE NO PUEDE INGRESAR AL AREA---");
            }
            if (ban == 1 && ban2 == 1 && fiebre==1)
            {
                Console.WriteLine($"\n---LA PERSONA EXISTE, ESTA EN LA PERSONAS AUTORIZADAS, SU PERMISO NO ESTA VENCIDO PERO TIENE FIEBRE POR LO QUE NO PUEDE INGRESAR AL AREA---");
            }
            if (ban == 1 && ban2 == 0 && fiebre == 1)
            {
                Console.WriteLine($"\n---LA PERSONA EXISTE, ESTA EN LA PERSONAS AUTORIZADAS, SU PERMISO ESTA VENCIDO Y TIENE FIEBRE POR LO QUE NO PUEDE INGRESAR AL AREA---");
            }
        }
        public static void bajaEmpleado()
        {
            string ingresoDNI;


            int opcion = 1;
            while (opcion == 1) 
            {
                Console.WriteLine("\nIngrese el DNI del empleado que desea dar de baja:");
                ingresoDNI = Console.ReadLine();

                foreach (var emp in CreacionListas.listaPersonas)
                {
                    if (ingresoDNI == emp.dni)
                    {
                        CreacionListas.listaPersonasActualizada.Add(emp);
                        Console.WriteLine($"\nSe dio de baja al empleado {emp.nombreApellido}---DNI:{emp.dni} ");
                    }
                }
                Console.WriteLine("\nDesea dar de baja a Otro empleado?\n1-Si\n2-No");
                opcion = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nLISTA DE EMPLEADOS DADOS DE BAJA");
            foreach (var borrar2 in CreacionListas.listaPersonasActualizada)
            {
                Console.WriteLine(borrar2.nombreApellido);
            }
        }
        public static void personasConFiebre()
        {
            foreach (var fiebre in CreacionListas.personasAutorizadas)
            {
                if (fiebre.temperatura>37)
                {
                    CreacionListas.personasConFiebre.Add(fiebre);
                }
            }
            
        }
        public static DateTime RegistrarSalida()
        {
            string ingresoDNI;
            string empleado="";
            DateTime hora=DateTime.Now;
            Console.WriteLine("\nIngrese el DNI del empleado que quiere retirarse del establecimiento:");
            ingresoDNI = Console.ReadLine();
            foreach (var emp in CreacionListas.personasAutorizadas)
            {
                 if (ingresoDNI==emp.dni)
                 {
                    hora =emp.horaSalida = DateTime.Now;
                     empleado=emp.nombreApellido;
                 }
            
               
            }
            Console.WriteLine("\nRegistro Exitoso");
            return hora;
        }

        public static void VerSalidas()
        {
            //VA A MOSTRAR SOLO SI PREVIAMENTE SE REGISTRO LA SALIDA
            foreach (var item in CreacionListas.personasAutorizadas)
            {
                if (item.horaSalida != default(DateTime))
                {
                    Console.WriteLine($"\nEl empleado {item.nombreApellido} se retiro a las {item.horaSalida}");
                }

            }
        }

    }
}
