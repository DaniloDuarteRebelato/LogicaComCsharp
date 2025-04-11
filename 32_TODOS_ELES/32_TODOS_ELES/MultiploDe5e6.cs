using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class MultiploDe5e6
    {
        public static void multiplode5e6()
        {
            double num1, num3, num5;

            Console.Write("digite o numero ");
            num1 = double.Parse(Console.ReadLine());



            if (num1 % 5 == 0)
            {
                Console.WriteLine("numero é multiplo de 5 ");
            }
            else if (num1 % 3 == 0)
            {
                Console.WriteLine("numero é multiplo de 3 ");

            }
            else
            {
                Console.WriteLine("ne nao ");
            }




        }















    }
}
