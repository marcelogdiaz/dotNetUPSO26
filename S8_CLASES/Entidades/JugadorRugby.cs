using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    class JugadorRugby : Deportista
    {
        public JugadorRugby(string n, string a, int e) : base(n, a, e)
        {
        }

        public override void Correr()
        {
            Console.WriteLine($"El JUGADOR DE RUGBY {Apellido} esta corriendo con la guinda");
        }
    

        public override void Precalentar()
        {
            Console.WriteLine($"El JUGADOR DE RUGBY {Apellido} esta precalentando con la guinda");
    }
    }
}
