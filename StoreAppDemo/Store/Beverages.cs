using System;

namespace Store
{
    public class Beverages : Perishable {

        public Beverages() : base() { }

        public Beverages(string name, string brand, decimal price, DateTime exdate) : base(name, brand, price, exdate) { }

    }


}
