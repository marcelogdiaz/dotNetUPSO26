using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            //string materia = "COBOL";

            //switch (materia)
            //{
            //    case "JAVA":
            //        Console.WriteLine("La materia es JAVA");
            //        break;
            //    case "PHP":
            //        Console.WriteLine("La materia es PHP");
            //        break;
            //    case "C#":
            //        Console.WriteLine("La materia es C#");
            //        break;
            //    case "PYTHON":
            //        Console.WriteLine("La materia es PYTHON");
            //        break;
            //    //default:
            //    //    Console.WriteLine($"La materia es {materia}");
            //    //    break;
            //}

            decimal valor = 1;
            switch (valor)
            {
                case 0:
                    Console.WriteLine("El valor es CERO.");
                    break;
                default:
                    if (valor > 2.0m)
                    {
                        Console.WriteLine("El valor es mayor que 2.0.");
                    }
                    else
                    {
                        Console.WriteLine("El valor es menor o igual que 2.0.");
                    }
                    break;
            }
        }
    }
}
