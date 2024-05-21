using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrolibreta=0, menor_nrolibreta, mayor_nrolibreta, iteraciones;
            double nota, mayornota, menornota;
            string nombre, nombre_menor, nombre_mayor;

            Console.WriteLine("Ingrese la cantidad de notas a procesar");
            iteraciones = Convert.ToInt32(Console.ReadLine());

            menornota = 0;
            mayornota = 0;
            menor_nrolibreta = nrolibreta;
            mayor_nrolibreta = nrolibreta;
            nombre_menor = "a";
            nombre_mayor = "a";

            for (int i = 0; i < iteraciones; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el nro de libreta");
                nrolibreta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la nota");
                nota = Convert.ToDouble(Console.ReadLine());

                if (i == 0)
                {
                    menornota = nota;
                    mayornota = nota;
                    menor_nrolibreta = nrolibreta;
                    mayor_nrolibreta = nrolibreta;
                    nombre_menor = nombre;
                    nombre_mayor = nombre;
                }
                else
                {
                    if (nota < menornota)
                    {
                        menornota = nota;
                        menor_nrolibreta = nrolibreta;
                        nombre_menor = nombre;
                    }
                    if (nota > mayornota)
                    {
                        mayornota = nota;
                        mayor_nrolibreta = nrolibreta;
                        nombre_mayor = nombre;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mayor nota: {0} Nombre: {1} Numero de libreta: {2}", mayornota, nombre_mayor, mayor_nrolibreta);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menor nota: {0} Nombre: {1} Numero de libreta: {2}", menornota, nombre_menor, menor_nrolibreta);
            Console.ReadKey();
        }
    }
}
