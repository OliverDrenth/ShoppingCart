using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Order
    {
        enum Status { Received, InProgress, Delivered}
        public DateTime Date { get; set; }
        public List<Item> ItemList { get; internal set; }

        Item Items = new Item();

        private double _total;
        public double CalculateTotal() 
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                _total = _total + ItemList[i].Price;
            }
            return _total;
        }
    }
}
