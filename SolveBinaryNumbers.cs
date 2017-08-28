using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    public class SolveBinaryNumbers
    {
        public void Solve(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            int max = 0;
            while (n > 0)
            {
                int rem = n % 2;
                if (rem == 1) total++;
                else total = 0;
                max = Math.Max(total, max);
                n /= 2;
            }

            Console.WriteLine(max);
        }
    }
}
