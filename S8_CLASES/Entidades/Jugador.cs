using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    class Jugador : Persona
    {
        private int infracciones;
        private string posicion;


        public int Infracciones { get => infracciones; set => infracciones = value; }
        public string Posicion { get => posicion; set => posicion = value; }


        public Jugador(string n, string a, int e, string posicion, int infracciones = 0) : base( n,  a,  e)
        {
            
            Infracciones = infracciones;
            Posicion = posicion;
        }

        public void Correr()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta corriendo");
        }

        public void Precalentar()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta precalentando");
        }
    }
}
