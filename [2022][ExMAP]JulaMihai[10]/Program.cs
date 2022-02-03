using System;

namespace _2022__ExMAP_JulaMihai_10_
{
    class Program
    {
        //Problema 10
        static void Main(string[] args)
        {
            int n, m, k = 0;

            string line = Console.ReadLine();
            char[] seps = { ' ', '.', ',', '?' };
            string[] input = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            if (m * 2 >= n)
                Console.Write("0 ");
            else
                Console.Write($"{n - 2 * m} ");

            while (k * (k - 1) / 2 < m)
            {
                k++;
            }

            Console.Write(n - k);
        }
    }
}
