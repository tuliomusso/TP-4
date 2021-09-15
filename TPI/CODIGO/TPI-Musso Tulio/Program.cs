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
                Console.WriteLine("\nINGRESE LA OPCION DESEADA:\n1-Registrar Producto\n2-Mostrar productos registrados");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1: Registro.registrarProducto(); break;
                    case 2: mostrar.productosRegistrados(); break;
                    default: Console.WriteLine("\nOPCION INCORRECTA"); break;
                }
                Console.WriteLine("\nDESEA REALIZAR OTRA OPERACION?\n1-SI\n2-NO");
                opcionContinuar = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcionContinuar == 1);


        }
    }
}
