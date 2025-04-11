using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class CasaDeShow
    {
        public static void casadeshow()
        {
            //crie um sistema para entrar na casa de show
            //apresentando as seguintes informações: RG a pulseira inviolável e seu numero de telefone.
            //se for de menor a entrada e somente com pais responsavel, Se caso for +18 não e necessário entrar acompanhado.
            //se tiver tudo ok a entrada estará liberada, tenha um bom show! 


            string rg, pulseira, telefone, responsavel;
            int idade;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
╔══════════════════════════════════════════════════════════════════════════════════════════╗
║.------..------..------..------.     .------..------.     .------..------..------..------.║
║|C.--. ||A.--. ||S.--. ||A.--. |.-.  |D.--. ||E.--. |.-.  |S.--. ||H.--. ||O.--. ||W.--. |║
║| :/\: || (\/) || :/\: || (\/) ((5)) | :/\: || (\/) ((5)) | :/\: || :/\: || :/\: || :/\: |║
║| :\/: || :\/: || :\/: || :\/: |'-.-.| (__) || :\/: |'-.-.| :\/: || (__) || :\/: || :\/: |║
║| '--'C|| '--'A|| '--'S|| '--'A| ((1)) '--'D|| '--'E| ((1)) '--'S|| '--'H|| '--'O|| '--'W|║
║`------'`------'`------'`------'  '-'`------'`------'  '-'`------'`------'`------'`------'║
╚══════════════════════════════════════════════════════════════════════════════════════════╝");

            while (true)
            {
                Console.ResetColor();
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("Digite seu RG: ");
                rg = Console.ReadLine();

                Console.Write("Está com a pulseira inviolável? (s/n): ");
                pulseira = Console.ReadLine().ToLower();

                Console.Write("Digite seu número de telefone: ");
                telefone = Console.ReadLine();

                if (idade < 18)
                {
                    Console.Write("Está acompanhado dos pais ou responsável? (s/n): ");
                    responsavel = Console.ReadLine().ToLower();

                    if (responsavel == "s" && pulseira == "s")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Entrada liberada. Tenha um bom show!");
                        break;
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada negada para menores desacompanhados ou sem pulseira.");
                    }
                }
                else
                {
                    if (pulseira == "s")
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Entrada liberada. Tenha um bom show!");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada negada. É necessário estar com a pulseira.");
                    }
                }

                Console.WriteLine();
            }




















    }
}
