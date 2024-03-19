using System;

namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mostrarMenu();
        }

        static void mostrarMenu()
        {
            bool continuar;

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
                continuar = decisao();

            } while (continuar);

        }

        static bool decisao()
        {

            string input = Console.ReadLine();
            if (input == "S" || input == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Adicao()
        {
            double primeiroNumero = obterValor("Adição\nDigite o primeiro número:");
            double segundoNumero = obterValor("Digite o segundo número:");


            double resultado = primeiroNumero + segundoNumero;
            Console.WriteLine($"O resultado da adição é: {resultado.ToString("F")}");
        }

        static void Subtracao()
        {
            double primeiroNumero = obterValor("Subtração\nDigite o primeiro número:");
            double segundoNumero = obterValor("Digite o segundo número:");


            double resultado = primeiroNumero - segundoNumero;
            Console.WriteLine($"O resultado da subtração é: {resultado.ToString("F")}");
        }

        static void Multiplicacao()
        {
            double primeiroNumero = obterValor("Multiplicação\nDigite o primeiro número:");
            double segundoNumero = obterValor("Digite o segundo número:");


            double resultado = primeiroNumero * segundoNumero;
            Console.WriteLine($"O resultado da multiplicação é: {resultado.ToString("F")}");
        }

        static void Divisao()
        {
            double primeiroNumero = obterValor("Divisão\nDigite o primeiro número:");
            double segundoNumero = obterValor("Digite o segundo número:");


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

        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double inputValor = Convert.ToDouble(Console.ReadLine());

            return inputValor;
        }
    }
}
