using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public Order GetOrder()
        {
            Order _order = new Order { Date = DateTime.Now, ItemList = new List<Item>() };
            return _order;
        }
    }
}
