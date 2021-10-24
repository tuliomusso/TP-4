using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Musso_Tulio
{
    public class detalleProducto
    {
        public string nombreCombo { get; set; }
        public int codigoCombo { get; set; }
        public string descripcionComponentes { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal descuento { get; set; }
        public bool disponibilidad { get; set; }
        public int cantidadActual { get; set; }

        public detalleProducto(int codigoCombo,string nombreCombo, string descripcionComponentes, decimal descuento, decimal precioUnitario, bool disponibilidad, int cantidadActual)
        {
            this.nombreCombo = nombreCombo;
            this.codigoCombo = codigoCombo;
            this.descripcionComponentes = descripcionComponentes;
            this.precioUnitario = precioUnitario;
            this.descuento = descuento;
            this.disponibilidad = disponibilidad;
            this.cantidadActual = cantidadActual;
        }
    }
}
