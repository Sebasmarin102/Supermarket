using System;
using System.Collections;
using System.Collections.Generic;

namespace Supermarket
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();
        public Invoice() { }
        public override string ToString()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }

            return "                    ================" +
                $"\nTOTAL: {$"{ValueToPay():C2}",29}";
        }

        public decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in _products)
            {
                payroll += product.ValueToPay();
            }
            return payroll;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
