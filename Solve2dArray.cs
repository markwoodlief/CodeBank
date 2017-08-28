using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBank
{
    public class Solve2dArray
    {
        public void Solve(string[] args)
        {
            // hourglass patern is going to be 1,2,3,5,7,8,9 total them.
            int[][] arr =
                 {
                new[] { 1, 1, 1, 0, 0, 0 },
                new[] { 0, 1, 0, 0, 0, 0 },
                new[] { 1, 1, 1, 0, 0, 0 },
                new[] { 0, 0, 2, 4, 4, 0 },
                new[] { 0, 0, 0, 2, 0, 0 },
                new[] { 0, 0, 1, 2, 4, 0 }
                };


            //int[] sum = new int[16];
            //int h = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sum[h] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
            //                + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
            //                + arr[i + 2][j + 2];
            //        h++;
            //    }
            //}

            //sum.ToList().Sort();
            //Console.WriteLine(sum.Last());



            List<int> totals = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int total = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    total += arr[i + 1][j + 1];
                    total += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    totals.Add(total);
                }
            }

            totals.Sort();
            Console.WriteLine(totals.Last());
        }
    }
}
