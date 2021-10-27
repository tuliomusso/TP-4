using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace TPI_Musso_Tulio
{
    class mostrar
    {
        public static void productosRegistrados()
        {
            if (creacionListas.listaProductos.Count == 0)
            {
                Console.WriteLine("\nTodavia NO se registraron productos");
            }
            else
            {
                foreach (var producto in creacionListas.listaProductos)
                {
                    Console.WriteLine($"\nCodigo del producto:{producto.codigoProducto}\nNombre del Producto:{producto.nombre}\nFecha de ingreso:{producto.fechaIngreso.ToShortDateString()}\n" +
                        $"Descripcion:{producto.descripcion}\nModelo:{producto.modelo}\nColor:{producto.color}\nTamaño:{producto.tamaño}\nPrecio Unitario:{producto.precioUnitario}\n" +
                        $"Cantidad Actual:{producto.cantidadActual}\nCategoria:{producto.categoria}\nDisponibilidad:{producto.disponible}\nEstado de Baja:{producto.dadoDeBaja}");
                }
            }
            
        }

        public static void combosRegistrados()
        {
            if (creacionListas.listaCombos.Count == 0)
            {
                Console.WriteLine("\nTodavia NO se registraron combos");
            }
            else
            {
                foreach (var combo in creacionListas.listaCombos)
                {
                    Console.WriteLine($"\nCodigo del combo:{combo.codigoCombo}\nNombre del Combo:{combo.nombreCombo}\nDescripcion del combo:");
                    Console.WriteLine($"\n{combo.descripcionComponentes}");
                    Console.WriteLine($"\nDescuento aplicado:{combo.descuento}\nPrecio unitario:{combo.precioUnitario}\nDisponibilidad:{combo.disponibilidad}");
                }
            }
        }
    }
}
