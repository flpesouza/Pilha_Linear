using System;
using System.Collections.Generic;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da pilha: ");
            int tamanho = int.Parse(Console.ReadLine());

            Pilha pilha = new Pilha(tamanho);

            bool isBemFormada = true;

            Console.WriteLine("Digite a sequencia de parenteses e colchetes: ");
            string sequencia = Console.ReadLine();
            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] == '[' || sequencia[i] == '(')
                {
                    pilha.InserirFim(sequencia[i]);
                }
                else if (sequencia[i] == ']')
                {
                    char desempilha = pilha.RemoverFim();
                    if (desempilha != '[')
                    {
                        isBemFormada = false;
                    }
                }
                else if (sequencia[i] == ')')
                {
                    char desempilha = pilha.RemoverFim();
                    if (desempilha != '(')
                    {
                        isBemFormada = false;
                    }
                }
            }

            if (sequencia[tamanho-1] == '(' || sequencia[tamanho - 1] == '[')
            {
                isBemFormada = false;
            }

            if (isBemFormada)
            {
                Console.WriteLine("A sequencia é bem-formada");
            }
            else
            {
                Console.WriteLine("A sequencia é malformada");
            }
            Console.ReadLine();
        }
    }
}
