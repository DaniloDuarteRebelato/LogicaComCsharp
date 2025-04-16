using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Senha
    {
        public static void senha()
        {
            string senhaUsuario = "alunoooooo";
            int tamanhoSenha;

            tamanhoSenha = senhaUsuario.Length;

            if (tamanhoSenha < 8)
            {
                Console.WriteLine("A senha deve ter 8 caracteres, tente novamente !");
            }

            // Verifica se a senha contém pelo menos uma letra
            // Verifica se a senha contém pelo menos um número
            else if (senhaUsuario.Any(char.IsLetter) && senhaUsuario.Any(char.IsDigit))
            {
                Console.WriteLine("Senha valida");
            }
            else
            {
                Console.WriteLine("Senha invalida");
            }

















        }
    }
}
