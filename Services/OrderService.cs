using AggregatorMicroservice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AggregatorMicroservice.Services
{
    public class OrderService : IOrderService
    {
        private HttpClient _httpClient;
        string Baseurl = "http://ordermicroservice_ordermicroservice_1/";
        public OrderService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Baseurl);
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(int userId)
        {
            List<Order> order = null;
            HttpResponseMessage Res = await _httpClient.GetAsync("api/order/" + userId);
            if (Res.IsSuccessStatusCode)
            {
                var orderResponse = Res.Content.ReadAsStringAsync().Result;
                order = JsonConvert.DeserializeObject<List<Order>>(orderResponse);
            }

            return order;
        }
    }
}
