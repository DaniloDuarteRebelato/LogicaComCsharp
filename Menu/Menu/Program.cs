using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um sistema de menu em cada opção cadastre um item, controlando o acesso do teclado.

                int opcao = 1;
                while (opcao != 0)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(@"
    ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
    ████╗░████║██╔════╝████╗░██║██║░░░██║
    ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
    ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
    ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
    ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");

                Console.ResetColor();
                Console.WriteLine("\n Menu de Cadastro\n");
                Console.WriteLine("1 - Cadastro de Cliente");
                Console.WriteLine("2 - Cadastro de Fornecedor");
                Console.WriteLine("3 - Cadastro de Funcionario");
                Console.WriteLine("4 - Cadastro de Produtos");
                Console.WriteLine("5 - Cadastro de Pedido");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma das opções: ");




                // ! = diferente
                //TryParse Eliminar ou comparar 
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção Invalida, Digite Novamente");
                } 

               switch(opcao)
                {
                    case 1:

                        Cadastro_cliente.CadastrarCliente();
                        break;
                    case 2:

                        CadastrarFornecedor();
                        break;
                    case 3:

                        CadastrarFuncionario();
                        break;
                    case 4:

                        CadastrarProduto();
                        break;
                    case 5:

                        CadastrarPedido();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Tente novamente"); 
                        break;
                }
                
                
                
                
                
                
                
                
                
                
                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                } 





            }
        }

    

        static void CadastrarFornecedor()
        {
            Console.WriteLine("\nCadastro de Fornecedor");
            Console.WriteLine("Digite o código de cadastro do fornecedor: ");
            string forncedor = Console.ReadLine();
            Console.WriteLine("Digite o nome do fornecedor: ");
            string nomefornecedor = Console.ReadLine();
            Console.WriteLine($"Código {forncedor} do fornecedor {nomefornecedor} cadastrado com sucesso!");
        }

        static void CadastrarFuncionario()
        {
            Console.WriteLine("\nCadastro de Funcionario");
            Console.WriteLine("Digite o nome do funcionario: ");
            string funcionario = Console.ReadLine();
            Console.WriteLine($"Funcionario {funcionario} cadastrado com sucesso!");
        }

        static void CadastrarProduto()
        {
            Console.WriteLine("\nCadastro de produtos");
            Console.WriteLine("Digite o nome do produto: ");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produto: ");
            string quantidadeproduto = Console.ReadLine();
            Console.WriteLine($"Produto: {nomeproduto} \nquantidade: {quantidadeproduto} \nCadastrados com sucesso");
        }

        static void CadastrarPedido()
        {
            Console.WriteLine("\nCadastro de pedido");
            Console.WriteLine("Digite o codigo do produto: ");
            string codproduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produto para entrega: ");
            string quantiproduto = Console.ReadLine();
            Console.WriteLine("Digite o nome do comprador: ");
            string comprador = Console.ReadLine();
            Console.WriteLine($"Código do produto: {codproduto} \nQuantidade do produto: {quantiproduto} \nNome do comprador: {comprador}");
        }

    }
}
