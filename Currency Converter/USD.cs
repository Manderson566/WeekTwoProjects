using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class USD : Money
    {
        public USD(double _value, double _exchangeRate) : base( _value, _exchangeRate) 
        { }

        public override double Exchange()
        {
            return value * exchangeRate;
        }


    }
}
