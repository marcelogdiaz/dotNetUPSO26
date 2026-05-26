using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    class Persona
    {
        #region PROPERTIES
        /// <summary>
        /// Campo para almacenar el nombre de una Persona
        /// </summary>
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get; set; }  //version reducida de property
        public string Apellido { get => apellido; set => apellido = value.ToUpper(); }  //version personalizada de property   gonzalez --> GONZALEZ
        public int Edad { get => edad; set => edad = value; }   //version ampliada de property
        #endregion

        /// <summary>
        /// Metodo para crear un objeto de la clase Persona
        /// </summary>
        /// <param name="n">Permite especificar el nombre de una persona</param>
        /// <param name="a">Permite especificar el apellido de una persona</param>
        /// <param name="e">Permite especificar la edad de una persona</param>
        public Persona(string n, string a, int e)
        {
            Nombre = n;
            Apellido = a;
            Edad = e;

            //a = Apellido;
        }

        /// <summary>
        /// Metodo que incrementa la edad actual en 1
        /// </summary>
        /// <returns>Retorna la edad cumplida</returns>
        public int CumplirAnios() {
            Edad = Edad + 1;
            return Edad;
        }
    }
}
