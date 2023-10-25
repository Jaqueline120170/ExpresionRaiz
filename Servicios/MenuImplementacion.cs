using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionRaiz.Servicios
{
    class MenuImplementacion : MenuInterfaz
    {
        public int PedirNum()
        {
            int numeroEnt;
            Console.WriteLine("Introduzca un número");
            numeroEnt = Console.ReadKey(true).KeyChar - '0';
            return numeroEnt;
        }

        
          
    }


}

   
  






