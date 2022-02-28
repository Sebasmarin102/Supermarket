namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity + (Price * (decimal)Quantity * (decimal)Tax);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement: {$"{Measurement}",5}" +
                $"\n\tQuantity...: {$"{Quantity:N2}",15}" +
                $"\n\tPrice......: {$"{Price:C2}",15}" +
                $"\n\tTax:.......: {$"{Tax:P2}",15}" +
                $"\n\tValue:.....: {$"{ValueToPay():C2}",15}";
        }
    }
}
