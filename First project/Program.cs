using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.ShowProducts();

            List<Product> products = new List<Product>();
            for (int i = 0; i < cart.GetProductsCount(); i++)
            {
                products.Add(cart.getProductByIndex(i));
            }

            products.RemoveAt(0);

            Console.WriteLine();
            cart.ShowProducts();
            Console.WriteLine();
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }

        }
    }
    class Cart
    {
        private List<Product> _products = new List<Product>();

        public Cart()
        {
            _products.Add(new Product("Apple"));
            _products.Add(new Product("Banana"));
            _products.Add(new Product("Orange"));
            _products.Add(new Product("Pear"));
        }
        public void ShowProducts()
        {
            foreach (var product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }
        public Product getProductByIndex(int index)
        {
            return _products.ElementAt(index);
        }
        public int GetProductsCount()
        {
            return _products.Count();
        }
    }
    class Product
    {
        public string Name { get; set; }
        public Product(string name)
        {
            Name = name;
        }
    }
}

