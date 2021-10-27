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
            bool productoDadoDeBaja = false;
            bool disponibilidad=true;
            Console.WriteLine("\nIngrese el codigo del producto");
            int codigoProducto;
            String Result = Console.ReadLine();
            while (!Int32.TryParse(Result, out codigoProducto))
            {
                Console.WriteLine("\nIngreso no valido, no es un numero entero:");
                Console.WriteLine("\nIngrese el codigo del producto");
                Result = Console.ReadLine();
            }
            Console.WriteLine("\nIngrese el nombre del producto");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("\nIngrese la fecha de ingreso del producto(dd/mm/yyyy)");
            DateTime fechaDeIngreso;
            String ResultFecha = Console.ReadLine();
            while (!DateTime.TryParse(ResultFecha, out fechaDeIngreso))
            {
                Console.WriteLine("\nIngreso no valido");
                Console.WriteLine("\nIngrese la fecha de ingreso del producto(dd/mm/yyyy)");
                ResultFecha = Console.ReadLine();
            }
            while (fechaDeIngreso > DateTime.Now)
            {
                Console.WriteLine("\nFecha Invalida,es mayor a la fecha actual");
                Console.WriteLine("\nIngrese la fecha de ingreso del producto(dd/mm/yyyy)");
                fechaDeIngreso = DateTime.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nIngrese la descripcion del producto");
            string descripcion = Console.ReadLine();
            Console.WriteLine("\nIngrese el modelo del producto");
            string modelo = Console.ReadLine();
            Console.WriteLine("\nIngrese el color del producto");
            string color = Console.ReadLine();
            Console.WriteLine("\nIngrese el tamaño del producto");
            string tamaño = Console.ReadLine();
            Console.WriteLine("\nIngrese el Precio unitario del producto");
            decimal precioUnitario = decimal.Parse(Console.ReadLine());
            while (precioUnitario<0)
            {
                Console.WriteLine("\nPrecio No valido");
                Console.WriteLine("\nIngrese el Precio unitario del producto");
                precioUnitario = decimal.Parse(Console.ReadLine());
            }
            int cantidadActual;
            Console.WriteLine("\nIngrese la cantidad de unidades del producto");
            String ResultCant = Console.ReadLine();
            while (!Int32.TryParse(ResultCant, out cantidadActual))
            {
                Console.WriteLine("\nIngreso no valido.Ingrese un numero entero:");
                ResultCant = Console.ReadLine();
            }
            if (cantidadActual < 0)
            {
                Console.WriteLine("\nIngreso no valido.Ingrese un numero positivo:");
                String ResultCantPos = Console.ReadLine();
                while (!Int32.TryParse(ResultCantPos, out cantidadActual))
                {
                    Console.WriteLine("\nIngreso no valido.Ingrese un numero entero:");
                    ResultCantPos = Console.ReadLine();
                }
            }
            if (cantidadActual > 0)
            {
                disponibilidad = true;
                productoDadoDeBaja = false;
            }
            if (cantidadActual == 0)
            {
                disponibilidad = false;
                productoDadoDeBaja = true;
            }
            //***COMPLETAR CATEGORIAS***
            Console.WriteLine("\nIngrese la categoria del producto:"); 
            string categoria = Console.ReadLine();
            Producto productoNuevo = new Producto(codigoProducto,nombreProducto,fechaDeIngreso,descripcion,modelo,color,tamaño,precioUnitario,cantidadActual,disponibilidad,categoria,productoDadoDeBaja);
            creacionListas.listaProductos.Add(productoNuevo);
        }
        public static void registrarCombo()
        {
           creacionListas.descripcionComponentes.Clear();
           creacionListas.descripcionCombo.Clear();
            int bandera = 0;
            int opcion = 1;
            decimal importe = 0;
            decimal suma = 0;
            int cantidadActual = 0;
            int confirmacion;
            Console.WriteLine("\nIngrese el codigo del Combo");
            //int codigoCombo = int.Parse(Console.ReadLine());
            int codigoCombo;
            String ResultCombo = Console.ReadLine();
            while (!Int32.TryParse(ResultCombo, out codigoCombo))
            {
                Console.WriteLine("\nIngreso no valido.Ingrese un numero entero:");
                ResultCombo = Console.ReadLine();
            }
            Console.WriteLine("\nIngrese el nombre del Combo");
            string nombreCombo = Console.ReadLine();
            ///Aca se le asignan todos los productos a la descripcion del combo
            do
            {
                Console.WriteLine("\ningrese el codigo del producto que desea agregar al combo");
                int codigoProducto = int.Parse(Console.ReadLine());
                foreach (var producto in creacionListas.listaProductos)
                {
                    if (producto.codigoProducto == codigoProducto && producto.disponible)
                    {
                        creacionListas.descripcionComponentes.Add(producto);
                        bandera = 1;
                    }
                }
                if (bandera == 0)
                {
                    Console.WriteLine("\nEl producto ingresado no tiene disponibilidad");
                }
                Console.WriteLine("\nQuiere confirmar el combo con los productos ingresados?\n1-SI\n2-NO");
                confirmacion = int.Parse(Console.ReadLine());
                if (confirmacion == 1)
                {
                    creacionListas.descripcionCombo = creacionListas.descripcionComponentes;
                    cantidadActual = cantidadActual + 1;
                }
                if (confirmacion == 2)
                {
                    Console.WriteLine("\nDesea agregar otro producto al combo?\n1-SI\n2-NO");
                    opcion = int.Parse(Console.ReadLine());
                }
            } while (confirmacion == 2) ;

            Console.WriteLine("\nIngrese el descuento que tendra el combo(ej 1%=0,01):");
            decimal descuento = decimal.Parse(Console.ReadLine());
            while (descuento < 0 || descuento > 1){
                Console.WriteLine("\nDescuento no valido");
                Console.WriteLine("\nIngrese el descuento que tendra el combo(ej 1%=0,01):");
                descuento = decimal.Parse(Console.ReadLine());
            }
            //Calculo del importe total del combo con el descuento aplicado
            foreach (var componentes in creacionListas.descripcionCombo)
            {
                suma = suma + componentes.precioUnitario;
            }
            importe =suma-(suma * descuento);

            bool disponibilidad = false;
            if (cantidadActual > 0)
            {
                disponibilidad = true;
            }
            string descripcion=""; 
            foreach (var combo in creacionListas.descripcionCombo)
            {
                descripcion = $"{descripcion}{combo.nombre},";
            }
            detalleProducto comboNuevo = new detalleProducto(codigoCombo,nombreCombo,descripcion,descuento,importe,disponibilidad,cantidadActual);
            creacionListas.listaCombos.Add(comboNuevo);
        }

        public static void actualizarStock()
        {
            int codigoABuscar;
            int bandera = 0;
            int opcion = 1;
            bool disponibilidad = false;
            bool productoDadoDeBaja = false;
            if (creacionListas.listaProductos.Count == 0 && creacionListas.listaCombos.Count == 0)
            {
                Console.WriteLine("\nTodavia no se registraron Productos ni combos"); return;
            }
            if (creacionListas.listaProductos.Count == 0)
            {
                Console.WriteLine("\nTodavia no se registraron Productos");
            }
            if (creacionListas.listaCombos.Count == 0)
            {
                Console.WriteLine("\nTodavia no se registraron Combos");
            }
            do
            {
                Console.WriteLine("\nIngrese el codigo del producto al cual desea actualizar stock:");
                codigoABuscar = int.Parse(Console.ReadLine());
                foreach (var prod in creacionListas.listaProductos)
                {
                    if (prod.codigoProducto == codigoABuscar)
                    {
                        Console.WriteLine("\nIngrese la cantidad de unidades que desea añadir al stock:");
                        int cantidadAAgregar = int.Parse(Console.ReadLine());
                        prod.cantidadActual = prod.cantidadActual + cantidadAAgregar;
                        Console.WriteLine($"\nSe actualizo con exito el stock del producto {prod.nombre}");
                    }
                    else bandera = 1;
                    //Actualiza la disponibilidad del producto
                    if (prod.cantidadActual > 0)
                    {
                        prod.disponible = true;
                        prod.dadoDeBaja = false;
                    }
                    if (prod.cantidadActual == 0)
                    {
                        prod.disponible = false;
                        prod.dadoDeBaja = true;
                    }
                    foreach (var combo in creacionListas.listaCombos)
                    {
                        foreach (var componentes in creacionListas.descripcionCombo)
                        {
                            if (componentes.codigoProducto==codigoABuscar)
                            {
                                if (componentes.cantidadActual > 0 && componentes.dadoDeBaja == false)
                                {
                                    combo.disponibilidad = true;
                                }
                                else combo.disponibilidad = false;
                            }
                        }
                    }
                }
                if (bandera == 1)
                {
                    Console.WriteLine("\nEl producto ingresado no existe");
                }
                Console.WriteLine("\nDesea actualizar el stock de otro producto?\n1-SI\n2-NO");
                opcion = int.Parse(Console.ReadLine());
            } while(opcion==1);
            
        }

        public static void registrarBaja()
        {
            if (creacionListas.listaProductos.Count == 0 && creacionListas.listaCombos.Count == 0)
            {
                Console.WriteLine("\nTodavia no se registraron Productos ni combos"); return;
            }
            if (creacionListas.listaProductos.Count == 0)
            {
                Console.WriteLine("\nTodavia no se registraron Productos");
            }
            if (creacionListas.listaCombos.Count == 0)
            {
                Console.WriteLine("\nTodavia no se registraron Combos");
            }
            int bandera = 0;
            int opcion=1;
            do
            {
                bandera = 0;
                Console.WriteLine("\nIngrese el codigo del producto al cual desea dar de baja:");
                int codigoABuscar = int.Parse(Console.ReadLine());
                foreach (var producto in creacionListas.listaProductos)
                {
                    if (codigoABuscar == producto.codigoProducto)
                    {
                        producto.dadoDeBaja = true;
                        producto.disponible = false;
                    }
                    else bandera = 1;
                    if (bandera==0)
                    {
                       Console.WriteLine($"\nSe realizo la baja del producto {producto.nombre}");
                    }
                    foreach (var combo in creacionListas.listaCombos)
                    {
                        foreach (var componentes in creacionListas.descripcionCombo)
                        {
                            if (componentes.codigoProducto == codigoABuscar)
                            {
                                if (componentes.cantidadActual > 0 && componentes.dadoDeBaja==false)
                                {
                                    combo.disponibilidad = true;
                                }
                                else combo.disponibilidad = false;
                            }
                        }
                    }
                }
                if (bandera == 1)
                {
                    Console.WriteLine("\nEl producto ingresado no existe");
                }
                Console.WriteLine("\nDesea dar de baja otro producto?\n1-SI\n2-NO");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion == 1);
           
        }
    }
}
