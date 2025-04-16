using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Troco
    {
        public static void troco()
        {
            int valor;

            Console.Write("Digite o valor: ");
            valor = int.Parse(Console.ReadLine());


            if (valor >= 100)
            {
                Console.WriteLine("1 nota de 100\n");
                valor = valor - 100;
            }
            if (valor >= 50)
            {
                Console.WriteLine("1 nota de 50\n");
                valor = valor - 50;
            }
            if (valor >= 20)
            {
                Console.WriteLine("1 nota de 20\n");
                valor = valor - 20;
            }
            if (valor >= 10)
            {
                Console.WriteLine("1 nota de 10\n");
                valor = valor - 10;
            }
            if (valor >= 5)
            {
                Console.WriteLine("1 nota de 5\n");
                valor = valor - 5;
            }
            if (valor >= 2)
            {
                Console.WriteLine("1 nota de 2\n");
                valor = valor - 2;
            }
            if (valor >= 1)
            {
                Console.WriteLine("1 nota de 1\n");
                valor = valor - 1;
            }
















        }
    }
}
