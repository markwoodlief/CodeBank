using System;
using System.Linq;

namespace CodeBank
{
    public class SolvePlusMinus
    {
        public void Solve(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string readLine = Console.ReadLine();
            if (readLine != null)
            {
                string[] arr_temp = readLine.Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, int.Parse);

                double positives = arr.Where(z => z > 0).Count();
                double negatives = arr.Where(z => z < 0).Count();
                double zeros = arr.Where(z => Math.Abs(z) == 0).Count();

                double perPositive = ((positives / n) * 100) / 100;
                double perNegatives = ((negatives / n) * 100) / 100;
                double perZeros = ((zeros / n) * 100) / 100;

                string percentagePositive = $"{perPositive:0.000000}";
                string percentageNegative = $"{perNegatives:0.000000}";
                string percentageZeros = $"{perZeros:0.000000}";

                Console.WriteLine(percentagePositive);
                Console.WriteLine(percentageNegative);
                Console.WriteLine(percentageZeros);
            }
        }
    }
}
