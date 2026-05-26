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


            //creamos un Deportista en particular
            Deportista j10 = new Deportista("Lionel", "Messi", 36);
            //j10.CumplirAnios();
            //j10.Correr();


            //JugadorFutbol j05 = new JugadorFutbol("Carlos", "Perez", 24, "Defensor");

            //j05.Correr();
            //j05.Precalentar();

            List<Deportista> deportistasCenard = new List<Deportista>();
            Deportista dep = new Deportista("Rodriguez", "Juan", 41);

            deportistasCenard.Add(j10);
            deportistasCenard.Add(dep);

            for (int i = 0; i < 12; i++)
            {
                deportistasCenard.Add(new JugadorFutbol($"NomLOCAL{i}", $"ApLOCAL{i}",25, i.ToString()));
            }

            deportistasCenard.Add(new JugadorHockey("Luciana", "Aimar", 29));


            foreach (var item in deportistasCenard)
            {
                item.Correr(); Console.WriteLine();

            }



            Console.ReadLine();
        }
    }
}
