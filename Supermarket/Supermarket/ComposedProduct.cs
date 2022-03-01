using System.Collections;

namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal accumulated = 0;
            foreach (Product product in Products)
            {
                accumulated += product.ValueToPay();
            }
            return accumulated - (accumulated * (decimal)Discount);
        }
        public override string ToString()
        {
            var ProductNames = string.Empty;
            foreach (Product product in Products)
            {
                ProductNames += $"{product.Description}, ";
            }

            return $"{base.ToString()} " +
                $"\n\tProducts...: {$"{ProductNames}",15}" +
                $"\n\tDiscount...: {$"{Discount:P2}",15}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
