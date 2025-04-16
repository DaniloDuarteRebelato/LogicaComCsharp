using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _32_TODOS_ELES
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("\n Menu de Atividades\n");
                Console.WriteLine("1 - 1 a 100");
                Console.WriteLine("2 - Algoritimo A e B");
                Console.WriteLine("3 - Calculo De Idade");
                Console.WriteLine("4 - Classificação de temperatura");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("6 - Escolha uma das opções: "); 
                Console.WriteLine("7 - Cadastro de Cliente");
                Console.WriteLine("8 - Cadastro de Fornecedor");
                Console.WriteLine("9 - Cadastro de Funcionario");
                Console.WriteLine("10 - Cadastro de Produtos");
                Console.WriteLine("11 - Cadastro de Pedido");
                Console.WriteLine("12 - Sair");
                Console.WriteLine("13 - Escolha uma das opções: ");
                Console.WriteLine("14 - Cadastro de Cliente");
                Console.WriteLine("15 - Cadastro de Fornecedor");
                Console.WriteLine("16 - Cadastro de Funcionario");
                Console.WriteLine("17 - Cadastro de Produtos");
                Console.WriteLine("18 - Cadastro de Pedido");
                Console.WriteLine("19 - Sair");
                Console.WriteLine("20 - Escolha uma das opções: "); 
                Console.WriteLine("21 - Cadastro de Cliente");
                Console.WriteLine("22 - Cadastro de Fornecedor");
                Console.WriteLine("23 - Cadastro de Funcionario");
                Console.WriteLine("24 - Cadastro de Produtos");
                Console.WriteLine("25 - Cadastro de Pedido");
                Console.WriteLine("26 - Sair");
                Console.WriteLine("27 - Escolha uma das opções: "); 
                Console.WriteLine("28 - Cadastro de Cliente");
                Console.WriteLine("29 - Cadastro de Fornecedor");
                Console.WriteLine("30 - Cadastro de Funcionario");
                Console.WriteLine("31 - Cadastro de Produtos");
                Console.WriteLine("32 - Cadastro de Pedido");
                Console.WriteLine("33 - Cadastro de Pedido");
                Console.WriteLine("34 - Cadastro de Pedido");
                Console.WriteLine("35 - Cadastro de Pedido");
                Console.WriteLine("36 - Cadastro de Pedido");
                Console.WriteLine("37 - Cadastro de Pedido");

                // ! = diferente
                //TryParse Eliminar ou comparar 
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção Invalida, Digite Novamente");
                }

                switch (opcao)
                {
                    case 1:

                        zero.Zero();
                        break;
                    case 2:

                        AlgoritimoAeB.Algoritimoaeb();
                        break;
                    case 3:
                        
                        Bissexto.bissexto();
                        break;
                    case 4:

                        CasaDeShow.casadeshow();
                        break;
                    case 5:

                        CalculoDeIdade.calculodeidade();
                        break;


                    case 6:

                        Desconto.desconto();
                        break;
                    case 7:

                        DiaDaSemana.diadasemana();
                        break;
                    case 8:

                        Ingressos.ingressos();
                        break;
                    case 9:

                        PixEDinheiro.pixedinheiro();
                        break;
                    case 10:

                        IdadeDirigir.idadedirigir();
                        break;
                    case 11:

                        IMC.imc();
                        break;
                    case 12:

                        ImparPar.imparpar();
                        break;
                    case 13:

                        Keno.keno();
                        break;
                    case 14:

                        MaiorDeIdade.maiordeidade();
                        break;
                    case 15:

                        MaioridadePenal.maioridadepenal();
                        break;
                    case 16:

                        Média.media();
                        break;
                    case 17:

                        MédiaBimestral.mediabimestral();
                        break;
                    case 18:

                        Menornumero.menornumero();
                        break;
                    case 19:

                        MultiploDe5e6.multiplode5e6();
                        break;
                    case 20:

                        NegativoPositivoOuZero.negativopositivoezero();
                        break;
                    case 21:
                        numeroentre0e90.Numeroentre0e90();
                        break;
                    case 22:
                        NumerosIguais.numerosiguais();
                        break;
                    case 23:
                        ParesEnquanto.paresenquanto();
                        break;
                    case 24:
                        Pecas.pecas();
                        break;
                    case 25:
                        Pescador.pescador();
                        break;
                    case 26:
                        PosicaoDeUmNumero.posicaodeumnumero();
                        break;
                    case 27:
                        SalarioMinimo.salariominimo();
                        break;
                    case 28:
                        Senha.senha();
                        break;
                    case 29:
                        TodosMatematica.todosmatematica();
                        break;
                    case 30:
                        Troco.troco();
                        break;
                        
                    case 31:
                        ValidarUmTriangulo.validarumtriangulo();
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
    }
}
