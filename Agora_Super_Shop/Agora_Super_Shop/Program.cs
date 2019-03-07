using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agora_Super_Shop
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

    class Product : Info
    {
        private double _Price;
        private int _Pieces;

        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
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

        public void ProductInfo(string id, string name, double price, int pieces) //Method
        {
            Id = id;
            Name = name;
            Price = price;
            Pieces = pieces;
        }
    }

    class Customer : Info
    {
        private string _CustomerType;
        private string _ProductId;
        private int _Pieces;

        private double _Bill;

        public string CustomerType
        {
            get
            {
                return _CustomerType;
            }
            set
            {
                _CustomerType = value;
            }
        }

        public string ProductId
        {
            get
            {
                return _ProductId;
            }
            set
            {
                _ProductId = value;
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

        public double Bill
        {
            get
            {
                return _Bill;
            }
            set
            {
                _Bill = value;
            }
        }

        public void CustomerInfo(string id, string name, string type, string productid, int pieces) //Method
        {
            Id = id;
            Name = name;
            CustomerType = type;
            ProductId = productid;
            Pieces = pieces;
        }

        public void CalculateBill(Product ob)
        {
            // 5% vat add
            ob.Price += ob.Price * 5 / 100;
            Bill = Pieces * ob.Price;

            Console.WriteLine("\n--------------------\n");
            Console.WriteLine("\n Your bill: {0} /-\n", Bill);
        }
    }

    class SellPerson : Info
    {
        public SellPerson(string I, string N) // Constructor
        {
            Id = I;
            Name = N;
        }

        public void CustomerInfoSubmit(Customer ob) //SellPerson can assign a customer information
        {
            Console.WriteLine("\n Enter customer id: ");
            string i = Console.ReadLine();
            Console.WriteLine("\n Enter customer name: ");
            string n = Console.ReadLine();
            Console.WriteLine("\n Enter customer type: ");
            string t = Console.ReadLine();

            Console.WriteLine("\n Enter product id: ");
            string pi = Console.ReadLine();
            Console.WriteLine("\n Enter pieces: ");
            int p = Convert.ToInt32(Console.ReadLine());

            ob.CustomerInfo(i, n, t, pi, p);
        }

        public void ProductAvailabilityCheck(Product ob, Customer ob1) //SellPerson can check product availability
        {
            if(ob.Id == ob1.ProductId)
            {
                int a = ob.Pieces - ob1.Pieces;
                Console.WriteLine("\n {0} is available. \n after sell {1} pieces are available.\n", ob.Name, a);
            }
            else
            {
                Console.WriteLine("\n Sorry! your product is not available.\n");
            }
        }
    }

    class Manager : Info
    {
        public Manager(string I, string N) // Constructor
        {
            Id = I;
            Name = N;
        }

        public void AddProduct(Product ob) //Manager can store the product
        {
            ob.ProductInfo("121", "Shampo", 300.0, 100);
        }

        public void CheckDiscount(Customer ob) //If a customer are regular and his total bill > 1000 then the customer will enjoy 5% discount given by the manager
        {
            if (ob.CustomerType == "regular" && ob.Bill > 1000)
            {
                ob.Bill -= ob.Bill * 5 / 100;

                Console.WriteLine("\n\n Congratulations! You have 5% discount.\n\n\n Your total bill: {0} /-\n", ob.Bill);
            }
            else
            {
                Console.WriteLine("\n\n Sorry! You have no discount.\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product pd = new Product();

            Customer cu = new Customer();

            Console.WriteLine("Enter your id: ");
            string i = Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            string n = Console.ReadLine();

            SellPerson sp = new SellPerson(i, n);

            Manager mg = new Manager("151", "Mukul");

            mg.AddProduct(pd);

            sp.CustomerInfoSubmit(cu);

            sp.ProductAvailabilityCheck(pd, cu);

            cu.CalculateBill(pd);

            mg.CheckDiscount(cu);

            Console.ReadLine();
        }
    }
}
