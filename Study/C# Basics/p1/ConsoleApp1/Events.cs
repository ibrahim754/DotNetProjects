using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 
    internal class Stock
    {
        public delegate void StockPriceChangeHandler(Stock s, double OldPrice);
        public event StockPriceChangeHandler StockPriceChange; // event should be delegate

        private string _name;
        private double _price;
        public string Name => _name; // read only prop
        public double Price {
            get { return _price; }
            set { _price = Math.Max(value,0); }
        } 
        public Stock(string StockName,double IntialPrice) { _name = StockName; _price = IntialPrice;  }
        public void ChangeStockPriceBy(double percent)
        {
            double OldPrice = _price;
            _price += Math.Round(_price * percent, 2);
            if (StockPriceChange != null)
            {
                StockPriceChange(this, OldPrice);
            }

        }



    }
}
