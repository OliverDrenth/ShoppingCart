using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Order
    {
        enum Status { Received, InProgress, Delivered}
        public DateTime Date { get; set; }

        Item Items = new Item();

        public double CalculateTotal() 
        {

        }
    }
}
