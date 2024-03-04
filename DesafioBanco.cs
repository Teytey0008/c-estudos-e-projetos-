using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Banco
    {
        public static void Main()
        {

            ContaBancaria conta;
            
            Console.Write("Entre o numero da conta : ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial ? (s/n) : ");
            char resp = char.Parse(Console.ReadLine());
            
        
            if (resp == 's'  || resp == 'S')
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");

                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
                     
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre o valor para deposito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre o valor para saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);









        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
namespace PrimeiroProjeto
{
    class ContaBancaria 
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
          
            
            
        }
        
        public ContaBancaria(int numero , string titular, double depositoInicial ) : this (numero, titular)
        {
            Deposito(depositoInicial);

        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        
        public void Saque (double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0; //TAXA
        }

        public override string ToString()
        {
            return "conta"
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }




}









        }
    }
}
