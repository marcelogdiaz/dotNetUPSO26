using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    abstract class Deportista : Persona
    {

        public Deportista(string n, string a, int e) : base( n,  a,  e)
        {
        }

        public abstract void Correr();
        //{
        //    //Console.WriteLine($"El Deportista {Apellido} esta corriendo");
        //}

        public abstract void Precalentar();
        //{
        //    //Console.WriteLine($"El Deportista {Apellido} esta precalentando");
        //}
    }
}
