using System;
using System.Globalization;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Conversor de Moedas");
            Console.WriteLine("Opção 1: Converter dolar para euro");
            Console.WriteLine("Opção 2: Converter euro para dolar");
            Console.WriteLine("Opção 3: Sair");
            Console.WriteLine("");
            Console.Write("Digite a opção: ");
            string option = Console.ReadLine() ?? string.Empty; // Usar string vazia se a entrada for nula

            switch (option)
            {
                case "1":
                    ConverterDolarParaEuro(); break;
                case "2":
                    ConverterEuroParaDolar(); break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    Menu();
                    break;
            }
        }

        static void ConverterDolarParaEuro()
        {

            Console.WriteLine("Digite o valor do dolar: ");
            string input = Console.ReadLine() ?? string.Empty;
            float valorDolar = 0; // Inicializa a variável

            // Tenta converter a entrada do usuário
            if (!float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out valorDolar))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                Menu(); // Chama o menu novamente em caso de erro
                return; // Sai da função para evitar continuar com valor inválido
            }

            Console.WriteLine($"O valor em euro é {valorDolar * 0.89}");
            Menu();
        }

        static void ConverterEuroParaDolar()
        {

            Console.WriteLine("Digite o valor em euro:");
            string input = Console.ReadLine() ?? string.Empty; // Adicionar leitura da entrada
            float valorEuro = 0; // Inicializa a variável

            // Tenta converter a entrada do usuário
            if (!float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out valorEuro))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                Menu(); // Chama o menu novamente em caso de erro
                return; // Sai da função para evitar continuar com valor inválido
            }

            Console.WriteLine($"O valor em dolar é {valorEuro / 0.89}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu..."); // Adicionar instrução para o usuário
            Console.ReadKey(); // Esperar o usuário pressionar uma tecla
            Menu(); // Chamar o menu após a confirmação do usuário
        }

















    }
}
