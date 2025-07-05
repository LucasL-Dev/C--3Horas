using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace C__3Horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Finalnumeros = 0;
            Console.WriteLine("Digite um número: ");
            double number01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Outro Númro: ");
            double number02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Operação desejada (+, -, /, *)");
            string operacao = (Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    Finalnumeros = number01 + number02;
                    Console.WriteLine(Finalnumeros);
                    break;
                case "-":
                    Finalnumeros = number01 - number02;
                    Console.WriteLine(Finalnumeros);
                    break;
                case "*":
                    Finalnumeros = number01 * number02;
                    Console.WriteLine(Finalnumeros);
                    break;
                case "/":
                    Finalnumeros = number01 / number02;
                    Console.WriteLine(Finalnumeros);
                    break;
                default:
                    Console.WriteLine("Dado Incorreto, seu burro");
                    break;
            }
        }
    }
}
