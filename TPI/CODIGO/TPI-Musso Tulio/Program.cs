using System;
using System.IO;
using Newtonsoft.Json;
namespace TPI_Musso_Tulio
{
    class Program
    {
        private static string _path = @"C:\Json Sample\json.json";
        static void Main(string[] args)
        {
            int opcionContinuar;
            do
            {
                Console.WriteLine("\nINGRESE LA OPCION DESEADA:\n1-Registrar Producto\n2-Mostrar productos registrados\n3-Registar combo\n4-Mostrar combos registrados\n5-Actualizar stock\n6-Registrar baja\n7-DTO Crear Json para los teams");
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
                    case 7: JsonTeamDos.DTOprepararJson(); JsonTeamTres.DTOprepararJson(); JsonTeamCinco.DTOprepararJson(); break;
                    default: Console.WriteLine("\nOPCION INCORRECTA"); break;
                }
                Console.WriteLine("\nDESEA REALIZAR OTRA OPERACION?\n1-SI\n2-NO");
                opcionContinuar = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcionContinuar == 1);
            string json = JsonConvert.SerializeObject(creacionListas.listaProductos);
            File.WriteAllText(_path,json);
        }
    }
}
