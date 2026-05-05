using System;

namespace DesafiosTecnicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== SELECIONE O DESAFIO ===");
                Console.WriteLine("1 - Verificador de Palíndromo");
                Console.WriteLine("2 - Sequência de Fibonacci");
                Console.WriteLine("0 - Sair");
                Console.Write("\nOpção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ExecutarDesafioPalindromo();
                        break;
                    case "2":
                        ExecutarDesafioFibonacci();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        // --- LÓGICA DO DESAFIO 1: PALÍNDROMO ---
        static void ExecutarDesafioPalindromo()
        {
            Console.Clear();
            Console.WriteLine("--- Verificador de Palíndromos ---");
            Console.Write("Digite a palavra ou frase: ");
            string entrada = Console.ReadLine();

            if (EhPalindromo(entrada))
                Console.WriteLine("\nÉ um palíndromo!");
            else
                Console.WriteLine("\nNão é um palíndromo.");
        }

        static bool EhPalindromo(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;
            string limpo = "";
            foreach (char c in texto.ToLower())
                if (char.IsLetterOrDigit(c)) limpo += c;

            int i = 0, j = limpo.Length - 1;
            while (i < j)
            {
                if (limpo[i] != limpo[j]) return false;
                i++; j--;
            }
            return true;
        }

        // --- LÓGICA DO DESAFIO 2: FIBONACCI ---
        static void ExecutarDesafioFibonacci()
        {
            Console.Clear();
            Console.WriteLine("--- Sequência de Fibonacci ---");
            Console.Write("Quantos elementos deseja gerar (X)? ");

            if (int.TryParse(Console.ReadLine(), out int x))
            {
                GerarFibonacci(x);
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        static void GerarFibonacci(int x)
        {
            if (x <= 0) return;
            long atual = 0, proximo = 1;
            for (int i = 0; i < x; i++)
            {
                Console.Write(atual + (i < x - 1 ? ", " : ""));
                long soma = atual + proximo;
                atual = proximo;
                proximo = soma;
            }
            Console.WriteLine();
        }
    }
}