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
            User.Identifications = 10;
            User user1 = new User();
            User user2 = new User();
            user1.ShowInfo();
            user2.ShowInfo();

        } 
    }
    class User
    {
        public static int Identifications;
        public int Identification;
        public User()
        {
            Identification = ++ Identifications;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Identification);
        }
    }
}

