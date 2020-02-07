using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public Order GetOrder()
        {
            List<Item> _itemsList = new List<Item>
            {
                new Item() { Description = "Samsung Galaxy S10", Id = "SG10", Price = 875},
                new Item() {Description = "Iphone XS", Id = "IPX", Price = 1300}



            };
            
            Order _order = new Order { Date = DateTime.Now, ItemList = new List<Item>() };
            return _order;
        }



    }
}
