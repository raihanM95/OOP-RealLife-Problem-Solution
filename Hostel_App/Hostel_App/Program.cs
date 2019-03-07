using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_App
{
    class Manager
    {
        public string ManagerId;
        public string Name;
        public Manager(string I, string N)
        {
            ManagerId = I;
            Name = N;
        }
        public void CheckRoom(Room ob, Student ob2)
        {
            if (ob.Availability == "yes")
            {
                Console.WriteLine("Room available please enter student information-\n");
                Console.WriteLine("Enter student Id: ");
                ob2.StudentId = Console.ReadLine();
                Console.WriteLine("Enter student Name: ");
                ob2.Name = Console.ReadLine();
                Console.WriteLine("Enter room Id: ");
                ob2.RoomId = Console.ReadLine();
                Console.WriteLine("Enter room Name: ");
                ob2.RoomName = Console.ReadLine();
                Console.WriteLine("Enter room type(big/small): ");
                ob2.Type = Console.ReadLine();
                Console.WriteLine("Enter service name(Food/Game) & type(full/half): ");
                ob2.Service = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Room not available!");
            }
        }
        public void CalculateTotalBill(Room ob, Student ob1)
        {
            if (ob1.Service == "Food half")
            {
                int sum = ob.Price + 1000;
                Console.WriteLine("{0} monthly total bill: {1}", ob1.Name, sum);
            }
            else if (ob1.Service == "Food full")
            {
                int sum = ob.Price + 2000;
                Console.WriteLine("{0} monthly total bill: {1}", ob1.Name, sum);
            }
            else if (ob1.Service == "Game half")
            {
                int sum = ob.Price + 400;
                Console.WriteLine("{0} monthly total bill: {1}", ob1.Name, sum);
            }
            else
            {
                int sum = ob.Price + 750;
                Console.WriteLine("{0} monthly total bill: {1}", ob1.Name, sum);
            }
        }
    }
    class Room
    {
        public string RoomId;
        public string Name;
        public string Type;
        public string Availability;
        public int Price;
        public Room(string I, string N, string T, string A, int P)
        {
            RoomId = I;
            Name = N;
            Type = T;
            Availability = A;
            Price = P;
        }
    }
    class Student
    {
        public string StudentId;
        public string Name;
        public string RoomId;
        public string RoomName;
        public string Type;
        public string Service;
        public Student(string I, string N, string RI, string RN, string T, string S)
        {
            StudentId = I;
            Name = N;
            RoomId = RI;
            RoomName = RN;
            Type = T;
            Service = S;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager ob = new Manager("17", "Ridoy");

            Room ob1 = new Room("103", "Bokul", "big", "no", 500);

            Student ob2 = new Student("161", "Mr Alam", "103", "Bokul", "small", "Food half");

            ob.CheckRoom(ob1, ob2);
            ob.CalculateTotalBill(ob1, ob2);

            Console.ReadLine();
        }
    }
}