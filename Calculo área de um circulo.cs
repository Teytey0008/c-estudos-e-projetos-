using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Calculo
    {
        static void Main()
        {
            Console.WriteLine("Escreva o Raio do Círculo:");
            // Usar CultureInfo.InvariantCulture para garantir que a entrada seja interpretada corretamente
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            // Utilizar interpolação de strings para tornar o código mais legível
            Console.WriteLine($"O valor da área do círculo é A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}


