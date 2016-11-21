using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class CurrencyRates
    {
        public string disclaimer { get; set; }
        public string license { get; set; }
        public int timestamp { get; set; }
        public string _base { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        public float USD { get; set; }
        public float CAD { get; set; }
        public float EUR { get; set; }
        public float GBP { get; set; }
        public float JPY { get; set; }
        public float ILS { get; set; }
        public float RUB { get; set; }
        public float BYR { get; set; }
        public float UAH { get; set; }
    }

}