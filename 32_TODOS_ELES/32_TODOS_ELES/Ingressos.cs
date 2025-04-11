using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Ingressos
    {
        public static void ingressos()
        {
            double total_compra, valor_total, desconto;

            Console.Write("Digite o total da compra de ingressos: ");
            total_compra = double.Parse(Console.ReadLine());

            desconto = total_compra * (10 / 100);
            valor_total = total_compra - desconto;

            if (total_compra > 200)
            {
                Console.WriteLine("Você tem direito a um desconto de: " + desconto + " sendo assim você irá pagar somente R$" + valor_total);
            }
            else
            {
                Console.WriteLine("Você não irá receber desconto e terá que pagar o valor de R$" + total_compra);


            }
        }







    }
}
