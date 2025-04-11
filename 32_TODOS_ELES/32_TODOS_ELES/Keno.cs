using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Keno
    {
        public static void keno()
        {
            double pd, pe;

            Console.Write("keno, digite o tamanho da sua perna direita: ");
            pd = int.Parse(Console.ReadLine());


            Console.WriteLine("keno, digite o tamanho da sua perna esquerda: ");
            pe = int.Parse(Console.ReadLine());
            if (pe > pd)
            {
                Console.WriteLine("ala o cara é cotoco da perna direita kakakakak lol ");
            }
            else
            {
                Console.WriteLine("normal");
            }

        }

















    }
}
