using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    public static class SolveTwoCharacters
    {
        public static void Solve()
        {
            string S = "SOSSPSSQSSOR";
            int total = 0;
            int totalSOS = S.Length / 3;

            int index = 0;
            for (int i = 0; i < totalSOS; i++)
            {
                string check = S.Substring(index, 3);
                index = index + 3;
                if (check[0].ToString().ToLower() != "s") total++;
                if (check[1].ToString().ToLower() != "o") total++;
                if (check[2].ToString().ToLower() != "s") total++;
  
            }
        }
    }
}
