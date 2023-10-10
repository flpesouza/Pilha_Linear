using System;
class Pilha
{
    private char[] array;
    private int n;

    public Pilha(int tamanho)
    {
        array = new char[tamanho];
        n = 0;
    }

    public void isVazia()
    {
        if (n == 0)
        {
            Console.WriteLine("Pilha vazia");
        }
    }

    public void InserirFim(char x)
    {
        if (n >= array.Length)
        {
            throw new Exception("Erro ao inserir!");
        }
        array[n] = x;
        n++;
    }

    public char RemoverFim()
    {
        if (n == 0)
        {
            throw new Exception("Erro ao remover!");
        }
        n--;
        return array[n];
    }

    public void Mostrar()
    {
        Console.Write("[ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("]");
    }
}