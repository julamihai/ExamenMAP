using System;

namespace _2022__ExMAP_JulaMihai_15_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 15
            int n, m, x, ok = 0;
            int[,] a = new int[101, 101];
            Console.WriteLine("Introduceti nr de linii");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti nr de coloane");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele matricei");
            for (int i = 1; i <= n; ++i)
                for (int j = 1; j <= m; ++j)
                    a[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar care apare sau nu in matrice: ");
            x = int.Parse(Console.ReadLine());

            while (ok == 0)
            {
                for (int i = 1; i <= n; ++i)
                    if (a[i, 1] == x  a[i, m] == x) ok = 1;
                for (int j = 1; j <= m; ++j)
                    if (a[1, j] == x  a[n, j] == x) ok = 1;
                if (ok == 0) break;
            }

            if (ok == 1) Console.WriteLine("DA");
            else Console.WriteLine("NU");
            Console.ReadKey();
        }
    }
}