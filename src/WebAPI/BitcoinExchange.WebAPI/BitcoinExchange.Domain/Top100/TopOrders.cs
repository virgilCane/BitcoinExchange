using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinExchange.Domain.Top100
{
    public class TopOrders
    {
      public long timestamp { get; set; }
      public Ask[] asks { get; set; }
      public Bid[] bids { get; set; }
    }

    public class Ask
    {
      public string price { get; set; }
      public string volume { get; set; }
    }

    public class Bid
    {
      public string price { get; set; }
      public string volume { get; set; }
    }

  
}
