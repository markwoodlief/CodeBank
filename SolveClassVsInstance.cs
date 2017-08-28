using System;

namespace CodeBank
{
    public class SolveClassVsInstance
    {

    }

    public class Persons
    {
        public int Age { get; set; }
        public Persons(int initialAge)
        {
            if (initialAge < 1)
            {
                Age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                Age = initialAge;
            }
            
        }

        internal void yearPasses()
        {
            Age++;
        }

        internal void amIOld()
        {
            if (Age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (Age >= 13 && Age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }
     
    }
   
}
