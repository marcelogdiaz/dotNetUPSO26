using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S10_INTERFACES.Entidades;

namespace S10_INTERFACES
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miVehiculo;

            miVehiculo = new Moto("Negro","Honda", 2);

            miVehiculo.alinearRueda();
            miVehiculo.cambiarRueda();
            miVehiculo.medirPresionAceite();

            Console.ReadLine();
        }
    }
}
