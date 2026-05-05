using System;

namespace DesafioPalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Verificador de Palíndromos ---");
            Console.Write("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine();

            bool resultado = EhPalindromo(entrada);

            if (resultado)
                Console.WriteLine("\nÉ um palíndromo!");
            else
                Console.WriteLine("\nNão é um palíndromo.");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        public static bool EhPalindromo(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;

            // Normalização manual (sem métodos prontos de reverse)
            string limpo = "";
            foreach (char c in texto.ToLower())
            {
                if (char.IsLetterOrDigit(c)) limpo += c;
            }

            int i = 0;
            int j = limpo.Length - 1;

            while (i < j)
            {
                if (limpo[i] != limpo[j]) return false;
                i++;
                j--;
            }

            return true;
        }
    }
}