using System;

namespace Store
{
    public class Clothes : Products {

        public string ClothesSize { get; set; }
        public string Color { get; set; }

        public Clothes() : base() { }

        public Clothes(string name, string brand, decimal price, string size, string color) : base(name, brand, price)
        {
            this.ClothesSize = size;
            this.Color = color;
        }

        public override double CheckForDiscount(DateTime purchaseDate)
        {
            // I am assuming working days are Monday to Friday
            if (purchaseDate.DayOfWeek != DayOfWeek.Saturday && purchaseDate.DayOfWeek != DayOfWeek.Sunday)
                return 0.1;
            return -1;
        }

        public override string ToString()
        {
            return $"{Name} {Brand} {ClothesSize} {Color}";
        }
    }


}
