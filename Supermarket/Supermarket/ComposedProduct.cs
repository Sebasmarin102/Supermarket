using System.Collections;

namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in Products)
            {
                payroll += product.ValueToPay();
            }
            return payroll - (payroll * (decimal)Discount);
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
