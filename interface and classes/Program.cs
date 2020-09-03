using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_and_classes
{

    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    class Customer : ICustomer2
    {

        public void Print1()
        {
            Console.WriteLine("Print 1 method");
        }

        public void Print2()
        {
            Console.WriteLine("Print 2 method");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            ICustomer1 C1 = new Customer();
            C1.Print1();

            ICustomer2 C2 = new Customer();
            C2.Print1();
            C2.Print2();

            Console.ReadLine();
        }
    }
}
