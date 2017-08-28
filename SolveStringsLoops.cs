using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    public class SolveStringsLoops
    {
        public void Solve(string[] args)
        {
            List<string> answers = new List<string>();

            // HackerRank uses a OpenStandardInput, unlike their Example C# stdin shows.
            using (Stream stdin = Console.OpenStandardInput())
            {
                using (StreamReader sr = new StreamReader(stdin))
                {
                    while (sr.Peek() >= 0)
                    {
                        string newLine = sr.ReadLine();
                        if (!string.IsNullOrEmpty(newLine))
                        {
                            //// add the raw city data to the list here.
                            // cities.Add(newLine);
                            int n;
                            bool isNumeric = int.TryParse(newLine, out n);
                            if (!isNumeric)
                            {
                                bool even = true;
                               StringBuilder evens = new StringBuilder();
                                StringBuilder odds = new StringBuilder();
                             
                                foreach (char t in newLine)
                                {
                                    if (even)
                                    {
                                        evens.Append(t.ToString());
                                        even = false;
                                    }
                                    else
                                    {
                                        odds.Append(t.ToString());
                                        even = true;
                                    }
                                }

                                answers.Add($"{evens} {odds}");
                            }
                        }
                    }
                }
            }

            foreach (string answer in answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
