using System;

namespace CRESCENTE_DECRESCENTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Entre com dois números inteiros" +
                "separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente!");
                }
                else
                {
                    Console.WriteLine("Crecente");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }


        }
    }
}
