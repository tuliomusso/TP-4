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
            public int codProducto { get; set; }
            public string nomProducto { get; set; }
            public decimal precio { get; set; }
            public string desc { get; set; }
            public string color { get; set; }
            public int stockProducto { get; set; }
            public string categoria { get; set; }
            public decimal? precioDosCinco { get; set; }
            public decimal? precioSeisDiez { get; set; }
            public decimal? precioDiezMas { get; set; }
            public bool estaOferta { get; set; }
            public string desOferta { get; set; }
            public decimal? precioOferta { get; set; }
            public DateTime? fechaInOferta { get; set; }
            public DateTime? fechaFinOferta { get; set; }

            public ProductoTeamDos(int CodigoProducto, string NombreProducto, decimal Precio, string Descripcion, string Color, int Stock, string Categoria, decimal? precioEntreDosYCincoUnidades, decimal? precioEntreSeisYDiezUnidades, decimal? precioMasDeDiezUnidades, bool estaEnOferta, string descripcionOferta, decimal? precioEnOferta, DateTime? fechaInicioOferta, DateTime? fechaCierreOferta)
            {
                this.codProducto = CodigoProducto;
                this.nomProducto = NombreProducto;
                this.precio = Precio;
                this.desc = Descripcion;
                this.color = Color;
                this.stockProducto = Stock;
                this.categoria = Categoria;
                this.precioDosCinco = precioEntreDosYCincoUnidades;
                this.precioSeisDiez = precioEntreSeisYDiezUnidades;
                this.precioDiezMas = precioMasDeDiezUnidades;
                this.estaOferta = estaEnOferta;
                this.desOferta = descripcionOferta;
                this.precioOferta = precioEnOferta;
                this.fechaInOferta = fechaInicioOferta;
                this.fechaFinOferta = fechaCierreOferta;
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
                decimal? precioEntreDosYCincoUnidades = producto.precioEntreDosYCincoUnidades;
                decimal? precioEntreSeisYDiezUnidades = producto.precioEntreSeisYDiezUnidades;
                decimal? precioMasDeDiezUnidades = producto.precioMasDeDiezUnidades;
                bool estaEnOferta = producto.estaEnOferta;
                string descripcionOferta = producto.descripcionOferta;
                decimal? precioEnOferta = producto.precioEnOferta;
                DateTime? fechaInicioOferta = producto.fechaInicioOferta;
                DateTime? fechaCierreOferta = producto.fechaCierreOferta;
                ProductoTeamDos nuevoProducto = new ProductoTeamDos(CodigoProducto, NombreProducto, Precio, Descripcion, Color, Stock, Categoria, precioEntreDosYCincoUnidades, precioEntreSeisYDiezUnidades, precioMasDeDiezUnidades, estaEnOferta,descripcionOferta, precioEnOferta, fechaInicioOferta, fechaCierreOferta);
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
