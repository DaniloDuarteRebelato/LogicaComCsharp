using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativo_positivo_ou_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.Write("digite numero desejado: ");
            num1 = double.Parse(Console.ReadLine());

            if(num1 > 0)
            {
                Console.WriteLine(" seu numero é positivo hehe ");
            }else if (num1 < 0)
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
