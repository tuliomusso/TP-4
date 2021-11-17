using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Musso_Tulio
{
    public class Producto
    {
        public int codigoProducto { get; set; } 
        public string nombre { get; set; }
        public DateTime fechaIngreso { get; set; }
        public string descripcion { get; set; }
        public string modelo { get; set; }// ej XF12233
        public string color { get; set; } 
        public string tamaño { get; set; }  
        public decimal precioUnitario { get; set; }
        public int cantidadActual { get; set; }
        public string categoria { get; set; } 
        public bool disponible { get; set; }
        public bool dadoDeBaja { get; set; }
        public decimal precioEntreDosYCincoUnidades { get; set; }//0,03 de descuento
        public decimal precioEntreSeisYDiezUnidades { get; set; }//0,05 de descuento
        public decimal precioMasDeDiezUnidades { get; set; }//0,07 de descuento
        public bool estaEnOferta { get; set; }
        public string descripcionOferta { get; set; }
        public decimal? precioEnOferta { get; set; }
        public DateTime? fechaInicioOferta { get; set; }
        public DateTime? fechaCierreOferta { get; set; }

        public Producto(int codigoProducto,string nombre,DateTime fechaIngreso,string descripcion, string modelo, string color, string tamaño, decimal precioUnitario, int cantidadActual, bool disponible, string categoria, bool dadoDeBaja, decimal precioEntreDosYCincoUnidades, decimal precioEntreSeisYDiezUnidades, decimal precioMasDeDiezUnidades, bool estaEnOferta, string descripcionOferta, decimal? precioEnOferta, DateTime? fechaInicioOferta, DateTime? fechaCierreOferta)
        {
            this.codigoProducto = codigoProducto;
            this.nombre = nombre;
            this.fechaIngreso = fechaIngreso;
            this.descripcion = descripcion;
            this.modelo = modelo;
            this.color = color;
            this.tamaño = tamaño;
            this.categoria = categoria;
            this.precioUnitario = precioUnitario;
            this.cantidadActual = cantidadActual;
            this.disponible = disponible;
            this.dadoDeBaja = dadoDeBaja;
            this.precioEntreDosYCincoUnidades = precioEntreDosYCincoUnidades;
            this.precioEntreSeisYDiezUnidades = precioEntreSeisYDiezUnidades;
            this.precioMasDeDiezUnidades = precioMasDeDiezUnidades;
            this.estaEnOferta = estaEnOferta;
            this.descripcionOferta = descripcionOferta;
            this.precioEnOferta = precioEnOferta;
            this.fechaCierreOferta = fechaCierreOferta;
            this.fechaInicioOferta = fechaInicioOferta;
        }
    }
}
