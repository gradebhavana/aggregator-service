using AggregatorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroservice.Services
{
    public interface IOrderService
    {
        public Task<List<Order>> GetOrdersByUserIdAsync(int userId);
    }
}
