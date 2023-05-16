﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public List<DayPrice> DayPrices { get; set; } = new List<DayPrice>();
    }
}
