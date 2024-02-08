﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMarket
{
    internal class MyFormatter
    {
        public static string FormatUsdPrice(double price)
        {
            var usc = new CultureInfo("en-us");
            return price.ToString("C2", usc);
        }
    }
}
