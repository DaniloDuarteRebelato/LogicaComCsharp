using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double pd, pe;

            Console.Write("keno, digite o tamanho da sua perna direita: ");
            pd = int.Parse(Console.ReadLine());


            Console.WriteLine("keno, digite o tamanho da sua perna esquerda: ");
            pe = int.Parse(Console.ReadLine());
            if(pe > pd)
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
