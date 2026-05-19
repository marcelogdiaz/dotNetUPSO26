using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos una lista de enteros
            List<int> my_list = new List<int>();

            my_list.Add(11);
            my_list.Add(24);
            my_list.Add(32);
            my_list.Add(55);

            Console.WriteLine($"El tamaño de la lista es {my_list.Count}");
            Console.WriteLine($"El segundo elemento es {my_list[1]}");

            my_list[1] = 88;

            foreach (var item in my_list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
