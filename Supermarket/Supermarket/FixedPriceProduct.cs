namespace Supermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + (Price * (decimal)Tax);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tPrice......: {$"{Price:C2}",15}" +
                $"\n\tTax:.......: {$"{Tax:P2}",15}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}
