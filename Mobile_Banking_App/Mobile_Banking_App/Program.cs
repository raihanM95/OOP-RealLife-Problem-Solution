using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Banking_App
{
    class Property
    {
        private string _Id;
        private string _Name;

        public string Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
    }

    class Customer : Property
    {
        private string PhoneNumber;
        private int Pin;
        private double _Balance;

        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
        }

        public void Register(string phone, int pin, string id, string name, double balance)
        {
            PhoneNumber = phone;
            Pin = pin;
            Id = id;
            Name = name;
            Balance = balance;

            Console.WriteLine(" Before update\n Phone: " + PhoneNumber + "; Pin: " + Pin + "; Name: " + Name + "; ID: " + Id + "; Balance: " + Balance);
        }
        public void Update(string phone, int pin, string name, double balance)
        {
            PhoneNumber = phone;
            Pin = pin;
            Name = name;
            Balance = balance;

            Console.WriteLine("\n After update\n Phone: " + PhoneNumber + "; Pin: " + Pin + "; Name: " + Name + "; Balance: " + Balance);
        }

        public void Withdraw(double i)
        {
            Balance = Balance - i;

            Console.WriteLine("\n After withdraw: " + Balance);
        }

        public void Deposit(double i)
        {
            Balance = Balance + i;

            Console.WriteLine("\n After Deposit: " + Balance);
        }

    }

    class Agent : Property
    {
        public void Register(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void RegisterCustomer(Customer c)
        {
            c.Register("01751", 123, "171", "Sumon", 500);
        }

        public void UpdateCustomer(Customer c)
        {
            c.Update("01750", 145, "Rony", 1000);
        }

        public void Print(Customer cu)
        {
            Console.WriteLine("\n Customer name: " + cu.Name + "; Current balance: " + cu.Balance);
        }
    }

    class Manager : Property
    {
        public Manager(string I, string N)
        {
            Id = I;
            Name = N;
        }

        public void RegisterAgent(Agent ag)
        {
            ag.Register("512", "Habib");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Agent ag = new Agent();
            Manager man = new Manager("001", "Raihan");

            man.RegisterAgent(ag);

            Customer cus = new Customer();

            ag.RegisterCustomer(cus);
            ag.UpdateCustomer(cus);
            cus.Withdraw(100);
            cus.Deposit(500);
            ag.Print(cus);

            Console.ReadLine();
        }
    }
}
