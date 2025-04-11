 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class MaiorDeIdade
    {

        public static void maiordeidade()
        {
            int idade;
            Console.Write("Qual a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("VOCE È MAIOR DE IDADE");
            }
            else
            {
                Console.WriteLine("VOCE È PRATICAMENTE MAIOR DE IDADE");
            }










        }
}
