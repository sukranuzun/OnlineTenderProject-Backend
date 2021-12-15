using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BidClient
    {
        public int BidClientId { get; set; }
        public int TenderId { get; set; }
        public int ClientId { get; set; }
        public double UnitPrice { get; set; }
    }
}
