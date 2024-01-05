using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CSHARP.Models
{
    class Program
    {
        static void Main()
        {
            int soma = 0, numero = 0;

            do
            {
                Console.WriteLine("Digite um numero (0 para parar!)");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while (numero != 0);

            Console.WriteLine($"A soma dos numeros digitados foi: {soma}");
        }
    }
}
