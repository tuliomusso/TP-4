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
        public bool dadoDeBaja { get; set; }
        public string descripcion { get; set; }
        public string modelo { get; set; }// ej XF12233
        public string color { get; set; }
        public double tamaño { get; set; }
        public decimal precioUnitario { get; set; }
        public int cantidadActual { get; set; }
        public bool disponible { get; set; } 
        public int categoria { get; set; } // menu de categorias

        public Producto(int codigoProducto,string nombre,DateTime fechaIngreso,string descripcion, string modelo, string color, double tamaño, decimal precioUnitario, int cantidadActual, bool disponible, int categoria, bool dadoDeBaja)
        {
            this.codigoProducto = codigoProducto;
            this.nombre = nombre;
            this.fechaIngreso = fechaIngreso;
            this.dadoDeBaja = dadoDeBaja;
            this.descripcion = descripcion;
            this.modelo = modelo;
            this.color = color;
            this.tamaño = tamaño;
            this.precioUnitario = precioUnitario;
            this.cantidadActual = cantidadActual;
            this.disponible = disponible;
            this.categoria = categoria;
        }
    }
}
