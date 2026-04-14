using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTipos2
{
    class Program
    {
        /// <summary>
        /// Tipo de dato ESTRUCTURADO, tipo por valor
        /// </summary>
        struct Book
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        }

        /// <summary>
        /// Tip de dato ENUMERADO, tipo por valor
        /// </summary>
        enum Dias { LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO }

        static void Main(string[] args)
        {
            Book miLibro = new Book
            {
                title = "Sistemas Operativos",
                author = "A. Silberchatz",
                subject = "Computacion",
                book_id = 1
            };


            Book miLibro2 = new Book();

            

            miLibro2 = miLibro;
            miLibro2.title = ".NET";


            Console.WriteLine(miLibro.title);
            Console.WriteLine(miLibro);

            Console.WriteLine("Hoy es " + Dias.MARTES);
            Console.ReadLine();

        }
    }
}
