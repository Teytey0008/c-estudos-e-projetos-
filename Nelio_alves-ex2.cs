using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Exercicio
    {
        public static void Main()
        {
            Console.WriteLine("Entre com se nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("quantos quartos temna sua casa:");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com se ultimo nome, idade e altura(Mesma Linha)");
            string[] Vet = Console.ReadLine().Split(' ');
            string ultimo = Vet[0];
            int idade = int.Parse(Vet[1]);
            double altura = double.Parse(Vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
