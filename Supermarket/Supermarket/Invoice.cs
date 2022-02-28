using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Invoice : IPay
    {
        private string _product;
        public Invoice(string product)
        {
            _product = product;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
