﻿using System;
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

        public Persona(string dni, string nombreApellido, string domicilio,string telefono,string email,Actividad actividadQueRealiza, Empresa nombreEmpresa, DateTime fechaVencimientoPermiso)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.email = email;
            this.actividadQueRealiza = actividadQueRealiza;
            this.nombreEmpresa = nombreEmpresa;
            this.fechaVencimientoPermiso = fechaVencimientoPermiso;
        }
    }
}
