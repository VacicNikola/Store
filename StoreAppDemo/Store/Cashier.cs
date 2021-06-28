using System;

namespace Store
{
    public static class Cashier {


        public static void PrintReceipt(Cart products, DateTime timeOfPurchase)
        {
            decimal subtotal = 0.0M;
            decimal totaldiscount = 0.0M;
            decimal price;
            decimal discount;

            if (products == null)
                Console.WriteLine("Cart is empty!");
            else
            {
                Console.WriteLine($"Date: {timeOfPurchase}\n");
                Console.WriteLine($"--Products--\n");

                foreach (var product in products.CartOfItems)
                {
                    Console.WriteLine(product.Product.ToString());
                    price = ((decimal)product.Quantity) * product.Product.Price;
                    Console.WriteLine($"{product.Quantity} x ${product.Product.Price} = ${price.ToString("0.##")}");
                    subtotal += price;

                    double dis = product.Product.CheckForDiscount(timeOfPurchase);

                    if (dis != -1) {
                        discount = ((decimal)product.Quantity) * product.Product.Price * (decimal)dis;
                        Console.WriteLine($"#Discount {dis*100}% - ${discount.ToString("0.##")}\n");
                        totaldiscount += discount;
                        
                    }
                    else
                        Console.WriteLine();
                    
                }

                Console.WriteLine("-----------------------------------------\n");
                Console.WriteLine($"SUBTOTAL: ${subtotal.ToString("0.##")}");
                Console.WriteLine($"DISCOUNT: -${totaldiscount.ToString("0.##")}\n");
                Console.WriteLine($"TOTAL: ${(subtotal - totaldiscount).ToString("0.##")}");

            }
        }
    
    }


}
