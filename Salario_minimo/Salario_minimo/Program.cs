using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double user, min = 1518.00, resultado;

            Console.Write("Digite o seu salario: ");
            user = double.Parse(Console.ReadLine());
            resultado = user / min;
            Console.WriteLine(resultado);
            
       

       

















        }
    }
}
