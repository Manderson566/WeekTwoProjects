﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = new USD(2, 200);
            double usdAnswer = usd.Exchange();
            Console.WriteLine(usdAnswer);

        }
    }
}
