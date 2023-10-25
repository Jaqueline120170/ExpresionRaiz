using ExpresionRaiz.Servicios;

namespace ExpresionRaiz.Controladores
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            int numeroEnt;
            numeroEnt = mi.PedirNum();

            
            OperacionesInterfaz oi = new OperacionesImplementacion();
            int raizCuadrada;
            raizCuadrada = Convert.ToInt32(oi.CalcularRaizCuadrada(numeroEnt));


            if (raizCuadrada  == numeroEnt)
            
            {
                Console.WriteLine($"El número {numeroEnt} se puede expresar como el cuadrado de {raizCuadrada}");

                Console.WriteLine("El numero introducido es entero");

            }
            else Console.WriteLine("El numero introducido no es entero");
        }
      
    }
} 