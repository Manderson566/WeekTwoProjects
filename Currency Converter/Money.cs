using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Money
    {
        public double value4;
        public double value3;
        public double value2;
        public double value1;
       
        
        public Money() { }

        public Money(double _value1, double _value2)
        {
            value1 = _value1;
            value2 = _value2;
        }
 



        public virtual double Exchange()
        {
            return 2;
        }

    }
}

