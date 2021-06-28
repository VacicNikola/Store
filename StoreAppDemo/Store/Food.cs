using System;

namespace Store
{
    public class Food : Perishable {

        public Food() : base() { }

        public Food(string name, string brand, decimal price, DateTime exdate) : base(name, brand, price, exdate) {}



    }


}
