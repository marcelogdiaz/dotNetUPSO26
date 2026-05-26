using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    class JugadorFutbol : Deportista
    {
        private int infracciones;
        private string posicion;

        public int Infracciones { get => infracciones; set => infracciones = value; }
        public string Posicion { get => posicion; set => posicion = value; }

        public JugadorFutbol(string n, string a, int e, string posicion, int infracciones=0): base(n,a,e)
        {
            this.infracciones = infracciones;
            this.posicion = posicion;
        }

        public override void Correr()
        {
            //base.Correr();

            Console.WriteLine($"El JUGADOR {Apellido} esta corriendo hacia la pelota");
        }

        public override void Precalentar()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta precalentando con la pelota de futbol");
        }

        public void TarjetaRoja() {
            Console.WriteLine($"El JUGADOR {Apellido} recibio tarjeta ROJA.");
        }
    }
}
