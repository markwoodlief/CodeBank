using System;
using System.Text;

namespace CodeBank
{
    public class Arrays
    {
        /// <summary>
        /// prints an array backwards.
        /// 1st input is the number in the array
        /// 2nd input is the array
        /// </summary>
        public Arrays()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string readLine = Console.ReadLine();
            if (readLine != null)
            {
                string[] arr_temp = readLine.Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, int.Parse);
 
                StringBuilder sb = new StringBuilder();
                for (int i = n - 1; i >= 0; i--)
                {
                    sb.Append(i == 0 ? arr[i].ToString() : $"{arr[i]} ");
                }
                Console.WriteLine(sb.ToString());
            }
            Console.ReadLine();
        }
    }
}
