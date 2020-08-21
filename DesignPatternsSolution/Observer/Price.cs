using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class Price
    {
        private List<PriceObserver> observers = new List<PriceObserver>();
        private decimal productPrice;

        public void Subscribe(PriceObserver observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(PriceObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (PriceObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                if(productPrice != value)
                {
                    productPrice = value;
                    Notify();
                }
            }
        }
    }
}
