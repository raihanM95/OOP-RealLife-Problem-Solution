using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agora_App
{
    class Manager
    {
        public string ProductId;
        public string Name;
        public double Price;
        public bool Availability;

        public Manager(string I, string N, double P, bool A)
        {
            ProductId = I;
            Name = N;
            Price = P;
            Availability = A;
        }
        public void StoreProduct()
        {
            Console.WriteLine("Availabil product are: \nProductId: {0} \nName: {1} \nPrice: {2}\n\n", ProductId, Name, Price);
        }
    }
    class Sallperson
    {
        public string SallPersonId;
        public string Name;
        public double Piece;
        public Sallperson(string I, string N, double P)
        {
            SallPersonId = I;
            Name = N;
            Piece = P;
        }
        public void CheckAvailability(Manager ob, Customer ob2)
        {
            if (ob.Availability == true)
            {
                Console.WriteLine("--receipt--\n\nSallPersonId: {0} \nProductId: {1} \nCustomer Name: {2}", SallPersonId, ob.ProductId, ob2.Name);
            }
            else
            {
                Console.WriteLine("No availabil product");
            }
        }
        public void CalculateBill(Manager ob)
        {
            double total = ob.Price * Piece;
            if (ob.Price < total)
            {
                Console.WriteLine("-------------------\nTotal_Bill: {0}/=", total);
            }
        }
    }
    class Customer
    {
        public string CustomerId;
        public string Name;

        public Customer(string I, string N)
        {
            CustomerId = I;
            Name = N;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager ob = new Manager("17", "Biskit", 24, true);

            Sallperson ob1 = new Sallperson("161", "Jahid", 2);

            Customer ob2 = new Customer("172", "Abir");

            ob.StoreProduct();
            ob1.CheckAvailability(ob, ob2);
            ob1.CalculateBill(ob);

            Console.ReadLine();
        }
    }
}
