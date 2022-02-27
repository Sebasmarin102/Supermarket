using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity * (decimal)Tax + (Price * (decimal)Quantity);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement: {$"{Measurement}",15}" +
                $"\n\tQuantity...: {$"{Quantity:N2}",15}" +
                $"\n\tValue:.....: {$"{ValueToPay():C2}",15}";
        }
    }
}
