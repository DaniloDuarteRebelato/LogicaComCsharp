﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maioridade_penal
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
                Console.WriteLine("vc tem maior idade penal");
            }
            else
            {
                Console.WriteLine("vc tem menor de idade penal");
            }
            
   
                


        














    }
    }
}
