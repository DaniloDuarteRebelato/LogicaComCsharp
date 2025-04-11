using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class IdadeDirigir
    {
        public static void idadedirigir()
        {
            double idade;


            Console.Write("insira sua idade ");
            idade = double.Parse(Console.ReadLine());
            if (idade > 17)
            {
                Console.WriteLine("pode dirigir");
            }
            else
            {
                Console.WriteLine("não pode dirigir");
            }
        }












    }
}
