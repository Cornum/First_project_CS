using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student("Jim",5);
            Person person2 = new Mentor("Tom",8);

            if (person is Student student)
            {
                student.ShowName();
                Console.WriteLine(student.AverageScore);
            }

            switch (person2) {
                case Mentor mentor:
                    mentor.ShowName();
                    Console.WriteLine(mentor.NumberOfStudents);
                    break;
                case Student student1:
                    break;
            }

        }
    }
    class Person
    {
        public string Name { get; private set; }

        public Person (string name)
        {
            Name = name;
        }
        public void ShowName()
        {
            Console.WriteLine("I am - " + Name);
        }
    }
    class Mentor : Person
    {
        public int NumberOfStudents { get; private set; }

        public Mentor(string name, int numberOfStudents): base(name)
        {
            NumberOfStudents = numberOfStudents;
        }
    }
    class Student : Person
    {
        public int AverageScore { get; private set; }

        public Student(string name, int averageScore) : base(name)
        {
            AverageScore = averageScore;
        }
    }
}

