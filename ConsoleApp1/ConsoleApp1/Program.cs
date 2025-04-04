using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int capacidadeMaxima = 100;  // Máximo de 5 vagas
            int vagasOcupadas = 0;

            while (true)
            {
                Console.WriteLine("\n1 - Entrada de carro");
                Console.WriteLine("2 - Saída de carro");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    if (vagasOcupadas < capacidadeMaxima)
                    {
                        vagasOcupadas++;
                        Console.WriteLine("Carro entrou!");
                    }
                    else
                    {
                        Console.WriteLine("Estacionamento cheio!");
                    }
                }
                else if (opcao == 2)
                {
                    if (vagasOcupadas > 0)
                    {
                        vagasOcupadas--;
                        Console.WriteLine("Carro saiu!");
                    }
                    else
                    {
                        Console.WriteLine("Não há carros no estacionamento.");
                    }
                }
                else if (opcao == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }


            }
        }
    }
}





















