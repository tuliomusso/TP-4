using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Musso_Tulio
{
    public class detalleProducto
    {
        public double descuento { get; set; }
        public int codigoCombo { get; set; }
        public Producto codigoComponente { get; set; }

        public detalleProducto(double descuento, int codigoCombo, Producto codigoComponente)
        {
            this.descuento = descuento;
            this.codigoCombo = codigoCombo;
            this.codigoComponente = codigoComponente;
        }
    }
}
