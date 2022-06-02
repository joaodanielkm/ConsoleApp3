using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
aswdfsd
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultado;
            string texto1 = "";
            string operacao = "";
            string texto2 = "";


            Console.WriteLine("Digite o valor 1:");
            texto1 = Console.ReadLine();
            Console.WriteLine("Escolha uma operação(+ - x / ou %)");
            operacao = Console.ReadLine();
            Console.WriteLine("Digite o valor 2:");
            texto2 = Console.ReadLine();
            if (decimal.TryParse(texto1, out decimal valor1))
            {
                if (decimal.TryParse(texto2, out decimal valor2))
                {
                    switch (operacao)
                    {
                        case "+":
                            resultado = valor1 + valor2;
                            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);
                            break;
                        case "-":
                            resultado = valor1 - valor2;
                            Console.WriteLine(valor1 + " - " + valor2 + " = " + resultado);
                            break;
                        case "x":
                            resultado = valor1 * valor2;
                            Console.WriteLine(valor1 + " x " + valor2 + " = " + resultado);
                            break;
                        case "/":
                            resultado = valor1 / valor2;
                            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);
                            break;
                        case "%":
                            resultado = valor1 % valor2;
                            Console.WriteLine(valor1 + " % " + valor2 + " Resto ) " + resultado);
                            break;
                        default:
                            Console.WriteLine("Nenhuma operacao selecionada!");
                            break;
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Favor digitar um numero!");
                }
            }
            else
            {
                Console.WriteLine("Favor digitar um numero!");
                Console.ReadKey();
            }
        }
    }
}
