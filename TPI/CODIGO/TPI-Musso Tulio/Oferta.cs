using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Musso_Tulio
{
    class Oferta
    {
        public string descripcionOferta { get; set; }
        public DateTime? InicioOferta { get; set; }
        public DateTime? CierreOferta { get; set; }

        public Oferta(string descripcionOferta, DateTime? InicioOferta, DateTime? CierreOferta)
        {
            this.descripcionOferta = descripcionOferta;
            this.InicioOferta = InicioOferta;
            this.CierreOferta = CierreOferta;
        }
    }
}
