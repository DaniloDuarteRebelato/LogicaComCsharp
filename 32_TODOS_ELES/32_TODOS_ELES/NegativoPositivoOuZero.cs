using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class NegativoPositivoOuZero
    {
        public static void negativopositivoezero()
        {
            double num1;
            Console.Write("digite numero desejado: ");
            num1 = double.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine(" seu numero é positivo hehe ");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("seu numero é negativo bb ");
            }
            else
            {
                Console.WriteLine("seu numero é 0 b");
            }
















        }
    }
}
