using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_INTERFACES.Interfaces
{
    /// <summary>
    /// Interface que permite definir un contrato para un vehiculo
    /// </summary>
    interface IService
    {
        void cambiarRueda();
        void alinearRueda();
        void medirPresionAceite();

    }
}
