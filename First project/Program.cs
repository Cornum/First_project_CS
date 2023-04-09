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
            Person person = new Student("Jim", 5); ;
            Person person2 = new Mentor("Tom", 8);
            Mentor mentor;
            Student student;
            //without Upcasting can't exist truly Downcasting
            
            student = (Student)person;
            mentor = (Mentor)person2; //Явное преобразование. Точно знаем что делаем.
            Console.WriteLine(student.AverageScore);


            //person = mentor;
            //cant be person.NumberOfStudents
            // person have info only about Person states
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

