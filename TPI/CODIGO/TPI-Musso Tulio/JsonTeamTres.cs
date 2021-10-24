using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace TPI_Musso_Tulio
{
    class JsonTeamTres
    {
        private static string _Productospath = @"C:\Json Sample\.jsonProductosTeamTres";
        public static List<ProductoTeamTres> ListaJsonTeamTres = new List<ProductoTeamTres>();

        public class ProductoTeamTres
        {
            public int CodigoProducto { get; set; }
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int CantidadActual { get; set; }
            public bool Disponible { get; set; }

            public ProductoTeamTres(int CodigoProducto, string Descripcion, decimal PrecioUnitario, int CantidadActual, bool Disponible)
            {
                this.CodigoProducto = CodigoProducto;
                this.Descripcion = Descripcion;
                this.PrecioUnitario = PrecioUnitario;
                this.CantidadActual = CantidadActual;
                this.Disponible = Disponible;
            }
        }
        public class comboTeamTres
        {
            public int CodigoProducto { get; set; } // ese team lo toma como un producto mas
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int CantidadActual { get; set; }
            public bool Disponible { get; set; }

            public comboTeamTres(int CodigoProducto, string Descripcion, decimal PrecioUnitario, int CantidadActual, bool Disponible)
            {
                this.CodigoProducto = CodigoProducto;
                this.Descripcion = Descripcion;
                this.PrecioUnitario = PrecioUnitario;
                this.CantidadActual = CantidadActual;
                this.Disponible = Disponible;
            }
        }
        public static void DTOprepararJson()
        {
            foreach (var producto in creacionListas.listaProductos)
            {
                int CodigoProducto = producto.codigoProducto;
                string Descripcion = producto.descripcion;
                decimal PrecioUnitario = producto.precioUnitario;
                int CantidadActual = producto.cantidadActual;
                bool Disponible = producto.disponible;
                ProductoTeamTres nuevoProducto = new ProductoTeamTres(CodigoProducto,Descripcion,PrecioUnitario,CantidadActual,Disponible);
                ListaJsonTeamTres.Add(nuevoProducto);
            }
            foreach (var combo in creacionListas.listaCombos)
            {
                int CodigoProducto = combo.codigoCombo;
                string Descripcion = combo.descripcionComponentes;
                decimal PrecioUnitario = combo.precioUnitario;
                int CantidadActual = combo.cantidadActual;
                bool Disponible = combo.disponibilidad;
                ProductoTeamTres nuevoCombo = new ProductoTeamTres(CodigoProducto, Descripcion, PrecioUnitario, CantidadActual, Disponible);
                ListaJsonTeamTres.Add(nuevoCombo);
            }
            string json = JsonConvert.SerializeObject(ListaJsonTeamTres);
            File.WriteAllText(_Productospath, json);
        }
    }
}
