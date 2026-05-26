using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_INTERFACES.Entidades
{
    /// <summary>
    /// Clase que personaliza el comportamiento de un vehiculo
    /// </summary>
    class Moto: Vehiculo
    {
        string color;

        public string Color { get => color; set => color = value; }

        public Moto(string color, string m, int cr) : base(m, cr)
        {
            this.color = color;
        }

        public override void alinearRueda()
        {
            Console.WriteLine("Alineamos MOTO {0}", Marca);
        }

        public override void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} ruedas en la MOTO {1}", CantidadRuedas, Marca);
        }
    }
}
