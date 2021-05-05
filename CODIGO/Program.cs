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
            Persona PersonaA = new Persona("41441970", "Tulio Musso", "domicilio 1", "telefono 1", "tulio@example.com", "estudiante");
            Persona PersonaB = new Persona("51515412", "Juan Perez", "domicilio 2", "telefono 2", "juan@example.com", "enfermera");
            Persona PersonaC = new Persona("51515425", "Pepito Perez", "domicilio 3", "telefono 3", "pepito@example.com", "medico");
            CreacionListas.listaPersonas.Add(PersonaA);
            CreacionListas.listaPersonas.Add(PersonaB);
            CreacionListas.listaPersonas.Add(PersonaC);

            CreacionListas.listaActividades.Add("medico");
            CreacionListas.listaActividades.Add("enfermera");
            CreacionListas.listaActividades.Add("industria lactea");

            Comprobacion.comprobacion();
            Mostrar.MostrarPersonasAutorizadas();
            Comprobacion.sistemaGestor();
        }
    }
}
