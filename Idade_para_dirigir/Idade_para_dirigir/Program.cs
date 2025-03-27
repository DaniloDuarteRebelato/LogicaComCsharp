using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_para_dirigir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade;


            Console.Write("insira sua idade ");
            idade = double.Parse(Console.ReadLine());
            if(idade > 17)
            {
                Console.WriteLine("pode dirigir");
            }else
            {
                Console.WriteLine("não pode dirigir");
            }
                    

























        }
    }
}
