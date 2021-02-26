using BitcoinExchange.Domain.Top100;
using BitcoinExchange.ApplicationServices.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinExchange.WebAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class OrderController: ControllerBase
  {
    private readonly ILogger<OrderController> _logger;
    private readonly IOrderApplicationService _appService;

    public OrderController(ILogger<OrderController> logger, IOrderApplicationService appService)
    {
      _logger = logger;
      _appService = appService;
    }

    [HttpGet]
    [Route("top100")]
    public async Task<TopOrders> GetTopOrdersAsync(string pair)
    {
      var topOrders = await _appService.GetTop100Async(pair);
      if (topOrders == null)
        throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);

      return topOrders;
    }

    [HttpGet]
    [Route("test")]
    public string Test()
    {
      return "foo";
    }

  }
}
