using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionRaiz.Servicios
{
     class OperacionesImplementacion : OperacionesInterfaz
    {
        public double CalcularRaizCuadrada(int numeroEnt)
        {
            double raizCuadrada = Math.Sqrt(numeroEnt);
            Console.WriteLine("El resultado de la raíz es: " + raizCuadrada);
            return raizCuadrada;

        }
    }
}
