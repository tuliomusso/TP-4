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
            Persona PersonaA = new Persona("41441970", "Tulio Musso", "domicilio 1", "telefono 1", "tulio@example.com", ActividadA,EmpresaC,DateTime.Parse("30/08/2021"));
            Persona PersonaB = new Persona("51515412", "Juan Perez", "domicilio 2", "telefono 2", "juan@example.com", ActividadB,EmpresaD, DateTime.Parse("30/08/2021"));
            Persona PersonaC = new Persona("51515425", "Pepito Perez", "domicilio 3", "telefono 3", "pepito@example.com", ActividadC,EmpresaA, DateTime.Parse("20/04/2021"));
            CreacionListas.listaPersonas.Add(PersonaA);
            CreacionListas.listaPersonas.Add(PersonaB);
            CreacionListas.listaPersonas.Add(PersonaC);
            CreacionListas.listaActividades.Add(ActividadD);
            CreacionListas.listaActividades.Add(ActividadB);
            CreacionListas.listaActividades.Add(ActividadC);
            CreacionListas.listaActividades.Add(ActividadA);
            Comprobacion.comprobacion();
            Mostrar.MostrarPersonasAutorizadas();
            Comprobacion.sistemaGestor();
            Comprobacion.bajaEmpleado();
        }
    }
}
