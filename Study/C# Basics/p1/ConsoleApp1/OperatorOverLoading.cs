using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Money

    {
        private decimal _amount;

        public decimal Amount {
             private get { return _amount; }
            set { _amount = value; }
        }
        private Money(decimal amount)
        {
            _amount = amount;
        }
        public Money()
        {
            _amount = -1;
        }

        public static Money operator +(Money a, Money b)
        {
            Money m = new Money(0);
            m._amount = a._amount + b._amount;
            return m;
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money(a._amount - b._amount);

        }
        public static bool operator <(Money a, Money b)
        {
            return a._amount < b._amount;
            
        }
        public static bool operator >(Money a, Money b)
        {

            return a.Amount > b.Amount;

        }
        public static Money operator   * (Money a, Money b)
        {
            return new Money(a._amount * b._amount);    
        }
        public static Money operator /(Money a, Money b)
        {
            return new Money(a._amount / b._amount);
        }

    }
}
