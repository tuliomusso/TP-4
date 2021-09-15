using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Musso_Tulio
{
    class mostrar
    {
        public static void productosRegistrados()
        {
            foreach (var producto in creacionListas.listaProductos)
            {
                Console.WriteLine($"\nCodigo del producto:{producto.codigoProducto}\nNombre del Producto:{producto.nombre}\nFecha de ingreso:{producto.fechaIngreso.ToShortDateString()}\n" +
                    $"Descripcion:{producto.descripcion}\nModelo:{producto.modelo}\nColor:{producto.color}\nTamaño:{producto.tamaño}\nPrecio Unitario:{producto.precioUnitario}\n" +
                    $"Cantidad Actual:{producto.cantidadActual}\nCategoria:{producto.categoria}\n");
            }
        }
    }
}
