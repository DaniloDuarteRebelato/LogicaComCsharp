using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Pescador
    {
        public static void pescador()
        {
            double peso;
            double sobra;
            Console.Write("digite o peso pescado: ");
            peso = int.Parse(Console.ReadLine());
            sobra = (peso - 50) * 4;
            Console.WriteLine(sobra);













        }
    }
}
