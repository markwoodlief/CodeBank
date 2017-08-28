using System;

namespace CodeBank
{
    internal class SolveOddEven
    {
        public void Solve(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            
            bool even = N % 2 == 0;
            if (!even)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                
                if (N.Between(2, 5, true))
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N.Between(6, 20, true))
                {
                    Console.WriteLine("Weird");
                }
                else if (N > 20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}
