using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    internal abstract class Veggies
    {
        private double _pricePerPound;
        private readonly List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public void Attach(IRestaurant restaurant) // Subscribe
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant) // Unsubscribe
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return _pricePerPound; }
            set
            {
                if (_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }
    }
}
