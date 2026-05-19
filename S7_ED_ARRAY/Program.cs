using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar un arrelo de enteros
            int[] intArray;

            //reservamos memoria para 5 enteros
            intArray = new int[5] { 1,20,30,40,50};
            intArray[0] = 5;

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine($"El valor {i} del arreglo es {intArray[i]}");
            //}

            int indice = 0;
            //foreach (var item in intArray)
            //{
            //    Console.WriteLine($"El valor {indice} del arreglo es {item}");
            //    indice++;
            //}

            while (indice < intArray.Length)
            {
                Console.WriteLine($"El valor {indice} del arreglo es {intArray[indice]}");
                indice++;
            }

            Console.ReadLine();
        }
    }
}
