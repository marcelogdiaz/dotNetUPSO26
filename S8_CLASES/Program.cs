using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S8_CLASES.Entidades;

namespace S8_CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ap = "Perez";

            //Persona p = new Persona("Juan",  ap, 33); //Persona p = new Persona("Juan", ref ap,33);

            //Console.WriteLine("Edad antes del cumple...");
            //Console.WriteLine("{0}, {1}, {2}", p.Apellido,p.Nombre, p.Edad);

            //p.CumplirAnios();

            //Console.WriteLine("Edad despues del cumple...");
            //Console.WriteLine("{0}, {1}, {2}", p.Apellido, p.Nombre, p.Edad);
            //Console.ReadLine();


            //creamos un jugador en particular
            Jugador j10 = new Jugador("Lionel", "Messi", 36, "delantero");

            j10.CumplirAnios();

            j10.Correr();
            Console.ReadLine();
        }
    }
}
