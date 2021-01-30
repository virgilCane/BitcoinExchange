using BitcoinExchange.Domain.Top100;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using BitcoinExchange.Infrastructure.Common;
using System.Threading.Tasks;
using System.Text.Json;

namespace BitcoinExchange.Infrastructure.Orders
{
  public class OrderRepo : IOrderRepo
  {
    private readonly IHttpClientFactory _clientFactory;
    private HttpClient _client;
    public OrderRepo(IHttpClientFactory clientFactory)
    {
      _clientFactory = clientFactory;
      _client = _clientFactory.CreateClient();
      _client.BaseAddress = new Uri(Endpoints.Base);
      _client.DefaultRequestHeaders.Add("Accept", "Application/Json");
      _client.DefaultRequestHeaders.Add("User-Agent", "BitcoinExchange");
    }
    public async Task<TopOrders> GetTop100Async(string pair)
    {
      var request = new HttpRequestMessage(HttpMethod.Get, Endpoints.Top100);
      var response = await _client.SendAsync(request);
      if (response.IsSuccessStatusCode)
      {
        using var responseStream = await response.Content.ReadAsStreamAsync();
        var topOrders = await JsonSerializer.DeserializeAsync<TopOrders>(responseStream);
        return topOrders;
      }
      else
      {
        return null;
      }
    }
  }
}
