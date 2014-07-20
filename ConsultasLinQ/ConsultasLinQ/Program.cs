using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasLinQ
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numero = { 2, 3, 7, 8, 2, 2, 32, 3, 32 };
            int[] resultado = (
                                from n in numero
                                where n > 4
                                select n).ToArray();
      
            Display(resultado);

            resultado = (from n in numero
                             where n > 4
                             select n).Take(2).ToArray();

            Display(resultado); 
            resultado = (from n in numero
                         orderby n descending
                         select n).Distinct().ToArray();

            Display(resultado);

            Console.WriteLine("Números Pares");
            resultado = (
                          from n in numero
                          orderby n descending
                          where (n % 2) == 0
                          select n).Distinct().ToArray();
            Display(resultado);

            Console.WriteLine("Números Impares");
            resultado = (
                          from n in numero
                          orderby n descending
                          where (n % 2) == 1
                          select n).Distinct().ToArray();
            Display(resultado);

        }

        private static void Display(int[] resultado)
        {
            foreach (int item in resultado)
            {
                Console.WriteLine("{0,2}", item);
            }
            Console.WriteLine();
            
        }
    }

    
}
