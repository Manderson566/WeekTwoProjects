using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class USD : Money
    {
        double usd = 1;
        double jpn = 144.44;
        double eur = 0.94;
        double btc = 0.0011;
        public USD(double _value1, double _value2) : base( _value1,  _value2)
        {
            
        }

        public void JPNtoUSD()
        {
            value1 = usd;
            value2 = jpn;
        }

        public void EURtoUSD()
        {
            value1 = usd;
            value2 = eur;
        }

        public void BTCtoUSD()
        {
            value1 = usd;
            value2 = btc;
        }


        public override double Exchange()
        {
            return value1 * value2;
        }


    }
}
