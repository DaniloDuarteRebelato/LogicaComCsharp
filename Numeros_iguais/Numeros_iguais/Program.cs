using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_iguais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2;

            Console.Write("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            num2 = double.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Números iguais");
            }
            else
            {
                Console.WriteLine("Esse números não são iguais");
            }
               
    
         


















        }
    }
}
