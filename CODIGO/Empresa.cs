using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4
{
    public class Empresa
    {
        public string razonSocial{ get; set; }
        public string cuit { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string localidad { get; set; }
        public string email { get; set; }
        public Actividad actividadEmpresa { get; set; }



        public Empresa(string razonSocial, string cuit, string domicilio, string telefono, string localidad, string email, Actividad actividadEmpresa)
        {
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.localidad = localidad;
            this.email = email;
            this.actividadEmpresa = actividadEmpresa;
        }
       
    }
}
