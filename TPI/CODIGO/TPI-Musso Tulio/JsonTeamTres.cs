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
            public DateTime? fechaInicioOferta { get; set; }
            public DateTime? fechaCierreOferta { get; set; }
            public bool estaEnOferta { get; set; }
            public decimal? DescuentoPorOferta { get; set; }
            public decimal? DescuentoEntreDosYCincoUnidades { get; set; }
            public decimal? DescuentoEntreSeisYDiezUnidades { get; set; }
            public decimal? DescuentoMasDeDiezUnidades { get; set; }

            public ProductoTeamTres(int codigoProducto, string descripcion, decimal precioUnitario, int cantidadActual, bool disponible, DateTime? fechaInicioOferta, DateTime? fechaCierreOferta, bool estaEnOferta, decimal? DescuentoPorOferta, decimal? DescuentoEntreDosYCincoUnidades, decimal? DescuentoEntreSeisYDiezUnidades, decimal? DescuentoMasDeDiezUnidades)
            {
                this.CodigoProducto = codigoProducto;
                this.Descripcion = descripcion;
                this.PrecioUnitario = precioUnitario;
                this.CantidadActual = cantidadActual;
                this.Disponible = disponible;
                this.fechaInicioOferta = fechaInicioOferta;
                this.fechaCierreOferta = fechaCierreOferta;
                this.estaEnOferta = estaEnOferta;
                this.DescuentoPorOferta = DescuentoPorOferta;
                this.DescuentoEntreDosYCincoUnidades = DescuentoEntreDosYCincoUnidades;
                this.DescuentoEntreSeisYDiezUnidades = DescuentoEntreSeisYDiezUnidades;
                this.DescuentoMasDeDiezUnidades = DescuentoMasDeDiezUnidades;
            }
        }
        public class comboTeamTres
        {
            public int CodigoProducto { get; set; } // ese team lo toma como un producto mas
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int CantidadActual { get; set; }
            public bool Disponible { get; set; }
            public DateTime? fechaInicioOferta { get; set; }
            public DateTime? fechaCierreOferta { get; set; }
            public bool estaEnOferta { get; set; }
            public decimal? DescuentoPorOferta { get; set; }
            public decimal? DescuentoEntreDosYCincoUnidades { get; set; }
            public decimal? DescuentoEntreSeisYDiezUnidades { get; set; }
            public decimal? DescuentoMasDeDiezUnidades { get; set; }

            public comboTeamTres(int codigoProducto, string descripcion, decimal precioUnitario, int cantidadActual, bool disponible, DateTime? fechaInicioOferta, DateTime? fechaCierreOferta, bool estaEnOferta, decimal? DescuentoPorOferta, decimal? DescuentoEntreDosYCincoUnidades, decimal? DescuentoEntreSeisYDiezUnidades, decimal? DescuentoMasDeDiezUnidades)
            {
                this.CodigoProducto = codigoProducto;
                this.Descripcion = descripcion;
                this.PrecioUnitario = precioUnitario;
                this.CantidadActual = cantidadActual;
                this.Disponible = disponible;
                this.fechaInicioOferta = fechaInicioOferta;
                this.fechaCierreOferta = fechaCierreOferta;
                this.estaEnOferta = estaEnOferta;
                this.DescuentoPorOferta = DescuentoPorOferta;
                this.DescuentoEntreDosYCincoUnidades = DescuentoEntreDosYCincoUnidades;
                this.DescuentoEntreSeisYDiezUnidades = DescuentoEntreSeisYDiezUnidades;
                this.DescuentoMasDeDiezUnidades = DescuentoMasDeDiezUnidades;
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
                decimal? descuentoEntreDosYCincoUnidades = 0.03M;
                decimal? descuentoEntreSeisYDiezUnidades = 0.05M;
                decimal? descuentoMasDeDiezUnidades = 0.07M;
                bool estaEnOferta = producto.estaEnOferta;
                decimal? descuentoPorOferta;
                if (estaEnOferta)
                {
                    descuentoPorOferta = 0.10M;
                }
                else { descuentoPorOferta = null; }
                DateTime? InicioOferta = producto.fechaInicioOferta;
               // string fechaInicioOferta = InicioOferta.HasValue ? InicioOferta.Value.ToString("yyyy, MM, dd") : null;
                DateTime? CierreOferta = producto.fechaCierreOferta;
               // string fechaCierreOferta = CierreOferta.HasValue ? CierreOferta.Value.ToString("yyyy, MM, dd") : null;
                ProductoTeamTres nuevoProducto = new ProductoTeamTres(CodigoProducto,Descripcion,PrecioUnitario,CantidadActual,Disponible,InicioOferta,CierreOferta,estaEnOferta,descuentoPorOferta,descuentoEntreDosYCincoUnidades,descuentoEntreSeisYDiezUnidades,descuentoMasDeDiezUnidades);
                ListaJsonTeamTres.Add(nuevoProducto);
            }

            foreach (var combo in creacionListas.listaCombos)
            {
                int CodigoProducto = combo.codigoCombo;
                string Descripcion = combo.descripcionComponentes;
                decimal PrecioUnitario = combo.precioUnitario;
                int CantidadActual = combo.cantidadActual;
                bool Disponible = combo.disponibilidad;
                decimal? descuentoEntreDosYCincoUnidades = null;
                decimal? descuentoEntreSeisYDiezUnidades = null;
                decimal? descuentoMasDeDiezUnidades = null;
                bool estaEnOferta = false;
                decimal? descuentoPorOferta = null;
                DateTime? fechaInicioOferta = null;
                DateTime? fechaCierreOferta = null;
                ProductoTeamTres nuevoCombo = new ProductoTeamTres(CodigoProducto, Descripcion, PrecioUnitario, CantidadActual, Disponible, fechaInicioOferta, fechaCierreOferta, estaEnOferta, descuentoPorOferta, descuentoEntreDosYCincoUnidades, descuentoEntreSeisYDiezUnidades, descuentoMasDeDiezUnidades);
                ListaJsonTeamTres.Add(nuevoCombo);
            }
            string json = JsonConvert.SerializeObject(ListaJsonTeamTres);
            File.WriteAllText(_Productospath, json);
        }
    }
}
