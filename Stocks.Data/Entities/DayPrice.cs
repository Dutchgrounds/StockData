using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Data.Entities
{
    public class DayPrice
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public DateOnly Datum { get; set; }
        public Double OpenPrice { get; set; }
        public Double ClosePrice { get; set; }
        public Double High { get; set; }
        public Double Low { get; set; }
        public Double AdjustedClosePrice { get; set; }
        public Double Volume { get; set; }
    }
}
