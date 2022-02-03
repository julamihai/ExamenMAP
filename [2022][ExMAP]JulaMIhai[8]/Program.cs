using System;
using System.IO;

namespace _2022__ExMAP_JulaMIhai_8_
{
    class Program
    {
        //Problema 8
        static int n, k;
        static int[] arr = new int[9];
        static StreamWriter writetext = new StreamWriter("aranjamente.out");
        static void Main(string[] args)
        {
            string[] buffer = (File.ReadAllText(@"....\aranjamente.in")).Split(' ');
            n = int.Parse(buffer[0]);
            k = int.Parse(buffer[1]);
            backtrack(0);
            writetext.Close();
        }
        private static bool verify(int pos)
        {
            for (int i = 0; i < pos; i++)
                if (arr[pos] == arr[i]) return false;
            return true;
        }
        private static void backtrack(int pos)
        {

            for (int i = 1; i < n; i++)
            {
                arr[pos] = i;
                if (verify(pos))
                    if (pos == k - 1)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            writetext.Write(arr[j] + " ");
                        }
                        writetext.WriteLine();
                    }
                    else backtrack(pos + 1);
            }
        }
    }
}