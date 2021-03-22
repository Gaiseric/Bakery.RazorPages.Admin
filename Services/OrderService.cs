using Bakery.RazorPages.Admin.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bakery.RazorPages.Admin.Services
{
    public class OrderService
    {
        private readonly string _route;

        private readonly HttpClient _httpClient;

        public OrderService(
            HttpClient httpClient,
            IConfiguration configuration)
        {
            _httpClient = httpClient;
            _route = configuration["OrderService:ControllerRoute"];
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            var response = await _httpClient.GetAsync(_route);
            response.EnsureSuccessStatusCode();

            var orders = await response.Content.ReadAsAsync<IEnumerable<Order>>();

            return orders;
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            var response = await _httpClient.GetAsync($"{_route}/{orderId}");
            response.EnsureSuccessStatusCode();

            var order = await response.Content.ReadAsAsync<Order>();

            return order;
        }

        public Task UpdateOrder(Order order) =>
            _httpClient.PutAsJsonAsync($"{_route}/{order.Id}", order);

        public Task DeleteOrder(int orderId) =>
            _httpClient.DeleteAsync($"{_route}/{orderId}");
    }  
}