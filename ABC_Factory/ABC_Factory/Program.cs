using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Factory
{
    class Info
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

    class Order : Info
    {
        private double _OrderedAmount;

        public double OrderedAmount
        {
            get
            {
                return _OrderedAmount;
            }
            set
            {
                _OrderedAmount = value;
            }
        }

        public void OrderI(string I)
        {
            Id = I;
        }

        public void CalculateOrder(Clients ob1)
        {
            int p = 200;
            p += p * 5 / 100;
            OrderedAmount = ob1.Pieces * p;

            double T;
            T = 5000 * p;

            if(OrderedAmount > T)
            {
                Console.WriteLine("Your order is confirmed.");
            }
            else
            {
                Console.WriteLine("Sorry! Please order more pieces.");
            }
        }
    }
    
    class Clients : Info
    {
        private string _ClientType;
        private int _Pieces;

        public string ClientType
        {
            get
            {
                return _ClientType;
            }
            set
            {
                _ClientType = value;
            }
        }

        public int Pieces
        {
            get
            {
                return _Pieces;
            }
            set
            {
                _Pieces = value;
            }
        }

        public Clients(string I, string N, string T, int P)
        {
            Id = I;
            Name = N;
            ClientType = T;
            Pieces = P;
        }

        public void CInput(Order ob)
        {
            ob.OrderI("15");
        }
    }

    class Supervaisor : Info
    {
        public Supervaisor(string I, string N)
        {
            Id = I;
            Name = N;
        }

        public void CheckDiscount(Order ob, Clients ob1)
        {
            int p = 200;
            p += p * 5 / 100;

            double T = 10000 * p;

            if (ob1.ClientType == "registered" && ob.OrderedAmount > T)
            {
                ob.OrderedAmount -= ob.OrderedAmount * 7 / 100;

                Console.WriteLine("Congratulations! You have 10% discount.\n Your total bill: {0}", ob.OrderedAmount);
            }
            else
            {
                Console.WriteLine("Sorry! You have no discount.\n Your total bill: {0}", ob.OrderedAmount);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order ob = new Order();

            Clients ob1 = new Clients("16", "Akib", "registered", 11000);

            Supervaisor ob2 = new Supervaisor("171", "Rony");

            ob1.CInput(ob);

            ob.CalculateOrder(ob1);

            ob2.CheckDiscount(ob, ob1);

            Console.ReadKey();
        }
    }
}
