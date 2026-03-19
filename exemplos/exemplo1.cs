using System;
namespace projeto_2DS.exemplos;

public static class Exemplo01
{
    public static void Executar()
    {
        Console.Write("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("ÍMPAR");
        }
    }
}