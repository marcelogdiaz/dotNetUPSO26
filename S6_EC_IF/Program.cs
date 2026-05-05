using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "UPSO C#";
            string y = "UPSO .NET";

            //if (x==Y)
            if(compararString(x,y))
            {
                Console.WriteLine("Los strings son IGUALES");
            }
            else
            {
                Console.WriteLine("Los strings son DISTINTOS");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Esta funcion permite COMPARAR dos strings. Es una funcion wrapper de la comparacion ==
        /// </summary>
        /// <param name="x">Un valor strig a comparar.</param>
        /// <param name="y">Otro valor string a comparar.</param>
        /// <returns>TRUE si ambos parametros son iguales, caso contrario retorna FALSE.</returns>
        private static bool compararString(string x, string y)
        {
            return (x==y);
        }
    }
}
