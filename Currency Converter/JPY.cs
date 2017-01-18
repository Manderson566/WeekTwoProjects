using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class JPY : Money
    {
        double usd = 0.0087;
        double jpn = 144.44;
        double eur = 0.0082;
        double btc = 0.0000099;
        public JPY(double _value1, double _value2) : base( _value1,  _value2)
        {

        }

        public void JPNtoUSD()
        {
            value1 = jpn;
            value2 = usd;
        }

        public void EWURtoUSD()
        {
            value1 = jpn;
            value2 = eur;
        }
        public void EURtoUSD()
        {
            value1 = jpn;
            value2 = eur;
        }
        public void BTCtoUSD()
        {
            value1 = jpn;
            value2 = btc;
        }


        public override double Exchange()
        {
            return value1 * value2;
        }


    }
}


