using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            //RANGO DE VALORES
            Console.WriteLine("RANGOS DE ENTEROS");
            Console.WriteLine($"short.MinValue = {short.MinValue}");
            Console.WriteLine($"short.MaxValue = {short.MaxValue}");
            Console.WriteLine($"int.MinValue = {int.MinValue}");
            Console.WriteLine($"int.MaxValue = {int.MaxValue}");            
            Console.WriteLine($"long.MinValue = {long.MinValue}");
            Console.WriteLine($"long.MaxValue = {long.MaxValue}");

            Console.WriteLine("------------------------");
            Console.WriteLine("RANGOS DE REALES");
            Console.WriteLine($"float.MinValue = {float.MinValue}");
            Console.WriteLine($"float.MaxValue = {float.MaxValue}");
            Console.WriteLine($"double.MinValue = {double.MinValue}");
            Console.WriteLine($"double.MaxValue = {double.MaxValue}");
            Console.WriteLine($"decimal.MinValue = {decimal.MinValue}");
            Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");

            //DECLARACION DE LITERALES
            double numDouble = 3.78;
            decimal numDecimal = 3.78M;
            float numFloat = 3.78F;

            int numInt;
            numInt = (int)numDouble;
            numInt = (int)numDecimal;

            Console.ReadLine();
        }
    }
}
