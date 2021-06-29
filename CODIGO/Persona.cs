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
        public Actividad actividadQueRealiza { get; set; }
        public DateTime fechaVencimientoPermiso { get; set; }
        public Empresa nombreEmpresa { get; set; }
        public DateTime fechaHoraIngreso { get; set; }
        public double temperatura { get; set; }
        public string patente { get; set; }
        public string destino { get; set; }
        public Persona(string dni, string nombreApellido, string domicilio,string telefono,string email,Actividad actividadQueRealiza, Empresa nombreEmpresa, DateTime fechaVencimientoPermiso, DateTime fechaHoraIngreso, double temperatura, string patente, string destino)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.email = email;
            this.actividadQueRealiza = actividadQueRealiza;
            this.nombreEmpresa = nombreEmpresa;
            this.fechaVencimientoPermiso = fechaVencimientoPermiso;
            this.fechaHoraIngreso = fechaHoraIngreso;
            this.temperatura = temperatura;
            this.patente = patente;
            this.destino = destino;
        }
    }
}
