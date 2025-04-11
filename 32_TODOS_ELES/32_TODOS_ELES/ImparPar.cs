using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class ImparPar
    {
        public static void imparpar()
        {
            int impar;


            for (impar = 1; impar < 100; impar++)
            {
                impar = impar + 4 / 2;
                Console.WriteLine("Números impars: " + impar, "\n");
            }

        }












    }
}
