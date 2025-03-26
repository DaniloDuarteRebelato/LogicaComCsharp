using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_ou_menor_de_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Qual a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if(idade >= 18)
            {
                Console.WriteLine("VOCE È MAIOR DE IDADE");
            }
            else
            {
                Console.WriteLine("VOCE È PRATICAMENTE MAIOR DE IDADE");
            }
            

    



        }
    }
}
