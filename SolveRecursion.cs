using System;
using System.IO;

namespace CodeBank
{
    class SolveRecursion
    {
        private int answer = 0;
        public void Solve(string[] args)
        {
            using (Stream stdin = Console.OpenStandardInput())
            {
                using (StreamReader sr = new StreamReader(stdin))
                {
                    while (sr.Peek() >= 0)
                    {
                        string newLine = sr.ReadLine();
                        if (!string.IsNullOrEmpty(newLine))
                        {
                            int factor = int.Parse(newLine);
                            answer = factor;
                            Factorial(factor - 1); 
                        }
                    }
                }
            }
           
        }
        public void Factorial(int factor)
        {
            if (factor != 0)
            {
                answer = answer * factor;
                int newFactory = factor - 1;
                Factorial(newFactory);
            }
        }
    }
}
