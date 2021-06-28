using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Products apples = new Food("apples", "BrandA", 1.50M, new DateTime(2021, 06, 14));
            Products milk = new Beverages("milk", "BrandM", 0.99M, new DateTime(2022, 2, 2));
            Products tshirt = new Clothes("T-Shirt", "BrandT", 15.99M, "M", "violet");
            Products laptop = new Appliances("laptop", "BrandL", 2345M, "ModeIL", new DateTime(2021,3,3), 1.125);

            Cart cart = new Cart();

            cart.AddProduct(apples, 2.45);
            cart.AddProduct(milk, 3);
            cart.AddProduct(tshirt, 2);
            cart.AddProduct(laptop, 1);

            Cashier.PrintReceipt(cart, new DateTime(2021, 6, 14, 12, 34, 56));

        }
    }


}
