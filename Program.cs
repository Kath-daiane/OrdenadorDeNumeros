using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista para armazenar os números inteiros
        List<int> numeros = new List<int>();

        // Leitura dos números da lista
        Console.WriteLine("Digite números inteiros. Digite 'fim' para terminar.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "fim")
            {
                break;
            }

            if (int.TryParse(input, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
            }
        }

        // Ordenando a lista em ordem decrescente
        numeros.Sort((a, b) => b.CompareTo(a));

        // Exibindo a lista ordenada
        Console.WriteLine("\nLista ordenada em ordem decrescente:");
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Exibindo os três maiores números
        Console.WriteLine("\nOs três maiores números:");
        for (int i = 0; i < Math.Min(3, numeros.Count); i++)
        {
            Console.WriteLine(numeros[i]);
        }

        // Verificando se o número 100 está na lista e removendo
        if (numeros.Contains(100))
        {
            numeros.Remove(100);
            Console.WriteLine("\nO número 100 foi removido da lista.");
        }
        else
        {
            Console.WriteLine("\nO número 100 não foi encontrado na lista.");
        }

        // Exibindo a lista após a remoção (se houve remoção)
        Console.WriteLine("\nLista final após remoção (se aplicável):");
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
