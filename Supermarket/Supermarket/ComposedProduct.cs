using System.Collections;

namespace Supermarket
{
    public class ComposedProduct : Product
    {
        string _ProductNames;
        public float Discount { get; set; }
        public ICollection Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal _payroll = 0;
            foreach (Product product in Products)
            {
                _payroll += product.ValueToPay();
            }
            return _payroll - (_payroll * (decimal)Discount);
        }
        public override string ToString()
        {
            foreach (Product product in Products)
            {
                _ProductNames += $"{ product.Description}, ";
            }

            return $"{base.ToString()} " +
                $"\n\tProducts...: {$"{_ProductNames}",15}" +
                $"\n\tDiscount...: {$"{Discount:P2}",15}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
