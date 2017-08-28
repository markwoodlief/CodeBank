using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    public class SolveDiagnolDifference
    {
        public void Solve(string[] args)
        {
            int n = 3;
            //int[][] a = new int[n][];
            //for (int a_i = 0; a_i < n; a_i++)
            //{
            //    string[] a_temp = Console.ReadLine().Split(' ');
            //    a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            //}

            int[][] a =
                 {
                new[] { 1, 1, 1 },
                new[] { 0, 1, 0 },
                new[] { 1, 1, 1 },
                new[] { 0, 0, 2 },
                new[] { 0, 0, 0 },
                new[] { 0, 0, 1 }
                };

            List<int> totals = new List<int>();
            for (int i = 0; i < n; i++)
            {
               
            }

        }

        public void Challenge()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            
            if (n > p / 2)
            {
                //start from the back
            }
            else
            {

                //start from the front of the book
                int total = p - (n / 2);
            }


        }

    }
}
