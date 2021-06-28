using System;

namespace Store
{
    public abstract class Products
    {

        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Products() { }
               

        public Products(string name, string brand, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        public abstract double CheckForDiscount(DateTime purchaseDate);

    }


}
