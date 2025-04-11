using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Temperatura
    {

        public static void temperatura()
        {
            int ano_nascimento, ano_atual, Idade;
            // declara as variaveis inteiro
            Console.WriteLine("Digite o ano do seu nascimento: ");
            //console.Write = escreva

            ano_nascimento = int.Parse(Console.ReadLine());
            // int.Parse - Converte textos em números

            Console.WriteLine("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            Idade = ano_atual - ano_nascimento;
            Console.WriteLine("Sua Idade é " + Idade + " anos");
        }













    }
}
