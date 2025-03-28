using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_bimestral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 4: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if(media >= 7)
            {
                Console.WriteLine("Aprovado com média: ", media);
            }
            else
            {
                Console.WriteLine("reprovado com média: " + media);
            }




















        }
    }
}
