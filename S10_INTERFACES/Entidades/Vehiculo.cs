using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S10_INTERFACES.Interfaces;

namespace S10_INTERFACES.Entidades
{
    /// <summary>
    /// Clase que permite gestionar un vehiculo e implementa el contrato de Service
    /// </summary>
    class Vehiculo : IService
    {
        #region PROPERTIES
        private string marca;
        private int cantidadRuedas;

        public string Marca { get => marca; set => marca = value; }
        public int CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        #endregion

        public Vehiculo(string marca, int cantidadRuedas)
        {
            Marca = marca;
            CantidadRuedas = cantidadRuedas;
        }
        public virtual void alinearRueda()
        {
            Console.WriteLine("Alineamos {0}",marca);
        }

        public virtual void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} ruedas del {1}",CantidadRuedas, Marca);
        }

        public void medirPresionAceite()
        {
            Console.WriteLine("Medimos el aceite del vehiculo {0}", Marca);
        }
    }
}
