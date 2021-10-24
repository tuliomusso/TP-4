using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace TPI_Musso_Tulio
{
    class JsonTeamCinco
    {
        private static string _Productospath = @"C:\Json Sample\jsonProductosTeamCinco.json";
        public static List<ProductoTeamCinco> ListaJsonTeamCinco = new List<ProductoTeamCinco>();
        public class ProductoTeamCinco
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }

            public ProductoTeamCinco(string Nombre, string Descripcion, decimal Precio)
            {
                this.Nombre = Nombre;
                this.Descripcion = Descripcion;
                this.Precio = Precio;
            }
        }
        public static void DTOprepararJson()
        {
            foreach (var producto in creacionListas.listaProductos)
            {
                string Nombre = producto.nombre;
                string Descripcion = producto.descripcion;
                decimal Precio = producto.precioUnitario;
                ProductoTeamCinco nuevoProducto = new ProductoTeamCinco(Nombre, Descripcion, Precio);
                ListaJsonTeamCinco.Add(nuevoProducto);
            }
            string json = JsonConvert.SerializeObject(ListaJsonTeamCinco);
            File.WriteAllText(_Productospath, json);
        }
    }
}
