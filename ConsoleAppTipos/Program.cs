using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTipos
{
    //consoleapptipos

    /// <summary>
    /// Esta es clase principal de nuestro proyecto
    /// </summary>
    class Program
    {
        /// <summary>
        /// Este es el metodo principal de nuestro proyecto
        /// </summary>
        /// <param name="args">este es un parametro de entrada de datos</param>
        static void Main(string[] args)
        {
            //Single s = 100;

            //if (s < Single.MinValue)
            //{
            //    Console.WriteLine("Your number is smaller than a Single.MINVALUE.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is greater than a Single.MINVALUE");
            //}

            double myDouble = 10.5;

            Console.WriteLine(myDouble);
            float myfloat = 10.5F;  //explicito
            //implicito
            Console.WriteLine(myfloat);

            //---------------------
            int myInt = 8;
            Console.WriteLine("Antes del CAST");
            Console.WriteLine(myInt);

            myInt = (int)myfloat; //conversion explicita mediante CAST

            Console.WriteLine("Despues del CAST");
            Console.WriteLine(myInt);
        }
    }
}
