namespace Soma
{
    using System;

    class Program
    {
        static void Main()
        {
            int numero1, numero2;

            // Solicita e valida o primeiro número
            while (true)
            {
                Console.Write("Digite o primeiro número: ");
                if (int.TryParse(Console.ReadLine(), out numero1))
                    break;
                else
                    Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
            }
            // Out retorna varios valores ou seja , serve como um modificador de paramentro
            // Solicita e valida o segundo número
            while (true)
            {
                Console.Write("Digite o segundo número: ");
                if (int.TryParse(Console.ReadLine(), out numero2))
                    break;
                else
                    Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");

                // Lê um número inteiro do usuário, garantindo que a entrada seja válida.
                // Tryparse, converte numero string em inteiro
                // Mensagem a ser exibida ao usuário
                // O número inteiro inserido pelo usuário

                        }

            // Calcula e exibe o resultado
            int resultado = numero1 + numero2;
            Console.WriteLine($"A soma dos números {numero1} e {numero2} é: {resultado}");

            // Retorna a soma de dois números inteiros.
            
            // "a">Primeiro número
            // "b">Segundo número
            // Soma de a e b.


        }
    }

}

