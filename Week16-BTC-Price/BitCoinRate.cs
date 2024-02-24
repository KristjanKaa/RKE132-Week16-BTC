using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week16_BTC_Price
{
    public class BitCoinRate
    {
        public Bpi bpi { get; set; }
    }

    public class Bpi
    {
        public USD USD { get; set; }
    }

    public class USD
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
}
   
   