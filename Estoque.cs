#(CLASSE PRODUTO)

  using System.Globalization;

namespace PrimeiroProjeto

{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }
        
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }





        public override string ToString()
        {
            return Nome + ", $ " +
                   Preco.ToString("F2", CultureInfo.InvariantCulture) +
                   ", " + Quantidade + " unidades, Total: $ " +
                   ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

#(PROGRAMA)

  using System;
using System.Globalization;
namespace PrimeiroProjeto

{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();

            Console.Write("Preço do produto:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("quantidade no estoque : ");
             p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Informações do produto :" + p);

            Console.WriteLine();
            Console.WriteLine("DIGITE O NUMERO DE PRODUTOS A SER ADICIONADOS");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados : " + p);

            Console.WriteLine();
            Console.WriteLine("Informações do produto :" + p);

            Console.WriteLine();
            Console.WriteLine("DIGITE O NUMERO DE PRODUTOS A SER REMOVIDO DO ESTOQUE");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados : " + p);






        }
    }
}



