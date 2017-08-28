using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBank
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
    class MyBook : Book
    {
        private int price;
        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }

    public class SolveInheritence
    {
        public void Solve(string[] args)
        {
            
        }
    }

    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            testScores = scores;
        }

        public char Calculate()
        {
            double average = testScores.ToList().Average();
            if (Between(average, 90, 100, true))
            {
                return char.Parse("O");
            }
            else if (Between(average, 80, 90, true))
            {
                return char.Parse("E");
            }
            else if (Between(average, 70, 80, true))
            {
                return char.Parse("A");
            }
            else if (Between(average, 55, 70, true))
            {
                return char.Parse("P");
            }
            else if (Between(average, 40, 55, true))
            {
                return char.Parse("D");
            }
            else if (average < 40)
            {
                return char.Parse("T");
            }
            return char.Parse("T");
        }

        private bool Between(double num, double lower, double upper, bool inclusive = false)
        {
            return inclusive
                       ? lower <= num && num <= upper
                       : lower < num && num < upper;
        }
    }

    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
}
