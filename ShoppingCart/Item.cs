using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    class Item
    {
        public string Id { get; set; }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                if (value == "" || value.Length <= 200)
                    throw new Exception("Description cannot be empty or exceed 200 characters");
                _description = value;

            }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new Exception("Price cannot be negative");
                _price = value;
            }
        }

    }
}
