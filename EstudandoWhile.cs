using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CSHARP.Models
{
    public class Tabuada
    {
        public static void Main()
        {
            int numero = 1;
            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine($"{contador}* Execução: {numero} x {contador} = {numero * contador}");
                contador++;
                
            }
        }
    }
}
