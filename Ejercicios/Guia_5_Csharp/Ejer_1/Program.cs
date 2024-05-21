using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, montomenor, montomayor;
            double monto, mmeng, mmayg;
            int pregunta;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el nombre del jugador");
            nom = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese el monto promedio de apuesta");
            monto = Convert.ToDouble(Console.ReadLine());

            mmeng = monto;
            mmayg = monto;
            montomenor = nom;
            montomayor = nom;
            bool bandera = true;

            while (bandera)
            {                
                if (monto < mmeng)
                {
                    montomenor = nom;
                    mmeng = monto;
                }

                if (monto > mmayg)
                {
                    montomayor = nom;
                    mmayg = monto;
                }

                Consultar();
                pregunta = Convert.ToInt32(Console.ReadLine());
                
                if (pregunta == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ingrese el nombre del jugador");
                    nom = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ingrese el monto promedio de apuesta");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                }
                else bandera = false;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El monto menor es de: {0}", montomenor);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El monto mayor es de: {0}", montomayor);
            Console.ReadKey();
        }
        static public void Consultar()
        {
            Console.Clear();
            Console.WriteLine("¿Desea seguir?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Seguir");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. Salir");
        }
    }
}
