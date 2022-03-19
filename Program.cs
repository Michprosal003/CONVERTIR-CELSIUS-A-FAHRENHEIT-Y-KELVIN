using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ingrese la cantidad de Celsius :");

            Console.Title="Conversion de Temperatura";


            int Celsius = Convert.ToInt32(Console.ReadLine());


            // La formula para pasar de Celsius a Fahrehheit es la siguiente : °F = C X 1.8 +32
            Console.WriteLine("Fahrenheit = {0} °F", Celsius * 1.8 + 32);


            // La formula para pasar de Celsius a Kelvin es la siguiente : K= C +273.15
            Console.WriteLine("Kelvin = {0} K", Celsius +273.15);

            Console.ReadKey();





        }
    }
}
