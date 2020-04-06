using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Un Caracter");
            String caracter;
            caracter = Console.ReadLine();
            bool esnumero = verificarnumero(caracter);
            bool esvocal = verificarvocal(caracter);
            bool eslargo = verificarlargo(caracter);

            if (eslargo == true)
            {
                Console.WriteLine("Se ingreso mas de un carcter");
                Console.ReadLine();
                return;
            }
            if (esvocal == true)
            {
                Console.WriteLine("Se ingreso una vocal");
                Console.ReadLine();
                return;
            }
            if (esvocal == true)
            {
                Console.WriteLine("Se ingreso una vocal");
                Console.ReadLine();
                return;
            }
            
            if (esnumero == true)
            {
                Console.WriteLine("Se ingreso un numero");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Se ingreso una consonante");
            Console.ReadLine();
        }


        private static bool verificarnumero(string caracter)
            {
            try
            {
                int numero = int.Parse(caracter);
                return true;
            }
            catch
            {
                return false;
            }
            }
        public static bool verificarvocal(string caracter)
        {

                if (caracter == "a" || caracter == "e" || caracter == "i" || caracter == "o" || caracter == "u")
                {
                    return true;
                }
                else
                 {
                return false;
                 }
        }

        public static bool verificarlargo(string caracter)
        {

            if (caracter.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
