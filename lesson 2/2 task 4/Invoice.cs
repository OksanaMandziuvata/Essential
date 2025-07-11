using System;

namespace Task_4
{
    class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public void SetOrder(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public void CalculateCost(bool includeVat)
        {
            double price;

            switch (article.ToLower())
            {
                case "laptop": price = 2400; break;
                case "iPhone": price =1000; break;
                case "headphone": price = 500; break;
                default:
                    Console.WriteLine("No information about this product.");
                    return;
            }

            if (includeVat)
            {
                price *= 1.6; 
            }

            double total = price * quantity;
            Console.WriteLine("Total payment amount: " + total);
        }
    }
}
