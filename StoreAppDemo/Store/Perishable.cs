using System;

namespace Store
{
    public abstract class Perishable : Products
    {

        public DateTime ExpirationDate { get; set; }

        public Perishable() : base() { }

        public Perishable(string name, string brand, decimal price, DateTime exdate) : base(name, brand, price)
        {
            this.ExpirationDate = exdate;
        }

        public override double CheckForDiscount(DateTime purchaseDate)
        {
            if (purchaseDate.Day == ExpirationDate.Day && purchaseDate.Month == ExpirationDate.Month && purchaseDate.Year == ExpirationDate.Year)
                return 0.5;
            TimeSpan ts = ExpirationDate.Subtract(purchaseDate);
            if (ts.Days <= 5)
                return 0.1;
            
            return -1;

        }

        public override string ToString()
        {
            return $"{Name} - {Brand}";
        }
    }


}
