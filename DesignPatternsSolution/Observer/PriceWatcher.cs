using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PriceWatcher : PriceObserver
    {
        private string name;
        private decimal price;

        public event EventHandler<decimal> PriceChanged = null;

        public PriceWatcher(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public override void Update(Price priceToWatch)
        {
            price = priceToWatch.ProductPrice;
            if (PriceChanged != null)
            {
                PriceChanged(this, price);
            }
        }
    }
}
