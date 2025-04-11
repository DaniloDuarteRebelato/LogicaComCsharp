using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class DiaDaSemana
    {
        public static void diadasemana()
        {
            int diaDaSemana;

            Console.Write("Digite o numero da semana: ;");
            diaDaSemana = int.Parse(Console.ReadLine());

            if (diaDaSemana > 7)
            {
                Console.WriteLine("Numero da semana invalida");


            }
            else if (diaDaSemana == 1 || diaDaSemana == 6)
            {
                Console.WriteLine("Final de semana");

            }
            else
            {
                Console.WriteLine("Dia da semana normal");
            }

        }















    }
}
