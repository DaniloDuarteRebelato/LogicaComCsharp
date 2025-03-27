using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pecas;
            int total;
            int resultado;

            Console.Write("Quantidades de peças armazenadas: ");
            pecas = int.Parse(Console.ReadLine());  
            for(total = 400; pecas < 400; pecas++)
            {
                resultado = total - pecas;
                Console.WriteLine("O total de peças descartadas foram: ", resultado);
            }
               





















        }
    }
}
