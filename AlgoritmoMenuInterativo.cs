using System;

namespace CSHARP.Models
{
    class Program
    {
        static void Main()
        {
            string opcao;

            while (true)
            {
                Console.WriteLine("Digite sua opcao");
                Console.WriteLine("1- Cadastrar Cliente");
                Console.WriteLine("2- Buscar Cliente ");
                Console.WriteLine("3- Apagar Cliente ");
                Console.WriteLine("4- Encerrar ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de Cliente");
                        break;

                    case "2":
                        Console.WriteLine("Busca de Cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar Cliente");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }
    }
}



         
