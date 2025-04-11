using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Desconto
    {
        public static void desconto()
        {
            double num1, des, total;
            Console.Write("digite o numero ");
            num1 = double.Parse(Console.ReadLine());
            if (num1 >= 100)
            {
                des = num1 * 0.10;
                total = num1 - des;
                Console.WriteLine(des);
            }
            else
            {
                des = num1 * 0.05;
                total = num1 - des;
                Console.WriteLine(des);
            }
        }






    }
}
