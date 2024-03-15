using System;

namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora Tabajara | Academia de programação 2024!\n");
                Console.WriteLine("1- Adição.\n2- Subtração.\n3- Multiplicação.\n4- Divisão.\n5- Fechar.");

                string operador = Console.ReadLine();

                switch (operador)
                {
                    case "1":
                        Adicao();
                        break;

                    case "2":
                        Subtracao();
                        break;

                    case "3":
                        Multiplicacao();
                        break;

                    case "4":
                        Divisao();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        break;
                }

                Console.WriteLine("\nDeseja realizar outra operação? (S/N)");
            } while (Console.ReadLine() == "S" || Console.ReadLine() == "s");
        }

        static void Adicao()
        {
            Console.WriteLine("Adição\nDigite o primeiro número:");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = primeiroNumero + segundoNumero;
            Console.WriteLine($"O resultado da adição é: {resultado.ToString("F")}");
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração\nDigite o primeiro número:");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = primeiroNumero - segundoNumero;
            Console.WriteLine($"O resultado da subtração é: {resultado.ToString("F")}");
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação\nDigite o primeiro número:");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = primeiroNumero * segundoNumero;
            Console.WriteLine($"O resultado da multiplicação é: {resultado.ToString("F")}");
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão\nDigite o primeiro número:");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            if (segundoNumero == 0)
            {
                Console.WriteLine("A operação é inválida, o divisor não pode ser igual a zero!");
            }
            else
            {
                double resultado = primeiroNumero / segundoNumero;
                Console.WriteLine($"O resultado da divisão é: {resultado.ToString("F")}");
            }
        }
    }
}
