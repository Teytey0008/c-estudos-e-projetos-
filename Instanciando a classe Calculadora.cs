using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CSHARP.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($" {x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($" {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($" {x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            // Certifique-se de verificar se o divisor não é zero antes de realizar a divisão
            if (y != 0)
            {
                Console.WriteLine($" {x} / {y} = {x / y}");
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero!");
            }
        }
    }

    
}


using CSHARP.Models;

Calculadora calc = new Calculadora();

calc.Somar(10,10);
calc.Subtrair(10,10);
calc.Multiplicar(10,10);
calc.Dividir(10,10);



