using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        PrintPiramid(n);
    }

    static void PrintPiramid(int n)
    {
        if (n <= 0)
            return;

        PrintPiramid(n - 1);

        for (int i = 1; i <= n; i++)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        PrintPiramid(n - 1);
    }
}

//Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
//afisa urmatoarea piramida a numerelor:

