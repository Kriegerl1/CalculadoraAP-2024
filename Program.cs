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
                Console.WriteLine("1- Adição.\n2- Subtração.\n3- Multiplicação.\n4- Divisão.\n5- Tabuada.\n6- Fechar.");

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
                        Tabuada();
                        break;

                    case "6":
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
            double primeiroNumero = obterValor<double>("\n\n\t\tAdição\nDigite o primeiro número:");
            double segundoNumero = obterValor<double>("Digite o segundo número:");


            double resultado = primeiroNumero + segundoNumero;
            Console.WriteLine($"O resultado da adição é: {resultado.ToString("F")}");
        }

        static void Subtracao()
        {
            double primeiroNumero = obterValor<double>("\n\n\t\tSubtração\nDigite o primeiro número:");
            double segundoNumero = obterValor<double>("Digite o segundo número:");


            double resultado = primeiroNumero - segundoNumero;
            Console.WriteLine($"O resultado da subtração é: {resultado.ToString("F")}");
        }

        static void Multiplicacao()
        {
            double primeiroNumero = obterValor<double>("\n\n\t\tMultiplicação\nDigite o primeiro número:");
            double segundoNumero = obterValor<double>("Digite o segundo número:");


            double resultado = primeiroNumero * segundoNumero;
            Console.WriteLine($"O resultado da multiplicação é: {resultado.ToString("F")}");
        }

        static void Divisao()
        {
            double primeiroNumero = obterValor<double>("\n\n\t\tDivisão\nDigite o primeiro número:");
            double segundoNumero = obterValor<double>("Digite o segundo número:");


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

        static void Tabuada()
        {
            int numeroDaTabuada = obterValor<int>("\n\n\t\tTabuada\nDigite um número para gerar a tabuada: "); 

            if (numeroDaTabuada == 0)
            {
                Console.WriteLine("A tabuada de zero, é zero!");
            }
            else
            {
                Console.WriteLine($"Tabuada de {numeroDaTabuada}: ");
                for (int i = 0; i <= 10; i++)
                {
                    int resultado = numeroDaTabuada * i;

                    Console.WriteLine($"\t\t{i.ToString().PadLeft(3)} X {numeroDaTabuada} = {resultado}");
                }
            }
        }

        static double obterValor(string texto) //Antigo, pode dar erro.
        {
            Console.WriteLine(texto);

            double inputValor = Convert.ToDouble(Console.ReadLine());

            return inputValor;
        }

        static Dinamica obterValor<Dinamica>(string texto)
        {
            Console.WriteLine(texto);

            string inputValor = Console.ReadLine();

            try
            {
                return (Dinamica)Convert.ChangeType(inputValor, typeof(Dinamica)); // Recebe um parâmetro dinâmico, que é identificado junto ao utilizador e só recebe aquele tipo.
            }                                                                                                                                                                                                               // Ex. Linha 124 e linha 107;
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido, tente novamente!");
                return obterValor<Dinamica>(texto);
            }

        }
    }
}
