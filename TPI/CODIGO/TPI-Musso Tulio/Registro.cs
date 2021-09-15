using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Musso_Tulio
{
    public class Registro
    {
        public static void registrarProducto()
        {
            bool disponibilidad=true;
            Console.WriteLine("\nIngrese el codigo del producto");
            int codigoProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el nombre del producto");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("\nIngrese la fecha de ingreso del producto(dd/mm/yyyy)");
            DateTime fechaDeIngreso =DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la descripcion del producto");
            string descripcion = Console.ReadLine();
            Console.WriteLine("\nIngrese el modelo del producto");
            string modelo = Console.ReadLine();
            Console.WriteLine("\nIngrese el color del producto");
            string color = Console.ReadLine();
            Console.WriteLine("\nIngrese el tamaño del producto");
            double tamaño = double.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el Precio unitario del producto");
            decimal precioUnitario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la cantidad actual del producto");
            int cantidadActual = int.Parse(Console.ReadLine());
            if (cantidadActual > 0)
            {
                disponibilidad = true;
            }
            if (cantidadActual == 0)
            {
                disponibilidad = false;
            }
            //***COMPLETAR CATEGORIAS***
            Console.WriteLine("\nIngrese la categoria del producto:\n1-CATEGORIA 1");
            int categoria = int.Parse(Console.ReadLine());
            bool productoDadoDeBaja = false;
          
            Producto productoNuevo = new Producto(codigoProducto,nombreProducto,fechaDeIngreso,descripcion,modelo,color,tamaño,precioUnitario,cantidadActual,disponibilidad,categoria,productoDadoDeBaja);
            creacionListas.listaProductos.Add(productoNuevo);
        }
    }
}
