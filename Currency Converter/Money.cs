using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Money
    {
        public double value;
        public double exchangeRate;

        public Money() { }

        public Money(double _value, double _exchangeRate)
        {
            value = _value;
            exchangeRate = _exchangeRate;
        }
        public virtual double Exchange()
        {
            return 2;
        }
        
    }
}
