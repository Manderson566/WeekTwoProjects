using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class BTC : Money
    {
        double usd = 880.00;
        double jpn = 101768.98;
        double eur = 835.24;
        double btc = 1;
        public BTC(double _value1, double _value2) : base( _value1,  _value2)
        {

        }

        public void JPNtoBTC()
        {
            value1 = btc;
            value2 = usd;
        }

        public void EURtoBTC()
        {
            value1 = btc;
            value2 = jpn;
        }
        public void USDtoBTC()
        {
            value1 = btc;
            value2 = eur;
        }


        public override double Exchange()
        {
            return value1 * value2;
        }


    }
}
