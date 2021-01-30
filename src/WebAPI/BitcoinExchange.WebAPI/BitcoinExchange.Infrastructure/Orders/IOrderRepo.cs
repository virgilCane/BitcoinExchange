using BitcoinExchange.Domain.Top100;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchange.Infrastructure.Orders
{
  public interface IOrderRepo
  {
    public Task<TopOrders> GetTop100Async(string pair);
  }
}
