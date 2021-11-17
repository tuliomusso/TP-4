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
            decimal precioUnitario;
            String ResultPrecio = Console.ReadLine();
            while (!decimal.TryParse(ResultPrecio, out precioUnitario))
            {
                Console.WriteLine("\nIngreso no valido");
                Console.WriteLine("\nIngrese el Precio unitario del producto");
                ResultPrecio = Console.ReadLine();
            }
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
            Console.WriteLine("\nIngrese la categoria del producto:"); 
            string categoria = Console.ReadLine();
            //PRECIOS CON DESCUENTO
            decimal precioEntreDosYCincoUnidades = precioUnitario - (precioUnitario * 0.03M);
            decimal precioEntreSeisYDiezUnidades = precioUnitario - (precioUnitario * 0.05M);
            decimal precioMasDeDiezUnidades = precioUnitario - (precioUnitario * 0.07M);
            //OFERTA
            DateTime fechaInicioA = new DateTime(2021, 10, 30);
            DateTime fechaInicioB = new DateTime(2021, 10, 30);
            DateTime fechaInicioC = new DateTime(2021, 10, 30);
            DateTime fechaCierreA = new DateTime(2021, 12, 20);
            DateTime fechaCierreB = new DateTime(2021, 12, 20);
            DateTime fechaCierreC = new DateTime(2021, 12, 20);
            Oferta ofertaA = new Oferta("OFERTA DIA DE LA MADRE 10% DESCUENTO",fechaInicioA,fechaCierreA);
            Oferta ofertaB = new Oferta("OFERTA DIA DEL PADRE 10% DESCUENTO", fechaInicioB,fechaCierreB);
            Oferta ofertaC = new Oferta("OFERTA DIA DE LA TRADICION 10% DESCUENTO", fechaInicioC,fechaCierreC);
            
            string descripcionOferta="";
            DateTime? fechaInicioOferta = null;
            DateTime? fechaCierreOferta=null;
            decimal? PrecioEnOferta=0;
            bool estaEnOferta=true;
            Console.WriteLine("\nDesea registrar este producto en una oferta?\n1-SI\n2-NO");
            int respuestaOferta = int.Parse(Console.ReadLine());
            if (respuestaOferta == 1)
            {
                Console.WriteLine("\nIngrese la oferta que desea aplicar:\n1-OFERTA DIA DE LA MADRE\n2-OFERTA DIA DEL PADRE\n3-OFERTA DIA DE LA TRADICION");
                int eleccion = int.Parse(Console.ReadLine());
                while (eleccion < 1 || eleccion > 3)
                {
                    Console.WriteLine("\nOpcion incorrecta");
                    Console.WriteLine("\nIngrese la oferta que desea aplicar:\n1-OFERTA DIA DE LA MADRE\n2-OFERTA DIA DEL PADRE\n3-OFERTA DIA DE LA TRADICION");
                    eleccion = int.Parse(Console.ReadLine());
                }
                    switch (eleccion)
                {
                    case 1:
                        descripcionOferta = ofertaA.descripcionOferta;
                        if (ofertaA.InicioOferta < DateTime.Now && ofertaA.CierreOferta> DateTime.Now)
                        {
                            fechaInicioOferta = ofertaA.InicioOferta;
                            fechaCierreOferta = ofertaA.CierreOferta;
                            PrecioEnOferta = precioUnitario - (precioUnitario * 0.10M);
                            estaEnOferta = true;
                        }
                        else
                        {
                            Console.WriteLine("\nLa oferta ya no se encuentra disponible");
                            descripcionOferta = null;
                            fechaInicioOferta = null;
                            fechaCierreOferta = null;
                            PrecioEnOferta = null;
                            estaEnOferta = false;
                        }
                        break;
                    case 2:
                        descripcionOferta = ofertaB.descripcionOferta;
                        if (ofertaB.InicioOferta < DateTime.Now && ofertaB.CierreOferta > DateTime.Now)
                        {
                            fechaInicioOferta = ofertaB.InicioOferta;
                            fechaCierreOferta = ofertaB.CierreOferta;
                            PrecioEnOferta = precioUnitario - (precioUnitario * 0.10M);
                            estaEnOferta = true;
                        }
                        else
                        {
                            Console.WriteLine("\nLa oferta ya no se encuentra disponible");
                            descripcionOferta = null;
                            fechaInicioOferta = null;
                            fechaCierreOferta = null;
                            PrecioEnOferta = null;
                            estaEnOferta = false;
                        }
                        break;
                    case 3:
                        descripcionOferta = ofertaC.descripcionOferta;
                        if (ofertaC.InicioOferta < DateTime.Now && ofertaC.CierreOferta > DateTime.Now)
                        {
                            fechaInicioOferta = ofertaC.InicioOferta;
                            fechaCierreOferta = ofertaC.CierreOferta;
                            PrecioEnOferta = precioUnitario - (precioUnitario * 0.10M);
                            estaEnOferta = true;
                        }
                        else
                        {
                            Console.WriteLine("\nLa oferta ya no se encuentra disponible");
                            descripcionOferta = null;
                            fechaInicioOferta = null;
                            fechaCierreOferta = null;
                            PrecioEnOferta = null;
                            estaEnOferta = false;
                        }
                        break;
                    default: Console.WriteLine("\nOPCION INCORRECTA"); break;
                }
            }
            else
            {
                descripcionOferta = "NO SE ENCUENTRA EN OFERTA";
                fechaCierreOferta = null;
                PrecioEnOferta = null;
                estaEnOferta = false;
            }
            Producto productoNuevo = new Producto(codigoProducto,nombreProducto,fechaDeIngreso,descripcion,modelo,color,tamaño,precioUnitario,cantidadActual,disponibilidad,categoria,productoDadoDeBaja,precioEntreDosYCincoUnidades,precioEntreSeisYDiezUnidades,precioMasDeDiezUnidades,estaEnOferta,descripcionOferta,PrecioEnOferta,fechaInicioOferta,fechaCierreOferta);
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
                String ResultCodigoABuscar = Console.ReadLine();
                while (!Int32.TryParse(ResultCodigoABuscar, out codigoABuscar))
                {
                    Console.WriteLine("\nIngreso no valido");
                    Console.WriteLine("\nIngrese el codigo del producto al cual desea actualizar stock:");
                    ResultCodigoABuscar = Console.ReadLine();
                }
                foreach (var prod in creacionListas.listaProductos)
                {
                    bandera = 0;
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
                int codigoABuscar;
                String ResultCodigoABuscar = Console.ReadLine();
                while (!Int32.TryParse(ResultCodigoABuscar, out codigoABuscar))
                {
                    Console.WriteLine("\nIngreso no valido");
                    Console.WriteLine("\nIngrese el codigo del producto al cual desea actualizar stock:");
                    ResultCodigoABuscar = Console.ReadLine();
                }
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
