using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    public class SolveDictionariesAndMaps
    {
        public void Solve(string[] args)
        {
            
            List<string> list = new List<string>();
            //ReadFromFile("inputDictionary.txt", out list);
            using (Stream stdin = Console.OpenStandardInput())
            {
                using (StreamReader sr = new StreamReader(stdin))
                {
                    while (sr.Peek() >= 0)
                    {
                        string newLine = sr.ReadLine();
                        if (!string.IsNullOrEmpty(newLine))
                        {
                            // add the raw city data to the list here.
                            list.Add(newLine);
                        }
                    }
                }
            }

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
             
            int totalInputs = int.Parse(list[0]);
            for (int i = 1; i <= totalInputs; i++)
            {
                string[] split = list[i].Split(char.Parse(" "));
                string name = split[0];
                string number = split[1];
                phoneBook.Add(name, number);
            }

            for (int i = totalInputs + 1; i < list.Count(); i++)
            {
                if (phoneBook.ContainsKey(list[i]))
                {
                    string number;

                    if (phoneBook.TryGetValue(list[i], out number))
                    {
                        Console.WriteLine($"{list[i]}={number}");
                    }
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
        private void ReadFromFile(string filePath, out List<string> rawList)
        {
            // read from a file we have copied in this sln.
            List<string> args = new List<string>();

            string line = string.Empty;

            using (StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    args.Add(line);
                }
            }

            rawList = args;
        }
    }
}
