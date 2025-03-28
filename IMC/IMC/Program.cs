using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma 
            //pessoa, leia o seu peso e sua altura e imprima na tela sua condição

            double altura, peso, resultado;
           
            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }else if(resultado > 18.6 && resultado < 24.9)
            {
                Console.WriteLine("Peso ideal (parabéns)");
            }else if (resultado > 25 && resultado < 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
            }else if (resultado > 30 && resultado < 34.9)
            {
                Console.WriteLine("Levemente acima do peso");            
            }else if(resultado > 35 && resultado < 39.9)
            {
                Console.WriteLine("Obesidade grau II (severa)");
            }else if (resultado > 40)
            {
                Console.WriteLine("Obesidade grau III (mórbida)");
            }






















        }
    }
}
