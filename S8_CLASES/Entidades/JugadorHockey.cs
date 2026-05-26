using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    class JugadorHockey : Deportista
    {

        public JugadorHockey(string n, string a, int e) : base(n, a, e)
        {
        }

        public override void Correr()
        {
            Console.WriteLine($"El JUGADOR DE HOCKEY {Apellido} esta corriendo con el palo y la bocha");
        }

        public override void Precalentar()
        {
            Console.WriteLine($"El JUGADOR DE HOCKEY {Apellido} esta precalentando con la bocha");
        }
    }
}
