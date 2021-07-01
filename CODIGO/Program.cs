using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Actividad ActividadA = new Actividad("Farmacia");
            Actividad ActividadB = new Actividad("Enfermero");
            Actividad ActividadC = new Actividad("Medico");
            Actividad ActividadD = new Actividad("Actividad alimenticia");
            Empresa EmpresaA = new Empresa("EmpresaA", "1111", "domicilio A", "Localidad A", "empresaA@example.com", "telefono A", ActividadC);
            Empresa EmpresaB = new Empresa("EmpresaB", "2222", "domicilio B", "Localidad B", "empresaB@example.com", "telefono B", ActividadD);
            Empresa EmpresaC = new Empresa("EmpresaC", "3333", "domicilio C", "Localidad C", "empresaC@example.com", "telefono C", ActividadA);
            Empresa EmpresaD = new Empresa("EmpresaD", "4444", "domicilio D", "Localidad D", "empresaD@example.com", "telefono D", ActividadB);
            Persona PersonaA = new Persona("41441970", "Tulio Musso", "domicilio 1", "telefono 1", "tulio@example.com", ActividadA,EmpresaC,DateTime.Parse("30/08/2021"), DateTime.Parse("28/06/2021 8:30:52 AM"),35.6,"AC 123 DE","Destino 1", default(DateTime));
            Persona PersonaB = new Persona("51515412", "Juan Perez", "domicilio 2", "telefono 2", "juan@example.com", ActividadB,EmpresaD, DateTime.Parse("30/08/2021"), DateTime.Parse("29/06/2021 9:30:25 AM"),36.1,"AE 534 ML","Destino 2", default(DateTime));
            Persona PersonaC = new Persona("51515425", "Pepito Perez", "domicilio 3", "telefono 3", "pepito@example.com", ActividadC,EmpresaA, DateTime.Parse("20/04/2021"), DateTime.Parse("30/06/2021 7:30:32 AM"), 36.2, "AA 326 ML", "Destino 3", default(DateTime));
            Persona PersonaD = new Persona("31525425", "Marcos Ramirez", "domicilio 4", "telefono 4", "marcos@example.com", ActividadD, EmpresaB, DateTime.Parse("20/09/2021"), DateTime.Parse("20/07/2021 6:30:15 AM"), 37.5, "AB 296 ML", "Destino 4", default(DateTime));
            Persona PersonaE = new Persona("40535425", "Gaston Perez", "domicilio 5", "telefono 5", "gaston@example.com", ActividadD, EmpresaB, DateTime.Parse("15/04/2021"), DateTime.Parse("24/07/2021 6:30:15 AM"), 38, "AC 296 ML", "Destino 5", default(DateTime));
            CreacionListas.listaPersonas.Add(PersonaA);
            CreacionListas.listaPersonas.Add(PersonaB);
            CreacionListas.listaPersonas.Add(PersonaC);
            CreacionListas.listaPersonas.Add(PersonaD);
            CreacionListas.listaPersonas.Add(PersonaE);
            CreacionListas.listaActividades.Add(ActividadD);
            CreacionListas.listaActividades.Add(ActividadB);
            CreacionListas.listaActividades.Add(ActividadC);
            CreacionListas.listaActividades.Add(ActividadA);
            Comprobacion.comprobacion();
            int opcionContinuar;
            do
            {
                Console.WriteLine("\nINGRESE LA OPCION DESEADA:\n1-Mostrar Personas Autorizadas Antes de Verficar DNI\n" +
               "2-Verificar Autorizacion de Ingreso\n3-Dar de Baja un Empleado\n4-Lista Personas con Fiebre\n5-Registrar Salida de Empleado" +
               "\n6-Ver salidas de empleados");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Mostrar.MostrarPersonasAutorizadas(); break;
                    case 2: Comprobacion.sistemaGestor(); break;
                    case 3: Comprobacion.bajaEmpleado(); break;
                    case 4: Mostrar.MostrarPersonasCFiebre();break;
                    case 5: Comprobacion.RegistrarSalida();break;
                    case 6: Comprobacion.VerSalidas();break; //VA A MOSTRAR LA SALIDA SOLO SI PREVIAMENTE FUE REGISTRADA
                    default: Console.WriteLine("\nOPCION INCORRECTA"); break;
                }
                Console.WriteLine("\nDESEA REALIZAR OTRA OPERACION?\n1-SI\n2-NO");
                opcionContinuar = int.Parse(Console.ReadLine());

            } while (opcionContinuar==1);
        }
    }
}
