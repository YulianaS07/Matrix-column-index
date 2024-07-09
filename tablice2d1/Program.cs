using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int[]> wejscie = Wczyt();

        int najwSumaKol = indeksKol(wejscie);

        Console.WriteLine(najwSumaKol);
    }

    static List<int[]> Wczyt()
    {
        List<int[]> wejscie = new List<int[]>();

        while (true)
        {
            string linia = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(linia))
                break;

            int[] wiersz = Array.ConvertAll(linia.Split(' '), int.Parse);
            wejscie.Add(wiersz);
        }

        return wejscie;
    }

    static int indeksKol(List<int[]> wejscie)
    {
        int najwSum = int.MinValue;
        int najwSumaKol = -1;

        for (int kolIndeks = 0; kolIndeks < wejscie[0].Length; kolIndeks++)
        {
            int kolSum = 0;

            for (int wierszIndex = 0; wierszIndex < wejscie.Count; wierszIndex++)
            {
                kolSum += wejscie[wierszIndex][kolIndeks];
            }

            if (kolSum > najwSum)
            {
                najwSum = kolSum;
                najwSumaKol = kolIndeks;
            }
        }

        return najwSumaKol;
    }
}