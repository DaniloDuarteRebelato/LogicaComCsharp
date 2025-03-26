using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma__Divisao__subtração__multiplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divi, num, num2, multi, sub, soma;
            Console.Write("Digite o primeiro numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            sub = num - num2;
            multi = num * num2;
            soma = num + num2;
            divi = num / num2;
            Console.WriteLine("O resultado é: " + sub);
            Console.WriteLine("\n O resultado é: " + multi);
            Console.WriteLine("\n O resultado é: " + divi);
            Console.WriteLine("\n O resultado é: " + soma);

 







        }
    }
}
