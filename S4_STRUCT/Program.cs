using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_STRUCT
{
    class Program
    {
        struct Coordenada
        {
            public int x;
            public int y;

            public Coordenada(int x, int b)
            {
                this.x = x;
                this.y = b;

            }
        }

        struct Persona
        {
            public string Nombre;
            public int Edad;
            public int Altura;
        }

        static void Main(string[] args)
        {
            //Coordenada point = new Coordenada(10, 20);
            //Console.WriteLine("X" + point.x);
            //Console.WriteLine("Y" + point.y);

            //Coordenada point2=point ;

            //point2.x *= 2;
            //point2.y = point2.y * 2;

            Persona P1;
            P1.Altura = 180;
            P1.Edad = 25;
            P1.Nombre = "Juan";
            Console.WriteLine($"{P1.Nombre} tiene {P1.Edad} años y mide {P1.Altura} cms.");

            Persona P2;
            P2 = P1;
            P2.Nombre = "Martin";
            Console.WriteLine($"{P2.Nombre} tiene {P2.Edad} años y mide {P2.Altura} cms.");
            //Console.ReadLine();
        }
    }
}
