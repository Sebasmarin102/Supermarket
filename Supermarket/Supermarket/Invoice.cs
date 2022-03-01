using System;
using System.Collections.Generic;

namespace Supermarket
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();
        public Invoice() { }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal ValueToPay()
        {
            decimal accumulated = 0;
            foreach (Product product in _products)
            {
                accumulated += product.ValueToPay();
            }
            return accumulated;
        }
        public override string ToString()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }

            return "                    ================" +
                $"\nTOTAL: {$"{ValueToPay():C2}",29}";
        }
    }
}
