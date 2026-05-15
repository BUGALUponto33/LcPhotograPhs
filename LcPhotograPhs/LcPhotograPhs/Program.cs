using System;
using System.Threading;

namespace LcPhotograPhs
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(@"
██╗░░░░░░█████╗░██████╗░██╗░░██╗░█████╗░████████╗░█████╗░
██║░░░░░██╔══██╗██╔══██╗██║░░██║██╔══██╗╚══██╔══╝██╔══██╗
██║░░░░░██║░░╚═╝██████╔╝███████║██║░░██║░░░██║░░░██║░░██║
██║░░░░░██║░░██╗██╔═══╝░██╔══██║██║░░██║░░░██║░░░██║░░██║
███████╗╚█████╔╝██║░░░░░██║░░██║╚█████╔╝░░░██║░░░╚█████╔╝
╚══════╝░╚════╝░╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░░╚════╝░
");
                
                Console.ResetColor();

                Console.WriteLine("\nBem vindo ao sistema LcPhotograPhs\n");

                Console.WriteLine("1 - Clientes");
                Console.WriteLine("2 - Serviços");
                Console.WriteLine("3 - Fornecedores");
                Console.WriteLine("4 - Agenda");
                Console.WriteLine("5 - Equipamentos");
                Console.WriteLine("6 - Sair");

                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();
               switch (opcao)
                {
                    case 1:
                        Clientes();
                        break;
                    case 2:
                        Servicos();
                        break;
                    case 3:
                        Fornecedores();
                        break;
                    case 4:
                        Agenda();
                        break;
                    case 5:
                        Equipamentos();
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }

        static void Clientes()
        {
            Console.WriteLine("\n=== CLIENTES ===\n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Serviço contratado: ");
            string servico = Console.ReadLine();
            Console.Write("Valor pago: ");
            string valor = Console.ReadLine();
            Console.WriteLine("\nCliente cadastrado!");
            Thread.Sleep(1500);
        }
        static void Servicos()
        {
            Console.WriteLine("\n=== SERVIÇOS ===\n");
            Console.Write("ensaios : ");
            string tipo = Console.ReadLine();
            Console.Write("eventos: ");
            string nome = Console.ReadLine();
           Console.Write("album : ");
            Console.Write("impressao : ");
            Console.Write("nome do servico : ");
            Console.WriteLine("\nServiço cadastrado!");                 
            Thread.Sleep(1500);
        }

        static void Fornecedores()
        {
            Console.WriteLine("\n=== FORNECEDORES ===\n");
            Console.Write("Nome do fornecedor/maquiador: ");
            string nome = Console.ReadLine();
            Console.Write("Valor pago: ");
            string valor = Console.ReadLine();
            Console.Write("Serviços fornecidos: ");
            string servico = Console.ReadLine();
            Console.Write("Tipo de serviço: ");
            string tipo = Console.ReadLine();
            Console.WriteLine("\nFornecedor cadastrado!");
            Thread.Sleep(1500);
        }

        static void Agenda()
        {
            Console.WriteLine("\n=== AGENDA ===\n");
            Console.Write("Data do ensaio: ");
            string data = Console.ReadLine();
            Console.Write("Horário: ");
            string horario = Console.ReadLine();
            Console.Write("Cliente: ");
            string cliente = Console.ReadLine();
            Console.Write("Local das fotos: ");
            string local = Console.ReadLine();
            Console.WriteLine("\nAgenda cadastrada!");
            Thread.Sleep(1500);
        }

        static void Equipamentos()
        {
            Console.WriteLine("\n=== EQUIPAMENTOS ===\n");
            Console.Write("Câmeras: ");
            string camera = Console.ReadLine();
            Console.Write("Lentes: ");
            string lente = Console.ReadLine();
            Console.Write("Flashes: ");
            string flash = Console.ReadLine();
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Estado: ");
            string estado = Console.ReadLine();

            Console.WriteLine("\nEquipamento cadastrado!");
            Thread.Sleep(1500);
        }
    }
}