using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "hello";
            //string b = "h";
            ////string c;


            //b += "ello";

            //a = b;

            //Console.WriteLine(a==b);
            //Console.WriteLine(object.ReferenceEquals(a,b));
            //Console.ReadLine();

            string parrafo = "esto es un " +
                "" +
                "" +
                "parrafo";

            string texto = @" esto es un parrafo
                    que tiene varias
                    lineas
                    ";

            //Console.WriteLine(parrafo);
            //Console.WriteLine("---------------");

            //Console.WriteLine(texto);

            string frase = parrafo.Substring(5);
            string minifrase = parrafo.Substring(5,3);
            Console.WriteLine(frase);
            Console.WriteLine(minifrase);

            string frase1 = "Her name was \"Sara\".";
            string frase2 = @" Her name was ""Sara."" ";

            Console.WriteLine(frase1);
            Console.WriteLine(frase2);

            Console.ReadLine();
        }
    }
}
