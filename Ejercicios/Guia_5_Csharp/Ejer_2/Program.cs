using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final, anterior, anteriordeanterior, actual;

            Console.WriteLine("Ingrese hasta que numero quiere saber la serie Fibonacci");
            final = Convert.ToInt32(Console.ReadLine());
            anterior = 0;
            anteriordeanterior = 0;
            actual = 0;

            for (int i = 0; i <= final; i++)
            {
                anteriordeanterior = anterior;
                anterior = actual;

                if (i == 1)
                {
                    actual = i;
                }
                else actual = anteriordeanterior + anterior;
                Console.WriteLine(actual);
            }
            Console.ReadKey();
        }
        
    }
}
