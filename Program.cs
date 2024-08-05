internal class Program
{
    static void Main(string[] args)
    {
        Dollar dollar = new Dollar(1.99m);
        dollar.SetAmount (0m);
        Console.WriteLine(dollar.Amount);
        Console.WriteLine(dollar.isZero);
    }

    public class Dollar
    {
        private decimal _amount;
        public decimal Amount
        {
            get
            {
                return _amount;
            }
           private set
            {
               this._amount = ProcessValue(value);
            }
        }
        public bool isZero => _amount == 0;
        public decimal ConversionFactor
        {
            get;
        } = 1.99m; 
        public void SetAmount (decimal value)
        {
            Amount = value;
        }
        public Dollar(decimal amount)
        {
          this._amount = ProcessValue(_amount);
        }
        private decimal ProcessValue(decimal value) => value <= 0 ? 0 : Math.Round(value,2);
    }


} 