using BitcoinExchange.Domain.Top100;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchange.ApplicationServices.Orders
{
public  interface IOrderApplicationService
  {
     Task<TopOrders> GetTop100Async(string pair);
  }
}
