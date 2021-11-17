using System;
using Xunit;
using TPI_Musso_Tulio;
using System.Linq;
using Newtonsoft.Json;
namespace XUnitTestMateAR
{
    public class UnitTest1
    {
        [Fact]
        public void testListaCombos()
        {
            Assert.NotNull(creacionListas.listaCombos);
        }

        [Fact] 
        public void testDisponibilidadProducto()
        {
            bool estaDisponible = false;
            Producto productoTest = new Producto(1, "P1",DateTime.Now, "d1", "m1", "c1", "t1", 1000, 50, true,"cat1",false,980,950,930,false,"no",null,null,null) ;
            creacionListas.listaProductos.Add(productoTest);
            foreach (var producto in creacionListas.listaProductos)
            {
                if (producto.disponible==true)
                {
                    estaDisponible = true;
                }
            }
            Assert.True(estaDisponible);
        }
        [Fact]
        public void listaProductosNoVacia()
        {
            Producto productoTest = new Producto(1, "P1", DateTime.Now, "d1", "m1", "c1", "t1", 1000, 50, true, "cat1", false, 980, 950, 930, false, "no", null, null, null);
            creacionListas.listaProductos.Add(productoTest);
            Assert.NotEmpty(creacionListas.listaProductos);
        }
        [Fact]
        public void cantProductosEnListaProductos()
        {
            Producto productoTest = new Producto(1, "P1", DateTime.Now, "d1", "m1", "c1", "t1", 1000, 50, true, "cat1", false, 980, 950, 930, false, "no", null, null, null);
            creacionListas.listaProductos.Add(productoTest);
            Assert.Equal(3,creacionListas.listaProductos.Count);
        }
        [Fact]
        public void testListaProductos()
        {
            Assert.NotNull(creacionListas.listaProductos);
        }
        [Fact]
        public void registroNombreProducto()
        {
            const string nombreProducto = "Mate Satanley";
            Producto productoTest = new Producto(1, nombreProducto, DateTime.Now, "d1", "m1", "c1", "t1", 1000, 50, true, "cat1", false, 980, 950, 930, false, "no", null, null, null);
            Assert.Equal(nombreProducto, productoTest.nombre);
        }
        [Fact]
        public void calculoPrecioCombo()
        {
            Producto productoTest = new Producto(1, "P1", DateTime.Now, "d1", "m1", "c1", "t1", 1000, 50, true, "cat1", false, 980, 950, 930, false, "no", null, null, null);
            creacionListas.listaProductos.Add(productoTest);
            detalleProducto combo1 = new detalleProducto(100,"combo1","P1",0.10M,900,true,1);
            creacionListas.listaCombos.Add(combo1);
            decimal precioCargado;
            decimal PrecioSinDescuento = 1000;
            decimal descuento = 0.10M;
            decimal CalculoPrecio = PrecioSinDescuento - (PrecioSinDescuento * descuento);
            foreach (var combo in creacionListas.listaCombos)
            {
                precioCargado = combo.precioUnitario;
                Assert.Equal(CalculoPrecio, precioCargado);
            }
       
        }
        [Fact]
        public void verificarBajaProducto()
        {
            Producto productoTest = new Producto(1, "P1", DateTime.Now, "d1", "m1", "c1", "t1", 1000, 50, true, "cat1", true, 980, 950, 930, false, "no", null, null, null);
            creacionListas.listaProductos.Add(productoTest);
            bool dadoDeBaja = true;
            foreach (var producto in creacionListas.listaProductos)
            {
               dadoDeBaja=producto.dadoDeBaja;
            }
            Assert.False(dadoDeBaja);
        }
        [Fact]
        public void descuentoEntreDosYCincoUnidades()
        {
            decimal precioUnitario = 1000;
            decimal descuentoEntreDosYCincoUnidades = 0.03M;
            decimal calculoEntreDosYCincoUnidades = precioUnitario - (precioUnitario * descuentoEntreDosYCincoUnidades);
            Producto productoTest = new Producto(1, "P1", DateTime.Now, "d1", "m1", "c1", "t1", precioUnitario, 50, true, "cat1", true, calculoEntreDosYCincoUnidades, 950, 930, false, "no", null, null, null);
            creacionListas.listaProductos.Add(productoTest);
            foreach (var producto in creacionListas.listaProductos)
            {
                decimal precioCalculado = producto.precioEntreDosYCincoUnidades;
                decimal precioEsperado = 970;
                Assert.Equal(precioCalculado,precioEsperado);
            }
        }
        [Fact]
        public void descuentoMasDeDiezUnidades()
        {
            decimal precioUnitario = 1000;
            decimal descuentoMasDeUnidades = 0.07M;
            decimal calculoMasDeUnidades = precioUnitario - (precioUnitario * descuentoMasDeUnidades);
            Producto productoTest = new Producto(1, "P1", DateTime.Now, "d1", "m1", "c1", "t1", precioUnitario, 50, true, "cat1", true, 970, 950, calculoMasDeUnidades, false, "no", null, null, null);
            creacionListas.listaProductos.Add(productoTest);
            foreach (var producto in creacionListas.listaProductos)
            {
                decimal precioCalculado = producto.precioMasDeDiezUnidades;
                decimal precioEsperado = 930;
                Assert.Equal(precioCalculado, precioEsperado);
            }
        }
    }
}
