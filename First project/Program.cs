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
            Person person = new Person("Jim") ; //if convertation happens. Write right info.
            Mentor mentor = person as Mentor; //else write null
            Student student = person as Student;
            
            if (mentor != null)
            {
                mentor.ShowName();
                Console.WriteLine(mentor.NumberOfStudents);
            }
            if(student != null)
            {
                student.ShowName();
                Console.WriteLine(student.AverageScore);
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

