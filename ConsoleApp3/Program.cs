using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor1 , valor2,resultado;
            string texto1 = "";
            string texto2 = "";

            
            Console.WriteLine("Digite o valor 1:");
            texto1 = Console.ReadLine    (); 
            if (int.TryParse(texto1, out int valor3))
            {
                Console.WriteLine("Valor ok");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Valor incorreto digitado");
                Console.ReadKey();
            }


        }
    }
}
