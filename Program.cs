namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora Tabajara 2024\nSelecione uma opção:");
            Console.WriteLine("1- Adição.\n2- Subtração.\n3- Multiplicação.\n4- Divisão.\n5- Fechar.\n");

            bool controlador = true;
            Console.WriteLine("Digite: ");
            string operador = Console.ReadLine();


            do
            {
                Console.Clear();

                switch (operador)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Adição\nDigite o primeiro número: ");

                        string primeiroNumeroString = Console.ReadLine();
                        double primeiroNumero = Convert.ToDouble(primeiroNumeroString);
                        Console.WriteLine("Digite o segundo número: ");
                        string segundoNumeroString = Console.ReadLine();
                        double segundoNumero = Convert.ToDouble(segundoNumeroString);

                        double resultado = primeiroNumero + segundoNumero;
                        Console.WriteLine("O resultado da sua operação é: " + resultado.ToString("F"));

                        Console.WriteLine("Deseja continuar? (S/N)");
                        string repeat = Console.ReadLine();


                        if (repeat == "S" || repeat == "s")
                        {
                            operador = "1";
                        }
                        else
                        {
                            controlador = false;
                        }
                        break;
                       

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Subtração\nDigite o primeiro número: ");

                        primeiroNumeroString = Console.ReadLine();
                        primeiroNumero = Convert.ToDouble(primeiroNumeroString);
                        Console.WriteLine("Digite o segundo número: ");
                        segundoNumeroString = Console.ReadLine();
                        segundoNumero = Convert.ToDouble(segundoNumeroString);

                        resultado = primeiroNumero - segundoNumero;
                        Console.WriteLine("O resultado da sua operação é: " + resultado.ToString("F"));

                        Console.WriteLine("Deseja continuar? (S/N)");
                        repeat = Console.ReadLine();

                        if (repeat == "S" || repeat == "s")
                        {
                            operador = "2";
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Multiplicação\nDigite o primeiro número: ");

                        primeiroNumeroString = Console.ReadLine();
                        primeiroNumero = Convert.ToDouble(primeiroNumeroString);
                        Console.WriteLine("Digite o segundo número: ");
                        segundoNumeroString = Console.ReadLine();
                        segundoNumero = Convert.ToDouble(segundoNumeroString);

                        resultado = primeiroNumero * segundoNumero;
                        Console.WriteLine("O resultado da sua operação é: " + resultado.ToString("F"));

                        Console.WriteLine("Deseja continuar? (S/N)");
                        repeat = Console.ReadLine();

                        if (repeat == "S" || repeat == "s")
                        {
                            operador = "3";
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Divisão\nDigite o primeiro número: ");

                        primeiroNumeroString = Console.ReadLine();
                        primeiroNumero = Convert.ToDouble(primeiroNumeroString);
                        Console.WriteLine("Digite o segundo número: ");
                        segundoNumeroString = Console.ReadLine();
                        segundoNumero = Convert.ToDouble(segundoNumeroString);
                        if (primeiroNumero == 0 || segundoNumero == 0)
                        {
                            Console.WriteLine("A operação é inválida!");
                            operador = "4";
                        }
                        else
                        {

                            resultado = primeiroNumero / segundoNumero;
                            Console.WriteLine("O resultado da sua operação é: " + resultado.ToString("F"));

                        }

                        Console.WriteLine("Deseja continuar? (S/N)");
                        repeat = Console.ReadLine();

                        if (repeat == "S" || repeat == "s")
                        {
                            operador = "4";
                        }
                        break;
                }
            } while (controlador = true);
            operador = Console.ReadLine();
        }
    }
}
