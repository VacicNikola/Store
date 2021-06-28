using System;

namespace Store
{
    public class Appliances : Products {

        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Weight { get; set; }

        public Appliances() : base() { }

        public Appliances(string name, string brand, decimal price, string model, DateTime pdate, double weight) : base(name, brand, price)
        {
            this.Model = Model;
            this.ProductionDate = pdate;
            this.Weight = weight;
        }

        public override double CheckForDiscount(DateTime purchaseDate)
        {
            if (this.Price > 999 && (purchaseDate.DayOfWeek == DayOfWeek.Saturday || purchaseDate.DayOfWeek == DayOfWeek.Sunday))
                return 0.05;
            return -1;
        }

        public override string ToString()
        {
            return $"{Name} {Brand} {Model}";
        }
    }


}
