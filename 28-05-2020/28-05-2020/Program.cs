using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice task = new Invoice("@user", "Alex", "Foxtrot");
            task.Article = "USB-hub";
            task.Quantity = 6;
            task.CostCalculation(true);

            Invoice task2 = new Invoice("@user2", "Jhon", "Asus");
            task2.Article = "Laptop";
            task2.Quantity = 2;
            task2.CostCalculation(false);

            Invoice task3 = new Invoice("@user3", "Lily", "Kingston");
            task3.Article = "SD-card";
            task3.Quantity = 4;
            task3.CostCalculation(true);

        }
    }

    class Invoice
    {
        private readonly string account;
        private readonly string customer;
        private readonly string provider;
        double cost;
        double edv = 0.18;
        double TotalPrice = 0;

        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article { get; set; }
        public int Quantity { get; set; }


        private void Products()
        {
            switch (Article)
            {
                case "Laptop":
                    cost = 1400;
                    break;
                case "SD-card":
                    cost = 30;
                    break;
                case "USB-hub":
                    cost = 12;
                    break;
                default:
                    break;
            }
        }

        public void CostCalculation(bool needAdv)
        {

            Products();

            if (needAdv)
            {
                TotalPrice = (Quantity * cost) + ((Quantity * cost) * edv);

            }
            else
            {
                TotalPrice = Quantity * cost;
            }
            Console.WriteLine($"Dear {customer} - Your order  with account {account} send to {provider} provider ");
            Console.WriteLine($"Total price for {Quantity} pieces of {Article} is {TotalPrice}");
            Console.WriteLine("Have a nice day!");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
