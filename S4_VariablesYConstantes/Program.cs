using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_VariablesYConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declaracion de variables
            //int variable1;
            ////asignacion de valor
            //variable1 = 10;

            ////  var variable2; ERROR EN COMPILACION PORQUE HAY QUE ASIGNARLE UN VALOR

            //var variable2 = 0;
            ////variable2 = "UPSO"; ERROR EN COMPILACION PORQUE EL TIPO INFERIDO ES INT

            //int variable3 = variable1 + 20;
            //float variable4 = 10.5F;

            //var variableVAR = variable3;

            //variableVAR = (int)variable4;

            //Console.WriteLine(variableVAR);
            //Console.WriteLine(variableVAR.GetType().ToString());
            //Console.ReadLine();

            //constantes
            const int VALORCONSTANTE = 1000; //ValorConstante //Valor_Constante  //VALOR_CONSTANTE
            const double PI = 3.1415;
            const string UNI = "UPSO";
            Console.WriteLine(UNI);
            Console.ReadLine();
        }
    }
}
