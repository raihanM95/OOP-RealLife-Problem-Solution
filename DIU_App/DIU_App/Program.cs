using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIU_App
{
    class Admin
    {
        public string AdminId;
        public string Name;
        public Admin(string I, string N)
        {
            AdminId = I;
            Name = N;
        }
        public void ApprovesSalary(Teacher ob)
        {
            if (ob.Marks == "yes")
            {
                Console.WriteLine("Your salary: {0}", ob.Salary);
            }
            else
            {
                Console.WriteLine("Sorry your salary not approve!");
            }
        }
    }
    class Course
    {
        public string CouurseId;
        public string Name;
        public string Type;
        public double Marks;
        public Course(string I, string N, string T, double M)
        {
            CouurseId = I;
            Name = N;
            Type = T;
            Marks = M;
        }
    }
    class Teacher
    {
        public string TeacherId;
        public string Name;
        public double Salary;
        public string Marks;
        public Teacher(string I, string N, double S, string M)
        {
            TeacherId = I;
            Name = N;
            Salary = S;
            Marks = M;
        }
    }
    class Student
    {
        public string StudentId;
        public string Name;
        public string Semester;
        public Student(string I, string N, string S)
        {
            StudentId = I;
            Name = N;
            Semester = S;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Admin ob = new Admin("Rafa", "197");

            Course ob1 = new Course("SWE-233", "OOP", "Lab", 25);

            Teacher ob2 = new Teacher("359", "Fazla Elahe", 50000, "yes");

            Student ob3 = new Student("1542", "Raihan", "5th");

            ob.ApprovesSalary(ob2);

            Console.ReadLine();
        }
    }
}

