using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    class Book
    {
        public string ID;
        public string Name;
        public string Auther;
        public string Availability;
        public Book(string I, string N, string A, string Av)
        {
            ID = I;
            Name = N;
            Auther = A;
            Availability = Av;
        }
        public void checkBook(Student ob)
        {
            if (Availability == "Yes")
            {
                Console.WriteLine("Student ID:" + ob.ID + "\n" + "Name:" + ob.Name);
            }
            else
            {
                Console.WriteLine("Book Not Available");
            }           
        }
    }
    class Student
    {
        public string ID;
        public string Name;
        public Student(string I, string N)
        {
            ID = I;
            Name = N;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book ob = new Book("16", "Physics", "JK", "Yes");

            Student ob1 = new Student("17", "Rony");

            ob.checkBook(ob1);
            Console.ReadLine();
        }
    }
}
