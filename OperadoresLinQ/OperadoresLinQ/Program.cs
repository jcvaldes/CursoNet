using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = { 2, 3, 7, 8, 9, 6, 5, 4, 0, 1 };
            string[] letras = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            var array = ( from n in numero
                          select letras[n]);

            Console.WriteLine("Muestra el indice del array letras");
            foreach (string item in array)
                Console.WriteLine("{0,2}", item);


            
            Console.WriteLine("Muestra en Mayusculas y Minusculas");
            string[] amimales = { "PerrO", "GaTo", "TorTuga" };
            var resultado = (
                                from a in amimales
                                select new {mayusculas = a.ToUpper(), minusculas = a.ToLower()}
                            );

            foreach (var item in resultado)
                Console.WriteLine("Mayus {0}, Minusc {1} ", item.mayusculas, item.minusculas);


            Console.WriteLine("Operacion < entre 2 array");            
            int[] num1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] num2 = { 1, 5, 6, 7, 9};
            var result  = from a in num1
                      from b in num2
                      where a < b
                      select new { a, b };

            foreach (var item in result)
                Console.WriteLine("{0} < {1} ", item.a, item.b);

            Console.WriteLine("Operacion > y < entre 2 array");

            var result1 = from a in num1
                      where a > 5
                      from b in num2
                      where a < b
                      select new { a, b };

            foreach (var item in result1)
                Console.WriteLine("{0} < {1} ", item.a, item.b);

        }

    }
}
