using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_STACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();

            //agregamos elementos
            my_stack.Push("UPSO");
            my_stack.Push("programacion");
            my_stack.Push("c#");
            my_stack.Push(5.5);

            /*
            5.5
            c#
            programacion
            upso
            */

            foreach (var item in my_stack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine($"El tamaño de stack es {my_stack.Count}");

            var item2 = my_stack.Pop();
            Console.WriteLine($"El tope de stack es {item2}");

            Console.WriteLine($"El nuevo tamaño de stack es {my_stack.Count}");

            if (my_stack.Contains("programacion")) {
                Console.WriteLine("LO TIENE");
            }

            Console.ReadLine();
        }
    }
}
