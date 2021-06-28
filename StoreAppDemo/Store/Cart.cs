using System.Collections.Generic;

namespace Store
{
    public class Cart {

        public class Item {

            public Products Product { get; set; }
            public double Quantity { get; set; }

            public Item(Products product, double quantity)
            {
                this.Product = product;
                this.Quantity = quantity;
            }
        }

        public List<Item> CartOfItems { get; set; } = new List<Item>();

        public void AddProduct(Products product, double quantity)
        {
            foreach (var item in CartOfItems)
            {
                if (item.Product == product)
                {
                    item.Quantity += quantity;      // Product already exists in cart so we just add quantity
                    return;
                }   
            }

            // If we havent hit return we add that product in list
            CartOfItems.Add(new Item(product, quantity));
        
        }


        public void RemoveProduct(Products product) {

            foreach (var item in CartOfItems)
                if (item.Product == product)
                {
                    CartOfItems.Remove(item);
                    break;
                }
        }
        

    }


}
