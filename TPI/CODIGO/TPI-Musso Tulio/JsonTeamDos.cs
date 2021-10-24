using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace TPI_Musso_Tulio
{
    class JsonTeamDos
    {
        private static string _Productospath = @"C:\Json Sample\jsonProductosTeamDos.json";
        private static string _Combospath = @"C:\Json Sample\jsonCombosTeamDos.json";
        public static List<ProductoTeamDos> ListaJsonTeamDos = new List<ProductoTeamDos>();
        public static List<comboTeamDos> ListaCombosJsonTeamDos = new List<comboTeamDos>();
        public class ProductoTeamDos
        {
            public int CodigoProducto { get; set; }
            public string NombreProducto { get; set; }
            public decimal Precio { get; set; }
            public string Descripcion { get; set; }
            public string Color { get; set; }
            public int Stock { get; set; }
            public string Categoria { get; set; } 

            public ProductoTeamDos(int CodigoProducto, string NombreProducto, decimal Precio, string Descripcion, string Color, int Stock, string Categoria)
            {
                this.CodigoProducto = CodigoProducto;
                this.NombreProducto = NombreProducto;
                this.Precio = Precio;
                this.Descripcion = Descripcion;
                this.Color = Color;
                this.Stock = Stock;
                this.Categoria = Categoria;
            }
        }
        public class comboTeamDos
        {
            public int CodigoCombo { get; set; }
            public string NombreCombo { get; set; }
            public decimal Precio { get; set; }
            public string Descripcion { get; set; }
            public int Stock { get; set; }

            public comboTeamDos(int CodigoCombo, string NombreCombo, decimal Precio, string Descripcion, int Stock)
            {
               this.CodigoCombo = CodigoCombo;
               this.NombreCombo = NombreCombo;
               this.Precio = Precio;
               this.Descripcion = Descripcion;
               this.Stock = Stock;
            }
        }

        public static void DTOprepararJson()
        {
            foreach (var producto in creacionListas.listaProductos)
            {
                int CodigoProducto = producto.codigoProducto;
                string NombreProducto = producto.nombre;
                decimal Precio = producto.precioUnitario;
                string Descripcion = producto.descripcion;
                string Color= producto.color;
                int Stock = producto.cantidadActual;
                string Categoria = producto.categoria;
                ProductoTeamDos nuevoProducto = new ProductoTeamDos(CodigoProducto, NombreProducto, Precio, Descripcion, Color, Stock, Categoria);
                ListaJsonTeamDos.Add(nuevoProducto);
            }
            string json = JsonConvert.SerializeObject(ListaJsonTeamDos);
            File.WriteAllText(_Productospath, json);

            foreach (var combo in creacionListas.listaCombos)
            {
                int CodigoCombo = combo.codigoCombo;
                string NombreCombo = combo.nombreCombo;
                decimal Precio = combo.precioUnitario;
                string Descripcion = combo.descripcionComponentes;
                int Stock = combo.cantidadActual;
                comboTeamDos nuevoCombo = new comboTeamDos(CodigoCombo,NombreCombo,Precio,Descripcion,Stock);
                ListaCombosJsonTeamDos.Add(nuevoCombo);
            }
            string jsonCombo = JsonConvert.SerializeObject(ListaCombosJsonTeamDos);
            File.WriteAllText(_Combospath, jsonCombo);
        }

    }
}
