using BitcoinExchange.Domain.Top100;
using BitcoinExchange.Infrastructure.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchange.ApplicationServices.Orders
{
 public class OrderApplicationService: IOrderApplicationService
  {
    private readonly OrderRepo _orderRepo;

    public OrderApplicationService(OrderRepo orderRepo)
    {
      _orderRepo = orderRepo;
    }

    public async Task<TopOrders> GetTop100Async(string pair)
    {
      var topOrders = await _orderRepo.GetTop100Async(pair);
      return topOrders;
    }
  }
}
