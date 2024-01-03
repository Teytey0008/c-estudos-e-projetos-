using System;

class Program 
{
    static void Main()
 {
   int quantidadeEmEstoque = 3;
   int quantidadeCompra = 0;
   bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

   Console.WriteLine($"quantidade em estoque : {quantidadeEmEstoque}");
   Console.WriteLine($"quantidade de compra : {quantidadeCompra}");
   Console.WriteLine($"É possivel realizar essa venda ? : {possivelVenda}");

   if (quantidadeCompra == 0)
   {
    Console.WriteLine("Venda inválida");
   }
   else if (possivelVenda)
   {
     Console.WriteLine("Venda Realizada");
   }
   else
   {
    Console.WriteLine("Desculpe,não temso a qntdade em Estoque.");
   }
 }
}
