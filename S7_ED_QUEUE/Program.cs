using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_QUEUE
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar una queue
            Queue my_queue = new Queue();

            //agregamos elementos
            my_queue.Enqueue("UPSO");
            my_queue.Enqueue(1);
            my_queue.Enqueue(200);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("C#");

            ////recorremos la  QUEUE
            //foreach (var item in my_queue)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine($"El primer elemento es {my_queue.Peek()}");
            Console.WriteLine($"Total de elementos antes {my_queue.Count}");

            var item2 = my_queue.Dequeue();

            Console.WriteLine($"Total de elementos despues {my_queue.Count}");


            Console.ReadLine();
        }
    }
}
