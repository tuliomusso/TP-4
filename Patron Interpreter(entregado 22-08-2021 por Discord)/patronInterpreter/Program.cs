using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace patronInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero Romano que desea evaluar:");
            string numeroIngresado = Console.ReadLine();
            Context CONTEXT = new Context(numeroIngresado); //recibe el numero a evaluar
            List<expression> Arbol = new List<expression>(); 
            Arbol.Add(new Mil());
            Arbol.Add(new Centenas());
            Arbol.Add(new Decenas());
            Arbol.Add(new Unidades());

            foreach (expression pos in Arbol)
            {
                pos.interpreter(CONTEXT);
            }
            Console.WriteLine($"Numero romano Ingresado:{numeroIngresado}\nSu numero es:{CONTEXT.salida}");
        }
        public class Context
        {
            public string ingreso { get; set; }
            public int salida { get; set; }

            public Context(string ingreso) // recibe el valor que quiero interpretar
            {
                this.ingreso = ingreso;
            }
        }
        public abstract class expression
        {
            public abstract String uno(); //Los voy a utilizar para realizar las combinaciones por EJ III
            public abstract String cuatro();
            public abstract String cinco();
            public abstract String nueve();
            public abstract int multiplicador();
            public void interpreter(Context context)
            {
                if (context.ingreso.Length == 0)
                {
                    return; // Para el caso de que el ingreso sea nulo 
                }
                if (context.ingreso.StartsWith(nueve()))
                {
                    context.salida = context.salida+(9 * multiplicador());
                    // posibles inicios para 9= IX, XC, CM
                    context.ingreso = context.ingreso.Substring(2);/*esto es para que no se vuelan a procesar 
                                                                  los 2 caracteres iniciales*/
                }
                else if (context.ingreso.StartsWith(cinco()))
                {
                    context.salida = context.salida + (5 * multiplicador());
                    // inicios V,L,D
                    context.ingreso = context.ingreso.Substring(1);
                }
                else if (context.ingreso.StartsWith(cuatro()))
                {
                    context.salida =context.salida + (4 * multiplicador());
                    // inicios IV,XL,CD
                    context.ingreso = context.ingreso.Substring(2);
                }
                //para las unidades usamos un ciclo porque se pueden repetir: III,XX,etc
                while (context.ingreso.StartsWith(uno()))
                {
                    context.salida = context.salida+ (1 * multiplicador());
                    context.ingreso = context.ingreso.Substring(1);
                }
            }

        }
        public class Unidades:expression  
        {
            public override string uno()
            {
                return "I";
            }
            public override string cuatro()
            {
                return "IV";
            }
            public override string cinco()
            {
                return "V";
            }
            public override string nueve()
            {
                return "IX";
            }
            public override int multiplicador()
            {
                return 1;
            }

            
        }
        public class Decenas : expression
        {
            public override string uno()
            {
                return "X";
            }
            public override string cuatro()
            {
                return "XL";
            }
            public override string cinco()
            {
                return "L";
            }
            public override string nueve()
            {
                return "XC";
            }
            public override int multiplicador()
            {
                return 10;
            }


        }
        public class Centenas : expression
        {
            public override string uno()
            {
                return "C";
            }
            public override string cuatro()
            {
                return "CD";
            }
            public override string cinco()
            {
                return "D";
            }
            public override string nueve()
            {
                return "CM";
            }
            public override int multiplicador()
            {
                return 100;
            }


        }
        public class Mil : expression
        {
            public override string uno()
            {
                return "M";
            }
            public override string cuatro()
            {
                return " ";
            }
            public override string cinco()
            {
                return " ";
            }
            public override string nueve()
            {
                return " ";
            }
            public override int multiplicador()
            {
                return 1000;
            }


        }


    }

}

