using System;

namespace TPI_Musso_Tulio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionContinuar;
            do
            {
                Console.WriteLine("\nINGRESE LA OPCION DESEADA:\n1-Registrar Producto\n2-Mostrar productos registrados\n3-Registar combo\n4-Mostrar combos registrados\n5-Actualizar stock\n6-Registrar baja");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1: Registro.registrarProducto(); break;
                    case 2: mostrar.productosRegistrados(); break;
                    case 3: Registro.registrarCombo(); break;
                    case 4: mostrar.combosRegistrados();break;
                    case 5: Registro.actualizarStock();break;
                    case 6: Registro.registrarBaja();break;
                    default: Console.WriteLine("\nOPCION INCORRECTA"); break;
                }
                Console.WriteLine("\nDESEA REALIZAR OTRA OPERACION?\n1-SI\n2-NO");
                opcionContinuar = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcionContinuar == 1);


        }
    }
}
