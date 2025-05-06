using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Review5_6_ShoppingCart
{
    internal class Program
    {
        //declarations

        static void Main(string[] args)
        {
            //declare
            
            //create a dictionary store all products in the stock
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            //create a list as shopping cart to store some products
            List<int> cart = new List<int>();

            //add some product to stocks

            Product p1 = new Product(1, "product 1", 2.99, 10);

            products.Add(1, p1);

            Product p2 = new Product(2, "product 2", 3.99, 5);

            products.Add(2, p2);

            //add some product to cart for user to check out
            cart.Add(1);
            cart.Add(2);
            Console.WriteLine("Before checking out");
            foreach (KeyValuePair<int, Product> kvp in products)
            {
                kvp.Value.DisplayFullDetails();
            }

            //calculate the total price
            double sum = 0;
            foreach (int i in cart)
            {
                sum += products[i].Price;
            }
            Console.WriteLine("Total price in cart: " + sum);

            //display cart contents with product details
            foreach(int i in cart)
            {
                products[i].DisplayDetails();

            }
            //check out
            foreach(int i in cart)
            {
                products[i].Stock--;
            }
            //empty the cart
            cart.Clear();
            Console.Read();

            Console.WriteLine("After checking out");
            foreach (KeyValuePair<int, Product> kvp in products) 
            {
                kvp.Value.DisplayFullDetails();
            }
        
          //create class
          class Product
            {
            public int ID { get; set; } //prop tab
            public string Name { get; set; }
            public double Price { get; set; }
            public string Stock { get; set; }
            

            public Product(int ID, string Name, double Price, string Stock)
            {
                this.ID = ID;
                this.Name = Name;
                this.Price = Price;
                this.Stock = Stock;
            }
            public void DisplayDetails()
            {
                Console.WriteLine(this.ID + "\t" + this.Name + "\t") + this.Price);
            }
            public void DisplayFullDetails()
            {
                Console.WriteLine(this.ID + "\t" + this.Name + "\t") + this.Price +"\t" + this.Stock);
            }


        }
       
        
        }
    }

