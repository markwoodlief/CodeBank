using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    public static class SolveCamelCase
    {
        public static void Solve()
        {
            string s = "saveChangesInTheEditor";
            List<string> words = new List<string>();
            string currentWord = string.Empty;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    // start of a new word here.
                    words.Add(currentWord);
                    currentWord = string.Empty;
                    currentWord = c.ToString();
                }
                else
                {
                    currentWord += c;
                }
            }
            words.Add(currentWord);
            Console.WriteLine(words.Count.ToString());
        }
    }
}
