using System;
using System.Collections.Generic;

namespace CodeBank
{
    internal class SolveArraysLeftRotation
    {
       

        public void Solve()
        {






            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int k = Convert.ToInt32(tokens_n[1]);

            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int n = 5;
            int k = 4;

            int[] a = new[] { 1, 2, 3, 4, 5 };
            int[] newAr = new int[n];

            int ind = n - 1;

            for (int i = n; i > 0; i--)
            {
                int v = (i + (n - k)) % n;
                if (v == 0) v = k + 1;
                newAr[v - 1] = a[ind];
                ind--;
            }

            string finalString = string.Empty;
            for (int i = 0; i < newAr.Length; i++)
            {
                if (i == newAr.Length)
                {
                    finalString += newAr[i].ToString();
                }
                else
                {
                    finalString += newAr[i] + " ";
                }
            }

            Console.WriteLine(finalString);

            Console.Read();
        }
    }
}