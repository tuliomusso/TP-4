using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4
{
    public class Persona
    {
        public string dni { get; set; }
        public string nombreApellido { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string actividadQueRealiza { get; set; }

        public Persona(string dni, string nombreApellido, string domicilio,string telefono,string email,string actividadQueRealiza)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.email = email;
            this.actividadQueRealiza = actividadQueRealiza;
        }
    }
}
