using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class EUR : Money
    {
        double usd = 1.06;
        double jpn = 122.00;
        double eur = 1;
        double btc = 0.0012;
        public EUR(double _value1, double _value2) : base( _value1,  _value2)
        {

        }

        public void JPNtoEUR()
        {
            value1 = eur;
            value2 = usd;
        }

        public void USDtoEUR()
        {
            value1 = eur;
            value2 = jpn;
        }
        public void BTCtoEUR()
        {
            value1 = eur;
            value2 = btc;
        }


        public override double Exchange()
        {
            return value1 * value2;
        }


    }
}
