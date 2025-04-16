using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class PosicaoDeUmNumero
    {
        public static void posicaodeumnumero()
        {
            double num;

            Console.Write("Digite um número entre 1 á 20: ");
            num = double.Parse(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("O número ", num, " está entre 1 á 10.");
            }
            else if (num >= 11 && num <= 20)
            {
                Console.WriteLine("O número ", num, " está entre 11 á 20.");


            }
            else if (num > 20)
            {
                Console.WriteLine("O número ", num, " está acima de 20.");
            }
            else
            {
                Console.WriteLine("ERRO! Não foi digitado um número válido.");
            }

























        }
    }
}
