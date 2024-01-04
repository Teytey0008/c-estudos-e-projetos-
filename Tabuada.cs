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

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{contador} x {numero} = {numero * contador}");
            }
        }
    }
}
