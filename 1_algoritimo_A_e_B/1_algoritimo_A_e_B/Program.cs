using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_algoritimo_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B 
            //forem iguais, deverá somar os dois valores,


            int num1, num2, resultado;

            Console.Write("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                resultado = num1 + num2;
                Console.WriteLine("Os números são iguais e sua soma é: : " + resultado);
            } else if (num1 != num2)
            {
                resultado = num1 * num2;
                Console.WriteLine("Os números são diferentes e sua multiplicação é: " + resultado);
            }
            
            






































        }
    }
}
