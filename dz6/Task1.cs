using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Task1
    {
        public static void Run()
        {
            Product product = new Product("Bread", 20, 50), product1 = new Product("Milk", 30, 75), product2 = new Product("Water", 10, 0);
            product1.MakeDiscount(5, 85);
            product2.MakeDiscount(20,10);
            List<Product> products = new List<Product> { product, product1, product2 };
            foreach(Product pr in products)
            {
                pr.Show();
            }
        }
    }

    public class Money
    {
        public int full { get; set; }
        public int coins { get; set; }

        public Money(int full, int coins)
        {
            this.full = full;
            this.coins = coins;
        }

        public override string ToString()
        {
            return string.Format($"{this.full}.{this.coins}");
        }
    }

    public class Product : Money
    {
        public string name { get; set; }

        public Product(string name, int full, int coins) : base(full, coins)
        {
            this.name = name;
        }

        public void MakeDiscount(int full, int coins)
        {
            int new_full = this.full - full;
            int new_coins = this.coins - coins;
            if (new_coins < 0)
            {
                new_coins += 100;
                new_full--;
            }
            if(new_full < 0)
            {
                return;
            }
            this.full = new_full;
            this.coins = new_coins;
        }

        public void Show()
        {
            Console.WriteLine($"Product name: {this.name}  Price: {base.ToString()}");
        }
    }
}
